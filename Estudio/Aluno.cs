using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    internal class Aluno
    {
        private string CPF;
        private string Nome;
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Complemento;
        private string CEP;
        private string Cidade;
        private string Estado;
        private string Telefone;
        private string Email;
        private byte[] Foto;
        private bool Ativo;
        private string text;

        public Aluno(string cpf, string nome, string rua , string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, string email)
        {
            DAO_Conexao.getConexao("143.106.241.3", "cl201289", "cl201289", "cl*11102005");
            setCpf(cpf);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCep(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
        }
        public Aluno()
        {

        }
        public Aluno(string cpf)
        {
            setCpf(cpf);
        }

        public bool consultarAluno()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno " + "WHERE CPFAluno = '" + CPF + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally{
                DAO_Conexao.con.Close();
            }
            return existe;
        }
        public bool cadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                string sql = "insert into Estudio_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, CEPAluno, cidadeAluno, estadoAluno, telefoneAluno, emailAluno) values('" + CPF + "','" + Nome + "','" + Rua + "','" + Numero + "','" + Bairro + "','" + Complemento + "','" + CEP + "','" + Cidade + "','" + Estado + "','" + Telefone + "','" + Email + "')";//insere.Parameters.AddWithValue("foto", this.foto);
                MySqlCommand insere = new MySqlCommand(sql, DAO_Conexao.con);
                insere.ExecuteNonQuery();
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

        public bool excluirAluno()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Estudio_Aluno set ativo " + "= 1 where CPFAluno = '" + CPF + "'", DAO_Conexao.con);
                //Console.Writeline("update Estudio_Aluno set ativo = 1 where CPFAluno = '" + CPF +
                exclui.ExecuteNonQuery();
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


        //getters e setters
        public void setCpf(string CPF)
        {
            this.CPF = CPF;
        }

        public string getCPF()
        {
            return this.CPF;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getNome()
        {
            return this.Nome;
        }
        public void setRua(string rua)
        {
            this.Rua = rua;
        }

        public string getRua()
        {
            return this.Rua;
        }

        public void setNumero(string numero)
        {
            this.Numero = numero;
        }

        public string getNumero()
        {
            return this.Numero;
        }
        public void setBairro(string bairro)
        {
            this.Bairro = bairro;
        }

        public string getBairro()
        {
            return this.Bairro;
        }
        public void setComplemento(string complemento)
        {
            this.Complemento = complemento;
        }

        public string getComplemento()
        {
            return this.Complemento;
        }
        public void setCep(string cep)
        {
            this.CEP = cep;
        }

        public string getCep()
        {
            return this.CEP;
        }
        public void setCidade(string cidade)
        {
            this.Cidade = cidade;
        }

        public string getCidade()
        {
            return this.Cidade;
        }
        public void setEstado(string estado)
        {
            this.Estado = estado;
        }

        public string getEstado()
        {
            return this.Estado;
        }
        public void setTelefone(string telefone)
        {
            this.Telefone = telefone;
        }

        public string getTelefone()
        {
            return this.Telefone;
        }
        public void setEmail(string email)
        {
            this.Email = email;
        }

        public string getEmail()
        {
            return this.Email;
        }
    }
}
