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
    public partial class ConsultarModalidade : Form
    {
        public ConsultarModalidade()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            
        }

        public void cmbDescModDisplay()
        {
            DAO_Conexao.con.Open();
            MySqlCommand comando = new MySqlCommand("SELECT descricaoModalidade, idEstudio_Modalidade FROM Estudio_Modalidade WHERE ativa = 0", DAO_Conexao.con);
            MySqlDataReader dataR = comando.ExecuteReader();
            while (dataR.Read())
            {
                cmbDescConsult.Items.Add(dataR["descricaoModalidade"].ToString());
                cmbDescConsult.DisplayMember = (dataR["descricaoModalidade"].ToString());
                cmbDescConsult.ValueMember = (dataR["idEstudio_Modalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void ConsultarModalidade_Load(object sender, EventArgs e)
        {
            cmbDescModDisplay();
        }

        private void cmbDescConsult_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAO_Conexao.con.Open();
            MySqlCommand comando = new MySqlCommand("SELECT precoModalidade, qtdeAlunos, qtdeAulas FROM Estudio_Modalidade WHERE descricaoModalidade ='" + cmbDescConsult.SelectedItem +"'", DAO_Conexao.con);
            MySqlDataReader dataR = comando.ExecuteReader();
            while (dataR.Read())
            {
                txtPrecoConsult.Text = dataR[0].ToString(); 
                txtQtdeAlunosConsult.Text = dataR[1].ToString();
                txtQtdeAulasConsult.Text = dataR[2].ToString();

                txtPrecoConsult.Enabled = false;
                txtQtdeAlunosConsult.Enabled = false;
                txtQtdeAulasConsult.Enabled = false;
            }
            DAO_Conexao.con.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            cmbDescConsult.Enabled = false;
            txtPrecoConsult.Enabled = true;
            txtQtdeAlunosConsult.Enabled = true;
            txtQtdeAulasConsult.Enabled = true;
            btnSalvarMod.Visible = true;
            btnAtualizar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(cmbDescConsult.Text, float.Parse(txtPrecoConsult.Text), int.Parse(txtQtdeAlunosConsult.Text), int.Parse(txtQtdeAulasConsult.Text));
            if (mod.atualizarModalidade())
                MessageBox.Show("Cadastro realizado com sucesso!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Erro no cadastro.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            limparCampos();
            txtPrecoConsult.Enabled = false;
            txtQtdeAlunosConsult.Enabled = false;
            txtQtdeAulasConsult.Enabled = false;
            cmbDescConsult.Enabled = true;
            btnSalvarMod.Enabled = false;
            btnAtualizar.Enabled = true;


        }

        private void grpConsultMod_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultTodos_Click(object sender, EventArgs e)
        {
            TodasModalidades todasMod = new TodasModalidades();
            //todasMod.MdiParent = this;
            todasMod.Show();
        }
    }
}
