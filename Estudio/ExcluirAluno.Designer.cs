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
            this.SuspendLayout();
            // 
            // mtxCpfExcluir
            // 
            this.mtxCpfExcluir.Location = new System.Drawing.Point(65, 72);
            this.mtxCpfExcluir.Mask = "999.999.999-99";
            this.mtxCpfExcluir.Name = "mtxCpfExcluir";
            this.mtxCpfExcluir.Size = new System.Drawing.Size(108, 22);
            this.mtxCpfExcluir.TabIndex = 0;
            this.mtxCpfExcluir.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxCpfExcluir_MaskInputRejected);
            this.mtxCpfExcluir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxCpfExcluir_KeyPress);
            // 
            // lblExcluiCpf
            // 
            this.lblExcluiCpf.AutoSize = true;
            this.lblExcluiCpf.Location = new System.Drawing.Point(12, 72);
            this.lblExcluiCpf.Name = "lblExcluiCpf";
            this.lblExcluiCpf.Size = new System.Drawing.Size(36, 16);
            this.lblExcluiCpf.TabIndex = 1;
            this.lblExcluiCpf.Text = "CPF:";
            // 
            // ExcluirAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExcluiCpf);
            this.Controls.Add(this.mtxCpfExcluir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExcluirAluno";
            this.Text = "ExcluirAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxCpfExcluir;
        private System.Windows.Forms.Label lblExcluiCpf;
    }
}