using Course_14_FirstWinForms.Properties;
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
    public partial class frmPictureBox : Form
    {
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void btnSyriaFoto_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Syria_Foto;
        }

        private void btnSyriaFlag_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Syria_Flag;
        }

        private void btnLoadFromFile1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\SYRIA FOTO.jpg");
        }

        private void btnLoadFromFile2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\SYRIA FLAG.jpg");
        }




    }
}
