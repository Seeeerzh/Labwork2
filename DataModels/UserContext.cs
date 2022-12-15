using Microsoft.EntityFrameworkCore;
using WebAPI;

public class TechnicContext : DbContext
{
    public TechnicContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Technic> Technics => Set<Technic>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Technic>()
            .HasKey(b => b.technicid);

        modelBuilder.Entity<Technic>().ToTable("technic", schema: "public");
        
        modelBuilder.Entity<Techniccompany>().ToTable("techniccompany", schema: "public");
    }

   
}