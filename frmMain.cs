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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowPart1_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmProjectForm();
            frm1.ShowDialog();
        }

        private void btnShowMessageBox_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMessageBox();
            frm1.ShowDialog();
        }

        private void chkCheckBoxRadioGroup_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmCheckBox();
            frm1.ShowDialog();
        }

        private void btnMoreAboutTextBox_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTextBox();
            frm1.ShowDialog();
        }

        private void btnPictureBox_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmPictureBox();
            frm1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmPictureBoxOdevi();
            frm.ShowDialog();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmDraw();
            frm1.ShowDialog();
        }
    }
}
