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
            
                MessageBox.Show("Usuario/Senha inválidos");
                txtLogin.Text = "";
                txtSenha.Text = "";
            if (tipo == 1)
            {
                MessageBox.Show("Usuário ADM");
                grpValidacao.Visible = false;
                arquivoMenuStrip.Enabled = true;
            }
            if (tipo == 2)
            {
                MessageBox.Show("Usuário Restrito");
                grpValidacao.Visible = false;
                cadastroAlunoToolStripMenuItem.Enabled = true;
                cadastroLoginToolStripMenuItem.Enabled = false;
            }
        }

        private void cadastroAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAluno cadastroAl = new CadastroAluno();
            cadastroAl.MdiParent = this;
            cadastroAl.Show();
        }

        private void cadastroLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroLog = new CadastroUsuario();
            cadastroLog.MdiParent = this;
            cadastroLog.Show();
        }

        private void exclusãoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirAluno excluirAl = new ExcluirAluno();
            excluirAl.MdiParent = this;
            excluirAl.Show();
        }

        private void cadastroModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroModalidade cadastroMod = new CadastroModalidade();
            cadastroMod.MdiParent = this;
            cadastroMod.Show();
        }

        private void exclusãoModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirModalidade excluirMod = new ExcluirModalidade();
            excluirMod.MdiParent = this;
            excluirMod.Show();
        }

        private void consultaModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarModalidade consultarMod = new ConsultarModalidade();
            consultarMod.MdiParent = this;
            consultarMod.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
