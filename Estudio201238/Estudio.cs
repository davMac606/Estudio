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
    public partial class Estudio : Form
    {
        public Estudio()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl201238", "cl201238", "cl*14032006"))
            {
                MessageBox.Show("Conectado ao banco de dados.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Console.WriteLine("Conectado.");
            }
            else
            {
                Console.WriteLine("Erro ao conectar ao banco de dados.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadAluno cd1 = new cadAluno();
            cd1.MdiParent = this;
            cd1.Show();
            grpBoxEstudio.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadUsuario cdu_login = new cadUsuario();
            cdu_login.MdiParent = this;
            cdu_login.Show();
            grpBoxEstudio.Visible = false;
            this.WindowState = FormWindowState.Maximized;

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(txtLogin.Text.Trim(), txtSenha.Text.Trim());
            if (tipo ==0)
            {
                MessageBox.Show("Usuário/Senha inválida.", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (tipo == 1)
            {
                MessageBox.Show("Usuário é um administrador. Bem vindo, admin!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grpBoxEstudio.Visible = false;
                menuStrip1.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Estudio_Load(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;
        }
    }
}
