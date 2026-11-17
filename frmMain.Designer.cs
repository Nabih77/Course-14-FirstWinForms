namespace Course_14_FirstWinForms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowPart1 = new System.Windows.Forms.Button();
            this.btnShowMessageBox = new System.Windows.Forms.Button();
            this.chkCheckBoxRadioGroup = new System.Windows.Forms.Button();
            this.btnMoreAboutTextBox = new System.Windows.Forms.Button();
            this.btnPictureBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowPart1
            // 
            this.btnShowPart1.Location = new System.Drawing.Point(50, 57);
            this.btnShowPart1.Name = "btnShowPart1";
            this.btnShowPart1.Size = new System.Drawing.Size(224, 64);
            this.btnShowPart1.TabIndex = 0;
            this.btnShowPart1.Text = "Show Part1";
            this.btnShowPart1.UseVisualStyleBackColor = true;
            this.btnShowPart1.Click += new System.EventHandler(this.btnShowPart1_Click);
            // 
            // btnShowMessageBox
            // 
            this.btnShowMessageBox.Location = new System.Drawing.Point(322, 57);
            this.btnShowMessageBox.Name = "btnShowMessageBox";
            this.btnShowMessageBox.Size = new System.Drawing.Size(224, 64);
            this.btnShowMessageBox.TabIndex = 1;
            this.btnShowMessageBox.Text = "Show Message Box";
            this.btnShowMessageBox.UseVisualStyleBackColor = true;
            this.btnShowMessageBox.Click += new System.EventHandler(this.btnShowMessageBox_Click);
            // 
            // chkCheckBoxRadioGroup
            // 
            this.chkCheckBoxRadioGroup.Location = new System.Drawing.Point(600, 57);
            this.chkCheckBoxRadioGroup.Name = "chkCheckBoxRadioGroup";
            this.chkCheckBoxRadioGroup.Size = new System.Drawing.Size(224, 64);
            this.chkCheckBoxRadioGroup.TabIndex = 2;
            this.chkCheckBoxRadioGroup.Text = "CheckBox/Radio/Group";
            this.chkCheckBoxRadioGroup.UseVisualStyleBackColor = true;
            this.chkCheckBoxRadioGroup.Click += new System.EventHandler(this.chkCheckBoxRadioGroup_Click);
            // 
            // btnMoreAboutTextBox
            // 
            this.btnMoreAboutTextBox.Location = new System.Drawing.Point(50, 197);
            this.btnMoreAboutTextBox.Name = "btnMoreAboutTextBox";
            this.btnMoreAboutTextBox.Size = new System.Drawing.Size(224, 64);
            this.btnMoreAboutTextBox.TabIndex = 3;
            this.btnMoreAboutTextBox.Text = "More About TextBox";
            this.btnMoreAboutTextBox.UseVisualStyleBackColor = true;
            this.btnMoreAboutTextBox.Click += new System.EventHandler(this.btnMoreAboutTextBox_Click);
            // 
            // btnPictureBox
            // 
            this.btnPictureBox.Location = new System.Drawing.Point(322, 197);
            this.btnPictureBox.Name = "btnPictureBox";
            this.btnPictureBox.Size = new System.Drawing.Size(224, 64);
            this.btnPictureBox.TabIndex = 4;
            this.btnPictureBox.Text = "Picture Box";
            this.btnPictureBox.UseVisualStyleBackColor = true;
            this.btnPictureBox.Click += new System.EventHandler(this.btnPictureBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Picture Box Odevi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(50, 324);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(224, 64);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "Draw ";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 453);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPictureBox);
            this.Controls.Add(this.btnMoreAboutTextBox);
            this.Controls.Add(this.chkCheckBoxRadioGroup);
            this.Controls.Add(this.btnShowMessageBox);
            this.Controls.Add(this.btnShowPart1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPart1;
        private System.Windows.Forms.Button btnShowMessageBox;
        private System.Windows.Forms.Button chkCheckBoxRadioGroup;
        private System.Windows.Forms.Button btnMoreAboutTextBox;
        private System.Windows.Forms.Button btnPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDraw;
    }
}