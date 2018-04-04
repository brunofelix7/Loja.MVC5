using Loja.MVC5.Model;
using System.Collections.Generic;
using System.Linq;

namespace Loja.MVC5.Database.DAO {

    public class CategoriaDAO {

        private static IList<Categoria> categorias = new List<Categoria>();

        public static void Save(Categoria categoria) {
            categorias.Add(categoria);
            categoria.Id = categorias.Select(m => m.Id).Max() + 1;
        }

        public static void Update(Categoria categoria) {
            categorias.Remove(categorias.Where(c => c.Id == categoria.Id).First());
            categorias.Add(categoria);
        }

        public static void Delete(Categoria categoria) {
            categorias.Remove(categorias.Where(c => c.Id == categoria.Id).First());
        }

        public static Categoria FindOne(long id) {
            return categorias.Where(m => m.Id == id).First();
        }

        public static IList<Categoria> FindAll(){
            categorias.Add(new Categoria() {
                Id = 1,
                Nome = "Notebooks"
            });
            categorias.Add(new Categoria() {
                Id = 2,
                Nome = "Monitores"
            });
            categorias.Add(new Categoria() {
                Id = 3,
                Nome = "Impressoras"
            });
            categorias.Add(new Categoria() {
                Id = 4,
                Nome = "Mouses"
            });
            categorias.Add(new Categoria() {
                Id = 5,
                Nome = "Desktops"
            });
            return categorias;
        }
    }
}
