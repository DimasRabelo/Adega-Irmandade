using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adega_Irmandade
{
    public partial class frmVendasCad : Form
    {
        public frmVendasCad()
        {
            InitializeComponent();
        }





        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmVendas().Show();
            Close();
        }
    }
}

       
