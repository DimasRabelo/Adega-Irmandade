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
    public partial class frmClienteCad : Form
    {
        public frmClienteCad()
        {
            InitializeComponent();
        }     

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Close();
        }

       
    }
}
