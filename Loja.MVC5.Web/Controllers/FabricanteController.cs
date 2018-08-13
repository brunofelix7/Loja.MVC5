using Loja.MVC5.Database.DAO;
using Loja.MVC5.Model;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace Loja.MVC5.Web.Controllers {

    public class FabricanteController : Controller {

        private FabricanteDAO fabricanteDAO;

        public FabricanteController() {
            this.fabricanteDAO = new FabricanteDAO();
        }

        [HttpGet]
        public ActionResult Index() {
            IList<Fabricante> fabricantes = this.fabricanteDAO.FindAll();
            return View(fabricantes);
        }

        [HttpGet]
        public ActionResult Form() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Form(Fabricante fabricante) {
            this.fabricanteDAO.Save(fabricante);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(long id) {
            if(id == null) {
                //  Retorna uma descrição e um código de erro
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fabricante fabricante = this.fabricanteDAO.FindOne(id);
            if(fabricante == null) {
                //  Retorna uma página de erro 404
                return HttpNotFound();
            }
            return View(fabricante);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Fabricante fabricante) {
            if (ModelState.IsValid) {
                this.fabricanteDAO.Update(fabricante);
                return RedirectToAction("Index");
            }
            return View(fabricante);
        }

        [HttpGet]
        public ActionResult Details(long? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fabricante fabricante = this.fabricanteDAO.FindOne(id);
            if (fabricante == null) {
                return HttpNotFound();
            }
            return View(fabricante);
        }

        [HttpGet]
        public ActionResult Delete(long id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fabricante fabricante = this.fabricanteDAO.FindOne(id);
            if(fabricante == null) {
                return HttpNotFound();
            }
            return View(fabricante);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long? id) {
            Fabricante fabricante = this.fabricanteDAO.FindOne(id);
            this.fabricanteDAO.Delete(fabricante);
            return RedirectToAction("Index");
        }
    }
}
