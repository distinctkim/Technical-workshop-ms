namespace JobCardSystem.Forms
{
    partial class frmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            this.button5 = new System.Windows.Forms.Button();
            this.txtqid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpamnt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttaxrate = new System.Windows.Forms.TextBox();
            this.txtgamnt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txttxamnt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtqamnt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtclientemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxassignedtech = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxtechsum = new System.Windows.Forms.ComboBox();
            this.cmbxstatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrid = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtnotes = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txthwserial = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtsftitems = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txthditems = new System.Windows.Forms.TextBox();
            this.txtreportedproblem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtequipmentid = new System.Windows.Forms.TextBox();
            this.txtdiagnosisdone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtclientname = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtequipmentserial = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtequipmentname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbid = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbxrcid = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtbilldate = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txttopup = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(594, 406);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 21);
            this.button5.TabIndex = 201;
            this.button5.Text = "&Compute Balance";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtqid
            // 
            this.txtqid.BackColor = System.Drawing.SystemColors.Info;
            this.txtqid.Location = new System.Drawing.Point(130, 140);
            this.txtqid.Name = "txtqid";
            this.txtqid.ReadOnly = true;
            this.txtqid.Size = new System.Drawing.Size(135, 20);
            this.txtqid.TabIndex = 211;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label6.Location = new System.Drawing.Point(3, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 210;
            this.label6.Text = "BID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttopup);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.txtstatus);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txtbalance);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtpamnt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttaxrate);
            this.groupBox1.Controls.Add(this.txtgamnt);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txttxamnt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtqamnt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(478, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 343);
            this.groupBox1.TabIndex = 212;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Amount Summary ";
            // 
            // txtstatus
            // 
            this.txtstatus.BackColor = System.Drawing.SystemColors.Info;
            this.txtstatus.Location = new System.Drawing.Point(116, 287);
            this.txtstatus.Multiline = true;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ReadOnly = true;
            this.txtstatus.Size = new System.Drawing.Size(92, 20);
            this.txtstatus.TabIndex = 159;
            this.txtstatus.TextChanged += new System.EventHandler(this.txtstatus_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label26.Location = new System.Drawing.Point(6, 294);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 13);
            this.label26.TabIndex = 158;
            this.label26.Text = "Status :";
            // 
            // txtbalance
            // 
            this.txtbalance.BackColor = System.Drawing.SystemColors.Info;
            this.txtbalance.Location = new System.Drawing.Point(116, 247);
            this.txtbalance.Multiline = true;
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.ReadOnly = true;
            this.txtbalance.Size = new System.Drawing.Size(92, 20);
            this.txtbalance.TabIndex = 157;
            this.txtbalance.TextChanged += new System.EventHandler(this.txtbalance_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label13.Location = new System.Drawing.Point(6, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 156;
            this.label13.Text = "Balance :";
            // 
            // txtpamnt
            // 
            this.txtpamnt.BackColor = System.Drawing.SystemColors.Info;
            this.txtpamnt.Location = new System.Drawing.Point(116, 201);
            this.txtpamnt.Multiline = true;
            this.txtpamnt.Name = "txtpamnt";
            this.txtpamnt.Size = new System.Drawing.Size(92, 20);
            this.txtpamnt.TabIndex = 155;
            this.txtpamnt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label4.Location = new System.Drawing.Point(6, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 154;
            this.label4.Text = "Paid Amount :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label8.Location = new System.Drawing.Point(6, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 153;
            this.label8.Text = "Tax rate:";
            // 
            // txttaxrate
            // 
            this.txttaxrate.BackColor = System.Drawing.SystemColors.Info;
            this.txttaxrate.Location = new System.Drawing.Point(116, 75);
            this.txttaxrate.Multiline = true;
            this.txttaxrate.Name = "txttaxrate";
            this.txttaxrate.ReadOnly = true;
            this.txttaxrate.Size = new System.Drawing.Size(92, 20);
            this.txttaxrate.TabIndex = 147;
            // 
            // txtgamnt
            // 
            this.txtgamnt.BackColor = System.Drawing.SystemColors.Info;
            this.txtgamnt.Location = new System.Drawing.Point(116, 165);
            this.txtgamnt.Multiline = true;
            this.txtgamnt.Name = "txtgamnt";
            this.txtgamnt.ReadOnly = true;
            this.txtgamnt.Size = new System.Drawing.Size(92, 20);
            this.txtgamnt.TabIndex = 152;
            this.txtgamnt.TextChanged += new System.EventHandler(this.txtgamnt_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label24.Location = new System.Drawing.Point(6, 172);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 13);
            this.label24.TabIndex = 151;
            this.label24.Text = "Gross Amount :";
            // 
            // txttxamnt
            // 
            this.txttxamnt.BackColor = System.Drawing.SystemColors.Info;
            this.txttxamnt.Location = new System.Drawing.Point(116, 119);
            this.txttxamnt.Multiline = true;
            this.txttxamnt.Name = "txttxamnt";
            this.txttxamnt.ReadOnly = true;
            this.txttxamnt.Size = new System.Drawing.Size(92, 20);
            this.txttxamnt.TabIndex = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label9.Location = new System.Drawing.Point(6, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 149;
            this.label9.Text = "Tax Amount :";
            // 
            // txtqamnt
            // 
            this.txtqamnt.BackColor = System.Drawing.SystemColors.Info;
            this.txtqamnt.Location = new System.Drawing.Point(116, 29);
            this.txtqamnt.Multiline = true;
            this.txtqamnt.Name = "txtqamnt";
            this.txtqamnt.Size = new System.Drawing.Size(92, 20);
            this.txtqamnt.TabIndex = 146;
            this.txtqamnt.TextChanged += new System.EventHandler(this.txtqamnt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label12.Location = new System.Drawing.Point(6, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 148;
            this.label12.Text = "Quote Amount :";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(255, 677);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(78, 29);
            this.btnupdate.TabIndex = 216;
            this.btnupdate.Text = "Update";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Info;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(190, 695);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 28);
            this.button6.TabIndex = 214;
            this.button6.Text = "Edit  ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Info;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(123, 695);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 28);
            this.button8.TabIndex = 213;
            this.button8.Text = "New  ";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Info;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(339, 695);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(66, 29);
            this.button10.TabIndex = 217;
            this.button10.Text = "Delete";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Info;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(411, 695);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(99, 29);
            this.button11.TabIndex = 218;
            this.button11.Text = "LoadBillInfo";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Info;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(516, 695);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 29);
            this.button12.TabIndex = 219;
            this.button12.Text = "&Cancel";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.Info;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(255, 695);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(78, 29);
            this.button13.TabIndex = 215;
            this.button13.Text = "&Save ";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Maroon;
            this.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(10, 3);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(42, 34);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 4;
            this.PictureBox2.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Controls.Add(this.label15);
            this.Panel1.Location = new System.Drawing.Point(1, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1116, 43);
            this.Panel1.TabIndex = 220;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(69, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "Bill Management";
            // 
            // txtclientemail
            // 
            this.txtclientemail.BackColor = System.Drawing.SystemColors.Info;
            this.txtclientemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclientemail.Location = new System.Drawing.Point(130, 310);
            this.txtclientemail.Name = "txtclientemail";
            this.txtclientemail.ReadOnly = true;
            this.txtclientemail.Size = new System.Drawing.Size(328, 20);
            this.txtclientemail.TabIndex = 228;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label7.Location = new System.Drawing.Point(3, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 256;
            this.label7.Text = "Client Email :";
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.SystemColors.Info;
            this.txtdate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdate.Location = new System.Drawing.Point(275, 112);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(141, 20);
            this.txtdate.TabIndex = 255;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(271, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 254;
            this.label1.Text = "ConfirmationDate :";
            // 
            // cmbxassignedtech
            // 
            this.cmbxassignedtech.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxassignedtech.FormattingEnabled = true;
            this.cmbxassignedtech.Location = new System.Drawing.Point(130, 579);
            this.cmbxassignedtech.Name = "cmbxassignedtech";
            this.cmbxassignedtech.Size = new System.Drawing.Size(326, 21);
            this.cmbxassignedtech.TabIndex = 235;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label5.Location = new System.Drawing.Point(0, 584);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 253;
            this.label5.Text = "Assigned Technician :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(3, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 252;
            this.label2.Text = "Notes:";
            // 
            // cmbxtechsum
            // 
            this.cmbxtechsum.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxtechsum.FormattingEnabled = true;
            this.cmbxtechsum.Items.AddRange(new object[] {
            "Tested and working well",
            "Tested,working well but requires monitoring ",
            "Tested,not working as expected requires monitoring"});
            this.cmbxtechsum.Location = new System.Drawing.Point(131, 611);
            this.cmbxtechsum.Name = "cmbxtechsum";
            this.cmbxtechsum.Size = new System.Drawing.Size(326, 21);
            this.cmbxtechsum.TabIndex = 236;
            // 
            // cmbxstatus
            // 
            this.cmbxstatus.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxstatus.FormattingEnabled = true;
            this.cmbxstatus.Location = new System.Drawing.Point(130, 550);
            this.cmbxstatus.Name = "cmbxstatus";
            this.cmbxstatus.Size = new System.Drawing.Size(326, 21);
            this.cmbxstatus.TabIndex = 234;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 251;
            this.label3.Text = "Requirement ID :";
            // 
            // txtrid
            // 
            this.txtrid.BackColor = System.Drawing.SystemColors.Info;
            this.txtrid.Enabled = false;
            this.txtrid.Location = new System.Drawing.Point(129, 169);
            this.txtrid.Name = "txtrid";
            this.txtrid.ReadOnly = true;
            this.txtrid.Size = new System.Drawing.Size(329, 20);
            this.txtrid.TabIndex = 223;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label25.Location = new System.Drawing.Point(1, 614);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(131, 13);
            this.label25.TabIndex = 250;
            this.label25.Text = "Technician Summary:";
            // 
            // txtnotes
            // 
            this.txtnotes.BackColor = System.Drawing.SystemColors.Info;
            this.txtnotes.Location = new System.Drawing.Point(131, 642);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.Size = new System.Drawing.Size(326, 39);
            this.txtnotes.TabIndex = 237;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label23.Location = new System.Drawing.Point(3, 555);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 13);
            this.label23.TabIndex = 249;
            this.label23.Text = "Progress Status:";
            // 
            // txthwserial
            // 
            this.txthwserial.BackColor = System.Drawing.SystemColors.Info;
            this.txthwserial.Location = new System.Drawing.Point(130, 523);
            this.txthwserial.Multiline = true;
            this.txthwserial.Name = "txthwserial";
            this.txthwserial.Size = new System.Drawing.Size(326, 20);
            this.txthwserial.TabIndex = 233;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label22.Location = new System.Drawing.Point(4, 529);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 13);
            this.label22.TabIndex = 248;
            this.label22.Text = "H/w Serial No:";
            // 
            // txtsftitems
            // 
            this.txtsftitems.BackColor = System.Drawing.SystemColors.Info;
            this.txtsftitems.Location = new System.Drawing.Point(130, 474);
            this.txtsftitems.Multiline = true;
            this.txtsftitems.Name = "txtsftitems";
            this.txtsftitems.ReadOnly = true;
            this.txtsftitems.Size = new System.Drawing.Size(326, 43);
            this.txtsftitems.TabIndex = 232;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label21.Location = new System.Drawing.Point(2, 477);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 13);
            this.label21.TabIndex = 247;
            this.label21.Text = "Software Items :";
            // 
            // txthditems
            // 
            this.txthditems.BackColor = System.Drawing.SystemColors.Info;
            this.txthditems.Location = new System.Drawing.Point(130, 423);
            this.txthditems.Multiline = true;
            this.txthditems.Name = "txthditems";
            this.txthditems.ReadOnly = true;
            this.txthditems.Size = new System.Drawing.Size(326, 43);
            this.txthditems.TabIndex = 231;
            // 
            // txtreportedproblem
            // 
            this.txtreportedproblem.BackColor = System.Drawing.SystemColors.Info;
            this.txtreportedproblem.Location = new System.Drawing.Point(131, 336);
            this.txtreportedproblem.Multiline = true;
            this.txtreportedproblem.Name = "txtreportedproblem";
            this.txtreportedproblem.ReadOnly = true;
            this.txtreportedproblem.Size = new System.Drawing.Size(326, 40);
            this.txtreportedproblem.TabIndex = 229;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label10.Location = new System.Drawing.Point(3, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 246;
            this.label10.Text = "Reported Problem :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 245;
            this.label11.Text = "Equipment ID :";
            // 
            // txtequipmentid
            // 
            this.txtequipmentid.BackColor = System.Drawing.SystemColors.Info;
            this.txtequipmentid.Enabled = false;
            this.txtequipmentid.Location = new System.Drawing.Point(129, 196);
            this.txtequipmentid.Name = "txtequipmentid";
            this.txtequipmentid.ReadOnly = true;
            this.txtequipmentid.Size = new System.Drawing.Size(329, 20);
            this.txtequipmentid.TabIndex = 224;
            // 
            // txtdiagnosisdone
            // 
            this.txtdiagnosisdone.BackColor = System.Drawing.SystemColors.Info;
            this.txtdiagnosisdone.Location = new System.Drawing.Point(131, 382);
            this.txtdiagnosisdone.Multiline = true;
            this.txtdiagnosisdone.Name = "txtdiagnosisdone";
            this.txtdiagnosisdone.Size = new System.Drawing.Size(327, 35);
            this.txtdiagnosisdone.TabIndex = 230;
            this.txtdiagnosisdone.TextChanged += new System.EventHandler(this.txtdiagnosisdone_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label16.Location = new System.Drawing.Point(3, 387);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 13);
            this.label16.TabIndex = 244;
            this.label16.Text = "Diagnosis Done :";
            // 
            // txtclientname
            // 
            this.txtclientname.BackColor = System.Drawing.SystemColors.Info;
            this.txtclientname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclientname.Location = new System.Drawing.Point(129, 283);
            this.txtclientname.Name = "txtclientname";
            this.txtclientname.ReadOnly = true;
            this.txtclientname.Size = new System.Drawing.Size(329, 20);
            this.txtclientname.TabIndex = 227;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label17.Location = new System.Drawing.Point(2, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 243;
            this.label17.Text = "Client Name :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(2, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 13);
            this.label18.TabIndex = 242;
            this.label18.Text = "Equipment Serial :";
            // 
            // txtequipmentserial
            // 
            this.txtequipmentserial.BackColor = System.Drawing.SystemColors.Info;
            this.txtequipmentserial.Location = new System.Drawing.Point(129, 254);
            this.txtequipmentserial.Name = "txtequipmentserial";
            this.txtequipmentserial.ReadOnly = true;
            this.txtequipmentserial.Size = new System.Drawing.Size(329, 20);
            this.txtequipmentserial.TabIndex = 226;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(2, 232);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 13);
            this.label19.TabIndex = 241;
            this.label19.Text = "Equipment Name :";
            // 
            // txtequipmentname
            // 
            this.txtequipmentname.BackColor = System.Drawing.SystemColors.Info;
            this.txtequipmentname.Location = new System.Drawing.Point(129, 225);
            this.txtequipmentname.Name = "txtequipmentname";
            this.txtequipmentname.ReadOnly = true;
            this.txtequipmentname.Size = new System.Drawing.Size(329, 20);
            this.txtequipmentname.TabIndex = 225;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 240;
            this.label14.Text = "ConfirmID :";
            // 
            // txtbid
            // 
            this.txtbid.BackColor = System.Drawing.SystemColors.Info;
            this.txtbid.Location = new System.Drawing.Point(130, 51);
            this.txtbid.Name = "txtbid";
            this.txtbid.ReadOnly = true;
            this.txtbid.Size = new System.Drawing.Size(75, 20);
            this.txtbid.TabIndex = 221;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label20.Location = new System.Drawing.Point(3, 429);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 13);
            this.label20.TabIndex = 239;
            this.label20.Text = "Hardware Items :";
            // 
            // cmbxrcid
            // 
            this.cmbxrcid.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxrcid.FormattingEnabled = true;
            this.cmbxrcid.Location = new System.Drawing.Point(131, 81);
            this.cmbxrcid.Name = "cmbxrcid";
            this.cmbxrcid.Size = new System.Drawing.Size(134, 21);
            this.cmbxrcid.TabIndex = 222;
            this.cmbxrcid.SelectedIndexChanged += new System.EventHandler(this.cmbxrcid_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label27.Location = new System.Drawing.Point(2, 150);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(51, 13);
            this.label27.TabIndex = 238;
            this.label27.Text = "INV ID:";
            // 
            // txtbilldate
            // 
            this.txtbilldate.BackColor = System.Drawing.SystemColors.Info;
            this.txtbilldate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbilldate.Location = new System.Drawing.Point(130, 112);
            this.txtbilldate.Name = "txtbilldate";
            this.txtbilldate.Size = new System.Drawing.Size(135, 20);
            this.txtbilldate.TabIndex = 258;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label28.Location = new System.Drawing.Point(3, 115);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 13);
            this.label28.TabIndex = 257;
            this.label28.Text = "Bill Date :";
            // 
            // txttopup
            // 
            this.txttopup.BackColor = System.Drawing.SystemColors.Info;
            this.txttopup.Location = new System.Drawing.Point(226, 201);
            this.txttopup.Multiline = true;
            this.txttopup.Name = "txttopup";
            this.txttopup.Size = new System.Drawing.Size(92, 20);
            this.txttopup.TabIndex = 161;
            this.txttopup.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label29.Location = new System.Drawing.Point(223, 185);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(103, 13);
            this.label29.TabIndex = 160;
            this.label29.Text = "Top-up Amount :";
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 738);
            this.Controls.Add(this.txtbilldate);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtclientemail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxassignedtech);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxtechsum);
            this.Controls.Add(this.cmbxstatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtrid);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txthwserial);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtsftitems);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txthditems);
            this.Controls.Add(this.txtreportedproblem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtequipmentid);
            this.Controls.Add(this.txtdiagnosisdone);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtclientname);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtequipmentserial);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtequipmentname);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtbid);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cmbxrcid);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtqid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Name = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.TextBox txtqid;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtstatus;
        internal System.Windows.Forms.Label label26;
        internal System.Windows.Forms.TextBox txtbalance;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox txtpamnt;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txttaxrate;
        internal System.Windows.Forms.TextBox txtgamnt;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.TextBox txttxamnt;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtqamnt;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.Button button6;
        internal System.Windows.Forms.Button button8;
        internal System.Windows.Forms.Button button10;
        internal System.Windows.Forms.Button button11;
        internal System.Windows.Forms.Button button12;
        internal System.Windows.Forms.Button button13;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txtclientemail;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtdate;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbxassignedtech;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbxtechsum;
        public System.Windows.Forms.ComboBox cmbxstatus;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtrid;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.TextBox txtnotes;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.TextBox txthwserial;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.TextBox txtsftitems;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.TextBox txthditems;
        internal System.Windows.Forms.TextBox txtreportedproblem;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtequipmentid;
        internal System.Windows.Forms.TextBox txtdiagnosisdone;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox txtclientname;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.TextBox txtequipmentserial;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.TextBox txtequipmentname;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtbid;
        internal System.Windows.Forms.Label label20;
        public System.Windows.Forms.ComboBox cmbxrcid;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.TextBox txtbilldate;
        internal System.Windows.Forms.Label label28;
        internal System.Windows.Forms.TextBox txttopup;
        internal System.Windows.Forms.Label label29;
    }
}