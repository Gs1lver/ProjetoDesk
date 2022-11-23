using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Estudio
{
    public partial class CadastroTurma : Form
    {
        public CadastroTurma()
        {
            InitializeComponent();
            //WindowState = FormWindowState.Maximized;

            Modalidade con_mod = new Modalidade();
            MySqlDataReader r = con_mod.consultarTodasModalidade();
            while (r.Read())
                dgvTurma.Rows.Add(r["descricaoModalidade"].ToString(), r["idEstudio_Modalidade"].ToString());
            DAO_Conexao.con.Close();
            limparCampos();
        }

        public void limparCampos()
        {
            txtModTurma.Text = "";
            txtProfTurma.Text = "";
            txtDiaSemanaTurma.Text = "";
            mtxHoraTurma.Text = "";
        }

        private void btnCadastrarTurma_Click(object sender, EventArgs e)
        {
                var selectedrow = dgvTurma.SelectedRows[0];
                var selectedvalue = selectedrow.Cells[1].Value.ToString();
            try
            {
                Turma turma = new Turma(int.Parse(dgvTurma.SelectedRows[0].Cells[1].Value.ToString()), txtProfTurma.Text, txtDiaSemanaTurma.Text ,mtxHoraTurma.Text);
                if (turma.cadastrarTurma())

                    MessageBox.Show("Cadastro realizado com sucesso", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Erro no cadastro.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Preencha todos os campos!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grvTurma_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvTurma.Rows.Count)
                return;

            var algo = dgvTurma.Rows[e.RowIndex].Cells[0].Value;
            if(algo != null)
                txtModTurma.Text = algo.ToString();

        }

        private void dgvTurma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
