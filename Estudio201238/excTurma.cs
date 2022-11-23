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
            updateComboBox();
        }

        public void updateComboBox()
        {
            try
            {
                if (DAO_Conexao.con.State != ConnectionState.Open)
                    DAO_Conexao.con.Open();
                string sql = "SELECT idTurma, idModalidade, nomeTurma, professor, diaSemana, hora, numAlunMatriculados FROM TurmaCS WHERE turmaAtiva = 0";
                MySqlCommand adiciona = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataReader dr = adiciona.ExecuteReader();
                while (dr.Read())
                {
                    cbxId.Items.Add(dr["idTurma"].ToString());
                    cbxId.DisplayMember = (dr["idTurma"].ToString());
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

        

       

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Turma tur = new Turma(int.Parse(cbxId.SelectedItem.ToString()));
                if (DAO_Conexao.con.State == ConnectionState.Open)
                {
                    DAO_Conexao.con.Close();
                }
                if (tur.excluirTurma())
                {
                    MessageBox.Show("Turma excluída com sucesso!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro. Por favor, tente novamente.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (DAO_Conexao.con.State == ConnectionState.Open)
                {
                    DAO_Conexao.con.Close();
                }
                DAO_Conexao.con.Open();
                string sql = "SELECT idTurma, idModalidade, nomeTurma, professor, diaSemana, hora, numAlunMatriculados FROM TurmaCS WHERE turmaAtiva = 0";
                MySqlCommand busca = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataReader dr = busca.ExecuteReader();
                while (dr.Read())
                {
                    cbxId.Items.Add(dr["idTurma"].ToString());
                    cbxId.DisplayMember = (dr["idTurma"].ToString());
                }
                DAO_Conexao.con.Close();
            }
        }

        private void excTurma_Load(object sender, EventArgs e)
        {

        }

        private void cbxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DAO_Conexao.con.State == ConnectionState.Open)
            {
                DAO_Conexao.con.Close();
            }
            DAO_Conexao.con.Open();
            string sql = "SELECT nomeTurma FROM TurmaCS WHERE idTurma = '" + int.Parse(cbxId.Text.ToString()) + "'";
            MySqlCommand buscar = new MySqlCommand(sql, DAO_Conexao.con);
            MySqlDataReader dr = buscar.ExecuteReader();
            while (dr.Read())
            {
                txtNome.Text = dr["nomeTurma"].ToString();
            }
            DAO_Conexao.con.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Estudio est = new Estudio();
            gerenTurma gerTur = new gerenTurma();
            gerTur.MdiParent = est;
            gerTur.Show();
            this.Close();
        }
    }
}
