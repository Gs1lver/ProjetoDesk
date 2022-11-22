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
    public partial class CadastroTurma : Form
    {
        public CadastroTurma()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            Modalidade con_mod = new Modalidade();
            MySqlDataReader r = con_mod.consultarTodasModalidade();
            while (r.Read())
                grvTurma.Rows.Add(r["descricaoModalidade"].ToString());
            DAO_Conexao.con.Close();
        }


        private void btnCadastrarTurma_Click(object sender, EventArgs e)
        {

        }
    }
}
