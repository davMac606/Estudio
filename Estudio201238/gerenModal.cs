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
            this.Hide();
            

        }

        private void btnConsModal_Click(object sender, EventArgs e)
        {
            consModal conMod = new consModal();
            conMod.Show();
            this.Hide();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            BuscaModal busca = new BuscaModal();
            busca.Show();
            this.Hide();
        }

    }
}
