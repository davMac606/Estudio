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
    public partial class BuscaModal : Form
    {
        public BuscaModal()
        { 
            InitializeComponent();
            tt.SetToolTip(txtDesc, "Insira uma descrição para busca. Para uma busca geral, deixe o campo vazio.");
        }
        public void buscaParam()
        {
            try
            {
                if (DAO_Conexao.con.State == ConnectionState.Open)
                {
                    DAO_Conexao.con.Close();
                }
                DAO_Conexao.con.Open();
                string sql = "SELECT descModal FROM ModalCS WHERE descModal LIKE '" + txtDesc.Text.Trim().ToLower() + "' AND ativa = 0";
                MySqlCommand adiciona = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataReader dr = adiciona.ExecuteReader();
                MessageBox.Show("Busca efetuada com sucesso.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                while (dr.Read())
                {
                    cbxModal.Items.Add(dr["descModal"].ToString());
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

        public void buscaGeral()
        {
            try
            {
                if (DAO_Conexao.con.State == ConnectionState.Open)
                {
                    DAO_Conexao.con.Close();
                }
                DAO_Conexao.con.Open();
                string sql = "SELECT * FROM ModalCS WHERE LOWER(descModal) LIKE '%" + txtDesc.Text.Trim().ToLower() + "%' AND ativa = 0";
                MySqlCommand adiciona = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataReader dr = adiciona.ExecuteReader();
                MessageBox.Show("Busca efetuada com sucesso.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                while (dr.Read())
                {
                    cbxModal.Items.Add(dr["descModal"].ToString());
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDesc.Text.ToString()))
                buscaGeral();
            else
                buscaParam();
            if (cbxModal.Items.Count > 0)
                cbxModal.SelectedIndex = 0;
        }

        public ToolTip tt = new ToolTip();

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            gerenModal gerMod = new gerenModal();
            gerMod.Show();
        }
    }
}
