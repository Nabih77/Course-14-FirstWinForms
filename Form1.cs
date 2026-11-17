using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course_14_FirstWinForms
{
    public partial class frmProjectForm : Form
    {
        public frmProjectForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + " Nabih";
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            label1.Text = textBox1.Text;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void btnVisable_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void btnHideTextBoxes_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
        }

        private void btnShowTextBoxes_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void btnBackColortxt1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            this.BackColor = Color.Green; // this is Form Control 
        }

        private void btnBackColortxt2_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            this.BackColor = Color.White;
        }

        private void btnChangeFormTitle_Click(object sender, EventArgs e)
        {
            this.Text = "MyProject";
        }

        private void btnChangeLabel_Click(object sender, EventArgs e)
        {
            label1.Text = "Mohammed Nabih";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
