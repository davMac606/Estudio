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
    public partial class consModal : Form
    {
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

        private void updatePreco()
        {
            DAO_Conexao.con.Open();
            string sql = "SELECT precoModal from ModalCS where descModal = '" + cbxDesc.SelectedItem + "'";
            MySqlCommand cmd = new MySqlCommand(sql, DAO_Conexao.con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtPreco.Text = dr[0].ToString();
            }
            DAO_Conexao.con.Close();
        } 
        private void updateQtdAl()
        {
            DAO_Conexao.con.Open();
            string sql = "SELECT qtdAlModal from ModalCS where descModal = '" + cbxDesc.SelectedItem + "'";
            MySqlCommand cmd = new MySqlCommand(sql, DAO_Conexao.con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtAlunos.Text = dr[0].ToString();
            }
            DAO_Conexao.con.Close();
        }

        private void updateQtdAu()
        {
            DAO_Conexao.con.Open();
            string sql = "SELECT qtdAuModal from ModalCS where descModal = '" + cbxDesc.SelectedItem + "'";
            MySqlCommand cmd = new MySqlCommand(sql, DAO_Conexao.con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtAulas.Text = dr[0].ToString();
            }
            DAO_Conexao.con.Close();
        }
        public consModal()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            gerenModal gerMod = new gerenModal();
            gerMod.Show();
            this.Hide();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade();
            updateComboBox();
        }

        private void consModal_Load(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade();
            updateComboBox();
        }

        private void cbxDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePreco();
            updateQtdAl();
            updateQtdAu();
        }
    }
}
