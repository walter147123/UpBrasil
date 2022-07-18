using Microsoft.EntityFrameworkCore;

namespace UPBRASIL.Models
{
    public class BDbase : DbContext
    {
        public DbSet<Produtos> Produtos { get; set; }   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=DESKTOP-085RSKP\SQLEXPRESS;Database=UPBRASIL;integrated security=True");
        }
    }
}
