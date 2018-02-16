using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Domain
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Form> Forms { get; set; }
    }
}