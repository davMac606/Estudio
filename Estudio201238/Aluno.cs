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
        private string _CPF;
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
        public bool ativo;

        public bool verificaCPF()
        {
            int soma, resto, cont = 0;

            soma = 0;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "");
            CPF = CPF.Replace("-", "");

            for (int i = 0; i < CPF.Length; i++)
            {
                int a = CPF[0] - '0';
                int b = CPF[i] - '0';

                if (a == b) cont++;
            }

            if (cont == 11) return false;

            for (int i = 1; i <= 9; i++) soma += int.Parse(CPF.Substring(i - 1, 1)) * (11 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(CPF.Substring(9, 1))) return false;

            soma = 0;

            for (int i = 1; i <= 10; i++) soma += int.Parse(CPF.Substring(i - 1, 1)) * (12 - i);

            resto = (soma * 10) % 11;

            if ((resto == 10) || (resto == 11)) resto = 0;

            if (resto != int.Parse(CPF.Substring(10, 1))) return false;

            return true;
        }

        public bool consultarAluno()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno WHERE CPFAluno ='" + CPF + "'", DAO_Conexao.con);
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



        public bool excluirAluno()
        {
            bool exc = false; 
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("UPDATE Estudio_Aluno SET ativo = 1 WHERE CPFALUNO = '" + CPF + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            } finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

       





        public string CPF { get => _CPF; 
            set 
            { 
                _CPF = value; 
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

        public Aluno(string cPF)
        {
            CPF = cPF;
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
