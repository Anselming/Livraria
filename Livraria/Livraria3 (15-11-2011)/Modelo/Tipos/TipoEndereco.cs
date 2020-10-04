using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Livraria.Modelo.Tipos
{
    [Serializable]
    [TypeConverter(typeof(Enum))]
    [Description("Tipo de Endereço.")]
    public enum TipoEndereco
    {
        [Description("Endereço Comercial")]
        Comercial,

        [Description("Endereço Residencial")]
        Residencial,

        [Description("Endereço de Cobrança")]
        Cobranca,

        [Description("Endereço de Entrega")]
        Entrega
    }
}
