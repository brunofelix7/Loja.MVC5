using Loja.MVC5.Model;
using System.Collections.Generic;

namespace Loja.MVC5.Database.Interfaces {

    interface ICategoriaDAO {

        void Save(Categoria categoria);
        void Update(Categoria categoria);
        void Delete(Categoria categoria);
        Categoria FindOne(long? id);
        IList<Categoria> FindAll();
    }
}
