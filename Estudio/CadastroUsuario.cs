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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            cboTipo.SelectedIndex = -1;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                int tipo = 0;
                if (cboTipo.SelectedIndex == 0)
                    tipo = 1;
                else if (cboTipo.SelectedIndex == 1)
                    tipo = 2;
                if (DAO_Conexao.CadLogin(txtUsuario.Text, txtSenha.Text, tipo))
                    MessageBox.Show("Cadastro realizado com sucesso", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Erro de cadastro", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparCampos();
            }

            catch
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
