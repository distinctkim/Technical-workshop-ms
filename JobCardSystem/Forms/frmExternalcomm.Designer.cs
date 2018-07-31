namespace JobCardSystem.Forms
{
    partial class frmExternalcomm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExternalcomm));
            this.label2 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.kdvcustomer = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblattachment = new System.Windows.Forms.LinkLabel();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdvcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clients Communication";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Location = new System.Drawing.Point(0, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1014, 58);
            this.Panel1.TabIndex = 4;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Maroon;
            this.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(17, 6);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(42, 42);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 3;
            this.PictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.kdvcustomer);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSubject);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblattachment);
            this.groupBox2.Controls.Add(this.Button2);
            this.groupBox2.Controls.Add(this.Button1);
            this.groupBox2.Controls.Add(this.txtTo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBody);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Label9);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1003, 395);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "External Communication";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Info;
            this.textBox7.Location = new System.Drawing.Point(577, 50);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(225, 21);
            this.textBox7.TabIndex = 81;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(456, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 80;
            this.label15.Text = "Search By Status:";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(454, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(543, 30);
            this.label17.TabIndex = 79;
            this.label17.Text = "Customer Contact";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kdvcustomer
            // 
            this.kdvcustomer.AllowUserToAddRows = false;
            this.kdvcustomer.AllowUserToDeleteRows = false;
            this.kdvcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdvcustomer.Location = new System.Drawing.Point(454, 73);
            this.kdvcustomer.Name = "kdvcustomer";
            this.kdvcustomer.ReadOnly = true;
            this.kdvcustomer.Size = new System.Drawing.Size(543, 312);
            this.kdvcustomer.TabIndex = 78;
            this.kdvcustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kdvcustomer_CellContentClick);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPassword.Location = new System.Drawing.Point(136, 290);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(275, 21);
            this.txtPassword.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 50;
            this.label7.Text = "Gmail Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(136, 251);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 21);
            this.txtEmail.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "Gmail Email:";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.SystemColors.Info;
            this.txtSubject.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSubject.Location = new System.Drawing.Point(136, 73);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(275, 21);
            this.txtSubject.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Subject :";
            // 
            // lblattachment
            // 
            this.lblattachment.AutoSize = true;
            this.lblattachment.Location = new System.Drawing.Point(133, 227);
            this.lblattachment.Name = "lblattachment";
            this.lblattachment.Size = new System.Drawing.Size(56, 15);
            this.lblattachment.TabIndex = 3;
            this.lblattachment.TabStop = true;
            this.lblattachment.Text = "Select File";
            this.lblattachment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.Info;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(285, 334);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 28);
            this.Button2.TabIndex = 7;
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
            this.Button1.Location = new System.Drawing.Point(137, 334);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(118, 28);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "&Send Message ";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.SystemColors.Info;
            this.txtTo.FormattingEnabled = true;
            this.txtTo.Location = new System.Drawing.Point(136, 29);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(275, 23);
            this.txtTo.TabIndex = 0;
            this.txtTo.SelectedIndexChanged += new System.EventHandler(this.cmbxto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Attach File  :";
            // 
            // txtBody
            // 
            this.txtBody.BackColor = System.Drawing.SystemColors.Info;
            this.txtBody.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtBody.Location = new System.Drawing.Point(136, 111);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(275, 99);
            this.txtBody.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Message :";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(3, 37);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(26, 15);
            this.Label9.TabIndex = 24;
            this.Label9.Text = "To :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frmExternalcomm
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button2;
            this.ClientSize = new System.Drawing.Size(1014, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExternalcomm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.frmExternalcomm_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdvcustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtBody;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label Label9;
        private System.Windows.Forms.LinkLabel lblattachment;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        public System.Windows.Forms.ComboBox txtTo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.TextBox txtSubject;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdvcustomer;
        internal System.Windows.Forms.TextBox textBox7;
        internal System.Windows.Forms.Label label15;
    }
}