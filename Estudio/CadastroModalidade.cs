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
    public partial class CadastroModalidade : Form
    {
        public CadastroModalidade()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            cmbDescModalidade.Text = "";
            txtPreco.Text = "";
            txtQtdeAlunos.Text = "";
            txtQtdeAulas.Text = "";
        }

        private void btnCadastrarMod_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(cmbDescModalidade.Text, float.Parse(txtPreco.Text), int.Parse(txtQtdeAlunos.Text), int.Parse(txtQtdeAulas.Text));
            if (mod.cadastrarModalidade())
                MessageBox.Show("Cadastro realizado com sucesso");
            else
                MessageBox.Show("Erro no cadastro.");
            limparCampos();
        }
    }
}
