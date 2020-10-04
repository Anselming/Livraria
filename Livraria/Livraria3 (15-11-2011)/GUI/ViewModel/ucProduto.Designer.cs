namespace Livraria.GUI.ViewModel
{
    partial class ucProduto
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
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.lbl_ValorUnitario = new System.Windows.Forms.Label();
            this.ttb_Descricao = new System.Windows.Forms.TextBox();
            this.ttb_ValorUnitario = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.ttb_Nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Location = new System.Drawing.Point(3, 42);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(55, 13);
            this.lbl_Descricao.TabIndex = 0;
            this.lbl_Descricao.Text = "Descrição";
            // 
            // lbl_ValorUnitario
            // 
            this.lbl_ValorUnitario.AutoSize = true;
            this.lbl_ValorUnitario.Location = new System.Drawing.Point(4, 79);
            this.lbl_ValorUnitario.Name = "lbl_ValorUnitario";
            this.lbl_ValorUnitario.Size = new System.Drawing.Size(70, 13);
            this.lbl_ValorUnitario.TabIndex = 1;
            this.lbl_ValorUnitario.Text = "Valor Unitário";
            // 
            // ttb_Descricao
            // 
            this.ttb_Descricao.Location = new System.Drawing.Point(81, 25);
            this.ttb_Descricao.Multiline = true;
            this.ttb_Descricao.Name = "ttb_Descricao";
            this.ttb_Descricao.Size = new System.Drawing.Size(192, 46);
            this.ttb_Descricao.TabIndex = 2;
            // 
            // ttb_ValorUnitario
            // 
            this.ttb_ValorUnitario.Location = new System.Drawing.Point(81, 72);
            this.ttb_ValorUnitario.Name = "ttb_ValorUnitario";
            this.ttb_ValorUnitario.Size = new System.Drawing.Size(106, 20);
            this.ttb_ValorUnitario.TabIndex = 2;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(4, 11);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome";
            // 
            // ttb_Nome
            // 
            this.ttb_Nome.Location = new System.Drawing.Point(81, 4);
            this.ttb_Nome.Name = "ttb_Nome";
            this.ttb_Nome.Size = new System.Drawing.Size(192, 20);
            this.ttb_Nome.TabIndex = 4;
            // 
            // ucProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ttb_Nome);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.ttb_ValorUnitario);
            this.Controls.Add(this.ttb_Descricao);
            this.Controls.Add(this.lbl_ValorUnitario);
            this.Controls.Add(this.lbl_Descricao);
            this.Name = "ucProduto";
            this.Size = new System.Drawing.Size(277, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Descricao;
        private System.Windows.Forms.Label lbl_ValorUnitario;
        private System.Windows.Forms.TextBox ttb_Descricao;
        private System.Windows.Forms.TextBox ttb_ValorUnitario;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox ttb_Nome;
    }
}
