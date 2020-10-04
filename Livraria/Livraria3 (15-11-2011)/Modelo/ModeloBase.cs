using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Livraria.Modelo
{
    public abstract class ModeloBase
    {
        [Browsable(false)]
        public int ID { get; set; }
    }
}
