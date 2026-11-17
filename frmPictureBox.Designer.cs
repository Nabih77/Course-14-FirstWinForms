namespace Course_14_FirstWinForms
{
    partial class frmPictureBox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSyriaFoto = new System.Windows.Forms.Button();
            this.btnSyriaFlag = new System.Windows.Forms.Button();
            this.btnLoadFromFile1 = new System.Windows.Forms.Button();
            this.btnLoadFromFile2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Course_14_FirstWinForms.Properties.Resources.Syria_Foto;
            this.pictureBox1.Location = new System.Drawing.Point(272, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(896, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSyriaFoto
            // 
            this.btnSyriaFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSyriaFoto.ForeColor = System.Drawing.Color.Red;
            this.btnSyriaFoto.Location = new System.Drawing.Point(406, 540);
            this.btnSyriaFoto.Name = "btnSyriaFoto";
            this.btnSyriaFoto.Size = new System.Drawing.Size(263, 73);
            this.btnSyriaFoto.TabIndex = 1;
            this.btnSyriaFoto.Text = "Syria Foto";
            this.btnSyriaFoto.UseVisualStyleBackColor = false;
            this.btnSyriaFoto.Click += new System.EventHandler(this.btnSyriaFoto_Click);
            // 
            // btnSyriaFlag
            // 
            this.btnSyriaFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSyriaFlag.ForeColor = System.Drawing.Color.Red;
            this.btnSyriaFlag.Location = new System.Drawing.Point(776, 540);
            this.btnSyriaFlag.Name = "btnSyriaFlag";
            this.btnSyriaFlag.Size = new System.Drawing.Size(263, 73);
            this.btnSyriaFlag.TabIndex = 2;
            this.btnSyriaFlag.Text = "Syria Flag";
            this.btnSyriaFlag.UseVisualStyleBackColor = false;
            this.btnSyriaFlag.Click += new System.EventHandler(this.btnSyriaFlag_Click);
            // 
            // btnLoadFromFile1
            // 
            this.btnLoadFromFile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoadFromFile1.ForeColor = System.Drawing.Color.Red;
            this.btnLoadFromFile1.Location = new System.Drawing.Point(406, 646);
            this.btnLoadFromFile1.Name = "btnLoadFromFile1";
            this.btnLoadFromFile1.Size = new System.Drawing.Size(263, 73);
            this.btnLoadFromFile1.TabIndex = 3;
            this.btnLoadFromFile1.Text = "Load From File Syria Foto";
            this.btnLoadFromFile1.UseVisualStyleBackColor = false;
            this.btnLoadFromFile1.Click += new System.EventHandler(this.btnLoadFromFile1_Click);
            // 
            // btnLoadFromFile2
            // 
            this.btnLoadFromFile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoadFromFile2.ForeColor = System.Drawing.Color.Red;
            this.btnLoadFromFile2.Location = new System.Drawing.Point(776, 646);
            this.btnLoadFromFile2.Name = "btnLoadFromFile2";
            this.btnLoadFromFile2.Size = new System.Drawing.Size(263, 73);
            this.btnLoadFromFile2.TabIndex = 4;
            this.btnLoadFromFile2.Text = "Load From File Syria Flag";
            this.btnLoadFromFile2.UseVisualStyleBackColor = false;
            this.btnLoadFromFile2.Click += new System.EventHandler(this.btnLoadFromFile2_Click);
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1422, 757);
            this.Controls.Add(this.btnLoadFromFile2);
            this.Controls.Add(this.btnLoadFromFile1);
            this.Controls.Add(this.btnSyriaFlag);
            this.Controls.Add(this.btnSyriaFoto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPictureBox";
            this.Text = "frmPictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSyriaFoto;
        private System.Windows.Forms.Button btnSyriaFlag;
        private System.Windows.Forms.Button btnLoadFromFile1;
        private System.Windows.Forms.Button btnLoadFromFile2;
    }
}