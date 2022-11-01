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
    public partial class ExcluirAluno : Form
    {
        public ExcluirAluno()
        {
            InitializeComponent();
        }

        private void mtxCpfExcluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(mtxCpfExcluir.Text);
            if(e.KeyChar == 13)
            {
                if (aluno.consultarAluno())
                {
                    if (aluno.excluirAluno())
                    {
                        MessageBox.Show("Aluno excluído com sucesso!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            if (!mtxCpfExcluir.MaskFull)
            {
                MessageBox.Show("Preencha o CPF!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxCpfExcluir.Focus();
                return;
            }
            Aluno aluno = new Aluno(mtxCpfExcluir.Text);
            if (aluno.consultarAluno())
            {
                if (aluno.excluirAluno())
                {
                    MessageBox.Show("Aluno excluído com sucesso!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Erro na exclusão", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mtxCpfExcluir.Clear();
        }
    }
}
