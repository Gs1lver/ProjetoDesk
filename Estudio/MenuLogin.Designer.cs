
namespace Estudio
{
    partial class MenuLogin
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.arquivoMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exclusãoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastroModalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaModalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exclusãoModalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastrarTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoMenuStrip});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(898, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // arquivoMenuStrip
            // 
            this.arquivoMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroAlunoToolStripMenuItem,
            this.cadastroLoginToolStripMenuItem,
            this.exclusãoAlunoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cadastroModalidadeToolStripMenuItem,
            this.consultaModalidadeToolStripMenuItem,
            this.exclusãoModalidadeToolStripMenuItem,
            this.toolStripSeparator2,
            this.cadastrarTurmaToolStripMenuItem,
            this.excluirTurmaToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoMenuStrip.Enabled = false;
            this.arquivoMenuStrip.Name = "arquivoMenuStrip";
            this.arquivoMenuStrip.Size = new System.Drawing.Size(75, 24);
            this.arquivoMenuStrip.Text = "Arquivo";
            // 
            // cadastroAlunoToolStripMenuItem
            // 
            this.cadastroAlunoToolStripMenuItem.Name = "cadastroAlunoToolStripMenuItem";
            this.cadastroAlunoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.cadastroAlunoToolStripMenuItem.Text = "Cadastro Aluno";
            this.cadastroAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastroAlunoToolStripMenuItem_Click);
            // 
            // cadastroLoginToolStripMenuItem
            // 
            this.cadastroLoginToolStripMenuItem.Name = "cadastroLoginToolStripMenuItem";
            this.cadastroLoginToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.cadastroLoginToolStripMenuItem.Text = "Cadastro Login";
            this.cadastroLoginToolStripMenuItem.Click += new System.EventHandler(this.cadastroLoginToolStripMenuItem_Click);
            // 
            // exclusãoAlunoToolStripMenuItem
            // 
            this.exclusãoAlunoToolStripMenuItem.Name = "exclusãoAlunoToolStripMenuItem";
            this.exclusãoAlunoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.exclusãoAlunoToolStripMenuItem.Text = "Exclusão Aluno";
            this.exclusãoAlunoToolStripMenuItem.Click += new System.EventHandler(this.exclusãoAlunoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(233, 6);
            // 
            // cadastroModalidadeToolStripMenuItem
            // 
            this.cadastroModalidadeToolStripMenuItem.Name = "cadastroModalidadeToolStripMenuItem";
            this.cadastroModalidadeToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.cadastroModalidadeToolStripMenuItem.Text = "Cadastro Modalidade";
            this.cadastroModalidadeToolStripMenuItem.Click += new System.EventHandler(this.cadastroModalidadeToolStripMenuItem_Click);
            // 
            // consultaModalidadeToolStripMenuItem
            // 
            this.consultaModalidadeToolStripMenuItem.Name = "consultaModalidadeToolStripMenuItem";
            this.consultaModalidadeToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.consultaModalidadeToolStripMenuItem.Text = "Consulta Modalidade";
            this.consultaModalidadeToolStripMenuItem.Click += new System.EventHandler(this.consultaModalidadeToolStripMenuItem_Click);
            // 
            // exclusãoModalidadeToolStripMenuItem
            // 
            this.exclusãoModalidadeToolStripMenuItem.Name = "exclusãoModalidadeToolStripMenuItem";
            this.exclusãoModalidadeToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.exclusãoModalidadeToolStripMenuItem.Text = "Exclusão Modalidade";
            this.exclusãoModalidadeToolStripMenuItem.Click += new System.EventHandler(this.exclusãoModalidadeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(233, 6);
            // 
            // cadastrarTurmaToolStripMenuItem
            // 
            this.cadastrarTurmaToolStripMenuItem.Name = "cadastrarTurmaToolStripMenuItem";
            this.cadastrarTurmaToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.cadastrarTurmaToolStripMenuItem.Text = "Cadastrar Turma";
            this.cadastrarTurmaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTurmaToolStripMenuItem_Click);
            // 
            // excluirTurmaToolStripMenuItem
            // 
            this.excluirTurmaToolStripMenuItem.Name = "excluirTurmaToolStripMenuItem";
            this.excluirTurmaToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.excluirTurmaToolStripMenuItem.Text = "Excluir Turma";
            this.excluirTurmaToolStripMenuItem.Click += new System.EventHandler(this.excluirTurmaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // grpValidacao
            // 
            this.grpValidacao.Controls.Add(this.btnLogin);
            this.grpValidacao.Controls.Add(this.txtSenha);
            this.grpValidacao.Controls.Add(this.txtLogin);
            this.grpValidacao.Controls.Add(this.label2);
            this.grpValidacao.Controls.Add(this.label1);
            this.grpValidacao.Location = new System.Drawing.Point(237, 153);
            this.grpValidacao.Margin = new System.Windows.Forms.Padding(4);
            this.grpValidacao.Name = "grpValidacao";
            this.grpValidacao.Padding = new System.Windows.Forms.Padding(4);
            this.grpValidacao.Size = new System.Drawing.Size(405, 218);
            this.grpValidacao.TabIndex = 3;
            this.grpValidacao.TabStop = false;
            this.grpValidacao.Text = "Validação";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(93, 150);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(251, 28);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Logar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(160, 101);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(183, 22);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(160, 52);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(183, 22);
            this.txtLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // MenuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 516);
            this.Controls.Add(this.grpValidacao);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MenuLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estúdio";
            this.Load += new System.EventHandler(this.MenuLogin_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.grpValidacao.ResumeLayout(false);
            this.grpValidacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem arquivoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cadastroAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroLoginToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpValidacao;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exclusãoAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroModalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exclusãoModalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaModalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirTurmaToolStripMenuItem;
    }
}

