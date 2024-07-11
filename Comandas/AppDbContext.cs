
using Microsoft.EntityFrameworkCore;

namespace Comandas
{
    // classe que representa o banco de dados
    public class AppDbContext : DbContext
    {
        // propriedade que representa a tabela usuarios
       public DbSet<Usuario> Usuarios { get; set; }
        // metodo que configura informando para o EF que o banco será SQLITE
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=comandas.db");
        }
    }

}
