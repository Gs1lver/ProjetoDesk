namespace Estudio
{
    partial class ExcluirTurma
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
            this.grpTurmaExcluir = new System.Windows.Forms.GroupBox();
            this.cmbHoraTurma = new System.Windows.Forms.ComboBox();
            this.cmbDiaSemanaTurma = new System.Windows.Forms.ComboBox();
            this.cmbModalidadeTurma = new System.Windows.Forms.ComboBox();
            this.btnExcluiTurma = new System.Windows.Forms.Button();
            this.lblHoraExcluiTurma = new System.Windows.Forms.Label();
            this.lblDiaSemanaExcluiTurma = new System.Windows.Forms.Label();
            this.lblModalidadeExcluiTurma = new System.Windows.Forms.Label();
            this.grpTurmaExcluir.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTurmaExcluir
            // 
            this.grpTurmaExcluir.Controls.Add(this.cmbHoraTurma);
            this.grpTurmaExcluir.Controls.Add(this.cmbDiaSemanaTurma);
            this.grpTurmaExcluir.Controls.Add(this.cmbModalidadeTurma);
            this.grpTurmaExcluir.Controls.Add(this.btnExcluiTurma);
            this.grpTurmaExcluir.Controls.Add(this.lblHoraExcluiTurma);
            this.grpTurmaExcluir.Controls.Add(this.lblDiaSemanaExcluiTurma);
            this.grpTurmaExcluir.Controls.Add(this.lblModalidadeExcluiTurma);
            this.grpTurmaExcluir.Location = new System.Drawing.Point(22, 12);
            this.grpTurmaExcluir.Name = "grpTurmaExcluir";
            this.grpTurmaExcluir.Size = new System.Drawing.Size(556, 367);
            this.grpTurmaExcluir.TabIndex = 0;
            this.grpTurmaExcluir.TabStop = false;
            this.grpTurmaExcluir.Text = "Turma";
            // 
            // cmbHoraTurma
            // 
            this.cmbHoraTurma.FormattingEnabled = true;
            this.cmbHoraTurma.Location = new System.Drawing.Point(134, 212);
            this.cmbHoraTurma.Name = "cmbHoraTurma";
            this.cmbHoraTurma.Size = new System.Drawing.Size(390, 24);
            this.cmbHoraTurma.TabIndex = 6;
            // 
            // cmbDiaSemanaTurma
            // 
            this.cmbDiaSemanaTurma.FormattingEnabled = true;
            this.cmbDiaSemanaTurma.Location = new System.Drawing.Point(136, 128);
            this.cmbDiaSemanaTurma.Name = "cmbDiaSemanaTurma";
            this.cmbDiaSemanaTurma.Size = new System.Drawing.Size(388, 24);
            this.cmbDiaSemanaTurma.TabIndex = 5;
            // 
            // cmbModalidadeTurma
            // 
            this.cmbModalidadeTurma.FormattingEnabled = true;
            this.cmbModalidadeTurma.Location = new System.Drawing.Point(134, 55);
            this.cmbModalidadeTurma.Name = "cmbModalidadeTurma";
            this.cmbModalidadeTurma.Size = new System.Drawing.Size(390, 24);
            this.cmbModalidadeTurma.TabIndex = 4;
            // 
            // btnExcluiTurma
            // 
            this.btnExcluiTurma.Location = new System.Drawing.Point(15, 307);
            this.btnExcluiTurma.Name = "btnExcluiTurma";
            this.btnExcluiTurma.Size = new System.Drawing.Size(509, 34);
            this.btnExcluiTurma.TabIndex = 3;
            this.btnExcluiTurma.Text = "Excluir";
            this.btnExcluiTurma.UseVisualStyleBackColor = true;
            this.btnExcluiTurma.Click += new System.EventHandler(this.btnExcluiTurma_Click);
            // 
            // lblHoraExcluiTurma
            // 
            this.lblHoraExcluiTurma.AutoSize = true;
            this.lblHoraExcluiTurma.Location = new System.Drawing.Point(76, 215);
            this.lblHoraExcluiTurma.Name = "lblHoraExcluiTurma";
            this.lblHoraExcluiTurma.Size = new System.Drawing.Size(40, 16);
            this.lblHoraExcluiTurma.TabIndex = 2;
            this.lblHoraExcluiTurma.Text = "Hora:";
            // 
            // lblDiaSemanaExcluiTurma
            // 
            this.lblDiaSemanaExcluiTurma.AutoSize = true;
            this.lblDiaSemanaExcluiTurma.Location = new System.Drawing.Point(12, 131);
            this.lblDiaSemanaExcluiTurma.Name = "lblDiaSemanaExcluiTurma";
            this.lblDiaSemanaExcluiTurma.Size = new System.Drawing.Size(104, 16);
            this.lblDiaSemanaExcluiTurma.TabIndex = 1;
            this.lblDiaSemanaExcluiTurma.Text = "Dia da Semana:";
            // 
            // lblModalidadeExcluiTurma
            // 
            this.lblModalidadeExcluiTurma.AutoSize = true;
            this.lblModalidadeExcluiTurma.Location = new System.Drawing.Point(33, 58);
            this.lblModalidadeExcluiTurma.Name = "lblModalidadeExcluiTurma";
            this.lblModalidadeExcluiTurma.Size = new System.Drawing.Size(83, 16);
            this.lblModalidadeExcluiTurma.TabIndex = 0;
            this.lblModalidadeExcluiTurma.Text = "Modalidade:";
            // 
            // ExcluirTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 399);
            this.Controls.Add(this.grpTurmaExcluir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExcluirTurma";
            this.Text = "Excluir Turma";
            this.grpTurmaExcluir.ResumeLayout(false);
            this.grpTurmaExcluir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTurmaExcluir;
        private System.Windows.Forms.Button btnExcluiTurma;
        private System.Windows.Forms.Label lblHoraExcluiTurma;
        private System.Windows.Forms.Label lblDiaSemanaExcluiTurma;
        private System.Windows.Forms.Label lblModalidadeExcluiTurma;
        private System.Windows.Forms.ComboBox cmbHoraTurma;
        private System.Windows.Forms.ComboBox cmbDiaSemanaTurma;
        private System.Windows.Forms.ComboBox cmbModalidadeTurma;
    }
}