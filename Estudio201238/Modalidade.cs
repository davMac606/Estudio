﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio201238
{
    class Modalidade
    {
        private int _id_Modalidade;
        private string _desc;
        private float _preco;
        private int _qtd_Alunos;
        private int _qtd_Aulas;
        private int _bolinha;

        public int Id_Modal { get => _id_Modalidade;
            set
            {
                _id_Modalidade = value;
            }
        }
        public string Desc {  get => _desc;
            set
            {
                _desc = value;
            }
            }

        public float Preco
        {
            get => _preco;
            set
            {
                _preco = value;
            }
        }

        public int Qtd_Alunos
        {
            get => _qtd_Alunos;
            set
            {
                _qtd_Alunos = value;
            }
        }
        public int Qtd_Aulas
        {
            get => _qtd_Aulas;
            set
            {
                _qtd_Aulas = value;
            }
        }

        public int Bolinha
        {
            get => _bolinha;
            set
            {
                _bolinha = value;
            }
        }

        public Modalidade(string _desc, float _preco, int _qtd_Alunos, int _qtd_Aulas)
        {
            Desc = _desc;
            Preco = _preco;
            Qtd_Alunos = _qtd_Alunos;
            Qtd_Aulas = _qtd_Aulas;
        }

        public Modalidade(string _desc)
        {
            _desc = Desc;
        }

        public Modalidade()
        {

        }

        public bool cadastrarModalidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into MODALCS (idModal, descModal, precoModal, qtdAlModal, qtdAuModal) values ('" + Id_Modal + "','" + Desc + "','" + Preco + "','" + Qtd_Alunos + "','" + Qtd_Aulas + "')", DAO_Conexao.con);

                Console.WriteLine("insert into MODALCS (idModal, descModal, precoModal, qtdAlModal, qtdAuModal) values ('" + Id_Modal + "','" + Desc + "','" + Preco + "','" + Qtd_Alunos + "','" + Qtd_Aulas + "')");
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

        public bool consultarModal()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM MODALCS WHERE idModal ='" + Id_Modal + "'", DAO_Conexao.con);
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


    }
}