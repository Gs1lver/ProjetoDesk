
namespace Estudio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.arquvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpValidacao = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.grpValidacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquvoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(509, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // arquvoToolStripMenuItem
            // 
            this.arquvoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroAlunoToolStripMenuItem,
            this.cadastroLoginToolStripMenuItem});
            this.arquvoToolStripMenuItem.Name = "arquvoToolStripMenuItem";
            this.arquvoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquvoToolStripMenuItem.Text = "Arquivo";
            // 
            // cadastroAlunoToolStripMenuItem
            // 
            this.cadastroAlunoToolStripMenuItem.Name = "cadastroAlunoToolStripMenuItem";
            this.cadastroAlunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroAlunoToolStripMenuItem.Text = "Cadastro Aluno";
            // 
            // cadastroLoginToolStripMenuItem
            // 
            this.cadastroLoginToolStripMenuItem.Name = "cadastroLoginToolStripMenuItem";
            this.cadastroLoginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroLoginToolStripMenuItem.Text = "Cadastro Login";
            // 
            // grpValidacao
            // 
            this.grpValidacao.Controls.Add(this.btnLogin);
            this.grpValidacao.Controls.Add(this.txtSenha);
            this.grpValidacao.Controls.Add(this.txtLogin);
            this.grpValidacao.Controls.Add(this.label2);
            this.grpValidacao.Controls.Add(this.label1);
            this.grpValidacao.Location = new System.Drawing.Point(91, 140);
            this.grpValidacao.Name = "grpValidacao";
            this.grpValidacao.Size = new System.Drawing.Size(327, 180);
            this.grpValidacao.TabIndex = 3;
            this.grpValidacao.TabStop = false;
            this.grpValidacao.Text = "Validação";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(70, 122);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(188, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Logar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(120, 82);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(138, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(120, 42);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(138, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.grpValidacao);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Estúdio";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.grpValidacao.ResumeLayout(false);
            this.grpValidacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem arquvoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroLoginToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpValidacao;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

