namespace JobCardSystem.Forms
{
    partial class frmequipfaults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmequipfaults));
            this.Label16 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbxsolutiondesign = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcreatedate = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtfaultdesc = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.GroupBox1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(8, 162);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(86, 13);
            this.Label16.TabIndex = 30;
            this.Label16.Text = "Create Date :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 80);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(106, 13);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Fault Description:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 37);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(26, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "ID:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.button7);
            this.GroupBox1.Controls.Add(this.btnAdd);
            this.GroupBox1.Controls.Add(this.button3);
            this.GroupBox1.Controls.Add(this.cmbxsolutiondesign);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.Label16);
            this.GroupBox1.Controls.Add(this.txtcreatedate);
            this.GroupBox1.Controls.Add(this.btndelete);
            this.GroupBox1.Controls.Add(this.button4);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.Controls.Add(this.txtid);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtfaultdesc);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(2, 58);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(662, 259);
            this.GroupBox1.TabIndex = 32;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Create New Fault";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Info;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(174, 211);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 29);
            this.button7.TabIndex = 5;
            this.button7.Text = "Edit  ";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(97, 211);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "New  ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(252, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Update";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbxsolutiondesign
            // 
            this.cmbxsolutiondesign.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxsolutiondesign.FormattingEnabled = true;
            this.cmbxsolutiondesign.Items.AddRange(new object[] {
            "Check motherboard",
            "Check ram",
            "Check CMOS Battery",
            "Check Power supply unit",
            "Check HDD",
            "Check DVD-Drive",
            "Check usb Ports-Enable via command prompt",
            "Check resolution settings",
            "Update software",
            "Install antivirus and Scan",
            "Install Operating system",
            "Use command prompt-chkdsk driveletter: /F to scan and repair damaged partition",
            "Check brightness settings",
            "Replace display screen",
            "",
            ""});
            this.cmbxsolutiondesign.Location = new System.Drawing.Point(140, 120);
            this.cmbxsolutiondesign.Name = "cmbxsolutiondesign";
            this.cmbxsolutiondesign.Size = new System.Drawing.Size(352, 21);
            this.cmbxsolutiondesign.TabIndex = 2;
            this.cmbxsolutiondesign.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbxsolutiondesign_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Solution Start from:";
            // 
            // txtcreatedate
            // 
            this.txtcreatedate.BackColor = System.Drawing.SystemColors.Info;
            this.txtcreatedate.Enabled = false;
            this.txtcreatedate.Location = new System.Drawing.Point(140, 159);
            this.txtcreatedate.Name = "txtcreatedate";
            this.txtcreatedate.Size = new System.Drawing.Size(354, 21);
            this.txtcreatedate.TabIndex = 3;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.Info;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(456, 211);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(78, 29);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(337, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "Load Fault Info";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.Info;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(540, 211);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 29);
            this.Button2.TabIndex = 10;
            this.Button2.Text = "&Cancel";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.Info;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.Location = new System.Drawing.Point(253, 213);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(78, 27);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "&Save ";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.Info;
            this.txtid.Location = new System.Drawing.Point(140, 29);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(214, 21);
            this.txtid.TabIndex = 0;
            // 
            // txtfaultdesc
            // 
            this.txtfaultdesc.BackColor = System.Drawing.SystemColors.Info;
            this.txtfaultdesc.Location = new System.Drawing.Point(140, 64);
            this.txtfaultdesc.Multiline = true;
            this.txtfaultdesc.Name = "txtfaultdesc";
            this.txtfaultdesc.Size = new System.Drawing.Size(352, 39);
            this.txtfaultdesc.TabIndex = 1;
            this.txtfaultdesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfaultdesc_KeyPress);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(69, 18);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(135, 23);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Fault Setup";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Location = new System.Drawing.Point(2, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(662, 51);
            this.Panel1.TabIndex = 33;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(3, 3);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(42, 42);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 4;
            this.PictureBox2.TabStop = false;
            // 
            // frmequipfaults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 321);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmequipfaults";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.frmequipfaults_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtcreatedate;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtid;
        internal System.Windows.Forms.TextBox txtfaultdesc;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ComboBox cmbxsolutiondesign;
        internal System.Windows.Forms.Button button7;
    }
}