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


    }
}
