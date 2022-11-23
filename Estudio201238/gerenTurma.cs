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
    public partial class gerenTurma : Form
    {
        public gerenTurma()
        {
            InitializeComponent();
        }

        private void btnCadastroTurma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cadTurma cadTu = new cadTurma();
            cadTu.Show();
            grpTurma.Visible = false;
            this.Close();

        }

        private void grpTurma_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultaTurma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            consTurma conTur = new consTurma();
            conTur.Show();
            grpTurma.Visible = false;
            this.Close();

        }

        private void btnExcsTurma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            excTurma excTur = new excTurma();
            excTur.Show();
            grpTurma.Visible = false;
            this.Close();

        }
    }
}
