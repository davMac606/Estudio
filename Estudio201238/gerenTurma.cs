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
            cadTurma cadTu = new cadTurma();
            cadTu.MdiParent = this;
            cadTu.Show();
            grpTurma.Visible = false;
        }

        private void grpTurma_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultaTurma_Click(object sender, EventArgs e)
        {
            consTurma conTur = new consTurma();
            conTur.MdiParent = this;
            conTur.Show();
            grpTurma.Visible = false;
        }
    }
}
