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
    public class EnderecoController : Controller
    {
        private Context db = new Context();

        // GET: /Endereco/
        public ViewResult Index()
        {
            var enderecos = db.Enderecos.ToList();
            return View(enderecos);
        }

        // GET: /Endereco/Details/5
        public ViewResult Details(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            return View(endereco);
        }

        // GET: /Endereco/Complete
        public ActionResult Complete()
        { 
            return View();
        }

        // GET: /Endereco/Complete
        [HttpPost]
        public ActionResult Complete(Endereco e)
        {
            if (ModelState.IsValid)
            {
                db.Enderecos.Add(e);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(e);
        }

        // GET: /Endereco/Create
        public ActionResult Create()
        {
            ViewBag.BairroId = new SelectList(db.Bairros, "ID", "Nome");
            ViewBag.TipoLogradouroId = new SelectList(db.Logradouro, "ID", "Descricao");
            return View();
        } 

        // POST: /Endereco/Create
        [HttpPost]
        public ActionResult Create(Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                db.Enderecos.Add(endereco);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.BairroId = new SelectList(db.Bairros, "ID", "Nome", endereco.BairroId);
            ViewBag.TipoLogradouroId = new SelectList(db.Logradouro, "ID", "Descricao", endereco.TipoLogradouroId);
            return View(endereco);
        }
        
        // GET: /Endereco/Edit/5
        public ActionResult Edit(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            ViewBag.BairroId = new SelectList(db.Bairros, "ID", "Nome", endereco.BairroId);
            ViewBag.TipoLogradouroId = new SelectList(db.Logradouro, "ID", "Descricao", endereco.TipoLogradouroId);
            return View(endereco);
        }

        // POST: /Endereco/Edit/5
        [HttpPost]
        public ActionResult Edit(Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(endereco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BairroId = new SelectList(db.Bairros, "ID", "Nome", endereco.BairroId);
            ViewBag.TipoLogradouroId = new SelectList(db.Logradouro, "ID", "Descricao", endereco.TipoLogradouroId);
            return View(endereco);
        }

        // GET: /Endereco/Delete/5
        public ActionResult Delete(int id)
        {
            Endereco endereco = db.Enderecos.Find(id);
            return View(endereco);
        }

        // POST: /Endereco/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Endereco endereco = db.Enderecos.Find(id);
            db.Enderecos.Remove(endereco);
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