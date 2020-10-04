using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Livraria.Repositorio.Repositorios
{
    public class RepositorioXML<TRepositorio>: IRepositorio<TRepositorio>
        where TRepositorio : class
    {
        #region RepositorioXML: Propriedades

        private string path = string.Format(@"{0}\{1}.xml", AppDomain.CurrentDomain.BaseDirectory, typeof(TRepositorio).Name);
        protected List<TRepositorio> lista;

        #endregion

        #region RepositorioXML: Construtores

        public RepositorioXML()
        {
            lista = new List<TRepositorio>();
        }

        #endregion

        #region RepositorioXML: Métodos privados

        protected virtual List<TRepositorio> Serialize()
        {
            try
            {
                if (File.Exists(path))
                    File.Delete(path);


                XmlWriter writer = XmlWriter.Create(path);

                XmlSerializer serializer =
                    new XmlSerializer(typeof(List<TRepositorio>));
                serializer.Serialize(writer, lista);

                writer.Flush();
                writer.Close();

                return lista;
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                throw new Exception(
                    string.Format("Caminho '{0}' não encontrado", path));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected virtual void Deserialize()
        {
            if (!File.Exists(path))
                return;

            XmlReader reader = XmlReader.Create(path);

            if (reader == null )
                return;

            XmlSerializer serializer =
                new XmlSerializer(typeof(List<TRepositorio>));
            lista = (List<TRepositorio>)serializer.Deserialize(reader);

            reader.Close();
        }

        #endregion

        #region IRepositorio<TRepositorio> Members

        public List<TRepositorio> Selecionar()
        {
            Deserialize();
            return lista;
        }

        public List<TRepositorio> Selecionar(Predicate<TRepositorio> selector)
        {
            Deserialize();
            return lista.FindAll(selector);
        }

        public void Inserir(TRepositorio t)
        {
            lista = Selecionar();
            lista.Add(t);
            Serialize();
        }

        public void Alterar(TRepositorio t_antigo, TRepositorio t_novo)
        {
            lista = Selecionar();
            TRepositorio objeto = lista.Find(obj => obj.Equals(t_antigo));

            if (objeto != null)
            {
                PropertyInfo[] propriedades = objeto.GetType().GetProperties();
                foreach (PropertyInfo prop in propriedades)
                {
                    // Buscando valor da propriedade no novo objeto
                    PropertyInfo propNovoObj = t_novo.GetType().GetProperty(prop.Name);
                    object valor = propNovoObj.GetValue(t_novo, null);

                    // Atribuindo o valor do novo objeto, ao objeto encontrado
                    prop.SetValue(objeto, valor, null);
                }

                Serialize();
            }
        }

        public void Excluir(TRepositorio t)
        {
            lista = Selecionar();
            lista.Remove(t);
            Serialize();
        }

        #endregion

    }
}
