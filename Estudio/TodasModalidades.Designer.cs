namespace Estudio
{
    partial class TodasModalidades
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
            this.dgvMod = new System.Windows.Forms.DataGridView();
            this.listID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listAlunos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listAulas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMod
            // 
            this.dgvMod.AllowUserToAddRows = false;
            this.dgvMod.AllowUserToDeleteRows = false;
            this.dgvMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listID,
            this.listDescr,
            this.listPreco,
            this.listAlunos,
            this.listAulas});
            this.dgvMod.Location = new System.Drawing.Point(54, 89);
            this.dgvMod.Name = "dgvMod";
            this.dgvMod.ReadOnly = true;
            this.dgvMod.RowHeadersWidth = 51;
            this.dgvMod.RowTemplate.Height = 24;
            this.dgvMod.Size = new System.Drawing.Size(680, 334);
            this.dgvMod.TabIndex = 0;
            // 
            // listID
            // 
            this.listID.HeaderText = "ID";
            this.listID.MinimumWidth = 6;
            this.listID.Name = "listID";
            this.listID.ReadOnly = true;
            this.listID.Width = 125;
            // 
            // listDescr
            // 
            this.listDescr.HeaderText = "Descrição";
            this.listDescr.MinimumWidth = 6;
            this.listDescr.Name = "listDescr";
            this.listDescr.ReadOnly = true;
            this.listDescr.Width = 125;
            // 
            // listPreco
            // 
            this.listPreco.HeaderText = "Preço";
            this.listPreco.MinimumWidth = 6;
            this.listPreco.Name = "listPreco";
            this.listPreco.ReadOnly = true;
            this.listPreco.Width = 125;
            // 
            // listAlunos
            // 
            this.listAlunos.HeaderText = "Alunos";
            this.listAlunos.MinimumWidth = 6;
            this.listAlunos.Name = "listAlunos";
            this.listAlunos.ReadOnly = true;
            this.listAlunos.Width = 125;
            // 
            // listAulas
            // 
            this.listAulas.HeaderText = "Aulas";
            this.listAulas.MinimumWidth = 6;
            this.listAulas.Name = "listAulas";
            this.listAulas.ReadOnly = true;
            this.listAulas.Width = 125;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(54, 26);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(144, 31);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Carregar Dados";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // TodasModalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dgvMod);
            this.Name = "TodasModalidades";
            this.Text = "TodasModalidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn listID;
        private System.Windows.Forms.DataGridViewTextBoxColumn listDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn listPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn listAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn listAulas;
        private System.Windows.Forms.Button btnLoadData;
    }
}