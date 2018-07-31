namespace JobCardSystem.Forms
{
    partial class frmquote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmquote));
            this.label7 = new System.Windows.Forms.Label();
            this.kdvtarrif = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcathd = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtqid = new System.Windows.Forms.TextBox();
            this.txtreportedproblem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtequipmentid = new System.Windows.Forms.TextBox();
            this.txtdiagnosisdone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtclientname = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtequipmentserial = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtequipmentname = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtcatsft = new System.Windows.Forms.TextBox();
            this.txthditems = new System.Windows.Forms.TextBox();
            this.txtsftitems = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtqamnt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txttxamnt = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtgamnt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txttaxrate = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtclientemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kdvtarrif)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(415, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(674, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Invoice Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kdvtarrif
            // 
            this.kdvtarrif.AllowUserToAddRows = false;
            this.kdvtarrif.AllowUserToDeleteRows = false;
            this.kdvtarrif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kdvtarrif.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.kdvtarrif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdvtarrif.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.kdvtarrif.Location = new System.Drawing.Point(415, 176);
            this.kdvtarrif.Name = "kdvtarrif";
            this.kdvtarrif.ReadOnly = true;
            this.kdvtarrif.Size = new System.Drawing.Size(674, 165);
            this.kdvtarrif.TabIndex = 13;
            this.kdvtarrif.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kdvtarrif_CellContentClick);
            this.kdvtarrif.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.kdvtarrif_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ServiceName";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label14.Location = new System.Drawing.Point(6, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Requirements ID:";
            // 
            // txtcathd
            // 
            this.txtcathd.BackColor = System.Drawing.SystemColors.Info;
            this.txtcathd.Location = new System.Drawing.Point(133, 323);
            this.txtcathd.Name = "txtcathd";
            this.txtcathd.ReadOnly = true;
            this.txtcathd.Size = new System.Drawing.Size(223, 20);
            this.txtcathd.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(67, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(237, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "Invoice Management";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Controls.Add(this.label15);
            this.Panel1.Location = new System.Drawing.Point(0, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1116, 48);
            this.Panel1.TabIndex = 70;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label10.Location = new System.Drawing.Point(6, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 106;
            this.label10.Text = "Hardware Items :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label5.Location = new System.Drawing.Point(5, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 103;
            this.label5.Text = "Category 1:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 114;
            this.label11.Text = "Inv ID :";
            // 
            // txtqid
            // 
            this.txtqid.BackColor = System.Drawing.SystemColors.Info;
            this.txtqid.Location = new System.Drawing.Point(133, 65);
            this.txtqid.Name = "txtqid";
            this.txtqid.ReadOnly = true;
            this.txtqid.Size = new System.Drawing.Size(75, 20);
            this.txtqid.TabIndex = 113;
            this.txtqid.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // txtreportedproblem
            // 
            this.txtreportedproblem.BackColor = System.Drawing.SystemColors.Info;
            this.txtreportedproblem.Location = new System.Drawing.Point(133, 269);
            this.txtreportedproblem.Name = "txtreportedproblem";
            this.txtreportedproblem.ReadOnly = true;
            this.txtreportedproblem.Size = new System.Drawing.Size(223, 20);
            this.txtreportedproblem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(6, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 126;
            this.label1.Text = "Reported Problem :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 124;
            this.label3.Text = "Equipment ID :";
            // 
            // txtequipmentid
            // 
            this.txtequipmentid.BackColor = System.Drawing.SystemColors.Info;
            this.txtequipmentid.Enabled = false;
            this.txtequipmentid.Location = new System.Drawing.Point(133, 125);
            this.txtequipmentid.Name = "txtequipmentid";
            this.txtequipmentid.ReadOnly = true;
            this.txtequipmentid.Size = new System.Drawing.Size(223, 20);
            this.txtequipmentid.TabIndex = 1;
            // 
            // txtdiagnosisdone
            // 
            this.txtdiagnosisdone.BackColor = System.Drawing.SystemColors.Info;
            this.txtdiagnosisdone.Location = new System.Drawing.Point(133, 295);
            this.txtdiagnosisdone.Name = "txtdiagnosisdone";
            this.txtdiagnosisdone.ReadOnly = true;
            this.txtdiagnosisdone.Size = new System.Drawing.Size(224, 20);
            this.txtdiagnosisdone.TabIndex = 7;
            this.txtdiagnosisdone.TextChanged += new System.EventHandler(this.txtdiagnosisdone_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label16.Location = new System.Drawing.Point(5, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 13);
            this.label16.TabIndex = 122;
            this.label16.Text = "Diagnosis Done :";
            // 
            // txtclientname
            // 
            this.txtclientname.BackColor = System.Drawing.SystemColors.Info;
            this.txtclientname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclientname.Location = new System.Drawing.Point(133, 214);
            this.txtclientname.Name = "txtclientname";
            this.txtclientname.ReadOnly = true;
            this.txtclientname.Size = new System.Drawing.Size(223, 20);
            this.txtclientname.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label17.Location = new System.Drawing.Point(6, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 119;
            this.label17.Text = "Client Name :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 13);
            this.label18.TabIndex = 118;
            this.label18.Text = "Equipment Serial :";
            // 
            // txtequipmentserial
            // 
            this.txtequipmentserial.BackColor = System.Drawing.SystemColors.Info;
            this.txtequipmentserial.Location = new System.Drawing.Point(133, 185);
            this.txtequipmentserial.Name = "txtequipmentserial";
            this.txtequipmentserial.ReadOnly = true;
            this.txtequipmentserial.Size = new System.Drawing.Size(223, 20);
            this.txtequipmentserial.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 163);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 13);
            this.label19.TabIndex = 116;
            this.label19.Text = "Equipment Name :";
            // 
            // txtequipmentname
            // 
            this.txtequipmentname.BackColor = System.Drawing.SystemColors.Info;
            this.txtequipmentname.Location = new System.Drawing.Point(133, 156);
            this.txtequipmentname.Name = "txtequipmentname";
            this.txtequipmentname.ReadOnly = true;
            this.txtequipmentname.Size = new System.Drawing.Size(223, 20);
            this.txtequipmentname.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label20.Location = new System.Drawing.Point(5, 360);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 13);
            this.label20.TabIndex = 128;
            this.label20.Text = "Category 2:";
            // 
            // txtcatsft
            // 
            this.txtcatsft.BackColor = System.Drawing.SystemColors.Info;
            this.txtcatsft.Location = new System.Drawing.Point(133, 348);
            this.txtcatsft.Name = "txtcatsft";
            this.txtcatsft.ReadOnly = true;
            this.txtcatsft.Size = new System.Drawing.Size(223, 20);
            this.txtcatsft.TabIndex = 9;
            // 
            // txthditems
            // 
            this.txthditems.BackColor = System.Drawing.SystemColors.Info;
            this.txthditems.Location = new System.Drawing.Point(133, 375);
            this.txthditems.Multiline = true;
            this.txthditems.Name = "txthditems";
            this.txthditems.ReadOnly = true;
            this.txthditems.Size = new System.Drawing.Size(223, 35);
            this.txthditems.TabIndex = 10;
            // 
            // txtsftitems
            // 
            this.txtsftitems.BackColor = System.Drawing.SystemColors.Info;
            this.txtsftitems.Location = new System.Drawing.Point(133, 416);
            this.txtsftitems.Multiline = true;
            this.txtsftitems.Name = "txtsftitems";
            this.txtsftitems.ReadOnly = true;
            this.txtsftitems.Size = new System.Drawing.Size(223, 35);
            this.txtsftitems.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label21.Location = new System.Drawing.Point(4, 423);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 13);
            this.label21.TabIndex = 130;
            this.label21.Text = "Software Items :";
            // 
            // txtqamnt
            // 
            this.txtqamnt.BackColor = System.Drawing.SystemColors.Info;
            this.txtqamnt.Location = new System.Drawing.Point(519, 385);
            this.txtqamnt.Multiline = true;
            this.txtqamnt.Name = "txtqamnt";
            this.txtqamnt.Size = new System.Drawing.Size(92, 20);
            this.txtqamnt.TabIndex = 12;
            this.txtqamnt.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.txtqamnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqamnt_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label22.Location = new System.Drawing.Point(415, 392);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 13);
            this.label22.TabIndex = 132;
            this.label22.Text = "Quote Amount :";
            // 
            // txttxamnt
            // 
            this.txttxamnt.BackColor = System.Drawing.SystemColors.Info;
            this.txttxamnt.Location = new System.Drawing.Point(863, 385);
            this.txttxamnt.Multiline = true;
            this.txttxamnt.Name = "txttxamnt";
            this.txttxamnt.ReadOnly = true;
            this.txttxamnt.Size = new System.Drawing.Size(92, 20);
            this.txttxamnt.TabIndex = 135;
            this.txttxamnt.TextChanged += new System.EventHandler(this.txttxamnt_TextChanged);
            this.txttxamnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttxamnt_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label23.Location = new System.Drawing.Point(762, 392);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 13);
            this.label23.TabIndex = 134;
            this.label23.Text = "Tax Amount :";
            // 
            // txtgamnt
            // 
            this.txtgamnt.BackColor = System.Drawing.SystemColors.Info;
            this.txtgamnt.Location = new System.Drawing.Point(863, 431);
            this.txtgamnt.Multiline = true;
            this.txtgamnt.Name = "txtgamnt";
            this.txtgamnt.ReadOnly = true;
            this.txtgamnt.Size = new System.Drawing.Size(92, 20);
            this.txtgamnt.TabIndex = 137;
            this.txtgamnt.TextChanged += new System.EventHandler(this.txtgamnt_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label24.Location = new System.Drawing.Point(749, 438);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 13);
            this.label24.TabIndex = 136;
            this.label24.Text = "Gross Amount :";
            // 
            // txttaxrate
            // 
            this.txttaxrate.BackColor = System.Drawing.SystemColors.Info;
            this.txttaxrate.Location = new System.Drawing.Point(519, 431);
            this.txttaxrate.Multiline = true;
            this.txttaxrate.Name = "txttaxrate";
            this.txttaxrate.ReadOnly = true;
            this.txttaxrate.Size = new System.Drawing.Size(92, 20);
            this.txttaxrate.TabIndex = 13;
            this.txttaxrate.TextChanged += new System.EventHandler(this.txttaxrate_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label25.Location = new System.Drawing.Point(416, 438);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 13);
            this.label25.TabIndex = 144;
            this.label25.Text = "Tax rate:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(628, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 21);
            this.button3.TabIndex = 145;
            this.button3.Text = "  &Tax";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(178, 577);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(78, 29);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "Update";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Info;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(112, 578);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 28);
            this.button7.TabIndex = 15;
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
            this.btnAdd.Location = new System.Drawing.Point(46, 578);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 28);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "New  ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.Info;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(262, 578);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(66, 29);
            this.btndelete.TabIndex = 18;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(334, 578);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 29);
            this.button4.TabIndex = 19;
            this.button4.Text = "LoadQuoteInfo";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.SystemColors.Info;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button2.Location = new System.Drawing.Point(455, 578);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 29);
            this.Button2.TabIndex = 20;
            this.Button2.Text = "&Cancel";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.Info;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button1.Location = new System.Drawing.Point(178, 578);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(78, 29);
            this.Button1.TabIndex = 16;
            this.Button1.Text = "&Save ";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
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
            this.button5.Location = new System.Drawing.Point(1064, 545);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 21);
            this.button5.TabIndex = 146;
            this.button5.Text = "  &GrandT&otal";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtclientemail
            // 
            this.txtclientemail.BackColor = System.Drawing.SystemColors.Info;
            this.txtclientemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclientemail.Location = new System.Drawing.Point(133, 240);
            this.txtclientemail.Name = "txtclientemail";
            this.txtclientemail.ReadOnly = true;
            this.txtclientemail.Size = new System.Drawing.Size(223, 20);
            this.txtclientemail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(7, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 147;
            this.label2.Text = "Client Email :";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(510, 95);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(179, 21);
            this.comboBox2.TabIndex = 148;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label4.Location = new System.Drawing.Point(412, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 149;
            this.label4.Text = "Service Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(749, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 153;
            this.label8.Text = "Price :";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(799, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 152;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Info;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(930, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 21);
            this.button6.TabIndex = 154;
            this.button6.Text = "Add";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_2);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Info;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(1008, 95);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 21);
            this.button8.TabIndex = 155;
            this.button8.Text = "   Remove";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Info;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(1064, 518);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(10, 21);
            this.button9.TabIndex = 156;
            this.button9.Text = "  &Sum";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // frmquote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 611);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtclientemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txttaxrate);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtgamnt);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txttxamnt);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtqamnt);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtsftitems);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txthditems);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtcatsft);
            this.Controls.Add(this.txtreportedproblem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtequipmentid);
            this.Controls.Add(this.txtdiagnosisdone);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtclientname);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtequipmentserial);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtequipmentname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtqid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtcathd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.kdvtarrif);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmquote";
            this.Text = "Create Quote";
            this.Load += new System.EventHandler(this.frmrequirements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kdvtarrif)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdvtarrif;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtcathd;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtqid;
        internal System.Windows.Forms.TextBox txtreportedproblem;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtequipmentid;
        internal System.Windows.Forms.TextBox txtdiagnosisdone;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox txtclientname;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.TextBox txtequipmentserial;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.TextBox txtequipmentname;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.TextBox txtcatsft;
        internal System.Windows.Forms.TextBox txthditems;
        internal System.Windows.Forms.TextBox txtsftitems;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.TextBox txtqamnt;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.TextBox txttxamnt;
        internal System.Windows.Forms.Label label23;
        internal System.Windows.Forms.TextBox txtgamnt;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.Button button7;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.TextBox txttaxrate;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button5;
        public System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.TextBox txtclientemail;
        internal System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBox2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.Button button8;
        internal System.Windows.Forms.Button button9;
    }
}