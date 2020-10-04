namespace Livraria.GUI.ViewModel
{
    partial class ucTelefone
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
            this.label3 = new System.Windows.Forms.Label();
            this.ttb_Ramal = new System.Windows.Forms.TextBox();
            this.ttb_DDD = new System.Windows.Forms.MaskedTextBox();
            this.ttb_Numero = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DDD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ramal";
            // 
            // ttb_Ramal
            // 
            this.ttb_Ramal.Location = new System.Drawing.Point(74, 42);
            this.ttb_Ramal.Name = "ttb_Ramal";
            this.ttb_Ramal.Size = new System.Drawing.Size(278, 20);
            this.ttb_Ramal.TabIndex = 4;
            // 
            // ttb_DDD
            // 
            this.ttb_DDD.Location = new System.Drawing.Point(74, 2);
            this.ttb_DDD.Mask = "(999)";
            this.ttb_DDD.Name = "ttb_DDD";
            this.ttb_DDD.Size = new System.Drawing.Size(66, 20);
            this.ttb_DDD.TabIndex = 5;
            // 
            // ttb_Numero
            // 
            this.ttb_Numero.Location = new System.Drawing.Point(74, 22);
            this.ttb_Numero.Mask = "0000-0000";
            this.ttb_Numero.Name = "ttb_Numero";
            this.ttb_Numero.Size = new System.Drawing.Size(278, 20);
            this.ttb_Numero.TabIndex = 6;
            // 
            // ucTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ttb_Numero);
            this.Controls.Add(this.ttb_DDD);
            this.Controls.Add(this.ttb_Ramal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucTelefone";
            this.Size = new System.Drawing.Size(355, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttb_Ramal;
        private System.Windows.Forms.MaskedTextBox ttb_DDD;
        private System.Windows.Forms.MaskedTextBox ttb_Numero;
    }
}
