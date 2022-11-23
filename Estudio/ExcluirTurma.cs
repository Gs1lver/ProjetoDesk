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

namespace Estudio
{
    public partial class ExcluirTurma : Form
    {
        public ExcluirTurma()
        {
            InitializeComponent();
            cmbModalidadeTurma.Items.Add("Selecione uma modalidade!");
            

            Modalidade con_mod = new Modalidade();
            MySqlDataReader r = con_mod.consultarTodasModalidade();
            while (r.Read())
                cmbModalidadeTurma.Items.Add(r["descricaoModalidade"]);
            DAO_Conexao.con.Close();

        }
        
        public void limparCampos()
        {
            cmbModalidadeTurma.SelectedIndex = 0;
        }

        private void btnExcluiTurma_Click(object sender, EventArgs e)
        {
            if (cmbModalidadeTurma.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione uma modalidade", "Alerta do Sistema");
                cmbModalidadeTurma.Focus();
                return;
            }

            try
            {
                DAO_Conexao.con.Open();
                var sql1 = "SELECT idEstudio_Modalidade FROM Estudio_Modalidade WHERE descricaoModalidade ='" + cmbModalidadeTurma.Text + "'";
                var comando = new MySqlCommand(sql1, DAO_Conexao.con);
                var r1 = comando.ExecuteReader();
                r1.Read();
                var idModalidade = int.Parse(r1["idEstudio_Modalidade"].ToString());
                r1.Dispose();
                DAO_Conexao.con.Close();

                var turma = new Turma(idModalidade, cmbHoraTurma.Text, cmbDiaSemanaTurma.Text);
                if (turma.excluirTurma())
                {
                    MessageBox.Show("Turma excluida com sucesso", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Erro na exclusão.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            limparCampos();
        }

        private void cmbModalidadeTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDiaSemanaTurma.Items.Clear();
            cmbHoraTurma.Items.Clear();
            
            if (cmbModalidadeTurma.SelectedIndex == 0)
            {
                cmbDiaSemanaTurma.Text = string.Empty;
                cmbHoraTurma.Text = string.Empty;
                return;
            }


            DAO_Conexao.con.Open();

            var sql1 = "SELECT idEstudio_Modalidade FROM Estudio_Modalidade WHERE descricaoModalidade ='" + cmbModalidadeTurma.Text + "'";
            var comando = new MySqlCommand(sql1, DAO_Conexao.con);
            var r1 = comando.ExecuteReader();
            r1.Read();

            var sql = "SELECT * FROM Estudio_Turma WHERE idModalidade ='" + r1["idEstudio_Modalidade"].ToString() + "'";
            r1.Dispose();
            var command = new MySqlCommand(sql, DAO_Conexao.con);
            var r = command.ExecuteReader();

            while (r.Read())
            {
                cmbDiaSemanaTurma.Items.Add(r["diadasemanaTurma"]);
                cmbHoraTurma.Items.Add(r["horaTurma"]);
            }
            DAO_Conexao.con.Close();
        }
    }
}
