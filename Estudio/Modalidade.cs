using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net;
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
                MySqlCommand inserir = new MySqlCommand("insert into Estudio_Modalidade (descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) values ('" + Descricao + "','" + Preco.ToString(new CultureInfo("en-US")) + "','" + Qtde_alunos + "','" + Qtde_aulas + "')", DAO_Conexao.con);
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


        public bool atualizarModalidade()
        {
            bool att = false;
            try
            {
                DAO_Conexao.con.Open();
                string sql = "update Estudio_Modalidade set descricaoModalidade ='" + Descricao + "', precoModalidade ='" + Preco + "', qtdeAlunos ='" + Qtde_alunos + "', qtdeAulas = '" + Qtde_aulas + "' WHERE descricaoModalidade = '" + Descricao + "' limit 1";
                MySqlCommand atualizar = new MySqlCommand(sql, DAO_Conexao.con);
                atualizar.ExecuteNonQuery();
                att = true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return att;
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

        internal MySqlDataReader consultarTodasModalidade()
        {
            DAO_Conexao.con.Open();
            string sql = "SELECT * FROM Estudio_Modalidade WHERE ativa = 0";
            MySqlCommand todos = new MySqlCommand(sql, DAO_Conexao.con);
            return todos.ExecuteReader();
        }
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

        

        /*public bool atualizarTodasModalidades()
         {

         }*/
    }
}
