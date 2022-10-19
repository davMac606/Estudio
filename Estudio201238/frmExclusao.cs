using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio201238
{
    public partial class frmExclusao : Form
    {
        public frmExclusao()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(mskCpfExc.Text);
            if (aluno.consultarAluno())
            {
            if (aluno.excluirAluno())
            {
                MessageBox.Show("Aluno excluído com sucesso.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
         } else
            {
                MessageBox.Show("Aluno não encontrado. Por favor, insira o CPF corretamente.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
