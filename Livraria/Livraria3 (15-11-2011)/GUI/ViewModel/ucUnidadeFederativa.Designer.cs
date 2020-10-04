namespace Livraria.GUI.ViewModel
{
    partial class ucUnidadeFederativa
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
            this.ttb_Sigla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sigla";
            // 
            // ttb_Nome
            // 
            this.ttb_Nome.Location = new System.Drawing.Point(54, 4);
            this.ttb_Nome.Name = "ttb_Nome";
            this.ttb_Nome.Size = new System.Drawing.Size(221, 20);
            this.ttb_Nome.TabIndex = 1;
            // 
            // ttb_Sigla
            // 
            this.ttb_Sigla.Location = new System.Drawing.Point(54, 31);
            this.ttb_Sigla.MaxLength = 2;
            this.ttb_Sigla.Name = "ttb_Sigla";
            this.ttb_Sigla.Size = new System.Drawing.Size(46, 20);
            this.ttb_Sigla.TabIndex = 2;
            // 
            // ucUnidadeFederativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ttb_Sigla);
            this.Controls.Add(this.ttb_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucUnidadeFederativa";
            this.Size = new System.Drawing.Size(278, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttb_Nome;
        private System.Windows.Forms.TextBox ttb_Sigla;

    }
}
