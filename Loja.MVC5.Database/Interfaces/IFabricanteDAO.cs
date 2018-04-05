using Loja.MVC5.Model;
using System.Collections.Generic;

namespace Loja.MVC5.Database.Interfaces {

    interface IFabricanteDAO {

        void Save(Fabricante fabricante);
        void Update(Fabricante fabricante);
        void Delete(Fabricante fabricante);
        Fabricante FindOne(long? id);
        IList<Fabricante> FindAll();
    }
}
