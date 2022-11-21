using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Estudio
{
    public partial class MenuLogin : Form
    {
        public MenuLogin()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl201289", "cl201289", "cl*11102005"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de Conexão");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(txtLogin.Text, txtSenha.Text);
            if (tipo == 0)
            
                MessageBox.Show("Usuario/Senha inválidos", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Text = "";
                txtSenha.Text = "";
            if (tipo == 1)
            {
                MessageBox.Show("Usuário ADM", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                grpValidacao.Visible = false;
                arquivoMenuStrip.Enabled = true;
                
            }
            if (tipo == 2)
            {
                MessageBox.Show("Usuário Restrito", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                grpValidacao.Visible = false;
                cadastroAlunoToolStripMenuItem.Enabled = true;
                cadastroLoginToolStripMenuItem.Enabled = false;
            }
        }

        private void abrirForm<T>() where T : Form
        {
            T cadastro;
            if (this.MdiChildren.OfType<T>().Count() == 0)
            {
                cadastro = (T)typeof(T).GetConstructor(Type.EmptyTypes).Invoke(null);
                cadastro.MdiParent = this;
            }
            else
            {
                cadastro = this.MdiChildren.OfType<T>().First();

            }
            cadastro.Show();
            cadastro.Focus();
        }
        private void cadastroAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm<CadastroAluno>();
        }

        private void cadastroLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm<CadastroUsuario>();
           
        }

        private void exclusãoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm<ExcluirAluno>();
        }

        private void cadastroModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm<CadastroModalidade>();
        }

        private void exclusãoModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm<ExcluirModalidade>();
        }

        private void consultaModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm<ConsultarModalidade>();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void cadastrarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm<CadastroTurma>();
        }

        private void excluirTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm<ExcluirTurma>();
        }
    }
}
