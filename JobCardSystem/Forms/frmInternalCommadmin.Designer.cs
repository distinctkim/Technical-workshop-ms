﻿namespace JobCardSystem.Forms
{
    partial class frmInternalCommadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInternalCommadmin));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblattachment = new System.Windows.Forms.LinkLabel();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.kdvequipreq = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdvequipreq)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPassword.Location = new System.Drawing.Point(136, 251);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(275, 21);
            this.txtPassword.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 54;
            this.label7.Text = "Gmail Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(136, 212);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 21);
            this.txtEmail.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 52;
            this.label6.Text = "Gmail Email:";
            // 
            // lblattachment
            // 
            this.lblattachment.AutoSize = true;
            this.lblattachment.Location = new System.Drawing.Point(137, 188);
            this.lblattachment.Name = "lblattachment";
            this.lblattachment.Size = new System.Drawing.Size(56, 15);
            this.lblattachment.TabIndex = 3;
            this.lblattachment.TabStop = true;
            this.lblattachment.Text = "Select File";
            this.lblattachment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblattachment_LinkClicked);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.Info;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(284, 279);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 28);
            this.Button2.TabIndex = 6;
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
            this.Button1.Location = new System.Drawing.Point(136, 279);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(118, 28);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "&Send Message ";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtsubject
            // 
            this.txtsubject.BackColor = System.Drawing.SystemColors.Info;
            this.txtsubject.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsubject.Location = new System.Drawing.Point(136, 71);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(275, 21);
            this.txtsubject.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "Subject :";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Info;
            this.textBox7.Location = new System.Drawing.Point(574, 88);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(225, 20);
            this.textBox7.TabIndex = 91;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(453, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 90;
            this.label15.Text = "Search By Status:";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(443, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(551, 30);
            this.label17.TabIndex = 89;
            this.label17.Text = "Customer Contact";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Location = new System.Drawing.Point(-2, -1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(996, 50);
            this.Panel1.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee  Communication";
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.SystemColors.Info;
            this.txtTo.FormattingEnabled = true;
            this.txtTo.Location = new System.Drawing.Point(136, 29);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(275, 23);
            this.txtTo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Attach File  :";
            // 
            // txtBody
            // 
            this.txtBody.BackColor = System.Drawing.SystemColors.Info;
            this.txtBody.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBody.Location = new System.Drawing.Point(136, 109);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(275, 62);
            this.txtBody.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 117);
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
            // kdvequipreq
            // 
            this.kdvequipreq.AllowUserToAddRows = false;
            this.kdvequipreq.AllowUserToDeleteRows = false;
            this.kdvequipreq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdvequipreq.Location = new System.Drawing.Point(444, 111);
            this.kdvequipreq.Name = "kdvequipreq";
            this.kdvequipreq.ReadOnly = true;
            this.kdvequipreq.Size = new System.Drawing.Size(543, 258);
            this.kdvequipreq.TabIndex = 88;
            this.kdvequipreq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kdvequipreq_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblattachment);
            this.groupBox2.Controls.Add(this.Button2);
            this.groupBox2.Controls.Add(this.Button1);
            this.groupBox2.Controls.Add(this.txtsubject);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBody);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Label9);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(-2, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 314);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Internal Communication";
            // 
            // frmInternalCommadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 381);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.kdvequipreq);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInternalCommadmin";
            this.Load += new System.EventHandler(this.frmInternalCommadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdvequipreq)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lblattachment;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtsubject;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox textBox7;
        internal System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtTo;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtBody;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label Label9;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdvequipreq;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}