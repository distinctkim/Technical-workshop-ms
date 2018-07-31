using System;

namespace JobCardSystem.Forms
{
    partial class frmUserManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtServerHost = new System.Windows.Forms.TextBox();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbxdept = new System.Windows.Forms.ComboBox();
            this.cmbxuserrole = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtServerHost);
            this.panel1.Controls.Add(this.txtconfirmpassword);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbxdept);
            this.panel1.Controls.Add(this.cmbxuserrole);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.txtdesignation);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtmobile);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kryptonLabel1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 445);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtServerHost
            // 
            this.txtServerHost.BackColor = System.Drawing.SystemColors.Info;
            this.txtServerHost.Location = new System.Drawing.Point(376, 235);
            this.txtServerHost.Name = "txtServerHost";
            this.txtServerHost.Size = new System.Drawing.Size(214, 31);
            this.txtServerHost.TabIndex = 28;
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmpassword.Location = new System.Drawing.Point(376, 179);
            this.txtconfirmpassword.Multiline = true;
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(281, 28);
            this.txtconfirmpassword.TabIndex = 26;
            this.txtconfirmpassword.TextChanged += new System.EventHandler(this.txtconfirmpassword_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(372, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Confirm Password";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(376, 65);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(281, 28);
            this.txtusername.TabIndex = 24;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            this.txtusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusername_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(372, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "UserName";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(376, 122);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(281, 28);
            this.txtpassword.TabIndex = 22;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(372, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Password";
            // 
            // cmbxdept
            // 
            this.cmbxdept.FormattingEnabled = true;
            this.cmbxdept.Location = new System.Drawing.Point(52, 122);
            this.cmbxdept.Name = "cmbxdept";
            this.cmbxdept.Size = new System.Drawing.Size(281, 30);
            this.cmbxdept.TabIndex = 20;
            // 
            // cmbxuserrole
            // 
            this.cmbxuserrole.FormattingEnabled = true;
            this.cmbxuserrole.Location = new System.Drawing.Point(52, 357);
            this.cmbxuserrole.Name = "cmbxuserrole";
            this.cmbxuserrole.Size = new System.Drawing.Size(281, 30);
            this.cmbxuserrole.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(48, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "UserRole";
            // 
            // txtdesignation
            // 
            this.txtdesignation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesignation.Location = new System.Drawing.Point(52, 296);
            this.txtdesignation.Multiline = true;
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(281, 28);
            this.txtdesignation.TabIndex = 11;
            this.txtdesignation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdesignation_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(52, 238);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(281, 28);
            this.txtemail.TabIndex = 10;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            this.txtemail.Validating += new System.ComponentModel.CancelEventHandler(this.txtemail_Validating);
            // 
            // txtmobile
            // 
            this.txtmobile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobile.Location = new System.Drawing.Point(52, 179);
            this.txtmobile.Multiline = true;
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(281, 28);
            this.txtmobile.TabIndex = 9;
            this.txtmobile.TextChanged += new System.EventHandler(this.txtmobile_TextChanged);
            this.txtmobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobile_KeyPress);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(52, 65);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(281, 28);
            this.txtname.TabIndex = 8;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(278, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.kryptonLabel1.Size = new System.Drawing.Size(187, 29);
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.ExtraText = "AJCS";
            this.kryptonLabel1.Values.Text = "MANAGEUSERS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(48, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Designation";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(48, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(48, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mobile";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(48, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightBlue;
            this.btnexit.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.btnexit.Image = global::JobCardSystem.Properties.Resources.Exit;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(610, 406);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(116, 33);
            this.btnexit.TabIndex = 16;
            this.btnexit.Text = "         EXI&T";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button4_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LightBlue;
            this.btndelete.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.btndelete.Image = global::JobCardSystem.Properties.Resources.Delete;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(477, 406);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(116, 33);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "              DEL&ETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LightBlue;
            this.btnupdate.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.btnupdate.Image = global::JobCardSystem.Properties.Resources.Update1;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(227, 406);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(116, 33);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "           UP&DATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LightBlue;
            this.btnsave.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.btnsave.Image = global::JobCardSystem.Properties.Resources.Save_1;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(349, 406);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(116, 33);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "     SA&VE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            //this.pictureBox1.Image = global::JobCardSystem.Properties.Resources.Personal;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(787, 473);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.frmUserManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void txtconfirmpassword_TextChanged (object sender, EventArgs e)
        {
            throw new NotImplementedException ();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ComboBox cmbxdept;
        private System.Windows.Forms.ComboBox cmbxuserrole;
        private System.Windows.Forms.Label label6;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtServerHost;
    }
}