using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Estudio201238
{
    class Aluno : cadAluno
    {
        private string _cPF;
        private string _nome;
        private string _rua;
        private string _numero;
        private string _bairro;
        private string _complemento;
        private string _cEP;
        private string _cidade;
        private string _estado;
        private string _telefone;
        private string _email;
        private byte[] foto;
        private bool ativo;

        /*public bool verifica_cPF()
        {
            int soma, resto, cont = 0;a
            soma = 0;
        }*/
        public string CPF { get => _cPF; 
            set 
            { 
                _cPF = value; 
            } 
        }
        public string Nome { get => _nome;
            set 
            { 
                _nome = value; 
            } 
        }
        public string Rua { get => _rua; 
            set 
            {
                _rua = value; 
            } 
        }
        public string Numero { get => _numero;
            set
            { 
                _numero = value; 
            }
        }
        public string Bairro { get => _bairro; 
            set
            { 
                _bairro = value;
            } 
        }
        public string Complemento { get => _complemento; 
            set
            {
                _complemento = value; 
            }
        }
        public string CEP { get => _cEP;
            set 
            {
                _cEP = value; 
            } 
        }
        public string Cidade { get => _cidade;
            set
            {
                _cidade = value;
            } 
        }
        public string Estado { get => _estado;
            set
            {
                _estado = value; 
            } 
        }
        public string Telefone { get => _telefone; 
            set
            {
                _telefone = value; 
            } 
        }
        public string Email { get => _email; 
            set
            {
                _email = value; 
            }
        }
        public bool Ativo { get => ativo; 
            set 
            { 
                ativo = value; 
            } 
        }

        public Aluno(string cPF, string nome, string rua, string numero, string bairro, string complemento, string cEP, string cidade, string estado, string telefone, string email)
        {
            CPF = cPF;
            Nome = nome;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Complemento = complemento;
            CEP = cEP;
            Cidade = cidade;
            Estado = estado;
            Telefone = telefone;
            Email = email;
            Ativo = true;
        }

        public bool cadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, CEPAluno, cidadeAluno, estadoAluno, telefoneAluno, emailAluno) values ('" + CPF + "','" + Nome + "','" + Rua + "','" + Numero + "','" + Bairro + "','" + Complemento + "','" +  CEP + "','" + Cidade + "','" + Estado + "','" + Telefone + "','" + Email + "')", DAO_Conexao.con);

                Console.WriteLine("insert into Estudio_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, CEPAluno, cidadeAluno, estadoAluno, telefoneAluno, emailAluno) values ('" + CPF + "','" + Nome + "','" + Rua + "','" + Numero + "','" + Bairro + "','" + Complemento + "','" + CEP + "','" + Cidade + "','" + Estado + "','" + Telefone + "','" + Email + "')");
                insere.ExecuteNonQuery();
                cad = true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            } finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }
    }
}
