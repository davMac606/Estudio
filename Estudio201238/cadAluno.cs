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
    public partial class cadAluno : Form
    {
        public cadAluno()
        {
            InitializeComponent();
        }

        private void btnCadastroAluno_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(mskCPF.Text, txtNome.Text, txtEndereco.Text, txtNum.Text, txtBairro.Text, txtComp.Text, mskCEP.Text, txtCidade.Text, txtEstado.Text, mskTel.Text, txtEmail.Text);
             if (aluno.cadastrarAluno())
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Alerta de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }  else
            {
                MessageBox.Show("Cadastro falhou. Por favor, tente novamente.", "Alerta de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
                }
    }
}
