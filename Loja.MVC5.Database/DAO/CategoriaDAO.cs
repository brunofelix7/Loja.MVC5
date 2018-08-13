using Loja.MVC5.Database.Context;
using Loja.MVC5.Database.Interfaces;
using Loja.MVC5.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Loja.MVC5.Database.DAO {

    public class CategoriaDAO : ICategoriaDAO, IDisposable {

        private EFContext context;

        public CategoriaDAO() {
            this.context = new EFContext();
        }

        public void Dispose() {
            this.context.Dispose();
        }

        public void Save(Categoria categoria) {
            this.context.Categorias.Add(categoria);
            this.context.SaveChanges();
        }

        public void Update(Categoria categoria) {
            this.context.Entry(categoria).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(Categoria categoria) {
            this.context.Categorias.Remove(categoria);
            this.context.SaveChanges();
        }

        public Categoria FindOne(long? id) {
            return this.context.Categorias.Find(id);
        }

        public IList<Categoria> FindAll() {
            IList<Categoria> categorias = this.context.Categorias.OrderBy(c => c.Nome).ToList();
            return categorias;
        }
    }
}
