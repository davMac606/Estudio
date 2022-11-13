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
    public partial class cadTurma : Form
    {
        public cadTurma()
        {
            InitializeComponent();
                
        }
           int limiteAviso;
        Modalidade mod = new Modalidade();
        bool uau = false;
        private void updateComboBox()
        {
            DAO_Conexao.con.Open();

            uau = true;

            string sql = "SELECT idModal, descModal FROM ModalCS";
            MySqlCommand adiciona = new MySqlCommand(sql, DAO_Conexao.con);
            MySqlDataReader dr = adiciona.ExecuteReader();
            while (dr.Read())
            {
                cbxID.Items.Add(dr["idModal"].ToString());
                cbxID.DisplayMember = (dr["idModal"].ToString());
            }
        }

        private void ()


        private void btnCadastro_Click(object sender, EventArgs e)
        {

            try
            {



                int horaStart = int.Parse(dtHoraComeco.Value.ToShortTimeString());
                int horaEnd = int.Parse(dtHoraFim.Value.ToShortTimeString());
                string dias = lsbDias.SelectedItems.ToString();
                string hora = horaStart.ToString() + "-" + horaEnd.ToString();


                while (int.Parse(txtAlunos.Text) >= mod.Qtd_Alunos)
                {
                    MessageBox.Show("A quantidade de alunos excede o limite.", "Alerta do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                consModal cons = new consModal();
                if (int.Parse(txtAlunos.Text) == int.Parse(cons.txtAlunos.Text) - 5)
                {
                    lblLimite.ForeColor = System.Drawing.Color.Red;
                    lblLimite.Text = "Só restam " + limiteAviso.ToString() + " alunos na modalidade!";
                }

                    Turma tur = new Turma(int.Parse(cons.txtID.Text), txtProfessor.Text.ToString(), dias.ToString(), hora, int.Parse(txtAlunos.Text));
                    cbxID.Items.Clear();
                if (tur.cadastrarTurma())
                {
                    MessageBox.Show("Cadastro de Turma realizado com sucesso!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else
                {

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
 private void btnModal_Click(object sender, EventArgs e)
        {
            consModal cons = new consModal();
            cons.StartPosition = FormStartPosition.CenterScreen;
            cons.Show();
        }
        

        private void cadTurma_Load(object sender, EventArgs e)
        {
            updateComboBox();
            txtIDModal.Visible = true;
           
        }

        private void dtHoraComeco_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAO_Conexao
            string
            cbxID.Text = 
        }
    }

       
    }
