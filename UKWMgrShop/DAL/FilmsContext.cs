
using Microsoft.EntityFrameworkCore;
using UKWMgrShop.Models;

namespace UKWMgrShop.DAL
{
    public class FilmsContext : DbContext
    {
        public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Film> Films { get; set; }
    }
}
