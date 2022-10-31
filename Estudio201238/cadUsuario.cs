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
    public partial class cadUsuario : Form
    {
        public cadUsuario()
        {
            InitializeComponent();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        public bool verificaExist()
        {
            bool exists = false;

            DAO_Conexao.con.Open();
            MySqlCommand existe = new MySqlCommand("SELECT * FROM CSDAO WHERE usuario LIKE '" + txtUser.Text + "'", DAO_Conexao.con);
            exists = existe.ExecuteReader().Read();
            DAO_Conexao.con.Close();

            return exists;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
           int tipo = 0;
                if (cboTipo.SelectedIndex == 0)
                {
                    tipo = 1; 
                }
                else if (cboTipo.SelectedIndex ==1)
                {
                    tipo = 2;
                }
                if (DAO_Conexao.CadLogin(txtUser.Text, txtSenha.Text, cboTipo.SelectedIndex))
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                MessageBox.Show("Cadastro falhou. Por favor, tente novamente.", "Aviso do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

               
            }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (verificaExist())
            {
                MessageBox.Show("Usuário já cadastrado!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
