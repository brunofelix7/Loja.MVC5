using Loja.MVC5.Model;
using System.Data.Entity;

namespace Loja.MVC5.Database.Context {

    public class EFContext : DbContext{

        /*Realiza a conexão com o banco de dados através da connectionString configurada no arquivo Web.config*/
        public EFContext() : base("connectionString") {

        }

        /*Toda classe a ser persistida pelo EF deve ser colocada aqui. Representa as tabelas no banco de dados*/
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }

    }
}
