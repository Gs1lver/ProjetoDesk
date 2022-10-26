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
    public partial class ExcluirModalidade : Form
    {
        public ExcluirModalidade()
        {
            InitializeComponent();
        }

        private void btnExcluirMod_Click(object sender, EventArgs e)
        {
            cmbDescExcluiMod.Items.Clear();
            Modalidade mod = new Modalidade(cmbDescExcluiMod.Text);
            if (mod.consultarModalidade()) 
            {
                if (mod.excluirModalidade())
                {
                    MessageBox.Show("Modalidade excluída com sucesso!");
                    cmbExcluiDescModDisplay();
                }
            }
            cmbDescExcluiMod.Text = "";
;        }

        public void cmbExcluiDescModDisplay()
        {
            DAO_Conexao.con.Open();
            MySqlCommand comando = new MySqlCommand("SELECT descricaoModalidade, idEstudio_Modalidade from Estudio_Modalidade WHERE ativa = 0", DAO_Conexao.con);
            MySqlDataReader dataR = comando.ExecuteReader();
            while (dataR.Read())
            {
                cmbDescExcluiMod.Items.Add(dataR["descricaoModalidade"].ToString());
                cmbDescExcluiMod.DisplayMember = (dataR["descricaoModalidade"].ToString());
                cmbDescExcluiMod.ValueMember = (dataR["idEstudio_Modalidade"].ToString());
                
            }
            DAO_Conexao.con.Close();
        }

        private void ExcluirModalidade_Load(object sender, EventArgs e)
        {
            cmbExcluiDescModDisplay();
        }
    }
}
