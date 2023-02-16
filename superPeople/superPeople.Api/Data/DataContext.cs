using Microsoft.EntityFrameworkCore;

namespace superPeople.Api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) :base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=.\\localhost; Database=superPeopleDb;Trusted_Connection=true;TrustServerCertificate=true");
    }
    
    public DbSet<SuperPeopleModel> SuperPeopleModels { get; set; }
}