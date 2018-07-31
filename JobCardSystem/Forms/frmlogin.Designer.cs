namespace JobCardSystem.Forms
{
    partial class frmlogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtlogintime = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mtdate = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbxrole = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new MetroFramework.Controls.MetroTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtcounters = new System.Windows.Forms.TextBox();
            this.txtuser = new MetroFramework.Controls.MetroTextBox();
            this.llforgotpass = new System.Windows.Forms.LinkLabel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mtlogintime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.mtdate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.cmbxrole);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.txtcounters);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.llforgotpass);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.lblpassword);
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Location = new System.Drawing.Point(139, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 263);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // mtlogintime
            // 
            // 
            // 
            // 
            this.mtlogintime.CustomButton.Image = null;
            this.mtlogintime.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.mtlogintime.CustomButton.Name = "";
            this.mtlogintime.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtlogintime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtlogintime.CustomButton.TabIndex = 1;
            this.mtlogintime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtlogintime.CustomButton.UseSelectable = true;
            this.mtlogintime.CustomButton.Visible = false;
            this.mtlogintime.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.mtlogintime.Lines = new string[0];
            this.mtlogintime.Location = new System.Drawing.Point(211, 168);
            this.mtlogintime.MaxLength = 32767;
            this.mtlogintime.Multiline = true;
            this.mtlogintime.Name = "mtlogintime";
            this.mtlogintime.PasswordChar = '\0';
            this.mtlogintime.ReadOnly = true;
            this.mtlogintime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtlogintime.SelectedText = "";
            this.mtlogintime.SelectionLength = 0;
            this.mtlogintime.SelectionStart = 0;
            this.mtlogintime.ShortcutsEnabled = true;
            this.mtlogintime.Size = new System.Drawing.Size(148, 25);
            this.mtlogintime.TabIndex = 17;
            this.mtlogintime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtlogintime.UseSelectable = true;
            this.mtlogintime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtlogintime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(208, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "LoginTime:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 15;
            // 
            // mtdate
            // 
            // 
            // 
            // 
            this.mtdate.CustomButton.Image = null;
            this.mtdate.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.mtdate.CustomButton.Name = "";
            this.mtdate.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtdate.CustomButton.TabIndex = 1;
            this.mtdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtdate.CustomButton.UseSelectable = true;
            this.mtdate.CustomButton.Visible = false;
            this.mtdate.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.mtdate.Lines = new string[0];
            this.mtdate.Location = new System.Drawing.Point(46, 168);
            this.mtdate.MaxLength = 32767;
            this.mtdate.Multiline = true;
            this.mtdate.Name = "mtdate";
            this.mtdate.PasswordChar = '\0';
            this.mtdate.ReadOnly = true;
            this.mtdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtdate.SelectedText = "";
            this.mtdate.SelectionLength = 0;
            this.mtdate.SelectionStart = 0;
            this.mtdate.ShortcutsEnabled = true;
            this.mtdate.Size = new System.Drawing.Size(148, 25);
            this.mtdate.TabIndex = 14;
            this.mtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtdate.UseSelectable = true;
            this.mtdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(43, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "LoginDate:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(409, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 14);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Test Connection";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cmbxrole
            // 
            this.cmbxrole.FormattingEnabled = true;
            this.cmbxrole.ItemHeight = 23;
            this.cmbxrole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbxrole.Location = new System.Drawing.Point(46, 21);
            this.cmbxrole.Name = "cmbxrole";
            this.cmbxrole.Size = new System.Drawing.Size(214, 29);
            this.cmbxrole.TabIndex = 11;
            this.cmbxrole.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Userrole:";
            // 
            // txtpass
            // 
            // 
            // 
            // 
            this.txtpass.CustomButton.Image = null;
            this.txtpass.CustomButton.Location = new System.Drawing.Point(342, 1);
            this.txtpass.CustomButton.Name = "";
            this.txtpass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpass.CustomButton.TabIndex = 1;
            this.txtpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpass.CustomButton.UseSelectable = true;
            this.txtpass.CustomButton.Visible = false;
            this.txtpass.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtpass.Lines = new string[0];
            this.txtpass.Location = new System.Drawing.Point(46, 118);
            this.txtpass.MaxLength = 32767;
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.PromptText = "Enter password";
            this.txtpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.ShortcutsEnabled = true;
            this.txtpass.Size = new System.Drawing.Size(366, 25);
            this.txtpass.TabIndex = 9;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpass.UseSelectable = true;
            this.txtpass.WaterMark = "Enter password";
            this.txtpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtpass.Click += new System.EventHandler(this.txtpass_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 241);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 17);
            this.textBox2.TabIndex = 2;
            // 
            // txtcounters
            // 
            this.txtcounters.Location = new System.Drawing.Point(46, 241);
            this.txtcounters.Multiline = true;
            this.txtcounters.Name = "txtcounters";
            this.txtcounters.Size = new System.Drawing.Size(39, 17);
            this.txtcounters.TabIndex = 1;
            // 
            // txtuser
            // 
            // 
            // 
            // 
            this.txtuser.CustomButton.Image = null;
            this.txtuser.CustomButton.Location = new System.Drawing.Point(340, 2);
            this.txtuser.CustomButton.Name = "";
            this.txtuser.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtuser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtuser.CustomButton.TabIndex = 1;
            this.txtuser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtuser.CustomButton.UseSelectable = true;
            this.txtuser.CustomButton.Visible = false;
            this.txtuser.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtuser.Lines = new string[0];
            this.txtuser.Location = new System.Drawing.Point(46, 70);
            this.txtuser.MaxLength = 32767;
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.PasswordChar = '\0';
            this.txtuser.PromptText = "Enter username";
            this.txtuser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtuser.SelectedText = "";
            this.txtuser.SelectionLength = 0;
            this.txtuser.SelectionStart = 0;
            this.txtuser.ShortcutsEnabled = true;
            this.txtuser.Size = new System.Drawing.Size(366, 28);
            this.txtuser.TabIndex = 8;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtuser.UseSelectable = true;
            this.txtuser.WaterMark = "Enter username";
            this.txtuser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtuser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            this.txtuser.Click += new System.EventHandler(this.txtuser_Click);
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            // 
            // llforgotpass
            // 
            this.llforgotpass.AutoSize = true;
            this.llforgotpass.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llforgotpass.Location = new System.Drawing.Point(261, 241);
            this.llforgotpass.Name = "llforgotpass";
            this.llforgotpass.Size = new System.Drawing.Size(98, 14);
            this.llforgotpass.TabIndex = 6;
            this.llforgotpass.TabStop = true;
            this.llforgotpass.Text = "Forgot Password?";
            this.llforgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llforgotpass_LinkClicked);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Cambria", 9F);
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(264, 203);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(148, 32);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogin.Location = new System.Drawing.Point(46, 203);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(148, 32);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.lblpassword.Location = new System.Drawing.Point(43, 101);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(65, 14);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(43, 53);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(66, 14);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.PictureBox2);
            this.panel2.Controls.Add(this.Label1);
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 42);
            this.panel2.TabIndex = 2;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Maroon;
            this.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(3, 3);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(42, 36);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 3;
            this.PictureBox2.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(51, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(116, 25);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "User Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmlogin
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(660, 330);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtcounters;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel llforgotpass;
        private MetroFramework.Controls.MetroTextBox txtpass;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Label1;
        private MetroFramework.Controls.MetroComboBox cmbxrole;
        private System.Windows.Forms.Label label2;
        public MetroFramework.Controls.MetroTextBox txtuser;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroTextBox mtdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroTextBox mtlogintime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
    }
}