namespace Livraria.GUI.ViewModel
{
    partial class ucEndereco
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
            this.btn_MaisBairro = new System.Windows.Forms.Button();
            this.cmb_TipoEndereco = new System.Windows.Forms.ComboBox();
            this.cmb_Bairro = new System.Windows.Forms.ComboBox();
            this.ttb_Endereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttb_CEP = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_MaisBairro
            // 
            this.btn_MaisBairro.Location = new System.Drawing.Point(319, 23);
            this.btn_MaisBairro.Name = "btn_MaisBairro";
            this.btn_MaisBairro.Size = new System.Drawing.Size(30, 23);
            this.btn_MaisBairro.TabIndex = 11;
            this.btn_MaisBairro.Text = "+";
            this.btn_MaisBairro.UseVisualStyleBackColor = true;
            this.btn_MaisBairro.Click += new System.EventHandler(this.btn_MaisBairro_Click);
            // 
            // cmb_TipoEndereco
            // 
            this.cmb_TipoEndereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoEndereco.FormattingEnabled = true;
            this.cmb_TipoEndereco.Location = new System.Drawing.Point(64, 69);
            this.cmb_TipoEndereco.Name = "cmb_TipoEndereco";
            this.cmb_TipoEndereco.Size = new System.Drawing.Size(154, 21);
            this.cmb_TipoEndereco.TabIndex = 10;
            // 
            // cmb_Bairro
            // 
            this.cmb_Bairro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Bairro.FormattingEnabled = true;
            this.cmb_Bairro.Location = new System.Drawing.Point(64, 24);
            this.cmb_Bairro.Name = "cmb_Bairro";
            this.cmb_Bairro.Size = new System.Drawing.Size(249, 21);
            this.cmb_Bairro.TabIndex = 9;
            // 
            // ttb_Endereco
            // 
            this.ttb_Endereco.Location = new System.Drawing.Point(64, 3);
            this.ttb_Endereco.Name = "ttb_Endereco";
            this.ttb_Endereco.Size = new System.Drawing.Size(285, 20);
            this.ttb_Endereco.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bairro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CEP";
            // 
            // ttb_CEP
            // 
            this.ttb_CEP.Location = new System.Drawing.Point(64, 47);
            this.ttb_CEP.Mask = "00000-999";
            this.ttb_CEP.Name = "ttb_CEP";
            this.ttb_CEP.Size = new System.Drawing.Size(100, 20);
            this.ttb_CEP.TabIndex = 12;
            // 
            // ucEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ttb_CEP);
            this.Controls.Add(this.btn_MaisBairro);
            this.Controls.Add(this.cmb_TipoEndereco);
            this.Controls.Add(this.cmb_Bairro);
            this.Controls.Add(this.ttb_Endereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucEndereco";
            this.Size = new System.Drawing.Size(355, 101);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ttb_Endereco;
        private System.Windows.Forms.ComboBox cmb_Bairro;
        private System.Windows.Forms.ComboBox cmb_TipoEndereco;
        private System.Windows.Forms.Button btn_MaisBairro;
        private System.Windows.Forms.MaskedTextBox ttb_CEP;
    }
}
