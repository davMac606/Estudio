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
    public partial class consTurma : Form
    {
        public consTurma()
        {
            InitializeComponent();
        }
        public void updateComboBox()
        {
        
            try
            {
                if (DAO_Conexao.con.State == ConnectionState.Open)
                {
                    DAO_Conexao.con.Close();
                }
                DAO_Conexao.con.Open();
                string sql = "SELECT idTurma, idModalidade, nomeTurma, professor, diaSemana, hora, numAlunMatriculados, turmaAtiva from TurmaCS";
                MySqlCommand adiciona = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataReader dr = adiciona.ExecuteReader();
                while (dr.Read())
                {
                    cbxNome.Items.Add(dr["nomeTurma"].ToString());
                    cbxNome.DisplayMember = (dr["nomeTurma"].ToString());
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

        public void updateProfessor()
        {
            try
            {
                DAO_Conexao.con.Open();
                string sql = "SELECT professor from ModalCS where nomeTurma = '" + cbxNome.SelectedItem + "'";
                MySqlCommand cmd = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtProfessor.Text = dr[0].ToString();
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

        public void updateDias()
        {
            try
            {
                DAO_Conexao.con.Open();
                string sql = "SELECT diaSemana from ModalCS where nomeTurma = '" + cbxNome.SelectedItem + "'";
                MySqlCommand cmd = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtDias.Text = dr[0].ToString();
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

        public void updateHora()
        {
            try
            {
                DAO_Conexao.con.Open();
                string sql = "SELECT hora from ModalCS where nomeTurma = '" + cbxNome.SelectedItem + "'";
                MySqlCommand cmd = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtHora.Text = dr[0].ToString();
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

        public void updateAlunos()
        {
            try
            {
                DAO_Conexao.con.Open();
                string sql = "SELECT numAlunMatriculados from ModalCS where nomeTurma = '" + cbxNome.SelectedItem + "'";
                MySqlCommand cmd = new MySqlCommand(sql, DAO_Conexao.con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtAlunos.Text = dr[0].ToString();
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

        public void atualizaDados()
        {
            btnAtualizar.Text = "Salvar";
            Turma tur = new Turma();
            updateComboBox();
            txtAlunos.Enabled = true;
            txtDias.Enabled = true;
            txtHora.Enabled = true;
            txtProfessor.Enabled = true;
            cbxNome.Enabled = false;
        }

        public bool atualizaTurma()
        {
            Turma tur = new Turma();
            bool atu = false;
            try
            {
                DAO_Conexao.con.Open();
                tur.Professor = txtProfessor.Text;
                tur.Dia_Semana = txtDias.Text;
                tur.Hora = txtHora.Text;
                tur.NumAlunMatriculados = int.Parse(txtAlunos.Text);
                MySqlCommand updateProfessor = new MySqlCommand("UPDATE TurmaCS SET professor = '" + tur.Professor + "' WHERE turmaAtiva = 1", DAO_Conexao.con);
                MySqlCommand updateDias = new MySqlCommand("UPDATE TurmaCS SET diaSemana = '" + tur.Dia_Semana + "' WHERE turmaAtiva = 1", DAO_Conexao.con);
                MySqlCommand updateHora = new MySqlCommand("UPDATE TurmaCS SET hora = '" + tur.Hora + "' WHERE turmaAtiva = 1", DAO_Conexao.con);
                MySqlCommand updateAlunos = new MySqlCommand("UPDATE TurmaCS SET numAlunMatriculados = '" + tur.NumAlunMatriculados + "' WHERE turmaAtiva = 1", DAO_Conexao.con);
                updateProfessor.ExecuteNonQuery();
                updateDias.ExecuteNonQuery();
                updateHora.ExecuteNonQuery();
                updateAlunos.ExecuteNonQuery();

                atu = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return atu;
        }
        private void consTurma_Load(object sender, EventArgs e)
        {
            updateComboBox();
            Turma tur = new Turma();
            txtAlunos.Enabled = false;
            txtDias.Enabled = false;
            txtHora.Enabled = false;
            txtProfessor.Enabled = false;
        }

        private void cbxNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateAlunos();
            updateDias();
            updateHora();
            updateProfessor();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (btnAtualizar.Text.Equals("Atualizar"))
            {
                atualizaDados();
            }
            if (btnAtualizar.Text.Equals("Salvar"))
            {
                if (atualizaTurma())
                {
                    MessageBox.Show("Turma atualizada com sucesso!", "Alerta de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else
                {
                    MessageBox.Show("Erro: Por favor, tente novamente.", "Alerta de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnAtualizar.Text = "Atualizar";
                cbxNome.Enabled = true;
                txtAlunos.Enabled = false;
                txtDias.Enabled = false;
                txtHora.Enabled = false;
                txtProfessor.Enabled = false;
            }
        }
    }
}
