using Microsoft.EntityFrameworkCore;
using QuestionsApi.Models;
public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions options):base(options)
    {
        
    }
    public ApplicationDbContext():base()
    {
        
    }
    public DbSet<Result>? Results { get; set; }
    public DbSet<Question> Questions { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-MV2T7M8\SQLEXPRESS;Database=ExamResults;Trusted_Connection=True;TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
    }

}
