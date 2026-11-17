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
    public partial class frmDraw : Form
    {
        public frmDraw()
        {
            InitializeComponent();
        }

        private void frmDraw_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(250, 0, 0, 0);
            Pen pen = new Pen(Black);
            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(pen,500,500,100,500);
            e.Graphics.DrawRectangle(pen,500,500,100,100);



        }

        private void frmDraw_Load(object sender, EventArgs e)
        {

        }
    }
}
