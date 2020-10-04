using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Livraria.Modelo.Tipos
{
    [Serializable]
    [TypeConverter(typeof(Enum))]
    public enum TipoDeArmazenamento
    {
        ArquivoTexto,
        BancoDeDados
    }
}
