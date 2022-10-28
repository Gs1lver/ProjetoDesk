namespace Estudio
{
    partial class ExcluirAluno
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
            this.mtxCpfExcluir = new System.Windows.Forms.MaskedTextBox();
            this.lblExcluiCpf = new System.Windows.Forms.Label();
            this.grpExcluirAluno = new System.Windows.Forms.GroupBox();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.grpExcluirAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxCpfExcluir
            // 
            this.mtxCpfExcluir.Location = new System.Drawing.Point(109, 55);
            this.mtxCpfExcluir.Mask = "999.999.999-99";
            this.mtxCpfExcluir.Name = "mtxCpfExcluir";
            this.mtxCpfExcluir.Size = new System.Drawing.Size(139, 22);
            this.mtxCpfExcluir.TabIndex = 0;
            this.mtxCpfExcluir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxCpfExcluir_KeyPress);
            // 
            // lblExcluiCpf
            // 
            this.lblExcluiCpf.AutoSize = true;
            this.lblExcluiCpf.Location = new System.Drawing.Point(44, 58);
            this.lblExcluiCpf.Name = "lblExcluiCpf";
            this.lblExcluiCpf.Size = new System.Drawing.Size(36, 16);
            this.lblExcluiCpf.TabIndex = 1;
            this.lblExcluiCpf.Text = "CPF:";
            // 
            // grpExcluirAluno
            // 
            this.grpExcluirAluno.Controls.Add(this.btnExcluirAluno);
            this.grpExcluirAluno.Controls.Add(this.mtxCpfExcluir);
            this.grpExcluirAluno.Controls.Add(this.lblExcluiCpf);
            this.grpExcluirAluno.Location = new System.Drawing.Point(12, 12);
            this.grpExcluirAluno.Name = "grpExcluirAluno";
            this.grpExcluirAluno.Size = new System.Drawing.Size(364, 188);
            this.grpExcluirAluno.TabIndex = 2;
            this.grpExcluirAluno.TabStop = false;
            this.grpExcluirAluno.Text = "Aluno";
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Location = new System.Drawing.Point(47, 126);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(98, 29);
            this.btnExcluirAluno.TabIndex = 2;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // ExcluirAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 212);
            this.Controls.Add(this.grpExcluirAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExcluirAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ExcluirAluno";
            this.grpExcluirAluno.ResumeLayout(false);
            this.grpExcluirAluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxCpfExcluir;
        private System.Windows.Forms.Label lblExcluiCpf;
        private System.Windows.Forms.GroupBox grpExcluirAluno;
        private System.Windows.Forms.Button btnExcluirAluno;
    }
}