namespace Estudio
{
    partial class ExcluirModalidade
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
            this.grpExcluirMod = new System.Windows.Forms.GroupBox();
            this.btnExcluirMod = new System.Windows.Forms.Button();
            this.cmbDescExcluiMod = new System.Windows.Forms.ComboBox();
            this.lblDescExcluirMod = new System.Windows.Forms.Label();
            this.grpExcluirMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpExcluirMod
            // 
            this.grpExcluirMod.Controls.Add(this.btnExcluirMod);
            this.grpExcluirMod.Controls.Add(this.cmbDescExcluiMod);
            this.grpExcluirMod.Controls.Add(this.lblDescExcluirMod);
            this.grpExcluirMod.Location = new System.Drawing.Point(12, 12);
            this.grpExcluirMod.Name = "grpExcluirMod";
            this.grpExcluirMod.Size = new System.Drawing.Size(569, 189);
            this.grpExcluirMod.TabIndex = 0;
            this.grpExcluirMod.TabStop = false;
            this.grpExcluirMod.Text = "Modalidades";
            // 
            // btnExcluirMod
            // 
            this.btnExcluirMod.Location = new System.Drawing.Point(49, 124);
            this.btnExcluirMod.Name = "btnExcluirMod";
            this.btnExcluirMod.Size = new System.Drawing.Size(94, 31);
            this.btnExcluirMod.TabIndex = 2;
            this.btnExcluirMod.Text = "Excluir";
            this.btnExcluirMod.UseVisualStyleBackColor = true;
            this.btnExcluirMod.Click += new System.EventHandler(this.btnExcluirMod_Click);
            // 
            // cmbDescExcluiMod
            // 
            this.cmbDescExcluiMod.FormattingEnabled = true;
            this.cmbDescExcluiMod.Location = new System.Drawing.Point(128, 68);
            this.cmbDescExcluiMod.Name = "cmbDescExcluiMod";
            this.cmbDescExcluiMod.Size = new System.Drawing.Size(338, 24);
            this.cmbDescExcluiMod.TabIndex = 1;
            // 
            // lblDescExcluirMod
            // 
            this.lblDescExcluirMod.AutoSize = true;
            this.lblDescExcluirMod.Location = new System.Drawing.Point(46, 71);
            this.lblDescExcluirMod.Name = "lblDescExcluirMod";
            this.lblDescExcluirMod.Size = new System.Drawing.Size(72, 16);
            this.lblDescExcluirMod.TabIndex = 0;
            this.lblDescExcluirMod.Text = "Descrição:";
            // 
            // ExcluirModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 215);
            this.Controls.Add(this.grpExcluirMod);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExcluirModalidade";
            this.Text = "Excluir Modalidade";
            this.grpExcluirMod.ResumeLayout(false);
            this.grpExcluirMod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpExcluirMod;
        private System.Windows.Forms.Label lblDescExcluirMod;
        private System.Windows.Forms.Button btnExcluirMod;
        private System.Windows.Forms.ComboBox cmbDescExcluiMod;
    }
}