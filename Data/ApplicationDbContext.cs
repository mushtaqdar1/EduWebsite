// File: Data/ApplicationDbContext.cs
using EduWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace EduWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
