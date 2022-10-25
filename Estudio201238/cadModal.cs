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
    public partial class cadModal : Form
    {
        public cadModal()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDesc.Text.Equals(""))
                {
                    MessageBox.Show("Cadastro falhou. Por favor, tente novamente.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Modalidade mod = new Modalidade(txtDesc.Text, float.Parse(txtPreco.Text), int.Parse(txtAlunos.Text), int.Parse(txtAulas.Text));
            
                if (mod.cadastrarModalidade())
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Cadastro falhou. Por favor, tente novamente.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excModal exc = new excModal();
            exc.Show();
            this.Hide();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            gerenModal gerMod = new gerenModal();
            gerMod.Show();
            this.Hide();
        }
    }
    }
