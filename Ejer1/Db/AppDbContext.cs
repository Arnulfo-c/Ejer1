using Microsoft.EntityFrameworkCore;
using Ejer1.Models;

namespace Ejer1.Db
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Alunmo> Alunmos { get; set; }
    }
}
