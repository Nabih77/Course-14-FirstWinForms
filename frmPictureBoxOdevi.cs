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
    public partial class frmPictureBoxOdevi : Form
    {
        public frmPictureBoxOdevi()
        {
            InitializeComponent();
        }

        void CheckPicture()
        {
            if(btnBoy.Checked)
            {
                pbSchool.Image = Image.FromFile(@"D:\Boy.png");
            }

            if (btnGirl.Checked)
            {
                pbSchool.Image = Image.FromFile(@"D:\Girl.png");
            }

            if (btnBook.Checked)
            {
                pbSchool.Image = Image.FromFile(@"D:\Book.png");
            }

            if (btnPen.Checked)
            {
                pbSchool.Image = Image.FromFile(@"D:\Pen.png");
            }
        }

        private void btnBoy_CheckedChanged(object sender, EventArgs e)
        {
            CheckPicture();
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void btnGirl_CheckedChanged(object sender, EventArgs e)
        {
            CheckPicture();
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void btnBook_CheckedChanged(object sender, EventArgs e)
        {
            CheckPicture();
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void btnPen_CheckedChanged(object sender, EventArgs e)
        {
            CheckPicture();
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }



    }
}
