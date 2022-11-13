using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio201238
{
    class Turma
    {
        private int _idTurma;
        private int _idModal;
        private string _nomeTurma;
        private string _professor;
        private string _diaSemana;
        private string _hora;
        private int _numAlunMatriculados;
        private bool _ativa;

        public int Id_Turma 
        {
            get => _idTurma;
            set
            {
                _idTurma = value;
            }
        }
        public int Id_Modal
        {
            get => _idModal;
            set
            {
                _idModal = value;
            }
        }

        public string Professor
        {
            get => _professor;
            set
            {
                _professor = value;
            }
        }

        public string Dia_Semana
        {
            get => _diaSemana;
            set
            {
                _diaSemana = value;
            }
        }
        public string Hora
        {
            get => _hora;
            set
            {
                _hora = value;
            }
        }
        private int NumAlunMatriculados
        {
            get => _numAlunMatriculados;
            set
            {
                _numAlunMatriculados = value;
            }
        }

        public bool Ativa
        {
            get => _ativa;
            set
            {
                _ativa = value;
            }
        }

        public string NomeTurma
        {
            get => _nomeTurma;
            set
            {
                _nomeTurma = value;
            }
        }

        public Turma(int _idModal, string _nomeTurma, string _professor, string _diaSemana, string _hora, int _numAlunMatriculados)
        {
            Id_Modal = _idModal;
            Professor = _professor;
            Dia_Semana = _diaSemana;
            Hora = _hora;
            NomeTurma = _nomeTurma;
            NumAlunMatriculados = _numAlunMatriculados;
        }

        public Turma()
        {

        }

        public bool cadastrarTurma()
        {
            bool cad = false;
            
            try
            {
                /*if (DAO_Conexao.con.State == ConnectionState.Open)
                {
                    DAO_Conexao.con.Close();
                }*/
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("INSERT INTO TurmaCS (idTurma, idModalidade, nomeTurma, professor, diaSemana, hora, numAlunMatriculados, turmaAtiva) VALUES ('" + Id_Turma + "','" + Id_Modal + "','" + NomeTurma + "','" + Professor + "','" + Dia_Semana + "','" + Hora + "','" + NumAlunMatriculados + "','" + 1 + "')", DAO_Conexao.con);
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
