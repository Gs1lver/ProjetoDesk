using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    internal class Modalidade
    {
        private string Descricao;
        private float Preco;
        private int qtde_alunos, qtde_aulas;
        private int idMod;

        //getters e setters

        public string Descricao1 { get => Descricao; set => Descricao = value; }
        public float Preco1 { get => Preco; set => Preco = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }
        public int IdMod { get => idMod; set => idMod = value; }

        //construtores
        public Modalidade(string descricao, float preco, int qtde_alunos, int qtde_aulas)
        {
            DAO_Conexao.getConexao("143.106.241.3", "cl201289", "cl201289", "cl*11102005");
            Descricao = descricao;
            Preco = preco;
            Qtde_alunos = qtde_alunos;
            Qtde_aulas = qtde_aulas;
        }

        public Modalidade(string descricao)
        {
            Descricao = descricao;
        }

        public Modalidade()
        {

        }

        //métodos
        public bool cadastrarModalidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand inserir = new MySqlCommand("insert into Estudio_Modalidade (descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) values ('" + Descricao + "','" + Preco + "','" + Qtde_alunos + "','" + Qtde_aulas + "')", DAO_Conexao.con);
                inserir.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cad;
        }

        public bool consultarModalidade()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade WHERE descricaoModalidade ='" + Descricao + "'", DAO_Conexao.con);
                MySqlDataReader result = consulta.ExecuteReader();
                if (result.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return existe;
        }

        /*public MySqlDataReader consultarTodasModalidades()
        {
          
        }*/

        /*public bool atualizarModalidade()
        {

        }*/

        public bool excluirModalidade()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand excluir = new MySqlCommand("update Estudio_Modalidade set ativa" + "= 1 where descricaoModalidade = '" + Descricao + "'", DAO_Conexao.con);
                excluir.ExecuteNonQuery();
                exc = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

        //Método do Wannakry
        /*
        public static Boolean dadosNoComboBox()
        {
            bool add = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand adicionar = new MySqlCommand("SELECT descModal from ModalCS", DAO_Conexao.con);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT descModal from ModalCS", DAO_Conexao.con);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                adicionar.ExecuteNonQuery();
                DAO_Conexao.con.Close();
                add = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return add;
        }*/
    }
}
