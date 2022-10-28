namespace Estudio
{
    partial class CadastroModalidade
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpCadastrarMod = new System.Windows.Forms.GroupBox();
            this.btnCadastrarMod = new System.Windows.Forms.Button();
            this.txtQtdeAulas = new System.Windows.Forms.TextBox();
            this.txtQtdeAlunos = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.cmbDescModalidade = new System.Windows.Forms.TextBox();
            this.lblQtdeAulas = new System.Windows.Forms.Label();
            this.lblQtdeAlunos = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDescCadastrarMod = new System.Windows.Forms.Label();
            this.grpCadastrarMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // grpCadastrarMod
            // 
            this.grpCadastrarMod.Controls.Add(this.btnCadastrarMod);
            this.grpCadastrarMod.Controls.Add(this.txtQtdeAulas);
            this.grpCadastrarMod.Controls.Add(this.txtQtdeAlunos);
            this.grpCadastrarMod.Controls.Add(this.txtPreco);
            this.grpCadastrarMod.Controls.Add(this.cmbDescModalidade);
            this.grpCadastrarMod.Controls.Add(this.lblQtdeAulas);
            this.grpCadastrarMod.Controls.Add(this.lblQtdeAlunos);
            this.grpCadastrarMod.Controls.Add(this.lblPreco);
            this.grpCadastrarMod.Controls.Add(this.lblDescCadastrarMod);
            this.grpCadastrarMod.Location = new System.Drawing.Point(12, 12);
            this.grpCadastrarMod.Name = "grpCadastrarMod";
            this.grpCadastrarMod.Size = new System.Drawing.Size(617, 317);
            this.grpCadastrarMod.TabIndex = 1;
            this.grpCadastrarMod.TabStop = false;
            this.grpCadastrarMod.Text = "Modalidades";
            // 
            // btnCadastrarMod
            // 
            this.btnCadastrarMod.Location = new System.Drawing.Point(60, 264);
            this.btnCadastrarMod.Name = "btnCadastrarMod";
            this.btnCadastrarMod.Size = new System.Drawing.Size(130, 32);
            this.btnCadastrarMod.TabIndex = 8;
            this.btnCadastrarMod.Text = "Cadastrar";
            this.btnCadastrarMod.UseVisualStyleBackColor = true;
            this.btnCadastrarMod.Click += new System.EventHandler(this.btnCadastrarMod_Click);
            // 
            // txtQtdeAulas
            // 
            this.txtQtdeAulas.Location = new System.Drawing.Point(179, 214);
            this.txtQtdeAulas.Name = "txtQtdeAulas";
            this.txtQtdeAulas.Size = new System.Drawing.Size(100, 22);
            this.txtQtdeAulas.TabIndex = 7;
            // 
            // txtQtdeAlunos
            // 
            this.txtQtdeAlunos.Location = new System.Drawing.Point(179, 161);
            this.txtQtdeAlunos.Name = "txtQtdeAlunos";
            this.txtQtdeAlunos.Size = new System.Drawing.Size(117, 22);
            this.txtQtdeAlunos.TabIndex = 6;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(179, 113);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(117, 22);
            this.txtPreco.TabIndex = 5;
            // 
            // cmbDescModalidade
            // 
            this.cmbDescModalidade.Location = new System.Drawing.Point(179, 60);
            this.cmbDescModalidade.Name = "cmbDescModalidade";
            this.cmbDescModalidade.Size = new System.Drawing.Size(323, 22);
            this.cmbDescModalidade.TabIndex = 4;
            // 
            // lblQtdeAulas
            // 
            this.lblQtdeAulas.AutoSize = true;
            this.lblQtdeAulas.Location = new System.Drawing.Point(57, 214);
            this.lblQtdeAulas.Name = "lblQtdeAulas";
            this.lblQtdeAulas.Size = new System.Drawing.Size(95, 16);
            this.lblQtdeAulas.TabIndex = 3;
            this.lblQtdeAulas.Text = "Qtde de Aulas:";
            // 
            // lblQtdeAlunos
            // 
            this.lblQtdeAlunos.AutoSize = true;
            this.lblQtdeAlunos.Location = new System.Drawing.Point(57, 161);
            this.lblQtdeAlunos.Name = "lblQtdeAlunos";
            this.lblQtdeAlunos.Size = new System.Drawing.Size(102, 16);
            this.lblQtdeAlunos.TabIndex = 2;
            this.lblQtdeAlunos.Text = "Qtde de Alunos:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(57, 113);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(46, 16);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço:";
            // 
            // lblDescCadastrarMod
            // 
            this.lblDescCadastrarMod.AutoSize = true;
            this.lblDescCadastrarMod.Location = new System.Drawing.Point(57, 63);
            this.lblDescCadastrarMod.Name = "lblDescCadastrarMod";
            this.lblDescCadastrarMod.Size = new System.Drawing.Size(72, 16);
            this.lblDescCadastrarMod.TabIndex = 0;
            this.lblDescCadastrarMod.Text = "Descrição:";
            // 
            // CadastroModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 346);
            this.Controls.Add(this.grpCadastrarMod);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroModalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastrar Modalidade";
            this.grpCadastrarMod.ResumeLayout(false);
            this.grpCadastrarMod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCadastrarMod;
        private System.Windows.Forms.Label lblQtdeAulas;
        private System.Windows.Forms.Label lblQtdeAlunos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDescCadastrarMod;
        private System.Windows.Forms.TextBox cmbDescModalidade;
        private System.Windows.Forms.Button btnCadastrarMod;
        private System.Windows.Forms.TextBox txtQtdeAulas;
        private System.Windows.Forms.TextBox txtQtdeAlunos;
        private System.Windows.Forms.TextBox txtPreco;
    }
}