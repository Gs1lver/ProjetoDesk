namespace Estudio
{
    partial class ConsultarModalidade
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnConsult = new System.Windows.Forms.Button();
            this.txtQtdeAulasConsult = new System.Windows.Forms.TextBox();
            this.txtQtdeAlunosConsult = new System.Windows.Forms.TextBox();
            this.txtPrecoConsult = new System.Windows.Forms.TextBox();
            this.cmbDescConsult = new System.Windows.Forms.ComboBox();
            this.lblQtdeAulasConsult = new System.Windows.Forms.Label();
            this.lblQtdeAlunosConsult = new System.Windows.Forms.Label();
            this.lblPrecoConsult = new System.Windows.Forms.Label();
            this.lblDescConsult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.btnConsult);
            this.groupBox1.Controls.Add(this.txtQtdeAulasConsult);
            this.groupBox1.Controls.Add(this.txtQtdeAlunosConsult);
            this.groupBox1.Controls.Add(this.txtPrecoConsult);
            this.groupBox1.Controls.Add(this.cmbDescConsult);
            this.groupBox1.Controls.Add(this.lblQtdeAulasConsult);
            this.groupBox1.Controls.Add(this.lblQtdeAlunosConsult);
            this.groupBox1.Controls.Add(this.lblPrecoConsult);
            this.groupBox1.Controls.Add(this.lblDescConsult);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidades";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(181, 266);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(93, 32);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnConsult
            // 
            this.btnConsult.Location = new System.Drawing.Point(56, 266);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(93, 32);
            this.btnConsult.TabIndex = 6;
            this.btnConsult.Text = "Consultar";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // txtQtdeAulasConsult
            // 
            this.txtQtdeAulasConsult.Location = new System.Drawing.Point(161, 216);
            this.txtQtdeAulasConsult.Name = "txtQtdeAulasConsult";
            this.txtQtdeAulasConsult.Size = new System.Drawing.Size(100, 22);
            this.txtQtdeAulasConsult.TabIndex = 5;
            // 
            // txtQtdeAlunosConsult
            // 
            this.txtQtdeAlunosConsult.Location = new System.Drawing.Point(161, 156);
            this.txtQtdeAlunosConsult.Name = "txtQtdeAlunosConsult";
            this.txtQtdeAlunosConsult.Size = new System.Drawing.Size(100, 22);
            this.txtQtdeAlunosConsult.TabIndex = 5;
            // 
            // txtPrecoConsult
            // 
            this.txtPrecoConsult.Location = new System.Drawing.Point(161, 100);
            this.txtPrecoConsult.Name = "txtPrecoConsult";
            this.txtPrecoConsult.Size = new System.Drawing.Size(100, 22);
            this.txtPrecoConsult.TabIndex = 5;
            // 
            // cmbDescConsult
            // 
            this.cmbDescConsult.FormattingEnabled = true;
            this.cmbDescConsult.Location = new System.Drawing.Point(161, 45);
            this.cmbDescConsult.Name = "cmbDescConsult";
            this.cmbDescConsult.Size = new System.Drawing.Size(271, 24);
            this.cmbDescConsult.TabIndex = 4;
            // 
            // lblQtdeAulasConsult
            // 
            this.lblQtdeAulasConsult.AutoSize = true;
            this.lblQtdeAulasConsult.Location = new System.Drawing.Point(53, 216);
            this.lblQtdeAulasConsult.Name = "lblQtdeAulasConsult";
            this.lblQtdeAulasConsult.Size = new System.Drawing.Size(95, 16);
            this.lblQtdeAulasConsult.TabIndex = 3;
            this.lblQtdeAulasConsult.Text = "Qtde de Aulas:";
            // 
            // lblQtdeAlunosConsult
            // 
            this.lblQtdeAlunosConsult.AutoSize = true;
            this.lblQtdeAlunosConsult.Location = new System.Drawing.Point(53, 159);
            this.lblQtdeAlunosConsult.Name = "lblQtdeAlunosConsult";
            this.lblQtdeAlunosConsult.Size = new System.Drawing.Size(102, 16);
            this.lblQtdeAlunosConsult.TabIndex = 2;
            this.lblQtdeAlunosConsult.Text = "Qtde de Alunos:";
            // 
            // lblPrecoConsult
            // 
            this.lblPrecoConsult.AutoSize = true;
            this.lblPrecoConsult.Location = new System.Drawing.Point(50, 103);
            this.lblPrecoConsult.Name = "lblPrecoConsult";
            this.lblPrecoConsult.Size = new System.Drawing.Size(46, 16);
            this.lblPrecoConsult.TabIndex = 1;
            this.lblPrecoConsult.Text = "Preço:";
            // 
            // lblDescConsult
            // 
            this.lblDescConsult.AutoSize = true;
            this.lblDescConsult.Location = new System.Drawing.Point(50, 48);
            this.lblDescConsult.Name = "lblDescConsult";
            this.lblDescConsult.Size = new System.Drawing.Size(72, 16);
            this.lblDescConsult.TabIndex = 0;
            this.lblDescConsult.Text = "Descrição:";
            // 
            // ConsultarModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 352);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultarModalidade";
            this.Text = "Consultar Modalidade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.TextBox txtQtdeAulasConsult;
        private System.Windows.Forms.TextBox txtQtdeAlunosConsult;
        private System.Windows.Forms.TextBox txtPrecoConsult;
        private System.Windows.Forms.ComboBox cmbDescConsult;
        private System.Windows.Forms.Label lblQtdeAulasConsult;
        private System.Windows.Forms.Label lblQtdeAlunosConsult;
        private System.Windows.Forms.Label lblPrecoConsult;
        private System.Windows.Forms.Label lblDescConsult;
        private System.Windows.Forms.Button btnAtualizar;
    }
}