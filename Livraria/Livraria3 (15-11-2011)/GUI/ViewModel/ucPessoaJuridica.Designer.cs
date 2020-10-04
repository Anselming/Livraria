namespace Livraria.GUI.ViewModel
{
    partial class ucPessoaJuridica
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
            this.ttb_RazaoSocial = new System.Windows.Forms.TextBox();
            this.ttb_NomeFantasia = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AdicionarRemover_Telefones = new Livraria.GUI.Controls.AdicionarRemover();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AdicionarRemover_Enderecos = new Livraria.GUI.Controls.AdicionarRemover();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttb_Observacao = new System.Windows.Forms.TextBox();
            this.ttb_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ttb_IM = new System.Windows.Forms.TextBox();
            this.ttb_IE = new System.Windows.Forms.TextBox();
            this.ttb_CNPJ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttb_RazaoSocial
            // 
            this.ttb_RazaoSocial.Location = new System.Drawing.Point(103, 38);
            this.ttb_RazaoSocial.Name = "ttb_RazaoSocial";
            this.ttb_RazaoSocial.Size = new System.Drawing.Size(240, 20);
            this.ttb_RazaoSocial.TabIndex = 1;
            // 
            // ttb_NomeFantasia
            // 
            this.ttb_NomeFantasia.Location = new System.Drawing.Point(103, 12);
            this.ttb_NomeFantasia.Name = "ttb_NomeFantasia";
            this.ttb_NomeFantasia.Size = new System.Drawing.Size(240, 20);
            this.ttb_NomeFantasia.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AdicionarRemover_Telefones);
            this.groupBox4.Location = new System.Drawing.Point(3, 400);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 110);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Telefones";
            // 
            // AdicionarRemover_Telefones
            // 
            this.AdicionarRemover_Telefones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdicionarRemover_Telefones.idPessoa = 0;
            this.AdicionarRemover_Telefones.Location = new System.Drawing.Point(3, 16);
            this.AdicionarRemover_Telefones.Name = "AdicionarRemover_Telefones";
            this.AdicionarRemover_Telefones.Size = new System.Drawing.Size(343, 91);
            this.AdicionarRemover_Telefones.TabIndex = 0;
            this.AdicionarRemover_Telefones.Valores = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CNPJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Razão Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome Fantasia";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AdicionarRemover_Enderecos);
            this.groupBox3.Location = new System.Drawing.Point(3, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 110);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereços";
            // 
            // AdicionarRemover_Enderecos
            // 
            this.AdicionarRemover_Enderecos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdicionarRemover_Enderecos.idPessoa = 0;
            this.AdicionarRemover_Enderecos.Location = new System.Drawing.Point(3, 16);
            this.AdicionarRemover_Enderecos.Name = "AdicionarRemover_Enderecos";
            this.AdicionarRemover_Enderecos.Size = new System.Drawing.Size(343, 91);
            this.AdicionarRemover_Enderecos.TabIndex = 0;
            this.AdicionarRemover_Enderecos.Valores = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttb_Observacao);
            this.groupBox1.Controls.Add(this.ttb_Email);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Gerais";
            // 
            // ttb_Observacao
            // 
            this.ttb_Observacao.Location = new System.Drawing.Point(10, 60);
            this.ttb_Observacao.Multiline = true;
            this.ttb_Observacao.Name = "ttb_Observacao";
            this.ttb_Observacao.Size = new System.Drawing.Size(333, 72);
            this.ttb_Observacao.TabIndex = 2;
            // 
            // ttb_Email
            // 
            this.ttb_Email.Location = new System.Drawing.Point(45, 17);
            this.ttb_Email.Name = "ttb_Email";
            this.ttb_Email.Size = new System.Drawing.Size(298, 20);
            this.ttb_Email.TabIndex = 1;
            this.ttb_Email.Leave += new System.EventHandler(this.ttb_Email_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Observação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ttb_IM);
            this.groupBox2.Controls.Add(this.ttb_IE);
            this.groupBox2.Controls.Add(this.ttb_CNPJ);
            this.groupBox2.Controls.Add(this.ttb_RazaoSocial);
            this.groupBox2.Controls.Add(this.ttb_NomeFantasia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pessoa Física";
            // 
            // ttb_IM
            // 
            this.ttb_IM.Location = new System.Drawing.Point(103, 104);
            this.ttb_IM.Name = "ttb_IM";
            this.ttb_IM.Size = new System.Drawing.Size(240, 20);
            this.ttb_IM.TabIndex = 4;
            // 
            // ttb_IE
            // 
            this.ttb_IE.Location = new System.Drawing.Point(103, 82);
            this.ttb_IE.Name = "ttb_IE";
            this.ttb_IE.Size = new System.Drawing.Size(240, 20);
            this.ttb_IE.TabIndex = 3;
            // 
            // ttb_CNPJ
            // 
            this.ttb_CNPJ.Location = new System.Drawing.Point(103, 59);
            this.ttb_CNPJ.Name = "ttb_CNPJ";
            this.ttb_CNPJ.Size = new System.Drawing.Size(240, 20);
            this.ttb_CNPJ.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "IM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "IE";
            // 
            // ucPessoaJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ucPessoaJuridica";
            this.Size = new System.Drawing.Size(355, 513);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ttb_RazaoSocial;
        private System.Windows.Forms.TextBox ttb_NomeFantasia;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ttb_Observacao;
        private System.Windows.Forms.TextBox ttb_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ttb_IM;
        private System.Windows.Forms.TextBox ttb_IE;
        private System.Windows.Forms.TextBox ttb_CNPJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Controls.AdicionarRemover AdicionarRemover_Telefones;
        private Controls.AdicionarRemover AdicionarRemover_Enderecos;

    }
}
