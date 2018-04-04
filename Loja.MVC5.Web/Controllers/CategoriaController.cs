using Loja.MVC5.Database.DAO;
using Loja.MVC5.Model;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Loja.MVC5.Web.Controllers {

    public class CategoriaController : Controller {

        private static IList<Categoria> categorias = CategoriaDAO.FindAll();

        [HttpGet]
        public ActionResult List() {
            return View(categorias);
        }

        [HttpGet]
        public ActionResult Form() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Form(Categoria categoria) {
            CategoriaDAO.Save(categoria);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(long id) {
            return View(CategoriaDAO.FindOne(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria categoria) {
            CategoriaDAO.Update(categoria);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Details(long id) {
            return View(CategoriaDAO.FindOne(id));
        }

        [HttpGet]
        public ActionResult Delete(long id) {
            return View(CategoriaDAO.FindOne(id));
        }

        [HttpPost]
        public ActionResult Delete(Categoria categoria) {
            CategoriaDAO.Delete(categoria);
            return RedirectToAction("List");
        }
    }
}