using System.Reflection;
using Amazon.Rekognition;
using Amazon.Rekognition.Model;

namespace FaceRecognitionServer.API.Features.MissingPerson;

public class FaceComparisonService
{
    public async Task<Result> Execute(byte[] sourceImageArray, byte[] targetImageArray)
    {
        try
        {
            var similarityThreshold = 70F;
            // var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/../../../TestImg/";
            // var sourceImage = $"{basePath}Img1.png";
            // var targetImage = $"{basePath}Img2.png";

            var rekognitionClient = new AmazonRekognitionClient();

            var imageSource = new Image();

            try
            {
                imageSource.Bytes = new MemoryStream(sourceImageArray);
            }
            catch (Exception)
            {
                throw new Exception("Failed to load source image");
            }

            var imageTarget = new Image();

            try
            {
                imageTarget.Bytes = new MemoryStream(targetImageArray);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to load target image");
            }

            var compareFacesRequest = new CompareFacesRequest
            {
                SourceImage = imageSource,
                TargetImage = imageTarget,
                SimilarityThreshold = similarityThreshold,
            };

            var compareFacesResponse = await rekognitionClient.CompareFacesAsync(compareFacesRequest);

            compareFacesResponse.FaceMatches.ForEach(match =>
            {
                ComparedFace face = match.Face;
                BoundingBox position = face.BoundingBox;
                Console.WriteLine($"Face at {position.Left} {position.Top} matches with {match.Similarity}% confidence.");
            });

            Console.WriteLine($"Found {compareFacesResponse.UnmatchedFaces.Count} face(s) that did not match.");
            
            var result = new Result
            {
                Similarity = compareFacesResponse.FaceMatches[0].Similarity,
                Face = compareFacesResponse.FaceMatches[0].Face
            };
            
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public class Result
    {
        public float Similarity { get; init; }
        public ComparedFace? Face { get; init; }
    }
}