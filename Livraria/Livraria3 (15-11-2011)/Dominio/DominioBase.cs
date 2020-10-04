using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Livraria.Dominio
{
    public class DominioBase: IDisposable
    {
        public static bool CodeFirst()
        {
            return Repositorio.ServiceAgent.CodeFirst.Generate();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
