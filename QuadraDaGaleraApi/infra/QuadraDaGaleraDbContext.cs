using Microsoft.EntityFrameworkCore;
using QuadraDaGaleraApi.Dominio.Entidades;

namespace QuadraDaGaleraApi.infra
{
    public class QuadraDaGaleraDbContext(DbContextOptions<QuadraDaGaleraDbContext> options) : DbContext(options)
    {
        public DbSet<Match> Matches { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
