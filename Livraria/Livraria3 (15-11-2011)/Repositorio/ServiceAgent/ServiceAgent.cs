using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Livraria.Repositorio.ServiceAgent
{
    public class ServiceAgent<T>: IDisposable
        where T: class
    {
        #region ServiceAgent<T>: Propriedades

        public string TipoDePersistencia { get; private set; }
        public Repositorio.Repositorios.IRepositorio<T> Repositorio
        {
            get
            {
                TipoDePersistencia = ((string)ConfigurationManager.AppSettings["tipoPersistencia"]).Trim().ToLower();
                return FabricaRepositorio(TipoDePersistencia);
            }
        }

        #endregion

        #region ServiceAgent<T>: Métodos Privados

        private Repositorios.IRepositorio<T> FabricaRepositorio(string tipoDePersistencia)
        {
            switch (tipoDePersistencia)
            {
                case "xml":
                    return new Repositorios.RepositorioXML<T>();

                case "banco":
                    return new Repositorios.RepositorioSQLServer<T>();

                default:
                    throw new ArgumentException("Repositório de configuração inválido.");
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion

    }
}
