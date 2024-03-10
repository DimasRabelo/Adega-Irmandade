using System;
using System.Windows.Forms;

namespace Adega_Irmandade
{
    public partial class frmEmailsCad : Form
    {
        public frmEmailsCad()
        {
            InitializeComponent();

           
        }

        private void pctFechar_Click(object sender, EventArgs e)
        {
            new frmEmails().Show();
            Close();
        }

        private void lblCadEndereco_Click(object sender, EventArgs e)
        {

        }
    }
}
