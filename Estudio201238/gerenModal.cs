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
            cdMod.MdiParent = this;
            cdMod.Show();

        }
    }
}
