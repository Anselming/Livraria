using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Livraria.Modelo.Tipos
{    
    [Serializable]
    [TypeConverter(typeof(Enum))]
    [Description("Tipo de Logradouro.")]
    public enum TipoLogradouro
    {
        [Description("Avenida")]
        Avenida,

        [Description("Rua")]
        Rua,

        [Description("Estrada")]
        Estrada,

        [Description("Praça")]
        Praca,
    }
}
