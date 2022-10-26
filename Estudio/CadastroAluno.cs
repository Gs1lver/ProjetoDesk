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
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            mtxCpf.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
            mtxCep.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            mtxTelefone.Text = "";
            txtEmail.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //byte[] foto = ConverterFotoParaByteArray();
            Aluno aluno = new Aluno(mtxCpf.Text, txtNome.Text, txtEndereco.Text, txtNumero.Text, txtBairro.Text, txtComplemento.Text, mtxCep.Text, txtCidade.Text, txtEstado.Text, mtxTelefone.Text, txtEmail.Text); //falta o photo mas né
            if (aluno.cadastrarAluno())
                MessageBox.Show("Cadastro realizado com sucesso!","Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Erro no cadastro. Por favor, tente novamente.","Alerta do Sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);
            limparCampos();
        }

        private void mtxCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(mtxCpf.Text);
            if(e.KeyChar == 13)
            {
                if (aluno.consultarAluno())
                {
                    MessageBox.Show("Aluno já cadastrado!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txtNome.Focus();
                }
            }
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {

        }
    }
}
