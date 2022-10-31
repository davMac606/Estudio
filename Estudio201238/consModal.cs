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
            bool aberta = false;
            
            try
            {
                if (DAO_Conexao.con.State == ConnectionState.Open)
                {
                    DAO_Conexao.con.Close();
                }
                DAO_Conexao.con.Open();
                aberta = true;
                string sql = "SELECT idModal, descModal, precoModal, qtdAlModal, qtdAuModal from ModalCS";
                MySqlCommand adiciona = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataReader dr = adiciona.ExecuteReader();
                while (dr.Read())
                {
                    cbxDesc.Items.Add(dr["descModal"].ToString());
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
            bool atu = false;
            try
            {
                DAO_Conexao.con.Open();
                string sql = "SELECT * from ModalCS";
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
                string sql = "SELECT precoModal from ModalCS where descModal = '" + cbxDesc.SelectedItem + "'";
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

        public bool cadastrarModalidade()
        {
            Modalidade mod = new Modalidade();
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                mod.Preco = float.Parse(txtPreco.Text);
                mod.Qtd_Alunos = int.Parse(txtAlunos.Text);
                mod.Qtd_Aulas = int.Parse(txtAulas.Text);
                MySqlCommand updatePrice = new MySqlCommand("UPDATE ModalCS SET precoModal = '" + mod.Preco + "' WHERE ativa = 0", DAO_Conexao.con);
                MySqlCommand updateQtdAl = new MySqlCommand("UPDATE ModalCS SET qtdAlModal = '" + mod.Qtd_Alunos + "' WHERE ativa = 0", DAO_Conexao.con);
                MySqlCommand updateQtdAu = new MySqlCommand("UPDATE ModalCS SET qtdAuModal = '" + mod.Qtd_Aulas + "' WHERE ativa = 0", DAO_Conexao.con);

                updatePrice.ExecuteNonQuery();
                updateQtdAl.ExecuteNonQuery();
                updateQtdAu.ExecuteNonQuery();
                
                cad = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
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
        }

        private void txtAulas_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpCons_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
      if (cadastrarModalidade())
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
