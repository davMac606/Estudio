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
            cbxDesc.Items.Clear();
            if (DAO_Conexao.con.State == ConnectionState.Open)
            {
                DAO_Conexao.con.Close();
            }
            
            try
            {
                if (DAO_Conexao.con.State == ConnectionState.Open)
                {
                    DAO_Conexao.con.Close();
                }
                DAO_Conexao.con.Open();
                string sql = "SELECT idModal, descModal, precoModal, qtdAlModal, qtdAuModal from ModalCS WHERE ativa = 0";
                MySqlCommand adiciona = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataReader dr = adiciona.ExecuteReader();
                while (dr.Read())
                {
                    cbxDesc.Items.Add(dr["descModal" ].ToString());
                    cbxDesc.DisplayMember = (dr["descModal"].ToString());
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
        public void atualizacaoPaia()
        {
            try
            {
                DAO_Conexao.con.Open();
                string sql = "SELECT * from ModalCS WHERE ativa = 0";
                MySqlCommand cmd = new MySqlCommand(sql, DAO_Conexao.con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
        }

        private void updatePreco()
        {
            try
            {
                DAO_Conexao.con.Open();
                string sql = "SELECT precoModal from ModalCS where descModal = '" + cbxDesc.SelectedItem + "' AND ativa = 0";
                MySqlCommand cmd = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtPreco.Text = dr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
        }
        
        private void updateQtdAl()
        {
            DAO_Conexao.con.Open();
            string sql = "SELECT qtdAlModal from ModalCS where descModal = '" + cbxDesc.SelectedItem + "' AND ativa = 0";
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
            string sql = "SELECT qtdAuModal from ModalCS where descModal = '" + cbxDesc.SelectedItem + "' AND ativa = 0";
            MySqlCommand cmd = new MySqlCommand(sql, DAO_Conexao.con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtAulas.Text = dr[0].ToString();
            }
            DAO_Conexao.con.Close();
        }

        private void updateID()
        {
            DAO_Conexao.con.Open();
            string sql = "SELECT idModal from ModalCS where descModal = '" + cbxDesc.SelectedItem + "' AND ativa = 0";
            MySqlCommand cmd = new MySqlCommand(sql, DAO_Conexao.con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cadTurma cadTur = new cadTurma();
                cadTur.txtIDModal.Text = dr[0].ToString();
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
            btnSalvar.Visible = true;
            Modalidade mod = new Modalidade();     
            updateComboBox();
            txtPreco.Enabled = true;
            txtAulas.Enabled = true;
            txtAlunos.Enabled = true;
            cbxDesc.Enabled = false;
        }

        private void consModal_Load(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade();
            updateComboBox();
            txtAlunos.Enabled = false;
            txtAulas.Enabled = false;
            txtPreco.Enabled = false;
            btnSalvar.Visible = false;
            if (btnSalvar.Visible)
            {
                btnAtualizar.Enabled = false;
            }

            
        }

        private void cbxDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePreco();
            updateQtdAl();
            updateQtdAu();
            updateID();
        }

        private void txtAulas_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpCons_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Modalidade mod = new Modalidade(cbxDesc.Text.ToString() ,float.Parse(txtPreco.Text), int.Parse(txtAlunos.Text), int.Parse(txtAulas.Text));
      if (mod.consultarModalidade())
            {
                MessageBox.Show("Modalidade atualizada com sucesso!", "Alerta de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                MessageBox.Show("Erro: Por favor, tente novamente.", "Alerta de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnSalvar.Visible = false;
            cbxDesc.Enabled = true;
            txtAlunos.Enabled = false;
            txtAulas.Enabled = false;
            txtPreco.Enabled = false;
        }
    }
}
