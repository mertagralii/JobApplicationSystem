using JobApplicationSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace JobApplicationSystem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Resume> Resume { get; set; }

        public DbSet<Skill> Skill { get; set; }

        public DbSet<Referance> Referance { get; set; }

        public DbSet<WorkCategory> WorkCategory { get; set; }

        public DbSet<Project> Project { get; set; }

        public DbSet<Personal> Personal { get; set; }

        public DbSet<Language> Language { get; set; }

        public DbSet<Experience> Experience { get; set; }

        public DbSet<Education> Education { get; set; }

        public DbSet<Certificate> Certificate { get; set; }

        public DbSet<Link> Link { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
