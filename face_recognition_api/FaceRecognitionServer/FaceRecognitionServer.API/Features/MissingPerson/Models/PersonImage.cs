namespace FaceRecognitionServer.API.Features.MissingPerson.Models;

public class PersonImage
{
    public int Id { get; set; }
    public byte[] Image { get; set; }
    public int PersonId { get; set; }
    public Person Person { get; set; }
}