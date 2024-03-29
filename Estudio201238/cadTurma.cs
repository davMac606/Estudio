﻿using MySql.Data.MySqlClient;
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
        Modalidade mod = new Modalidade();
        consModal cons = new consModal();
        private void updateComboBox()
        {
            DAO_Conexao.con.Open();

            string sql = "SELECT idModal, descModal, qtdAuModal FROM ModalCS WHERE ativa = 0";
            MySqlCommand adiciona = new MySqlCommand(sql, DAO_Conexao.con);
            MySqlDataReader dr = adiciona.ExecuteReader();
            while (dr.Read())
            {
                txtIDModal.Text = (dr["idModal"].ToString());
                txtIDModal.ReadOnly = true;
                cbxDesc.Items.Add(dr["descModal"].ToString());
                cbxDesc.DisplayMember = (dr["descModal"].ToString());
                mod.Qtd_Alunos = int.Parse((dr["qtdAuModal"].ToString()));
            }
            DAO_Conexao.con.Close();
        }

        private void atualizaID()
        { 
            if (DAO_Conexao.con.State == ConnectionState.Open)
            {
                DAO_Conexao.con.Close();
            }
            DAO_Conexao.con.Open();
            string sql = "SELECT idModal, qtdAuModal FROM ModalCS WHERE descModal = '" + cbxDesc.Text + "' AND ativa = 0";
            MySqlCommand cmd = new MySqlCommand(sql, DAO_Conexao.con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtIDModal.Text = dr[0].ToString();
                mod.Qtd_Alunos = int.Parse(dr[1].ToString());
            }
            DAO_Conexao.con.Close();
            
        }



        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                string hora = txtHora.Text;
                string dias = txtDias.Text;


                consModal cons = new consModal();

                Turma tur = new Turma(int.Parse(txtIDModal.Text), txtNome.Text.ToString(), txtProfessor.Text.ToString(), dias.ToString(), hora, int.Parse(txtAlunos.Text));

                if (int.Parse(txtAlunos.Text) >= mod.Qtd_Alunos)
                {
                    MessageBox.Show("A quantidade de alunos excede o limite.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                  
                    if (tur.cadastrarTurma())
                    {
                        MessageBox.Show("Cadastro de Turma realizado com sucesso!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("ERRO: Não foi possível cadastrar a turma. Por favor, tente novamente.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
            txtIDModal.Clear();
            grpCadTurma.Enabled = false;
            cbxDesc.Sorted = true;
           
        }

  

        private void cbxDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizaID();
            int limite = mod.Qtd_Alunos;
            lblLimite.ForeColor = Color.Red;
            lblLimite.Text = "O Limite é de " + limite.ToString() + " alunos.";
            grpCadTurma.Enabled = true;
        }


        private void lsbDias_Leave(object sender, EventArgs e)
        {
            txtDias.Clear();
            foreach (object selectedItem in lsbDias.SelectedItems)
            {
                txtDias.AppendText(selectedItem.ToString() + ";" + Environment.NewLine);
            }
        }

        private void dtHoraComeco_Leave(object sender, EventArgs e)
        {
            txtHora.Visible = true;
            string hora = dtHoraComeco.Text + "-" + dtHoraFim.Text;
            txtHora.Text = hora;
        }

        private void btnTempo_Click(object sender, EventArgs e)
        {
            txtHora.Visible = true;
            string hora = dtHoraComeco.Text + "-" + dtHoraFim.Text;
            txtHora.Text = hora;
            txtHora.Enabled = false;
        }

   

        private void txtAlunos_Leave(object sender, EventArgs e)
        {
            
        }

        private void dtHoraFim_Leave(object sender, EventArgs e)
        {
            
        }

    

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Estudio est = new Estudio();
            gerenTurma gerTur = new gerenTurma();
            gerTur.MdiParent = est;
            gerTur.Show();
            this.Close();
        }

       

       

        private void grpCadTurma_Enter(object sender, EventArgs e)
        {
         
        }

        private void dtHoraFim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtHora.Visible = true;
                string hora = dtHoraComeco.Text + "-" + dtHoraFim.Text;
                txtHora.Text = hora;
                txtHora.Enabled = false;
            }
        }

        private void dtHoraComeco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtHora.Visible = true;
                string hora = dtHoraComeco.Text + "-" + dtHoraFim.Text;
                txtHora.Text = hora;
                txtHora.Enabled = false;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void txtAlunos_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtAlunos.Text) == int.Parse(cons.txtAlunos.Text) - 5)
            {
                lblLimite.ForeColor = System.Drawing.Color.Red;
                lblLimite.Text = "Só restam " + limiteAviso.ToString() + " alunos na modalidade!";
            }
        }*/
    }

       
    }
