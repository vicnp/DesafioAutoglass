using Microsoft.EntityFrameworkCore;

namespace Autoglass.Models
{
    public class ProdutoDbContext : DbContext
    {
        public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options): base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }

    }
}
