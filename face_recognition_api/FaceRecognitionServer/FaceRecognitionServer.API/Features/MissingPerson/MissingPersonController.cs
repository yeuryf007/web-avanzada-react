using FaceRecognitionServer.API.Features.MissingPerson.Models;
using Microsoft.AspNetCore.Mvc;

namespace FaceRecognitionServer.API.Features.MissingPerson;

[Route("api/[controller]/[action]")]
[ApiController]
public class MissingPersonController(PersonService service) : Controller
{
    [HttpPost]
    public async Task<IActionResult> Add(AddPersonRequest request)
    {
        var person = request.MapToPerson();
        await service.AddAsync(person);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await service.GetAllAsync();
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Compare(CompareRequest request)
    {
        var result = await service.CompareAsync(request.SourceImage);
        return Ok(result);
    }

    public class CompareRequest
    {
        public string? SourceImage { get; set; }     
    }
    
    public class AddPersonRequest
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public int HeightInCentimeters { get; set; }
        public int WeightInPound { get; set; }
        public DateTime ReportedOn { get; set; }
        public string? ReportedBy { get; set; }
        public List<AddPersonImageRequest> Images { get; set; } = new();

        public class AddPersonImageRequest
        {
            public string? ImageInBase64 { get; set; }
        }

        public Person MapToPerson()
        {
            var model = new Person()
            {
                Name = Name,
                Age = Age,
                HeightInCentimeters = HeightInCentimeters,
                WeightInPound = WeightInPound,
                ReportedOn = ReportedOn,
                ReportedBy = ReportedBy
            };


            foreach (var image in Images)
            {
                if (string.IsNullOrEmpty(image.ImageInBase64))
                    continue;
                
                var bytes = Convert.FromBase64String(image.ImageInBase64);
                model.Images.Add(new PersonImage { Image = bytes });
            }

            return model;
        }
    }
}