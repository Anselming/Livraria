namespace Livraria.GUI.Controls
{
    partial class AdicionarRemover
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
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ckb_Inseridos = new System.Windows.Forms.CheckedListBox();
            this.ckb_NaoInseridos = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-145, -51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.ckb_Inseridos, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ckb_NaoInseridos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 329);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ckb_Inseridos
            // 
            this.ckb_Inseridos.CheckOnClick = true;
            this.ckb_Inseridos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_Inseridos.FormattingEnabled = true;
            this.ckb_Inseridos.Location = new System.Drawing.Point(258, 3);
            this.ckb_Inseridos.Name = "ckb_Inseridos";
            this.ckb_Inseridos.Size = new System.Drawing.Size(204, 323);
            this.ckb_Inseridos.TabIndex = 3;
            // 
            // ckb_NaoInseridos
            // 
            this.ckb_NaoInseridos.CheckOnClick = true;
            this.ckb_NaoInseridos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_NaoInseridos.FormattingEnabled = true;
            this.ckb_NaoInseridos.Location = new System.Drawing.Point(3, 3);
            this.ckb_NaoInseridos.Name = "ckb_NaoInseridos";
            this.ckb_NaoInseridos.Size = new System.Drawing.Size(203, 323);
            this.ckb_NaoInseridos.TabIndex = 1;
            this.ckb_NaoInseridos.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Inserir, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Remover, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(212, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(40, 323);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Inserir.Location = new System.Drawing.Point(3, 135);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(34, 23);
            this.btn_Inserir.TabIndex = 0;
            this.btn_Inserir.Text = ">>";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Remover.Location = new System.Drawing.Point(3, 164);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(34, 23);
            this.btn_Remover.TabIndex = 1;
            this.btn_Remover.Text = "<<";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // AdicionarRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdicionarRemover";
            this.Size = new System.Drawing.Size(465, 329);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox ckb_Inseridos;
        private System.Windows.Forms.CheckedListBox ckb_NaoInseridos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Remover;

    }
}
