using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Livraria.Modelo;
using System.Data;

namespace MvcPresentation.Controllers
{
    public class TelefoneController : Controller
    {
        private Context db = new Context();

        // GET: /Telefone/
        public ActionResult Index()
        {
            return View(db.Telefones.ToList());
        }

        // GET: /Telefone/Details/5
        public ActionResult Details(int id)
        {
            Telefone telefone = db.Telefones.Find(id);
            return View(telefone);
        }

        // GET: /Telefone/Create
        public ActionResult Create()
        {
            return View();
        } 

        // POST: /Telefone/Create
        [HttpPost]
        public ActionResult Create(Telefone telefone)
        {
            if (ModelState.IsValid)
            {
                db.Telefones.Add(telefone);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(telefone);
        }
        
        // GET: /Telefone/Edit/5
        public ActionResult Edit(int id)
        {
            Telefone telefone = db.Telefones.Find(id);
            return View(telefone);
        }

        // POST: /Telefone/Edit/5
        [HttpPost]
        public ActionResult Edit(Telefone telefone)
        {
            if (ModelState.IsValid)
            {
                db.Entry(telefone).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(telefone);
        }

        // GET: /Telefone/Delete/5
        public ActionResult Delete(int id)
        {
            Telefone pessoafisica = db.Telefones.Find(id);
            return View(pessoafisica);
        }

        // POST: /Telefone/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Telefone telefone = db.Telefones.Find(id);
                db.Telefones.Remove(telefone);
                db.SaveChanges();
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
