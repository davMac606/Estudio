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
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            
            try
            {
                bool ativ = false;
                if (chkAtiva.Checked)
                {
                    ativ = true;
                }
                else
                {
                    ativ = false;
                }
                int horaStart = int.Parse(dtHoraComeco.Value.ToShortTimeString());
                int horaEnd = int.Parse(dtHoraFim.Value.ToShortTimeString());
                string dias = lsbDias.SelectedItems.ToString();
                int horario = horaStart - horaEnd;
                string hora = horario.ToString();
                consModal cons = new consModal();
                if (int.Parse(txtAlunos.Text) == int.Parse(cons.txtAlunos.Text) - 5)
                {
                    lblLimite.ForeColor = System.Drawing.Color.Red;
                    lblLimite.Text = "Só restam " + limiteAviso.ToString() + " alunos na modalidade!";
                    while (int.Parse(txtAlunos.Text) > mod.Qtd_Alunos)
                {
                    MessageBox.Show("A quantidade de alunos excede o limite.", "Alerta do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                Turma tur = new Turma(int.Parse(cons.txtID.Text), txtProfessor.Text.ToString(), dias.ToString(), hora, int.Parse(txtAlunos.Text));
                tur.cadastrarTurma();
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
            
            txtIDModal.Visible = true;
           
        }

        private void dtHoraComeco_ValueChanged(object sender, EventArgs e)
        {

        }
    }

       
    }
