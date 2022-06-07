using APIGestaoProdutos.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIGestaoProdutos.Data
{
     public class APIGestaoProdutosDBContext : DbContext
     {
          public APIGestaoProdutosDBContext()
          {
          }

          public APIGestaoProdutosDBContext(DbContextOptions<APIGestaoProdutosDBContext> options) : base(options)
          {
               Database.EnsureCreated();
          }
          public DbSet<Fornecedor> Fornecedores { get; set; }

          public DbSet<Produto> Produtos { get; set; }
     }
}
