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
    public class CidadeController : Controller
    {
        private Context db = new Context();

        // GET: /Cidade/
        public ViewResult Index()
        {
            var cidades = db.Cidades.Include(c => c.UF);
            return View(cidades.ToList());
        }

        // GET: /Cidade/Details/5
        public ViewResult Details(int id)
        {
            Cidade cidade = db.Cidades.Find(id);
            return View(cidade);
        }

        // GET: /Cidade/Create
        public ActionResult Create()
        {
            ViewBag.UfId = new SelectList(db.UFs, "ID", "Nome");
            return View();
        } 

        // POST: /Cidade/Create
        [HttpPost]
        public ActionResult Create(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                db.Cidades.Add(cidade);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.UfId = new SelectList(db.UFs, "ID", "Nome", cidade.UfId);
            return View(cidade);
        }
        
        // GET: /Cidade/Edit/5
        public ActionResult Edit(int id)
        {
            Cidade cidade = db.Cidades.Find(id);
            ViewBag.UfId = new SelectList(db.UFs, "ID", "Nome", cidade.UfId);
            return View(cidade);
        }

        // POST: /Cidade/Edit/5
        [HttpPost]
        public ActionResult Edit(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UfId = new SelectList(db.UFs, "ID", "Nome", cidade.UfId);
            return View(cidade);
        }

        // GET: /Cidade/Delete/5
        public ActionResult Delete(int id)
        {
            Cidade cidade = db.Cidades.Find(id);
            return View(cidade);
        }

        // POST: /Cidade/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Cidade cidade = db.Cidades.Find(id);
            db.Cidades.Remove(cidade);
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