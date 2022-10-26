using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    internal class Modalidade
    {
        private string Descricao;
        private float Preco;
        private int qtde_alunos, qtde_aulas;
        
        //getters e setters
        public string Descricao1 { get => Descricao; set => Descricao = value; }
        public float Preco1 { get => Preco; set => Preco = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }

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
                MySqlCommand inserir = new MySqlCommand("insert into Estudio_Modalidade (idEstudo_Moidalidade, descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) values ('" + Descricao + "','" + Preco + "','" + Qtde_alunos + "','" + Qtde_aulas + "')", DAO_Conexao.con);
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
        
        /*public MySqlDataReader consultarModalidade()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consultar = new MySqlCommand("SELECT * FROM Estudio_Modalidade" + "WHERE descricaoModalidade = '" + Descricao + "'", DAO_Conexao.con);
                MySqlDataReader result = consultar.ExecuteReader();
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

            return existe;//??
        }*/

        //public MySqlDataReader consultarTodasModalidades()
        

        //public bool atualizarModalidade()

        public bool excluirModalide()
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
    }
}
