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
    public partial class excModal : Form
    {
        public excModal()
        {
            InitializeComponent();
        }

        public void updateComboBox()
        {
            try
            {
                DAO_Conexao.con.Open();
                string sql = "SELECT idModal, descModal, precoModal, qtdAlModal, qtdAuModal from ModalCS";
                MySqlCommand adiciona = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataReader dr = adiciona.ExecuteReader();
                while (dr.Read())
                {
                    cbxDesc.Items.Add(dr["descModal"].ToString());
                    cbxDesc.DisplayMember = (dr["descModal"].ToString());
                    cbxDesc.ValueMember = (dr["idModal"].ToString());
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
        }

        private void grpExcModal_Enter(object sender, EventArgs e)
        {

        }

        private void btnExcModal_Click(object sender, EventArgs e)
        {
                Modalidade mod = new Modalidade();
                mod.Desc = cbxDesc.Text.ToString();
                if (mod.excluirModal())
            {
                MessageBox.Show("Modalidade desativada com sucesso!", "ALerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                MessageBox.Show("Erro: Por favor, tente novamente", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void cbxDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void excModal_Load(object sender, EventArgs e)
        {
            updateComboBox();
        }
        

private void btnSair_Click(object sender, EventArgs e)
        {
            cadModal cadMo = new cadModal();
            cadMo.Show();
            this.Hide();
        }
    }
}
