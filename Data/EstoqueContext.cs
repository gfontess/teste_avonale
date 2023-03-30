using EstoqueAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EstoqueAPI.Data
{
    public class EstoqueContext : DbContext
    {
        public EstoqueContext(DbContextOptions<EstoqueContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
