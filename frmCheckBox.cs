using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_14_FirstWinForms
{
    public partial class frmCheckBox : Form
    {
        public frmCheckBox()
        {
            InitializeComponent();
        }

        private void chkRevcieveEmail_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = chkRevcieveEmail.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chkRevcieveEmail.Checked.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rdSmall.Checked.ToString());
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            gbPizza.Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            gbPizza.Visible = true;
        }
    }
}
