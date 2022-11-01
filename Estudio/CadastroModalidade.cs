using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                Modalidade mod = new Modalidade(cmbDescModalidade.Text, float.Parse(txtPreco.Text.Replace(".", ",")), int.Parse(txtQtdeAlunos.Text), int.Parse(txtQtdeAulas.Text));
                if (mod.cadastrarModalidade())
                    
                    MessageBox.Show("Cadastro realizado com sucesso", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Erro no cadastro." , "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limparCampos();
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos!","Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        
    }
}
