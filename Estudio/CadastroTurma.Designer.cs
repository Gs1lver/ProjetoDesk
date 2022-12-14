namespace Estudio
{
    partial class CadastroTurma
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
            this.grpTurmaCad = new System.Windows.Forms.GroupBox();
            this.mtxHoraTurma = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaSemanaTurma = new System.Windows.Forms.TextBox();
            this.txtProfTurma = new System.Windows.Forms.TextBox();
            this.txtModTurma = new System.Windows.Forms.TextBox();
            this.btnCadastrarTurma = new System.Windows.Forms.Button();
            this.lblHoraTurma = new System.Windows.Forms.Label();
            this.lblDiaSemanaTurma = new System.Windows.Forms.Label();
            this.lblProfTurma = new System.Windows.Forms.Label();
            this.lblModalidadeTurma = new System.Windows.Forms.Label();
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTurmaCad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTurmaCad
            // 
            this.grpTurmaCad.Controls.Add(this.mtxHoraTurma);
            this.grpTurmaCad.Controls.Add(this.txtDiaSemanaTurma);
            this.grpTurmaCad.Controls.Add(this.txtProfTurma);
            this.grpTurmaCad.Controls.Add(this.txtModTurma);
            this.grpTurmaCad.Controls.Add(this.btnCadastrarTurma);
            this.grpTurmaCad.Controls.Add(this.lblHoraTurma);
            this.grpTurmaCad.Controls.Add(this.lblDiaSemanaTurma);
            this.grpTurmaCad.Controls.Add(this.lblProfTurma);
            this.grpTurmaCad.Controls.Add(this.lblModalidadeTurma);
            this.grpTurmaCad.Location = new System.Drawing.Point(12, 12);
            this.grpTurmaCad.Name = "grpTurmaCad";
            this.grpTurmaCad.Size = new System.Drawing.Size(526, 242);
            this.grpTurmaCad.TabIndex = 0;
            this.grpTurmaCad.TabStop = false;
            this.grpTurmaCad.Text = "Turma";
            // 
            // mtxHoraTurma
            // 
            this.mtxHoraTurma.Location = new System.Drawing.Point(115, 145);
            this.mtxHoraTurma.Mask = "00:00";
            this.mtxHoraTurma.Name = "mtxHoraTurma";
            this.mtxHoraTurma.Size = new System.Drawing.Size(100, 22);
            this.mtxHoraTurma.TabIndex = 4;
            this.mtxHoraTurma.ValidatingType = typeof(System.DateTime);
            // 
            // txtDiaSemanaTurma
            // 
            this.txtDiaSemanaTurma.Location = new System.Drawing.Point(115, 109);
            this.txtDiaSemanaTurma.Name = "txtDiaSemanaTurma";
            this.txtDiaSemanaTurma.Size = new System.Drawing.Size(337, 22);
            this.txtDiaSemanaTurma.TabIndex = 3;
            // 
            // txtProfTurma
            // 
            this.txtProfTurma.Location = new System.Drawing.Point(115, 72);
            this.txtProfTurma.Name = "txtProfTurma";
            this.txtProfTurma.Size = new System.Drawing.Size(337, 22);
            this.txtProfTurma.TabIndex = 2;
            // 
            // txtModTurma
            // 
            this.txtModTurma.Location = new System.Drawing.Point(115, 32);
            this.txtModTurma.Name = "txtModTurma";
            this.txtModTurma.Size = new System.Drawing.Size(337, 22);
            this.txtModTurma.TabIndex = 1;
            // 
            // btnCadastrarTurma
            // 
            this.btnCadastrarTurma.Location = new System.Drawing.Point(18, 189);
            this.btnCadastrarTurma.Name = "btnCadastrarTurma";
            this.btnCadastrarTurma.Size = new System.Drawing.Size(186, 31);
            this.btnCadastrarTurma.TabIndex = 5;
            this.btnCadastrarTurma.Text = "Cadastrar";
            this.btnCadastrarTurma.UseVisualStyleBackColor = true;
            this.btnCadastrarTurma.Click += new System.EventHandler(this.btnCadastrarTurma_Click);
            // 
            // lblHoraTurma
            // 
            this.lblHoraTurma.AutoSize = true;
            this.lblHoraTurma.Location = new System.Drawing.Point(69, 148);
            this.lblHoraTurma.Name = "lblHoraTurma";
            this.lblHoraTurma.Size = new System.Drawing.Size(40, 16);
            this.lblHoraTurma.TabIndex = 3;
            this.lblHoraTurma.Text = "Hora:";
            // 
            // lblDiaSemanaTurma
            // 
            this.lblDiaSemanaTurma.AutoSize = true;
            this.lblDiaSemanaTurma.Location = new System.Drawing.Point(6, 112);
            this.lblDiaSemanaTurma.Name = "lblDiaSemanaTurma";
            this.lblDiaSemanaTurma.Size = new System.Drawing.Size(107, 16);
            this.lblDiaSemanaTurma.TabIndex = 2;
            this.lblDiaSemanaTurma.Text = "Dia da Semana: ";
            // 
            // lblProfTurma
            // 
            this.lblProfTurma.AutoSize = true;
            this.lblProfTurma.Location = new System.Drawing.Point(41, 75);
            this.lblProfTurma.Name = "lblProfTurma";
            this.lblProfTurma.Size = new System.Drawing.Size(68, 16);
            this.lblProfTurma.TabIndex = 1;
            this.lblProfTurma.Text = "Professor:";
            // 
            // lblModalidadeTurma
            // 
            this.lblModalidadeTurma.AutoSize = true;
            this.lblModalidadeTurma.Location = new System.Drawing.Point(26, 35);
            this.lblModalidadeTurma.Name = "lblModalidadeTurma";
            this.lblModalidadeTurma.Size = new System.Drawing.Size(83, 16);
            this.lblModalidadeTurma.TabIndex = 0;
            this.lblModalidadeTurma.Text = "Modalidade:";
            // 
            // dgvTurma
            // 
            this.dgvTurma.AllowUserToAddRows = false;
            this.dgvTurma.AllowUserToDeleteRows = false;
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modalidade,
            this.dataGridViewTextBoxColumn1});
            this.dgvTurma.Location = new System.Drawing.Point(0, 280);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.RowHeadersWidth = 51;
            this.dgvTurma.RowTemplate.Height = 24;
            this.dgvTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurma.Size = new System.Drawing.Size(550, 297);
            this.dgvTurma.TabIndex = 1;
            this.dgvTurma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurma_CellContentClick);
            this.dgvTurma.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTurma_RowEnter);
            // 
            // modalidade
            // 
            this.modalidade.HeaderText = "Modalidade";
            this.modalidade.MinimumWidth = 6;
            this.modalidade.Name = "modalidade";
            this.modalidade.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // CadastroTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 577);
            this.Controls.Add(this.dgvTurma);
            this.Controls.Add(this.grpTurmaCad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroTurma";
            this.Text = "Cadastrar Turma";
            this.grpTurmaCad.ResumeLayout(false);
            this.grpTurmaCad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTurmaCad;
        private System.Windows.Forms.Label lblDiaSemanaTurma;
        private System.Windows.Forms.Label lblProfTurma;
        private System.Windows.Forms.Label lblModalidadeTurma;
        private System.Windows.Forms.TextBox txtDiaSemanaTurma;
        private System.Windows.Forms.TextBox txtProfTurma;
        private System.Windows.Forms.TextBox txtModTurma;
        private System.Windows.Forms.Button btnCadastrarTurma;
        private System.Windows.Forms.Label lblHoraTurma;
        private System.Windows.Forms.MaskedTextBox mtxHoraTurma;
        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}