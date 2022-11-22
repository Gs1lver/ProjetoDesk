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
        public Turma (int modalidade, string dia_semana)
        {
            this.modalidade = modalidade;
            this.dia_semana = dia_semana;
        }

        //Métodos
        
        public bool cadastrarTurma()
        {
            DAO_Conexao.con.Open();
            string sql = "INSERT INTO Estudio_Turma (idModalidade, professorTurma, diadasemanaTurma, horaTurma ) values ('" + Modalidade + "','" + Professor + "','" + Dia_semana + "','" + Hora + "',)";
            MessageBox.Show(sql);
            MySqlCommand inserir = new MySqlCommand(sql, DAO_Conexao.con);
            return true;
        }

        
        /*public bool excluirTurma()
        {
            DAO_Conexao.con.Open();
        
        }
        /*
        public MySqlDataReader consultarTurma()
        {

        }
        */

        /*public MySqlDataReader consultarTurma01()
        {

        }*/
    }
}
