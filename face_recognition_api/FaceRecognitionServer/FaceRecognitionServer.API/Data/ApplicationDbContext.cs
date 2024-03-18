using FaceRecognitionServer.API.Features.MissingPerson.Models;
using Microsoft.EntityFrameworkCore;

namespace FaceRecognitionServer.API.Data;

public class ApplicationDbContext(IConfiguration configuration) : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    }
    
    public DbSet<Person> Persons { get; set; }
    public DbSet<PersonImage> PersonImagea { get; set; }
}