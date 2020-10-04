namespace Livraria.GUI.ViewModel
{
    partial class ucPessoaFisica
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttb_Observacao = new System.Windows.Forms.TextBox();
            this.ttb_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ttb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.date_DataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.ttb_Nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AdicionarRemover_Enderecos = new Livraria.GUI.Controls.AdicionarRemover();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AdicionarRemover_Telefones = new Livraria.GUI.Controls.AdicionarRemover();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.TabIndex = 0;
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
            this.groupBox2.Controls.Add(this.ttb_CPF);
            this.groupBox2.Controls.Add(this.date_DataDeNascimento);
            this.groupBox2.Controls.Add(this.ttb_Nome);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pessoa Física";
            // 
            // ttb_CPF
            // 
            this.ttb_CPF.Location = new System.Drawing.Point(45, 38);
            this.ttb_CPF.Mask = "000.000.000-00";
            this.ttb_CPF.Name = "ttb_CPF";
            this.ttb_CPF.Size = new System.Drawing.Size(298, 20);
            this.ttb_CPF.TabIndex = 3;
            // 
            // date_DataDeNascimento
            // 
            this.date_DataDeNascimento.Location = new System.Drawing.Point(117, 66);
            this.date_DataDeNascimento.Name = "date_DataDeNascimento";
            this.date_DataDeNascimento.Size = new System.Drawing.Size(226, 20);
            this.date_DataDeNascimento.TabIndex = 2;
            // 
            // ttb_Nome
            // 
            this.ttb_Nome.Location = new System.Drawing.Point(45, 12);
            this.ttb_Nome.Name = "ttb_Nome";
            this.ttb_Nome.Size = new System.Drawing.Size(298, 20);
            this.ttb_Nome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AdicionarRemover_Enderecos);
            this.groupBox3.Location = new System.Drawing.Point(3, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 121);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereços";
            // 
            // AdicionarRemover_Enderecos
            // 
            this.AdicionarRemover_Enderecos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdicionarRemover_Enderecos.idPessoa = 0;
            this.AdicionarRemover_Enderecos.Location = new System.Drawing.Point(3, 16);
            this.AdicionarRemover_Enderecos.Name = "AdicionarRemover_Enderecos";
            this.AdicionarRemover_Enderecos.Size = new System.Drawing.Size(343, 102);
            this.AdicionarRemover_Enderecos.TabIndex = 0;
            this.AdicionarRemover_Enderecos.Valores = null;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AdicionarRemover_Telefones);
            this.groupBox4.Location = new System.Drawing.Point(3, 380);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 121);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Telefones";
            // 
            // AdicionarRemover_Telefones
            // 
            this.AdicionarRemover_Telefones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdicionarRemover_Telefones.idPessoa = 0;
            this.AdicionarRemover_Telefones.Location = new System.Drawing.Point(3, 16);
            this.AdicionarRemover_Telefones.Name = "AdicionarRemover_Telefones";
            this.AdicionarRemover_Telefones.Size = new System.Drawing.Size(343, 102);
            this.AdicionarRemover_Telefones.TabIndex = 0;
            this.AdicionarRemover_Telefones.Valores = null;
            // 
            // ucPessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucPessoaFisica";
            this.Size = new System.Drawing.Size(355, 507);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ttb_Observacao;
        private System.Windows.Forms.TextBox ttb_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker date_DataDeNascimento;
        private System.Windows.Forms.TextBox ttb_Nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Controls.AdicionarRemover AdicionarRemover_Enderecos;
        private Controls.AdicionarRemover AdicionarRemover_Telefones;
        private System.Windows.Forms.MaskedTextBox ttb_CPF;

    }
}
