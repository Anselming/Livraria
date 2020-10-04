namespace Livraria.GUI.ViewModel
{
    partial class ucVenda
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adicionarRemover_ItensDeVenda = new Livraria.GUI.Controls.AdicionarRemover();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.btn_MaisCliente = new System.Windows.Forms.Button();
            this.rdb_TipoDePessoa1 = new System.Windows.Forms.RadioButton();
            this.rdb_TipoDePessoa2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // adicionarRemover_ItensDeVenda
            // 
            this.adicionarRemover_ItensDeVenda.idPessoa = 0;
            this.adicionarRemover_ItensDeVenda.Location = new System.Drawing.Point(3, 55);
            this.adicionarRemover_ItensDeVenda.Name = "adicionarRemover_ItensDeVenda";
            this.adicionarRemover_ItensDeVenda.Size = new System.Drawing.Size(507, 156);
            this.adicionarRemover_ItensDeVenda.TabIndex = 0;
            this.adicionarRemover_ItensDeVenda.Valores = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Location = new System.Drawing.Point(6, 11);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(39, 13);
            this.lbl_Cliente.TabIndex = 2;
            this.lbl_Cliente.Text = "Cliente";
            // 
            // cmb_Cliente
            // 
            this.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cliente.FormattingEnabled = true;
            this.cmb_Cliente.Location = new System.Drawing.Point(51, 3);
            this.cmb_Cliente.Name = "cmb_Cliente";
            this.cmb_Cliente.Size = new System.Drawing.Size(459, 21);
            this.cmb_Cliente.TabIndex = 3;
            // 
            // btn_MaisCliente
            // 
            this.btn_MaisCliente.Location = new System.Drawing.Point(484, 24);
            this.btn_MaisCliente.Name = "btn_MaisCliente";
            this.btn_MaisCliente.Size = new System.Drawing.Size(26, 23);
            this.btn_MaisCliente.TabIndex = 4;
            this.btn_MaisCliente.Text = "+";
            this.btn_MaisCliente.UseVisualStyleBackColor = true;
            this.btn_MaisCliente.Click += new System.EventHandler(this.btn_MaisCliente_Click);
            // 
            // rdb_TipoDePessoa1
            // 
            this.rdb_TipoDePessoa1.AutoSize = true;
            this.rdb_TipoDePessoa1.Checked = true;
            this.rdb_TipoDePessoa1.Location = new System.Drawing.Point(265, 30);
            this.rdb_TipoDePessoa1.Name = "rdb_TipoDePessoa1";
            this.rdb_TipoDePessoa1.Size = new System.Drawing.Size(92, 17);
            this.rdb_TipoDePessoa1.TabIndex = 5;
            this.rdb_TipoDePessoa1.TabStop = true;
            this.rdb_TipoDePessoa1.Text = "Pessoa Física";
            this.rdb_TipoDePessoa1.UseVisualStyleBackColor = true;
            this.rdb_TipoDePessoa1.CheckedChanged += new System.EventHandler(this.rdb_TipoDePessoa1_CheckedChanged);
            // 
            // rdb_TipoDePessoa2
            // 
            this.rdb_TipoDePessoa2.AutoSize = true;
            this.rdb_TipoDePessoa2.Location = new System.Drawing.Point(377, 30);
            this.rdb_TipoDePessoa2.Name = "rdb_TipoDePessoa2";
            this.rdb_TipoDePessoa2.Size = new System.Drawing.Size(101, 17);
            this.rdb_TipoDePessoa2.TabIndex = 5;
            this.rdb_TipoDePessoa2.TabStop = true;
            this.rdb_TipoDePessoa2.Text = "Pessoa Jurídica";
            this.rdb_TipoDePessoa2.UseVisualStyleBackColor = true;
            this.rdb_TipoDePessoa2.CheckedChanged += new System.EventHandler(this.rdb_TipoDePessoa2_CheckedChanged);
            // 
            // ucVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdb_TipoDePessoa2);
            this.Controls.Add(this.rdb_TipoDePessoa1);
            this.Controls.Add(this.btn_MaisCliente);
            this.Controls.Add(this.cmb_Cliente);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adicionarRemover_ItensDeVenda);
            this.Name = "ucVenda";
            this.Size = new System.Drawing.Size(513, 233);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.AdicionarRemover adicionarRemover_ItensDeVenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.ComboBox cmb_Cliente;
        private System.Windows.Forms.Button btn_MaisCliente;
        private System.Windows.Forms.RadioButton rdb_TipoDePessoa1;
        private System.Windows.Forms.RadioButton rdb_TipoDePessoa2;
    }
}
