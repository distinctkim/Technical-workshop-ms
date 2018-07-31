namespace JobCardSystem.Forms
{
    partial class frmequipmentdiagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmequipmentdiagnosis));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtclientemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txturgency = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtequipmentid = new System.Windows.Forms.TextBox();
            this.txtequipmentname = new System.Windows.Forms.TextBox();
            this.txtclientname = new System.Windows.Forms.TextBox();
            this.txtequipmentserial = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtreportedproblem = new System.Windows.Forms.TextBox();
            this.txtedid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbxprogress = new System.Windows.Forms.ComboBox();
            this.cmbxcomment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxreason = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxresponsetime = new System.Windows.Forms.ComboBox();
            this.txtduration = new System.Windows.Forms.TextBox();
            this.cmbxtechassigned = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtdiagnosisdone = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.kdvequip = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvequip)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.button8);
            this.GroupBox1.Controls.Add(this.groupBox2);
            this.GroupBox1.Controls.Add(this.button7);
            this.GroupBox1.Controls.Add(this.btnAdd);
            this.GroupBox1.Controls.Add(this.btnUpdate);
            this.GroupBox1.Controls.Add(this.txtreportedproblem);
            this.GroupBox1.Controls.Add(this.txtedid);
            this.GroupBox1.Controls.Add(this.label14);
            this.GroupBox1.Controls.Add(this.cmbxprogress);
            this.GroupBox1.Controls.Add(this.cmbxcomment);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.cmbxreason);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.cmbxresponsetime);
            this.GroupBox1.Controls.Add(this.txtduration);
            this.GroupBox1.Controls.Add(this.cmbxtechassigned);
            this.GroupBox1.Controls.Add(this.button4);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.Controls.Add(this.Label16);
            this.GroupBox1.Controls.Add(this.txtdiagnosisdone);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(0, 59);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(768, 392);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Equipment Diagnosis Information";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Info;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(566, 357);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 28);
            this.button8.TabIndex = 13;
            this.button8.Text = " &Requirements";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtclientemail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txturgency);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtequipmentid);
            this.groupBox2.Controls.Add(this.txtequipmentname);
            this.groupBox2.Controls.Add(this.txtclientname);
            this.groupBox2.Controls.Add(this.txtequipmentserial);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(412, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 231);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Equipment Info";
            // 
            // txtclientemail
            // 
            this.txtclientemail.BackColor = System.Drawing.SystemColors.Info;
            this.txtclientemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclientemail.Enabled = false;
            this.txtclientemail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclientemail.Location = new System.Drawing.Point(121, 156);
            this.txtclientemail.Name = "txtclientemail";
            this.txtclientemail.Size = new System.Drawing.Size(223, 21);
            this.txtclientemail.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Client Email :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Equipment ID :";
            // 
            // txturgency
            // 
            this.txturgency.BackColor = System.Drawing.SystemColors.Info;
            this.txturgency.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txturgency.Enabled = false;
            this.txturgency.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txturgency.Location = new System.Drawing.Point(121, 189);
            this.txturgency.Name = "txturgency";
            this.txturgency.Size = new System.Drawing.Size(223, 21);
            this.txturgency.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Equipment Name :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 199);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "Urgency :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Equipment Serial :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Client Name :";
            // 
            // txtequipmentid
            // 
            this.txtequipmentid.BackColor = System.Drawing.SystemColors.Info;
            this.txtequipmentid.Enabled = false;
            this.txtequipmentid.Location = new System.Drawing.Point(121, 17);
            this.txtequipmentid.Name = "txtequipmentid";
            this.txtequipmentid.Size = new System.Drawing.Size(223, 21);
            this.txtequipmentid.TabIndex = 3;
            // 
            // txtequipmentname
            // 
            this.txtequipmentname.BackColor = System.Drawing.SystemColors.Info;
            this.txtequipmentname.Enabled = false;
            this.txtequipmentname.Location = new System.Drawing.Point(121, 58);
            this.txtequipmentname.Name = "txtequipmentname";
            this.txtequipmentname.Size = new System.Drawing.Size(223, 21);
            this.txtequipmentname.TabIndex = 36;
            // 
            // txtclientname
            // 
            this.txtclientname.BackColor = System.Drawing.SystemColors.Info;
            this.txtclientname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclientname.Enabled = false;
            this.txtclientname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclientname.Location = new System.Drawing.Point(121, 129);
            this.txtclientname.Name = "txtclientname";
            this.txtclientname.Size = new System.Drawing.Size(223, 21);
            this.txtclientname.TabIndex = 41;
            // 
            // txtequipmentserial
            // 
            this.txtequipmentserial.BackColor = System.Drawing.SystemColors.Info;
            this.txtequipmentserial.Enabled = false;
            this.txtequipmentserial.Location = new System.Drawing.Point(121, 95);
            this.txtequipmentserial.Name = "txtequipmentserial";
            this.txtequipmentserial.Size = new System.Drawing.Size(223, 21);
            this.txtequipmentserial.TabIndex = 38;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Info;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(262, 357);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 29);
            this.button7.TabIndex = 9;
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
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(179, 357);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "    New  ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(351, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 28);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtreportedproblem
            // 
            this.txtreportedproblem.BackColor = System.Drawing.SystemColors.Info;
            this.txtreportedproblem.Enabled = false;
            this.txtreportedproblem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreportedproblem.Location = new System.Drawing.Point(133, 52);
            this.txtreportedproblem.Multiline = true;
            this.txtreportedproblem.Name = "txtreportedproblem";
            this.txtreportedproblem.Size = new System.Drawing.Size(270, 42);
            this.txtreportedproblem.TabIndex = 0;
            this.txtreportedproblem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtreportedproblem_KeyPress);
            // 
            // txtedid
            // 
            this.txtedid.BackColor = System.Drawing.SystemColors.Info;
            this.txtedid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtedid.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedid.Location = new System.Drawing.Point(129, 17);
            this.txtedid.Name = "txtedid";
            this.txtedid.Size = new System.Drawing.Size(39, 21);
            this.txtedid.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Did:";
            // 
            // cmbxprogress
            // 
            this.cmbxprogress.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxprogress.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxprogress.FormattingEnabled = true;
            this.cmbxprogress.Location = new System.Drawing.Point(133, 147);
            this.cmbxprogress.Name = "cmbxprogress";
            this.cmbxprogress.Size = new System.Drawing.Size(270, 21);
            this.cmbxprogress.TabIndex = 2;
            // 
            // cmbxcomment
            // 
            this.cmbxcomment.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxcomment.FormattingEnabled = true;
            this.cmbxcomment.Items.AddRange(new object[] {
            "Problem Identified. Being handled,no order to be placed.",
            "Problem Identified,order for replacement items placed.",
            "Problem Identified, beyond repair."});
            this.cmbxcomment.Location = new System.Drawing.Point(178, 321);
            this.cmbxcomment.Name = "cmbxcomment";
            this.cmbxcomment.Size = new System.Drawing.Size(225, 21);
            this.cmbxcomment.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Comment(?) :";
            // 
            // cmbxreason
            // 
            this.cmbxreason.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxreason.FormattingEnabled = true;
            this.cmbxreason.Items.AddRange(new object[] {
            "Order to be placed",
            "Required Items available"});
            this.cmbxreason.Location = new System.Drawing.Point(178, 291);
            this.cmbxreason.Name = "cmbxreason";
            this.cmbxreason.Size = new System.Drawing.Size(225, 21);
            this.cmbxreason.TabIndex = 6;
            this.cmbxreason.SelectedIndexChanged += new System.EventHandler(this.cmbxreason_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Reason :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbxresponsetime
            // 
            this.cmbxresponsetime.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxresponsetime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxresponsetime.FormattingEnabled = true;
            this.cmbxresponsetime.Items.AddRange(new object[] {
            "IMMEDIATE",
            "QUEUED"});
            this.cmbxresponsetime.Location = new System.Drawing.Point(196, 259);
            this.cmbxresponsetime.Name = "cmbxresponsetime";
            this.cmbxresponsetime.Size = new System.Drawing.Size(207, 21);
            this.cmbxresponsetime.TabIndex = 5;
            // 
            // txtduration
            // 
            this.txtduration.BackColor = System.Drawing.SystemColors.Info;
            this.txtduration.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtduration.Location = new System.Drawing.Point(196, 218);
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(207, 21);
            this.txtduration.TabIndex = 4;
            // 
            // cmbxtechassigned
            // 
            this.cmbxtechassigned.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxtechassigned.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxtechassigned.FormattingEnabled = true;
            this.cmbxtechassigned.Location = new System.Drawing.Point(133, 179);
            this.cmbxtechassigned.Name = "cmbxtechassigned";
            this.cmbxtechassigned.Size = new System.Drawing.Size(270, 21);
            this.cmbxtechassigned.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(436, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 28);
            this.button4.TabIndex = 12;
            this.button4.Text = "Load Diagnosis";
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
            this.Button2.Location = new System.Drawing.Point(688, 357);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 28);
            this.Button2.TabIndex = 14;
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
            this.Button1.Location = new System.Drawing.Point(353, 357);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 28);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "&Save ";
            this.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(9, 185);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(80, 13);
            this.Label16.TabIndex = 11;
            this.Label16.Text = "Assigned To:";
            // 
            // txtdiagnosisdone
            // 
            this.txtdiagnosisdone.BackColor = System.Drawing.SystemColors.Info;
            this.txtdiagnosisdone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiagnosisdone.Location = new System.Drawing.Point(133, 105);
            this.txtdiagnosisdone.Multiline = true;
            this.txtdiagnosisdone.Name = "txtdiagnosisdone";
            this.txtdiagnosisdone.Size = new System.Drawing.Size(270, 32);
            this.txtdiagnosisdone.TabIndex = 1;
            this.txtdiagnosisdone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiagnosisdone_KeyPress);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(9, 52);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(119, 13);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Reported Problem :";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(9, 267);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(159, 13);
            this.Label10.TabIndex = 0;
            this.Label10.Text = "Expected Response Time :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(9, 155);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(106, 13);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Progress Status :";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(9, 226);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(181, 13);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Estimated Task duration(hrs) :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(9, 113);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(121, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Diagnosis Findings :";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(0, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1320, 48);
            this.Panel1.TabIndex = 3;
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
            this.PictureBox2.TabIndex = 3;
            this.PictureBox2.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(42, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(259, 25);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Add Equipment Diagnosis";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1152, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 24);
            this.button3.TabIndex = 75;
            this.button3.Text = "    Generate Csv";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Info;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(1035, 97);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 24);
            this.button6.TabIndex = 73;
            this.button6.Text = "          Print";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(772, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(548, 36);
            this.label17.TabIndex = 69;
            this.label17.Text = "Equipment Record Information";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kdvequip
            // 
            this.kdvequip.AllowUserToAddRows = false;
            this.kdvequip.AllowUserToDeleteRows = false;
            this.kdvequip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kdvequip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdvequip.Location = new System.Drawing.Point(771, 129);
            this.kdvequip.Name = "kdvequip";
            this.kdvequip.ReadOnly = true;
            this.kdvequip.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.kdvequip.Size = new System.Drawing.Size(549, 322);
            this.kdvequip.TabIndex = 68;
            this.kdvequip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kdvequip_CellContentClick);
            // 
            // frmequipmentdiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 456);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.kdvequip);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmequipmentdiagnosis";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.frmequipmentdiagnosis_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvequip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txtequipmentid;
        internal System.Windows.Forms.TextBox txtdiagnosisdone;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cmbxcomment;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbxreason;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cmbxresponsetime;
        internal System.Windows.Forms.TextBox txtduration;
        internal System.Windows.Forms.ComboBox cmbxtechassigned;
        internal System.Windows.Forms.ComboBox cmbxprogress;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtequipmentserial;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtequipmentname;
        internal System.Windows.Forms.TextBox txtclientname;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox txtedid;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtreportedproblem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label17;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdvequip;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button button7;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.TextBox txturgency;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button button8;
        internal System.Windows.Forms.TextBox txtclientemail;
        internal System.Windows.Forms.Label label3;
    }
}