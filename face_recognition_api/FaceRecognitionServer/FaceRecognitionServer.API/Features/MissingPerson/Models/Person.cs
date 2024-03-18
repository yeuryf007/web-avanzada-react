namespace FaceRecognitionServer.API.Features.MissingPerson.Models;

public class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public int HeightInCentimeters { get; set; }
    public int WeightInPound { get; set; }
    public DateTime ReportedOn { get; set; }
    public string? ReportedBy { get; set; }
    public List<PersonImage> Images { get; set; } = new();
}