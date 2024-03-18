using FaceRecognitionServer.API.Data;
using FaceRecognitionServer.API.Features.MissingPerson.Models;
using Microsoft.EntityFrameworkCore;

namespace FaceRecognitionServer.API.Features.MissingPerson;

public class PersonService(ApplicationDbContext context, FaceComparisonService faceComparisonFaceComparisonService)
{
    public async Task AddAsync(Person personToCreate)
    {
        context.Persons.Add(personToCreate);
        await context.SaveChangesAsync();
    }

    public async Task<List<Person>> GetAllAsync()
    {
        var result =  await context.Persons.Include(x => x.Images).ToListAsync();
        return result;
    }

    public async Task<ComparePersonSimilarityResult> CompareAsync(string base64ImageToCompare)
    {
        var persons = await GetAllAsync();
        var bytesToCompare = Convert.FromBase64String(base64ImageToCompare);

        var allResults = new List<ComparisonProcessResult>();
        foreach (var person in persons)
        {
            foreach (var image in person.Images)
            {
                var result = await faceComparisonFaceComparisonService.Execute(bytesToCompare, image.Image);
                allResults.Add(new ComparisonProcessResult(person, result));
            }
        }

        var mostSimilarResult = allResults.MaxBy(x => x.Result.Similarity);

        if (mostSimilarResult is null)
            return new ComparePersonSimilarityResult()
            {
                Success = false,
                Message = "No similar person found"
            };
        
        if (mostSimilarResult.Result.Similarity < 70F)
            return new ComparePersonSimilarityResult()
            {
                Success = false,
                Message = "Most similar person found is less than 50% similar"
            };

        return new ComparePersonSimilarityResult()
        {
            Success = true,
            Message = "Person found",
            Data = new ComparePersonSimilarityResult.ComparePersonSimilarityData()
            {
                PersonName = mostSimilarResult.Person.Name,
                ImageBase64 = mostSimilarResult.Person.Images.First().Image.ToString(),
                Similarity = mostSimilarResult.Result.Similarity,
                ReportedOn = mostSimilarResult.Person.ReportedOn,
                ReportedBy = mostSimilarResult.Person.ReportedBy
            }
        };
    }
    
    private record ComparisonProcessResult(Person Person, FaceComparisonService.Result Result);

    public class ComparePersonSimilarityResult
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public ComparePersonSimilarityData? Data { get; set; }

        public class ComparePersonSimilarityData
        {
            public string? PersonName { get; set; }
            public string? ImageBase64 { get; set; }
            public double Similarity { get; set; }
            public DateTime ReportedOn { get; set; }
            public string? ReportedBy { get; set; }
        }
    }
}