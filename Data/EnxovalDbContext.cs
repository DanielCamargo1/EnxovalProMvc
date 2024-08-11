using Microsoft.EntityFrameworkCore;
using NossoEnxoval.Models;

namespace NossoEnxoval.Data
{
    public class EnxovalDbContext : DbContext
    {
        public EnxovalDbContext(DbContextOptions<EnxovalDbContext> options) : base(options)
        {

        }

        public DbSet<EnxovalModel> Sala { get; set; }  
        public DbSet<EnxovalModel> Cozinha { get; set; }  
        public DbSet<EnxovalModel> Banheiro { get; set; }  
        public DbSet<EnxovalModel> Quarto { get; set; }  
    }
}
