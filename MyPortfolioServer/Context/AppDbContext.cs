using Microsoft.EntityFrameworkCore;
using MyPortfolioServer.Models;

namespace MyPortfolioServer.Context;

public sealed class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }


    public DbSet<User> Users  { get; set; }
    public DbSet<UserDetail> UserDetails { get; set; }
    public DbSet<Technology> Technologies { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<BlogTag> BlogTags { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Thesis> Thesises { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<UsedTechnology> UsedTechnologies { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Technology>().HasData(
            new Technology
            {
                Id = Guid.NewGuid(),
                Name = ".NET",
                Status = "Backend",
                URL = "NET_Core_Logo.svg.png",
                UserId = new Guid("9D06CF48-EDCA-4D1D-8F24-6539390B0D1B")
                
            },
            new Technology
            {
                Id = Guid.NewGuid(),
                Name = "MSSQL",
                Status = "Database",
                URL = "mssql.png",
                UserId = new Guid("9D06CF48-EDCA-4D1D-8F24-6539390B0D1B")
               
            },
            new Technology
            {
                Id = Guid.NewGuid(),
                Name = "Angular",
                Status = "Frontend",
                URL = "angular.png",
                UserId = new Guid("9D06CF48-EDCA-4D1D-8F24-6539390B0D1B")
               
            },
            new Technology
            {
                Id = Guid.NewGuid(),
                Name = "MongoDB",
                Status = "Database",
                URL = "mongo.png",
                UserId = new Guid("9D06CF48-EDCA-4D1D-8F24-6539390B0D1B")
                
            },
            new Technology
            {
                Id = Guid.NewGuid(),
                Name = "TypeScript",
                Status = "Frontend",
                URL = "typescript.png",
                UserId = new Guid("9D06CF48-EDCA-4D1D-8F24-6539390B0D1B")
            },
            new Technology
            {
                Id = Guid.NewGuid(),
                Name = "JavaScript",
                Status = "Frontend",
                URL = "javascript.png",
                UserId = new Guid("9D06CF48-EDCA-4D1D-8F24-6539390B0D1B") 
            },
            new Technology
            {
                Id = Guid.NewGuid(),
                Name = "HTML",
                Status = "Frontend",
                URL = "html.png",
                UserId = new Guid("9D06CF48-EDCA-4D1D-8F24-6539390B0D1B")
              
            },
            new Technology
            {
                Id = Guid.NewGuid(),
                Name = "CSS",
                Status = "Frontend",
                URL = "css.png",
                UserId = new Guid("9D06CF48-EDCA-4D1D-8F24-6539390B0D1B")
                
            }
        );

        modelBuilder.Entity<BlogTag>()
             .HasKey(bt => new { bt.BlogId, bt.TagId });

        modelBuilder.Entity<BlogTag>()
            .HasOne(bt => bt.Blog)
            .WithMany(b => b.BlogTags)
            .HasForeignKey(bt => bt.BlogId);

        modelBuilder.Entity<BlogTag>()
            .HasOne(bt => bt.Tag)
            .WithMany(t => t.BlogTags)
            .HasForeignKey(bt => bt.TagId);
    
    
    }

    


}

