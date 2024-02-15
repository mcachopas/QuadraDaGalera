using Microsoft.EntityFrameworkCore;

namespace QuadraDaGaleraApi.infra
{
    public class QuadraDaGaleraDbContext(DbContextOptions<QuadraDaGaleraDbContext> options) : DbContext(options)
    {
    }
}
