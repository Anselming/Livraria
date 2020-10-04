using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Livraria.Modelo;

namespace MvcPresentation.Controllers
{ 
    public class BairroController : Controller
    {
        private Context db = new Context();

        // GET: /Bairro/
        public ViewResult Index()
        {
            var bairros = db.Bairros.Include(b => b.Cidade);
            return View(bairros.ToList());
        }

        // GET: /Bairro/Details/5
        public ViewResult Details(int id)
        {
            Bairro bairro = db.Bairros.Find(id);
            return View(bairro);
        }

        // GET: /Bairro/Create
        public ActionResult Create()
        {
            ViewBag.CidadeId = new SelectList(db.Cidades, "ID", "Nome");
            return View();
        } 

        // POST: /Bairro/Create
        [HttpPost]
        public ActionResult Create(Bairro bairro)
        {
            if (ModelState.IsValid)
            {
                db.Bairros.Add(bairro);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.CidadeId = new SelectList(db.Cidades, "ID", "Nome", bairro.CidadeId);
            return View(bairro);
        }
        
        // GET: /Bairro/Edit/5
        public ActionResult Edit(int id)
        {
            Bairro bairro = db.Bairros.Find(id);
            ViewBag.CidadeId = new SelectList(db.Cidades, "ID", "Nome", bairro.CidadeId);
            return View(bairro);
        }

        // POST: /Bairro/Edit/5
        [HttpPost]
        public ActionResult Edit(Bairro bairro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bairro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CidadeId = new SelectList(db.Cidades, "ID", "Nome", bairro.CidadeId);
            return View(bairro);
        }

        // GET: /Bairro/Delete/5
        public ActionResult Delete(int id)
        {
            Bairro bairro = db.Bairros.Find(id);
            return View(bairro);
        }

        // POST: /Bairro/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Bairro bairro = db.Bairros.Find(id);
            db.Bairros.Remove(bairro);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}