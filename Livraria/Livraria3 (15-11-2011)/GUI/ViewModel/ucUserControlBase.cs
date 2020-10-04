using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Livraria.GUI.ViewModel
{
    public partial class ucUserControlBase : UserControl
    {
        #region ucUserControlBase: Construtores

        public ucUserControlBase()
        {
            InitializeComponent();
        }

        #endregion

        #region ucUserControlBase: Métodos Virtuais

        public virtual Size DefinirTamanhoDoForm()
        {
            return new Size(444, 640);
        }

        public virtual Size DefinirTamanhoDoContainer()
        {
            return new Size(380, 80);
        }

        public virtual object ObterVariacao()
        { return null; }

        public virtual void Atualizar()
        { return; }

        #endregion

    }
}
