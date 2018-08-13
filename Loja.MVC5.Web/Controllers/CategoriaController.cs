using Loja.MVC5.Database.DAO;
using Loja.MVC5.Model;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace Loja.MVC5.Web.Controllers {

    public class CategoriaController : Controller {

        private CategoriaDAO categoriaDAO;

        public CategoriaController() {
            this.categoriaDAO = new CategoriaDAO();
        }

        [HttpGet]
        public ActionResult Index() {
            IList<Categoria> categorias = this.categoriaDAO.FindAll();
            return View(categorias);
        }

        [HttpGet]
        public ActionResult Form() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Form(Categoria categoria) {
            this.categoriaDAO.Save(categoria);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(long id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = this.categoriaDAO.FindOne(id);
            if (categoria == null) {
                return HttpNotFound();
            }
            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria categoria) {
            if (ModelState.IsValid) {
                this.categoriaDAO.Update(categoria);
                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        [HttpGet]
        public ActionResult Details(long id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = this.categoriaDAO.FindOne(id);
            if (categoria == null) {
                return HttpNotFound();
            }
            return View(categoria);
        }

        [HttpGet]
        public ActionResult Delete(long id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = this.categoriaDAO.FindOne(id);
            if (categoria == null) {
                return HttpNotFound();
            }
            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long? id) {
            Categoria categoria = this.categoriaDAO.FindOne(id);
            this.categoriaDAO.Delete(categoria);
            return RedirectToAction("Index");
        }
    }
}