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

        public void cmbDescModDisplay()
        {
            DAO_Conexao.con.Open();
            MySqlCommand comando = new MySqlCommand("SELECT descricaoModalidade, idEstudio_Modalidade from Estudio_Modalidade", DAO_Conexao.con);
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
                txtPrecoConsult.Text = dataR[0].ToString(); //what do I do indiando :(
                txtQtdeAlunosConsult.Text = dataR[1].ToString();
                txtQtdeAulasConsult.Text = dataR[2].ToString();

                txtPrecoConsult.Enabled = false;
                txtQtdeAlunosConsult.Enabled = false;
                txtQtdeAulasConsult.Enabled = false;
                btnAtualizar.Visible = false;
            }
            DAO_Conexao.con.Close();
        }
    }
}
