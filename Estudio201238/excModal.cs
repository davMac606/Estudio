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

        private void grpExcModal_Enter(object sender, EventArgs e)
        {

        }

        private void btnExcModal_Click(object sender, EventArgs e)
        {

        }

        private void cbxDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void excModal_Load(object sender, EventArgs e)
        {
            try
            {
                DAO_Conexao.con.Open();
                string sql = "SELECT descModal from ModalCS";
                MySqlCommand adiciona = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataAdapter da = new MySqlDataAdapter(sql, DAO_Conexao.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                adiciona.ExecuteNonQuery();
                DAO_Conexao.con.Close();
                DAO_Conexao.AddItemCbxDesc();
                cbxDesc.DisplayMember = "items";
                cbxDesc.ValueMember = "items";
                cbxDesc.DataSource = ds.Tables[0];
                cbxDesc.Enabled = true;
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
    }
}
