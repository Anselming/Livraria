using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Configuration;

namespace Livraria.Repositorio.ServiceAgent
{
    public static class CodeFirst
    {
        public static bool Generate()
        {
            return Repositorios.SqlEF4Context<Modelo.PessoaJuridica>.CodeFirst();
        }
    }
}
