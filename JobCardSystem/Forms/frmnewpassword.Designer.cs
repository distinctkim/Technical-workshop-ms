namespace JobCardSystem.Forms
{
    partial class frmnewpassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnewpassword));
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxshowpass = new System.Windows.Forms.CheckBox();
            this.txtverify = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtuserid
            // 
            this.txtuserid.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserid.Location = new System.Drawing.Point(123, 22);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(202, 22);
            this.txtuserid.TabIndex = 0;
            // 
            // btncancel
            // 
            this.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btncancel.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(243, 158);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(82, 23);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnsubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnsubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnsubmit.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnsubmit.Image")));
            this.btnsubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsubmit.Location = new System.Drawing.Point(123, 158);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(93, 23);
            this.btnsubmit.TabIndex = 4;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserIdNo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxshowpass);
            this.groupBox1.Controls.Add(this.txtverify);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnewpass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtuserid);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnsubmit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 199);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cbxshowpass
            // 
            this.cbxshowpass.AutoSize = true;
            this.cbxshowpass.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.cbxshowpass.Location = new System.Drawing.Point(344, 93);
            this.cbxshowpass.Name = "cbxshowpass";
            this.cbxshowpass.Size = new System.Drawing.Size(111, 21);
            this.cbxshowpass.TabIndex = 9;
            this.cbxshowpass.Text = "ShowPassword";
            this.cbxshowpass.UseVisualStyleBackColor = true;
            this.cbxshowpass.CheckedChanged += new System.EventHandler(this.cbxshowpass_CheckedChanged);
            // 
            // txtverify
            // 
            this.txtverify.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtverify.Location = new System.Drawing.Point(123, 119);
            this.txtverify.Name = "txtverify";
            this.txtverify.PasswordChar = '*';
            this.txtverify.Size = new System.Drawing.Size(202, 22);
            this.txtverify.TabIndex = 3;
            this.txtverify.UseSystemPasswordChar = true;
            this.txtverify.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Verify Password:";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(123, 54);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(202, 22);
            this.txtusername.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username:";
            // 
            // txtnewpass
            // 
            this.txtnewpass.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass.Location = new System.Drawing.Point(123, 88);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(202, 22);
            this.txtnewpass.TabIndex = 2;
            this.txtnewpass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Password:";
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(12, 7);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(42, 42);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 3;
            this.PictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "New Password";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Location = new System.Drawing.Point(0, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(492, 58);
            this.Panel1.TabIndex = 7;
            // 
            // frmnewpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 277);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmnewpassword";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.TextBox txtverify;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxshowpass;
    }
}