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
    public partial class excTurma : Form
    {
        public excTurma()
        {
            InitializeComponent();
        }

        public bool excluirTurma()
        {
            bool exc = false;
            if (DAO_Conexao.con.State == ConnectionState.Open)
            {
                DAO_Conexao.con.Close();
            }
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM TurmaCS WHERE idTurma = '" + lblID.Text + "'", DAO_Conexao.con);
                cmd.ExecuteReader();
                exc = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (DAO_Conexao.con.State == ConnectionState.Open)
            {
                DAO_Conexao.con.Close();
            }
            try
            {
                DAO_Conexao.con.Open();
                string sql = "SELECT * FROM TurmaCS WHERE nomeTurma LIKE + '" + txtNome.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblID.Text = dr[0].ToString();
                }
                DAO_Conexao.con.Close();

            }   catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            } finally
            {
                DAO_Conexao.con.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Turma tur = new Turma();
            if (DAO_Conexao.con.State == ConnectionState.Open)
            {
                DAO_Conexao.con.Close();
            }
            if (excluirTurma())
            {
                MessageBox.Show("Turma excluída com sucesso!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                MessageBox.Show("Ocorreu um erro. Por favor, tente novamente.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
