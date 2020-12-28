using Microsoft.EntityFrameworkCore;
using myWebApp.Models;

namespace myWebApp.Data
{
    public class parts : DbContext
    {
        public parts(DbContextOptions<parts> options) : base(options)
        {
        }

        public DbSet<Laptop> Laptop { get; set; }
    }
}