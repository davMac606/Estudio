using MySql.Data.MySqlClient;
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

        public bool verificaExist()
        {
            bool exists = false;

            DAO_Conexao.con.Open();
            MySqlCommand existe = new MySqlCommand("SELECT * FROM Estudio_Aluno WHERE CPFAluno LIKE '" + mskCPF.Text + "'", DAO_Conexao.con);
            exists = existe.ExecuteReader().Read();
            DAO_Conexao.con.Close();

            return exists;
        }


        private void btnCadastroAluno_Click(object sender, EventArgs e)
        {
            consModal cons = new consModal();
            cons.Show();
            Aluno aluno = new Aluno(mskCPF.Text, txtNome.Text, txtEndereco.Text, txtNum.Text, txtBairro.Text, txtComp.Text, mskCEP.Text, txtCidade.Text, txtEstado.Text, mskTel.Text, txtEmail.Text);

            
            if (aluno.cadastrarAluno())
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Alerta de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }  else
            {
                MessageBox.Show("Cadastro falhou. Por favor, tente novamente.", "Alerta de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validaCampos();
            }
                
                }

        private void validaCampos()
        {
            foreach (TextBoxBase txt in this.Controls.OfType<TextBoxBase>())
            {
                if (string.IsNullOrWhiteSpace(txt.ToString()))
                {
                    MessageBox.Show("Não é permitido inserir um campo vazio!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt.Focus();
                    return;
                }
            }
            
        }

        private void mskCPF_Leave(object sender, EventArgs e)
        {
            if (verificaExist())
            {
                MessageBox.Show("Aluno já cadastrado.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmExclusao FormExcluir = new frmExclusao();
            FormExcluir.Show();
        }

        private void grpDados_Enter(object sender, EventArgs e)
        {

        }
    }
}
