using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Loja.MVC5.Database.Context;
using Loja.MVC5.Database.Interfaces;
using Loja.MVC5.Model;

namespace Loja.MVC5.Database.DAO {

    public class FabricanteDAO : IFabricanteDAO, IDisposable {

        private EFContext context;

        public FabricanteDAO() {
            this.context = new EFContext();
        }

        public void Dispose() {
            this.context.Dispose();
        }

        public void Save(Fabricante fabricante) {
            this.context.Fabricantes.Add(fabricante);
            this.context.SaveChanges();
        }

        public void Update(Fabricante fabricante) {
            this.context.Entry(fabricante).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(Fabricante fabricante) {
            this.context.Fabricantes.Remove(fabricante);
            this.context.SaveChanges();
        }

        public Fabricante FindOne(long? id) {
            return this.context.Fabricantes.Find(id);
        }

        public IList<Fabricante> FindAll() {
            IList<Fabricante> fabricantes = this.context.Fabricantes.OrderBy(c => c.Nome).ToList(); ;
            return fabricantes;
        }
    }
}
