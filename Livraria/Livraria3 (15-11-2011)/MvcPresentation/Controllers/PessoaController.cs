using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Livraria.Modelo;
using System.Data;

namespace MvcPresentation.Controllers
{
    public class PessoaController : Controller
    {
        private Context db = new Context();

        // GET: /Pessoa/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Pessoa/
        public ActionResult Create()
        {
            return View();
        }



        // GET: /Pessoa/id
        public ActionResult EditFisicas(int id)
        {
            
            PessoaFisica PessoaFisica = db.Fisicas.Find(id);

            return View(PessoaFisica);
        }

        // GET: /Pessoa/id
        public ActionResult EditJuridicas(int id)
        {
            PessoaJuridica PessoaJuridica = db.Juridicas.Find(id);
            return View(PessoaJuridica);
        }
        
        [HttpPost]
        public ActionResult EditFisicas(PessoaFisica pessoaFisica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoaFisica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pessoaFisica);
        }

        [HttpPost]
        public ActionResult EditJuridicas(PessoaJuridica pessoaJuridica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoaJuridica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pessoaJuridica);
        }

        // GET: /Pessoa/id
        public ActionResult DetailsFisica(int id)
        {
            PessoaFisica PessoaFisica = db.Fisicas.Find(id);
            return View(PessoaFisica);
        }

        // GET: /Pessoa/id
        public ActionResult DetailsJuridica(int id)
        {
            PessoaJuridica PessoaJuridica = db.Juridicas.Find(id);
            return View(PessoaJuridica);
        }

        // GET: /Pessoa/
        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            string tipoCliente = form["tipoCliente"];

            Livraria.Modelo.Endereco endereco = new Livraria.Modelo.Endereco();
            endereco.BairroId = int.Parse( form["bairro"]);
            endereco.Bairro = new Livraria.Modelo.Bairro()
            {
                ID = int.Parse(form["bairro"]),
                CidadeId = int.Parse(form["cidade"]),
                Cidade = new Livraria.Modelo.Cidade()
                {
                    ID = int.Parse(form["cidade"]),
                    UfId = int.Parse(form["unidadefederativa"]),
                }
            };
            endereco.CEP = form["cep"];
            endereco.TipoLogradouro = new Livraria.Modelo.TipoLogradouro()
            {
                Descricao = form["logradouro"],
            };

            Telefone telefone = new Telefone()
            {
                Ddd = form["ddd"],
                Numero = form["numero"],
                Ramal = form["ramal"],
            };

            
            if (tipoCliente == "pessoafisica")
            {
                Livraria.Modelo.PessoaFisica pessoaFisica = new Livraria.Modelo.PessoaFisica();
                pessoaFisica.Nome = form["nome"];
                pessoaFisica.Cpf = form["cpf"];
                pessoaFisica.DataNascimento = DateTime.Parse(form["datadenascimento"]);
                pessoaFisica.Email = form["email1"];
                pessoaFisica.Observacao = form["Observação1"];
                pessoaFisica.Enderecos = new List<Endereco>();
                pessoaFisica.Telefones = new List<Telefone>();
                pessoaFisica.Enderecos.Add(endereco);
                pessoaFisica.Telefones.Add(telefone);

                db.Fisicas.Add(pessoaFisica);
                db.SaveChanges();
            }
            else
                if (tipoCliente == "pessoajuridica")
                {
                    Livraria.Modelo.PessoaJuridica pessoaJuridica = new Livraria.Modelo.PessoaJuridica();
                    pessoaJuridica.NomeFantasia = form["nomefantasia"];
                    pessoaJuridica.Cnpj = form["CNPJ"];
                    pessoaJuridica.RazaoSocial = form["RazaoSocial"];
                    pessoaJuridica.IE = form["IE"];
                    pessoaJuridica.IM = form["IM"];
                    pessoaJuridica.Email = form["Email2"];
                    pessoaJuridica.Observacao = form["Observação2"];
                    pessoaJuridica.Enderecos = new List<Endereco>();
                    pessoaJuridica.Telefones = new List<Telefone>();
                    pessoaJuridica.Enderecos.Add(endereco);
                    pessoaJuridica.Telefones.Add(telefone);

                    db.Juridicas.Add(pessoaJuridica);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception();
                }
            
            return View();
        }

        public ActionResult DeleteFisica(int id)
        {
            PessoaFisica pessoaFisica = db.Fisicas.Find(id);
            return View(pessoaFisica);
        }

        public ActionResult DeleteJuridica(int id)
        {
            PessoaJuridica pessoaJuridica = db.Juridicas.Find(id);
            return View(pessoaJuridica);
        }

        [HttpPost]
        public ActionResult DeleteFisica(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                PessoaFisica pessoaFisica = db.Fisicas.Find(id);
                db.Fisicas.Remove(pessoaFisica);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        [HttpPost]
        public ActionResult DeleteJuridica(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                PessoaJuridica pessoaJuridica = db.Juridicas.Find(id);
                db.Juridicas.Remove(pessoaJuridica);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
