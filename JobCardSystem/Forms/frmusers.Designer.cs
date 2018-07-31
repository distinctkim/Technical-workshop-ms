namespace JobCardSystem.Forms
{
    partial class frmusers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmusers));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbxstamp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbxdesig = new System.Windows.Forms.ComboBox();
            this.cmbxurole = new System.Windows.Forms.ComboBox();
            this.cmbxdept = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtconpass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtmobileno = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnuserinfo = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Location = new System.Drawing.Point(0, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(534, 56);
            this.Panel1.TabIndex = 29;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Maroon;
            this.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(3, 3);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(42, 42);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 4;
            this.PictureBox2.TabStop = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(51, 22);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(160, 23);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Manage Users";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.cmbxstamp);
            this.GroupBox1.Controls.Add(this.label12);
            this.GroupBox1.Controls.Add(this.cmbxdesig);
            this.GroupBox1.Controls.Add(this.cmbxurole);
            this.GroupBox1.Controls.Add(this.cmbxdept);
            this.GroupBox1.Controls.Add(this.label11);
            this.GroupBox1.Controls.Add(this.txtconpass);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.label9);
            this.GroupBox1.Controls.Add(this.label10);
            this.GroupBox1.Controls.Add(this.txtuname);
            this.GroupBox1.Controls.Add(this.txtpass);
            this.GroupBox1.Controls.Add(this.txtid);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtname);
            this.GroupBox1.Controls.Add(this.txtmobileno);
            this.GroupBox1.Controls.Add(this.txtemail);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(0, 67);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(528, 402);
            this.GroupBox1.TabIndex = 30;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Create New User";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // cmbxstamp
            // 
            this.cmbxstamp.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxstamp.Location = new System.Drawing.Point(149, 373);
            this.cmbxstamp.Name = "cmbxstamp";
            this.cmbxstamp.Size = new System.Drawing.Size(254, 21);
            this.cmbxstamp.TabIndex = 10;
            this.cmbxstamp.TextChanged += new System.EventHandler(this.cmbxstamp_TextChanged);
            this.cmbxstamp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbxstamp_KeyPress);
            this.cmbxstamp.Leave += new System.EventHandler(this.cmbxstamp_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "ID Number :";
            // 
            // cmbxdesig
            // 
            this.cmbxdesig.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxdesig.FormattingEnabled = true;
            this.cmbxdesig.Items.AddRange(new object[] {
            "MD",
            "Business Development Manager",
            "Marketing Manager",
            "Sales and Marketing Executive",
            "Technical Manager",
            "Technician",
            "Administrator ",
            "Accounts"});
            this.cmbxdesig.Location = new System.Drawing.Point(149, 199);
            this.cmbxdesig.Name = "cmbxdesig";
            this.cmbxdesig.Size = new System.Drawing.Size(254, 21);
            this.cmbxdesig.TabIndex = 5;
            // 
            // cmbxurole
            // 
            this.cmbxurole.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxurole.FormattingEnabled = true;
            this.cmbxurole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbxurole.Location = new System.Drawing.Point(149, 235);
            this.cmbxurole.Name = "cmbxurole";
            this.cmbxurole.Size = new System.Drawing.Size(254, 21);
            this.cmbxurole.TabIndex = 6;
            // 
            // cmbxdept
            // 
            this.cmbxdept.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxdept.FormattingEnabled = true;
            this.cmbxdept.Location = new System.Drawing.Point(149, 102);
            this.cmbxdept.Name = "cmbxdept";
            this.cmbxdept.Size = new System.Drawing.Size(254, 21);
            this.cmbxdept.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Confirm Password :";
            // 
            // txtconpass
            // 
            this.txtconpass.BackColor = System.Drawing.SystemColors.Info;
            this.txtconpass.Location = new System.Drawing.Point(149, 338);
            this.txtconpass.Name = "txtconpass";
            this.txtconpass.Size = new System.Drawing.Size(254, 21);
            this.txtconpass.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "User role :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Password :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Designation :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "UserName :";
            // 
            // txtuname
            // 
            this.txtuname.BackColor = System.Drawing.SystemColors.Info;
            this.txtuname.Location = new System.Drawing.Point(149, 272);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(254, 21);
            this.txtuname.TabIndex = 7;
            this.txtuname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuname_KeyPress);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.Info;
            this.txtpass.Location = new System.Drawing.Point(149, 303);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(254, 21);
            this.txtpass.TabIndex = 8;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.Info;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(149, 33);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(254, 21);
            this.txtid.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 102);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Department :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 167);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(47, 13);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "Email :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 71);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(49, 13);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "Name :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 134);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(71, 13);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Mobile No :";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.SystemColors.Info;
            this.txtname.Location = new System.Drawing.Point(149, 71);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(254, 21);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // txtmobileno
            // 
            this.txtmobileno.BackColor = System.Drawing.SystemColors.Info;
            this.txtmobileno.Location = new System.Drawing.Point(149, 134);
            this.txtmobileno.Name = "txtmobileno";
            this.txtmobileno.Size = new System.Drawing.Size(254, 21);
            this.txtmobileno.TabIndex = 3;
            this.txtmobileno.TextChanged += new System.EventHandler(this.txtmobileno_TextChanged);
            this.txtmobileno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobileno_KeyPress);
            this.txtmobileno.Leave += new System.EventHandler(this.txtmobileno_Leave);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.Info;
            this.txtemail.Location = new System.Drawing.Point(149, 167);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(254, 21);
            this.txtemail.TabIndex = 4;
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(26, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.Button1);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnuserinfo);
            this.groupBox2.Controls.Add(this.Button2);
            this.groupBox2.Location = new System.Drawing.Point(9, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 67);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(106, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "Edit  ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(25, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "New  ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.Info;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.Location = new System.Drawing.Point(195, 23);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(91, 28);
            this.Button1.TabIndex = 13;
            this.Button1.Text = "&Save ";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(195, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 28);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnuserinfo
            // 
            this.btnuserinfo.BackColor = System.Drawing.SystemColors.Info;
            this.btnuserinfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnuserinfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnuserinfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuserinfo.Image = ((System.Drawing.Image)(resources.GetObject("btnuserinfo.Image")));
            this.btnuserinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuserinfo.Location = new System.Drawing.Point(292, 23);
            this.btnuserinfo.Name = "btnuserinfo";
            this.btnuserinfo.Size = new System.Drawing.Size(125, 27);
            this.btnuserinfo.TabIndex = 15;
            this.btnuserinfo.Text = "Load User Info";
            this.btnuserinfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnuserinfo.UseVisualStyleBackColor = false;
            this.btnuserinfo.Click += new System.EventHandler(this.btnuserinfo_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.Info;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(423, 23);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 27);
            this.Button2.TabIndex = 16;
            this.Button2.Text = "&Cancel";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // frmusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmusers";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.frmusers_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnuserinfo;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtid;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtname;
        internal System.Windows.Forms.TextBox txtmobileno;
        internal System.Windows.Forms.TextBox txtemail;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtuname;
        internal System.Windows.Forms.TextBox txtpass;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtconpass;
        internal System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button button3;
        public System.Windows.Forms.ComboBox cmbxdept;
        public System.Windows.Forms.ComboBox cmbxdesig;
        public System.Windows.Forms.ComboBox cmbxurole;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox cmbxstamp;
    }
}