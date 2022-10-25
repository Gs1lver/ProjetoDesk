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

        /*métodos
        public bool cadastrarModalidade()
        {
            
        }
        
        public MySqlDataReader consultarModalide()
        {

        }

        public MySqlDataReader consultarTodasModalidades()

        public bool atualizarModalide()
        {

        }

        public bool excluirModalide()
        {

        }*/
    }
}
