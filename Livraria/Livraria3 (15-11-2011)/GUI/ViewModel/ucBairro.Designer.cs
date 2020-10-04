namespace Livraria.GUI.ViewModel
{
    partial class ucBairro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttb_Nome = new System.Windows.Forms.TextBox();
            this.cmb_Cidade = new System.Windows.Forms.ComboBox();
            this.btn_MaisCidade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cidade";
            // 
            // ttb_Nome
            // 
            this.ttb_Nome.Location = new System.Drawing.Point(54, 0);
            this.ttb_Nome.Name = "ttb_Nome";
            this.ttb_Nome.Size = new System.Drawing.Size(297, 20);
            this.ttb_Nome.TabIndex = 2;
            // 
            // cmb_Cidade
            // 
            this.cmb_Cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cidade.FormattingEnabled = true;
            this.cmb_Cidade.Location = new System.Drawing.Point(54, 22);
            this.cmb_Cidade.Name = "cmb_Cidade";
            this.cmb_Cidade.Size = new System.Drawing.Size(261, 21);
            this.cmb_Cidade.TabIndex = 3;
            // 
            // btn_MaisCidade
            // 
            this.btn_MaisCidade.Location = new System.Drawing.Point(321, 20);
            this.btn_MaisCidade.Name = "btn_MaisCidade";
            this.btn_MaisCidade.Size = new System.Drawing.Size(30, 23);
            this.btn_MaisCidade.TabIndex = 4;
            this.btn_MaisCidade.Text = "+";
            this.btn_MaisCidade.UseVisualStyleBackColor = true;
            this.btn_MaisCidade.Click += new System.EventHandler(this.btn_MaisCidade_Click);
            // 
            // ucBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_MaisCidade);
            this.Controls.Add(this.cmb_Cidade);
            this.Controls.Add(this.ttb_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ucBairro";
            this.Size = new System.Drawing.Size(355, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttb_Nome;
        private System.Windows.Forms.ComboBox cmb_Cidade;
        private System.Windows.Forms.Button btn_MaisCidade;

    }
}
