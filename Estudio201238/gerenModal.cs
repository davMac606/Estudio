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
    public partial class gerenModal : Form
    {
        public gerenModal()
        {
            InitializeComponent();
        }

        private void btnCadModal_Click(object sender, EventArgs e)
        {
            cadModal cdMod = new cadModal();
            cdMod.Show();

        }

        private void btnConsModal_Click(object sender, EventArgs e)
        {
            consModal conMod = new consModal();
            this.Hide();
            conMod.Show();
        }

        private void btnExcModal_Click(object sender, EventArgs e)
        {
            excModal exc = new excModal();
            this.Hide();
            exc.Show();
        }
    }
}
