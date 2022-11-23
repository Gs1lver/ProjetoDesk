using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    internal class Turma
    {
        private string professor, dia_semana, hora;
        private int modalidade;

        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Modalidade { get => modalidade; set => modalidade = value; }
    
        //Construtores
        public Turma (int modalidade, string professor, string dia_semana, string hora)
        {
            this.modalidade = modalidade;
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;

        }
        public Turma (int modalidade)
        {
            this.modalidade = modalidade;
        }  
        public Turma (int modalidade, string hora, string dia_semana)
        {
            this.modalidade = modalidade;
            this.hora = hora;
            this.dia_semana = dia_semana;
        }

        //Métodos
        
        public bool cadastrarTurma()
        {
            bool check = false;
            try
            {
                DAO_Conexao.con.Open();
                var sql = "INSERT INTO Estudio_Turma (idModalidade, professorTurma, diadasemanaTurma, horaTurma) values ('" + Modalidade + "','" + Professor + "','" + Dia_semana + "','" + Hora + "')";
                //MessageBox.Show(sql);
                var inserir = new MySqlCommand(sql, DAO_Conexao.con);
                inserir.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return check;
        }

        
        public bool excluirTurma()
        {
            var check = false;
            try
            {
                DAO_Conexao.con.Open();
                var sql = "DELETE FROM Estudio_Turma WHERE idModalidade ='" + modalidade + "' AND horaTurma = '" + hora + "' AND diadasemanaTurma ='" + dia_semana + "'";
                MessageBox.Show(sql);
                var inserir = new MySqlCommand(sql, DAO_Conexao.con);
                inserir.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return check;

        }
        
        /*
        public MySqlDataReader consultarTurma()
        {
            DAO_Conexao.con.Open();
            var sql = "SELECT * FROM Estudio"
        }
        

        /*public MySqlDataReader consultarTurma01()
        {

        }*/
    }
}
