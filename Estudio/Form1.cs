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
    public partial class Form1 : Form
    {
        public Form1()
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
            if (tipo == 1)
            {
                MessageBox.Show("Usuário ADM");
                grpValidacao.Visible = false;
                //menuStrip.Enabled = true;
            }
            if (tipo == 2)
            {
                MessageBox.Show("Usuário Restrito");
                grpValidacao.Visible = false;
                //menuStrip1.Enabled = true;
                //cadastrarLoginToolStripMenuItem.Enabled = false;
            }
        }
    }
}
