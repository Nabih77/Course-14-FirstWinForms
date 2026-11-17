namespace Course_14_FirstWinForms
{
    partial class frmCheckBox
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
            this.chkRevcieveEmail = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbPizza = new System.Windows.Forms.GroupBox();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbPizza.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkRevcieveEmail
            // 
            this.chkRevcieveEmail.AutoSize = true;
            this.chkRevcieveEmail.Location = new System.Drawing.Point(117, 50);
            this.chkRevcieveEmail.Name = "chkRevcieveEmail";
            this.chkRevcieveEmail.Size = new System.Drawing.Size(186, 17);
            this.chkRevcieveEmail.TabIndex = 0;
            this.chkRevcieveEmail.Text = "Do You Want To Revcieve Email ?";
            this.chkRevcieveEmail.UseVisualStyleBackColor = true;
            this.chkRevcieveEmail.CheckedChanged += new System.EventHandler(this.chkRevcieveEmail_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(117, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbPizza
            // 
            this.gbPizza.Controls.Add(this.rdLarge);
            this.gbPizza.Controls.Add(this.rdMedium);
            this.gbPizza.Controls.Add(this.rdSmall);
            this.gbPizza.Location = new System.Drawing.Point(117, 135);
            this.gbPizza.Name = "gbPizza";
            this.gbPizza.Size = new System.Drawing.Size(149, 144);
            this.gbPizza.TabIndex = 5;
            this.gbPizza.TabStop = false;
            this.gbPizza.Text = "Size";
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Location = new System.Drawing.Point(24, 87);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(52, 17);
            this.rdLarge.TabIndex = 7;
            this.rdLarge.TabStop = true;
            this.rdLarge.Text = "Large";
            this.rdLarge.UseVisualStyleBackColor = true;
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Location = new System.Drawing.Point(24, 64);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(61, 17);
            this.rdMedium.TabIndex = 6;
            this.rdMedium.TabStop = true;
            this.rdMedium.Text = "Medium";
            this.rdMedium.UseVisualStyleBackColor = true;
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Location = new System.Drawing.Point(24, 41);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(49, 17);
            this.rdSmall.TabIndex = 5;
            this.rdSmall.TabStop = true;
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Location = new System.Drawing.Point(17, 34);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(45, 17);
            this.rdThin.TabIndex = 7;
            this.rdThin.TabStop = true;
            this.rdThin.Text = "Thin";
            this.rdThin.UseVisualStyleBackColor = true;
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(17, 57);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(49, 17);
            this.rbThick.TabIndex = 8;
            this.rbThick.TabStop = true;
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbThick);
            this.gbCrust.Controls.Add(this.rdThin);
            this.gbCrust.Location = new System.Drawing.Point(309, 136);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(119, 143);
            this.gbCrust.TabIndex = 9;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(470, 135);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(108, 37);
            this.btnHide.TabIndex = 10;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(604, 135);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(108, 37);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbPizza);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkRevcieveEmail);
            this.Name = "frmCheckBox";
            this.Text = "frmCheckBox";
            this.gbPizza.ResumeLayout(false);
            this.gbPizza.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRevcieveEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbPizza;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
    }
}