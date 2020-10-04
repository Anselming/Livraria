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
    public class UnidadeFederativaController : Controller
    {
        private Context db = new Context();

        // GET: /UnidadeFederativa/
        public ViewResult Index()
        {
            return View(db.UFs.ToList());
        }

        // GET: /UnidadeFederativa/Details/5
        public ViewResult Details(int id)
        {
            UnidadeFederativa unidadefederativa = db.UFs.Find(id);
            return View(unidadefederativa);
        }

        // GET: /UnidadeFederativa/Create
        public ActionResult Create()
        {
            return View();
        } 

        // POST: /UnidadeFederativa/Create
        [HttpPost]
        public ActionResult Create(UnidadeFederativa unidadefederativa)
        {
            if (ModelState.IsValid)
            {
                db.UFs.Add(unidadefederativa);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(unidadefederativa);
        }
        
        // GET: /UnidadeFederativa/Edit/5
        public ActionResult Edit(int id)
        {
            UnidadeFederativa unidadefederativa = db.UFs.Find(id);
            return View(unidadefederativa);
        }

        // POST: /UnidadeFederativa/Edit/5
        [HttpPost]
        public ActionResult Edit(UnidadeFederativa unidadefederativa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unidadefederativa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(unidadefederativa);
        }

        // GET: /UnidadeFederativa/Delete/5
        public ActionResult Delete(int id)
        {
            UnidadeFederativa unidadefederativa = db.UFs.Find(id);
            return View(unidadefederativa);
        }

        // POST: /UnidadeFederativa/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            UnidadeFederativa unidadefederativa = db.UFs.Find(id);
            db.UFs.Remove(unidadefederativa);
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