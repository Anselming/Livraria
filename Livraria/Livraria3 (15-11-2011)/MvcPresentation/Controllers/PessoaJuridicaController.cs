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
    public class PessoaJuridicaController : Controller
    {
        private Context db = new Context();

        // GET: /PessoaJuridica/
        public ViewResult Index()
        {
            return View(db.Juridicas.ToList());
        }

        // GET: /PessoaJuridica/Details/5
        public ViewResult Details(int id)
        {
            PessoaJuridica pessoajuridica = db.Juridicas.Find(id);
            return View(pessoajuridica);
        }

        // GET: /PessoaJuridica/Create
        public ActionResult Create()
        {
            return View();
        } 

        // POST: /PessoaJuridica/Create
        [HttpPost]
        public ActionResult Create(PessoaJuridica pessoajuridica)
        {
            if (ModelState.IsValid)
            {
                db.Juridicas.Add(pessoajuridica);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(pessoajuridica);
        }
        
        // GET: /PessoaJuridica/Edit/5
        public ActionResult Edit(int id)
        {
            PessoaJuridica pessoajuridica = db.Juridicas.Find(id);
            return View(pessoajuridica);
        }

        // POST: /PessoaJuridica/Edit/5
        [HttpPost]
        public ActionResult Edit(PessoaJuridica pessoajuridica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoajuridica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pessoajuridica);
        }

        // GET: /PessoaJuridica/Delete/5
        public ActionResult Delete(int id)
        {
            PessoaJuridica pessoajuridica = db.Juridicas.Find(id);
            return View(pessoajuridica);
        }

        // POST: /PessoaJuridica/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            PessoaJuridica pessoajuridica = db.Juridicas.Find(id);
            db.Juridicas.Remove(pessoajuridica);
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