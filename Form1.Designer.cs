namespace Course_14_FirstWinForms
{
    partial class frmProjectForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnVisable = new System.Windows.Forms.Button();
            this.btnHideTextBoxes = new System.Windows.Forms.Button();
            this.btnShowTextBoxes = new System.Windows.Forms.Button();
            this.btnBackColortxt1 = new System.Windows.Forms.Button();
            this.btnBackColortxt2 = new System.Windows.Forms.Button();
            this.btnChangeFormTitle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeLabel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(502, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Copy On Mouse Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Copy On Mouse Enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(502, 126);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(202, 46);
            this.btn.TabIndex = 6;
            this.btn.Text = "Disable TextBox1";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(502, 189);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(202, 46);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "Enable TextBox1";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(294, 126);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(202, 46);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "Hide TextBox1";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnVisable
            // 
            this.btnVisable.Location = new System.Drawing.Point(294, 189);
            this.btnVisable.Name = "btnVisable";
            this.btnVisable.Size = new System.Drawing.Size(202, 46);
            this.btnVisable.TabIndex = 9;
            this.btnVisable.Text = "Show TextBox1";
            this.btnVisable.UseVisualStyleBackColor = true;
            this.btnVisable.Click += new System.EventHandler(this.btnVisable_Click);
            // 
            // btnHideTextBoxes
            // 
            this.btnHideTextBoxes.Location = new System.Drawing.Point(12, 9);
            this.btnHideTextBoxes.Name = "btnHideTextBoxes";
            this.btnHideTextBoxes.Size = new System.Drawing.Size(202, 46);
            this.btnHideTextBoxes.TabIndex = 10;
            this.btnHideTextBoxes.Text = "Hide TextBox";
            this.btnHideTextBoxes.UseVisualStyleBackColor = true;
            this.btnHideTextBoxes.Click += new System.EventHandler(this.btnHideTextBoxes_Click);
            // 
            // btnShowTextBoxes
            // 
            this.btnShowTextBoxes.Location = new System.Drawing.Point(615, 19);
            this.btnShowTextBoxes.Name = "btnShowTextBoxes";
            this.btnShowTextBoxes.Size = new System.Drawing.Size(202, 46);
            this.btnShowTextBoxes.TabIndex = 11;
            this.btnShowTextBoxes.Text = "Show TextBox";
            this.btnShowTextBoxes.UseVisualStyleBackColor = true;
            this.btnShowTextBoxes.Click += new System.EventHandler(this.btnShowTextBoxes_Click);
            // 
            // btnBackColortxt1
            // 
            this.btnBackColortxt1.Location = new System.Drawing.Point(79, 254);
            this.btnBackColortxt1.Name = "btnBackColortxt1";
            this.btnBackColortxt1.Size = new System.Drawing.Size(202, 47);
            this.btnBackColortxt1.TabIndex = 12;
            this.btnBackColortxt1.Text = "txt1 Red and All Green";
            this.btnBackColortxt1.UseVisualStyleBackColor = true;
            this.btnBackColortxt1.Click += new System.EventHandler(this.btnBackColortxt1_Click);
            // 
            // btnBackColortxt2
            // 
            this.btnBackColortxt2.Location = new System.Drawing.Point(79, 318);
            this.btnBackColortxt2.Name = "btnBackColortxt2";
            this.btnBackColortxt2.Size = new System.Drawing.Size(202, 47);
            this.btnBackColortxt2.TabIndex = 13;
            this.btnBackColortxt2.Text = "All White";
            this.btnBackColortxt2.UseVisualStyleBackColor = true;
            this.btnBackColortxt2.Click += new System.EventHandler(this.btnBackColortxt2_Click);
            // 
            // btnChangeFormTitle
            // 
            this.btnChangeFormTitle.Location = new System.Drawing.Point(294, 254);
            this.btnChangeFormTitle.Name = "btnChangeFormTitle";
            this.btnChangeFormTitle.Size = new System.Drawing.Size(202, 46);
            this.btnChangeFormTitle.TabIndex = 14;
            this.btnChangeFormTitle.Text = "Change Form Title";
            this.btnChangeFormTitle.UseVisualStyleBackColor = true;
            this.btnChangeFormTitle.Click += new System.EventHandler(this.btnChangeFormTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(254, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "This is A Practis Project";
            // 
            // btnChangeLabel
            // 
            this.btnChangeLabel.Location = new System.Drawing.Point(294, 319);
            this.btnChangeLabel.Name = "btnChangeLabel";
            this.btnChangeLabel.Size = new System.Drawing.Size(202, 46);
            this.btnChangeLabel.TabIndex = 16;
            this.btnChangeLabel.Text = "Change Label";
            this.btnChangeLabel.UseVisualStyleBackColor = true;
            this.btnChangeLabel.Click += new System.EventHandler(this.btnChangeLabel_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 5;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(502, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 47);
            this.button3.TabIndex = 17;
            this.button3.Text = "Test Button";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 5;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(502, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(202, 47);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 763);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnChangeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeFormTitle);
            this.Controls.Add(this.btnBackColortxt2);
            this.Controls.Add(this.btnBackColortxt1);
            this.Controls.Add(this.btnShowTextBoxes);
            this.Controls.Add(this.btnHideTextBoxes);
            this.Controls.Add(this.btnVisable);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "frmProjectForm";
            this.Text = " Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnVisable;
        private System.Windows.Forms.Button btnHideTextBoxes;
        private System.Windows.Forms.Button btnShowTextBoxes;
        private System.Windows.Forms.Button btnBackColortxt1;
        private System.Windows.Forms.Button btnBackColortxt2;
        private System.Windows.Forms.Button btnChangeFormTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClose;
    }
}

