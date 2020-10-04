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
    public class PessoaFisicaController : Controller
    {
        private Context db = new Context();

        // GET: /PessoaFisica/
        public ViewResult Index()
        {
            return View(db.Fisicas.ToList());
        }

        // GET: /PessoaFisica/Details/5
        public ViewResult Details(int id)
        {
            PessoaFisica pessoafisica = db.Fisicas.Find(id);
            return View(pessoafisica);
        }

        // GET: /PessoaFisica/Create
        public ActionResult Create()
        {
            return View();
        } 

        // POST: /PessoaFisica/Create
        [HttpPost]
        public ActionResult Create(PessoaFisica pessoafisica)
        {
            if (ModelState.IsValid)
            {
                db.Fisicas.Add(pessoafisica);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(pessoafisica);
        }
        
        // GET: /PessoaFisica/Edit/5
        public ActionResult Edit(int id)
        {
            PessoaFisica pessoafisica = db.Fisicas.Find(id);
            return View(pessoafisica);
        }

        // POST: /PessoaFisica/Edit/5
        [HttpPost]
        public ActionResult Edit(PessoaFisica pessoafisica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoafisica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pessoafisica);
        }

        // GET: /PessoaFisica/Delete/5
        public ActionResult Delete(int id)
        {
            PessoaFisica pessoafisica = db.Fisicas.Find(id);
            return View(pessoafisica);
        }

        // POST: /PessoaFisica/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            PessoaFisica pessoafisica = db.Fisicas.Find(id);
            db.Fisicas.Remove(pessoafisica);
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