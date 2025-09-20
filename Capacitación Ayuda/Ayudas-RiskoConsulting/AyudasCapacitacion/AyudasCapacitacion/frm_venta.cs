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
    public partial class frm_venta : Form
    {
        public frm_venta()
        {
            InitializeComponent();
        }

        private void picBox_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaRisko/AyudaRiskoAS2.chm", "Venta.html");
        }
    }
}
