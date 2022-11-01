using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class TodasModalidades : Form
    {

        private static ArrayList ListID;
        private static ArrayList ListDescr;
        private static ArrayList ListPreco;
        private static ArrayList ListAlunos;
        private static ArrayList ListAulas;

        public TodasModalidades()
        {
            InitializeComponent();
            LoadModalidades(null, null);

        }

        public void consultarTodasModalidades()
        {
            ListID = new ArrayList();
            ListDescr = new ArrayList();
            ListPreco = new ArrayList();
            ListAlunos = new ArrayList();
            ListAulas = new ArrayList();

            try
            {
                DAO_Conexao.con.Open();
                string consultaTudo = "select idEstudio_Modalidade, descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas from Estudio_Modalidade where ativa = 0";
                MySqlCommand comando = new MySqlCommand(consultaTudo, DAO_Conexao.con);
                MySqlDataReader coluna = comando.ExecuteReader();
                if (coluna.HasRows)
                {
                    while (coluna.Read())
                    {
                        ListID.Add(coluna["idEstudio_Modalidade"].ToString());
                        ListDescr.Add(coluna["descricaoModalidade"].ToString());
                        ListPreco.Add(coluna["precoModalidade"].ToString());
                        ListAlunos.Add(coluna["qtdeAlunos"].ToString());
                        ListAulas.Add(coluna["qtdeAulas"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Dados não encontrados");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

        }
        private void LoadModalidades(object sender, EventArgs e)
        {
            consultarTodasModalidades();
            if(ListID.Count > 0)
            {
                carregarDataGrid();
            }
            else
            {
                MessageBox.Show("Dados não encontrados");
            }            
        }

        private void carregarDataGrid()
        {

            dgvMod.Rows.Clear();
            for (int i = 0; i < ListID.Count; i++)
            {
                DataGridViewRow novaColuna = new DataGridViewRow();

                novaColuna.CreateCells(dgvMod);
                novaColuna.Cells[0].Value = ListID[i];
                novaColuna.Cells[1].Value = ListDescr[i];
                novaColuna.Cells[2].Value = ListPreco[i];
                novaColuna.Cells[3].Value = ListAlunos[i];
                novaColuna.Cells[4].Value = ListAulas[i];
                dgvMod.Rows.Add(novaColuna);

            }
            
        }
    }
}
