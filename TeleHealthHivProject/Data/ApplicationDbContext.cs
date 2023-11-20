using Microsoft.EntityFrameworkCore;
using YourProjectNamespace.Models; // Replace with the actual namespace of your project

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Patient> Patients { get; set; }

    // You can add more DbSet<T> properties here for other models
}