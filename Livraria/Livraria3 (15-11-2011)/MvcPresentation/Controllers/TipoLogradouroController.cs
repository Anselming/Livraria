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
    public class TipoLogradouroController : Controller
    {
        private Context db = new Context();

        // GET: /TipoLogradouro/
        public ViewResult Index()
        {
            return View(db.Logradouro.ToList());
        }

        // GET: /TipoLogradouro/Details/5
        public ViewResult Details(int id)
        {
            TipoLogradouro tipologradouro = db.Logradouro.Find(id);
            return View(tipologradouro);
        }

        // GET: /TipoLogradouro/Create
        public ActionResult Create()
        {
            return View();
        } 

        // POST: /TipoLogradouro/Create
        [HttpPost]
        public ActionResult Create(TipoLogradouro tipologradouro)
        {
            if (ModelState.IsValid)
            {
                db.Logradouro.Add(tipologradouro);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(tipologradouro);
        }
        
        // GET: /TipoLogradouro/Edit/5
        public ActionResult Edit(int id)
        {
            TipoLogradouro tipologradouro = db.Logradouro.Find(id);
            return View(tipologradouro);
        }

        // POST: /TipoLogradouro/Edit/5
        [HttpPost]
        public ActionResult Edit(TipoLogradouro tipologradouro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipologradouro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipologradouro);
        }

        // GET: /TipoLogradouro/Delete/5
        public ActionResult Delete(int id)
        {
            TipoLogradouro tipologradouro = db.Logradouro.Find(id);
            return View(tipologradouro);
        }

        // POST: /TipoLogradouro/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            TipoLogradouro tipologradouro = db.Logradouro.Find(id);
            db.Logradouro.Remove(tipologradouro);
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