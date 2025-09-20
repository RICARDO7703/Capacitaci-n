using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyudasCapacitacion
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cliente nuevo = new frm_cliente();
            nuevo.Show();
            nuevo.MdiParent = this;
        }

        private void VehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_vehiculos nuevo = new frm_vehiculos();
            nuevo.Show();
            nuevo.MdiParent = this;
        }

        private void CompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_venta nuevo = new frm_venta();
            nuevo.Show();
            nuevo.MdiParent = this;
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaRisko/AyudaRiskoAS2.chm", "MDI.html");
        }
    }
}
