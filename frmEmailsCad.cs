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

       

        private void frmEmailsCad_Load(object sender, EventArgs e)
        {

        }
    }
}
