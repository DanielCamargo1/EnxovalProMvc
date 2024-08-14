using Microsoft.EntityFrameworkCore;
using NossoEnxoval.Models;

namespace NossoEnxoval.Data
{
    public class EnxovalDbContext : DbContext
    {
        public EnxovalDbContext(DbContextOptions<EnxovalDbContext> options) : base(options)
        {

        }

        public DbSet<EnxovalModel> Itens { get; set; }
    }
}
