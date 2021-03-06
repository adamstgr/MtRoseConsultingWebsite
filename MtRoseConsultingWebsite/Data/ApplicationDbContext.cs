using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MtRoseConsultingWebsite.Models;

namespace MtRoseConsultingWebsite.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public DbSet<BlogPost> Blogs { get; set; }
    public DbSet<ConsultationRequests> ConsultationRequests { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
