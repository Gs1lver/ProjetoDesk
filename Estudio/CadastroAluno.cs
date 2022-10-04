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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(mtxCpf.Text, txtNome.Text, txtEndereco.Text, txtNumero.Text )
            if| (aluno.cadastrarAluno())
                MessageBox.Show("Cadastro realizado com sucesso");

        }
    }
}
