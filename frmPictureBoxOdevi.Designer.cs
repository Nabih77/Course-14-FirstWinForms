namespace Course_14_FirstWinForms
{
    partial class frmPictureBoxOdevi
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbSchool = new System.Windows.Forms.PictureBox();
            this.btnBoy = new System.Windows.Forms.RadioButton();
            this.btnGirl = new System.Windows.Forms.RadioButton();
            this.btnBook = new System.Windows.Forms.RadioButton();
            this.btnPen = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchool)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(563, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 63);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // pbSchool
            // 
            this.pbSchool.Location = new System.Drawing.Point(281, 114);
            this.pbSchool.Name = "pbSchool";
            this.pbSchool.Size = new System.Drawing.Size(715, 401);
            this.pbSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSchool.TabIndex = 1;
            this.pbSchool.TabStop = false;
            // 
            // btnBoy
            // 
            this.btnBoy.AutoSize = true;
            this.btnBoy.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoy.Location = new System.Drawing.Point(325, 577);
            this.btnBoy.Name = "btnBoy";
            this.btnBoy.Size = new System.Drawing.Size(58, 27);
            this.btnBoy.TabIndex = 2;
            this.btnBoy.Tag = "Boy";
            this.btnBoy.Text = "Boy";
            this.btnBoy.UseVisualStyleBackColor = true;
            this.btnBoy.CheckedChanged += new System.EventHandler(this.btnBoy_CheckedChanged);
            // 
            // btnGirl
            // 
            this.btnGirl.AutoSize = true;
            this.btnGirl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirl.Location = new System.Drawing.Point(526, 577);
            this.btnGirl.Name = "btnGirl";
            this.btnGirl.Size = new System.Drawing.Size(56, 27);
            this.btnGirl.TabIndex = 3;
            this.btnGirl.Tag = "Girl";
            this.btnGirl.Text = "Girl";
            this.btnGirl.UseVisualStyleBackColor = true;
            this.btnGirl.CheckedChanged += new System.EventHandler(this.btnGirl_CheckedChanged);
            // 
            // btnBook
            // 
            this.btnBook.AutoSize = true;
            this.btnBook.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(713, 577);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(68, 27);
            this.btnBook.TabIndex = 4;
            this.btnBook.Tag = "Book";
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.CheckedChanged += new System.EventHandler(this.btnBook_CheckedChanged);
            // 
            // btnPen
            // 
            this.btnPen.AutoSize = true;
            this.btnPen.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPen.Location = new System.Drawing.Point(904, 577);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(59, 27);
            this.btnPen.TabIndex = 5;
            this.btnPen.Tag = "Pen";
            this.btnPen.Text = "Pen";
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.CheckedChanged += new System.EventHandler(this.btnPen_CheckedChanged);
            // 
            // frmPictureBoxOdevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 710);
            this.Controls.Add(this.btnPen);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnGirl);
            this.Controls.Add(this.btnBoy);
            this.Controls.Add(this.pbSchool);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmPictureBoxOdevi";
            this.Text = "frmPictureBoxOdevi";
            ((System.ComponentModel.ISupportInitialize)(this.pbSchool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbSchool;
        private System.Windows.Forms.RadioButton btnBoy;
        private System.Windows.Forms.RadioButton btnGirl;
        private System.Windows.Forms.RadioButton btnBook;
        private System.Windows.Forms.RadioButton btnPen;
    }
}