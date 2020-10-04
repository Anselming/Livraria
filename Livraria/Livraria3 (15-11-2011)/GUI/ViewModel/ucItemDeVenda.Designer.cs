namespace Livraria.GUI.ViewModel
{
    partial class ucItemDeVenda
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
            this.cmb_Produto = new System.Windows.Forms.ComboBox();
            this.lbl_Produto = new System.Windows.Forms.Label();
            this.lbl_Quantidade = new System.Windows.Forms.Label();
            this.ttb_Quantidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Produto
            // 
            this.cmb_Produto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Produto.FormattingEnabled = true;
            this.cmb_Produto.Location = new System.Drawing.Point(74, 8);
            this.cmb_Produto.Name = "cmb_Produto";
            this.cmb_Produto.Size = new System.Drawing.Size(193, 21);
            this.cmb_Produto.TabIndex = 0;
            // 
            // lbl_Produto
            // 
            this.lbl_Produto.AutoSize = true;
            this.lbl_Produto.Location = new System.Drawing.Point(4, 16);
            this.lbl_Produto.Name = "lbl_Produto";
            this.lbl_Produto.Size = new System.Drawing.Size(44, 13);
            this.lbl_Produto.TabIndex = 1;
            this.lbl_Produto.Text = "Produto";
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.AutoSize = true;
            this.lbl_Quantidade.Location = new System.Drawing.Point(4, 44);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(62, 13);
            this.lbl_Quantidade.TabIndex = 2;
            this.lbl_Quantidade.Text = "Quantidade";
            // 
            // ttb_Quantidade
            // 
            this.ttb_Quantidade.Location = new System.Drawing.Point(74, 37);
            this.ttb_Quantidade.Name = "ttb_Quantidade";
            this.ttb_Quantidade.Size = new System.Drawing.Size(104, 20);
            this.ttb_Quantidade.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucItemDeVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ttb_Quantidade);
            this.Controls.Add(this.lbl_Quantidade);
            this.Controls.Add(this.lbl_Produto);
            this.Controls.Add(this.cmb_Produto);
            this.Name = "ucItemDeVenda";
            this.Size = new System.Drawing.Size(307, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Produto;
        private System.Windows.Forms.Label lbl_Produto;
        private System.Windows.Forms.Label lbl_Quantidade;
        private System.Windows.Forms.TextBox ttb_Quantidade;
        private System.Windows.Forms.Button button1;
    }
}
