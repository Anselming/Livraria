namespace Livraria.GUI.ViewModel
{
    partial class ucCidade
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
            this.cmb_UF = new System.Windows.Forms.ComboBox();
            this.btn_MaisUF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "UF";
            // 
            // ttb_Nome
            // 
            this.ttb_Nome.Location = new System.Drawing.Point(46, 4);
            this.ttb_Nome.Name = "ttb_Nome";
            this.ttb_Nome.Size = new System.Drawing.Size(306, 20);
            this.ttb_Nome.TabIndex = 1;
            // 
            // cmb_UF
            // 
            this.cmb_UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UF.FormattingEnabled = true;
            this.cmb_UF.Location = new System.Drawing.Point(46, 27);
            this.cmb_UF.Name = "cmb_UF";
            this.cmb_UF.Size = new System.Drawing.Size(259, 21);
            this.cmb_UF.TabIndex = 2;
            // 
            // btn_MaisUF
            // 
            this.btn_MaisUF.Location = new System.Drawing.Point(311, 27);
            this.btn_MaisUF.Name = "btn_MaisUF";
            this.btn_MaisUF.Size = new System.Drawing.Size(41, 23);
            this.btn_MaisUF.TabIndex = 3;
            this.btn_MaisUF.Text = "+";
            this.btn_MaisUF.UseVisualStyleBackColor = true;
            this.btn_MaisUF.Click += new System.EventHandler(this.btn_MaisUF_Click);
            // 
            // ucCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_MaisUF);
            this.Controls.Add(this.cmb_UF);
            this.Controls.Add(this.ttb_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucCidade";
            this.Size = new System.Drawing.Size(355, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttb_Nome;
        private System.Windows.Forms.ComboBox cmb_UF;
        private System.Windows.Forms.Button btn_MaisUF;

    }
}
