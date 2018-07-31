namespace JobCardSystem.Forms
{
    partial class frmsetuptarrifs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsetuptarrifs));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbxdept = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.GroupBox1.SuspendLayout();
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
            this.Panel1.Size = new System.Drawing.Size(527, 56);
            this.Panel1.TabIndex = 28;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Maroon;
            this.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(10, 3);
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
            this.Label6.Location = new System.Drawing.Point(69, 18);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 23);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Tarrifs";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.txtStid);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.button7);
            this.GroupBox1.Controls.Add(this.btnAdd);
            this.GroupBox1.Controls.Add(this.cmbxdept);
            this.GroupBox1.Controls.Add(this.btnUpdate);
            this.GroupBox1.Controls.Add(this.button4);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.Controls.Add(this.txtid);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtdesc);
            this.GroupBox1.Controls.Add(this.txtprice);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(11, 80);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(506, 263);
            this.GroupBox1.TabIndex = 27;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Create New Tarrif";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // txtStid
            // 
            this.txtStid.BackColor = System.Drawing.SystemColors.Info;
            this.txtStid.Location = new System.Drawing.Point(140, 65);
            this.txtStid.Name = "txtStid";
            this.txtStid.Size = new System.Drawing.Size(56, 21);
            this.txtStid.TabIndex = 1;
            this.txtStid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStid_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "ItemRef:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Info;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(87, 227);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 29);
            this.button7.TabIndex = 6;
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
            this.btnAdd.Location = new System.Drawing.Point(6, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "New  ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbxdept
            // 
            this.cmbxdept.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxdept.FormattingEnabled = true;
            this.cmbxdept.Items.AddRange(new object[] {
            "Labour ",
            "Software Installation",
            "Software Upgrade",
            "Hardware repair",
            "Hardware Item replacement"});
            this.cmbxdept.Location = new System.Drawing.Point(140, 103);
            this.cmbxdept.Name = "cmbxdept";
            this.cmbxdept.Size = new System.Drawing.Size(214, 21);
            this.cmbxdept.TabIndex = 2;
            this.cmbxdept.SelectedIndexChanged += new System.EventHandler(this.cmbxdept_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(158, 227);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 29);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(255, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 29);
            this.button4.TabIndex = 9;
            this.button4.Text = "Load Tariff Info";
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
            this.Button2.Location = new System.Drawing.Point(386, 227);
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
            this.Button1.Location = new System.Drawing.Point(158, 227);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(91, 29);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "&Save ";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.Info;
            this.txtid.Location = new System.Drawing.Point(140, 33);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(56, 21);
            this.txtid.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 106);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Service Name :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(11, 190);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(70, 13);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "Unit Price :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 149);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 13);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Description :";
            // 
            // txtdesc
            // 
            this.txtdesc.BackColor = System.Drawing.SystemColors.Info;
            this.txtdesc.Location = new System.Drawing.Point(140, 130);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(214, 46);
            this.txtdesc.TabIndex = 3;
            this.txtdesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdesc_KeyPress);
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.SystemColors.Info;
            this.txtprice.Location = new System.Drawing.Point(140, 182);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(214, 21);
            this.txtprice.TabIndex = 4;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
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
            // frmsetuptarrifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 352);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmsetuptarrifs";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.frmDatabase_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtid;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtdesc;
        internal System.Windows.Forms.TextBox txtprice;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.ComboBox cmbxdept;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button button7;
        internal System.Windows.Forms.TextBox txtStid;
        internal System.Windows.Forms.Label label5;
    }
}