namespace JobCardSystem.Forms
{
    partial class frmviewcleareditemsadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmviewcleareditemsadmin));
            this.txtre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttamnt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtletally = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kdvclientequipmentgrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtresamnt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvclientequipmentgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtre
            // 
            this.txtre.Location = new System.Drawing.Point(644, 343);
            this.txtre.Multiline = true;
            this.txtre.Name = "txtre";
            this.txtre.Size = new System.Drawing.Size(110, 19);
            this.txtre.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 118;
            this.label3.Text = "Total re-embursed amount Kshs:";
            // 
            // txttamnt
            // 
            this.txttamnt.Location = new System.Drawing.Point(346, 343);
            this.txttamnt.Multiline = true;
            this.txttamnt.Name = "txttamnt";
            this.txttamnt.Size = new System.Drawing.Size(110, 19);
            this.txttamnt.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Total Uncollected amount Kshs:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1054, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label13.Location = new System.Drawing.Point(13, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 13);
            this.label13.TabIndex = 114;
            this.label13.Text = "Search By Clientname :";
            // 
            // txtletally
            // 
            this.txtletally.Location = new System.Drawing.Point(83, 344);
            this.txtletally.Multiline = true;
            this.txtletally.Name = "txtletally";
            this.txtletally.Size = new System.Drawing.Size(74, 17);
            this.txtletally.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 112;
            this.label1.Text = "Record Tally:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(543, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 20);
            this.button2.TabIndex = 109;
            this.button2.Text = "          Csv";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(423, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 21);
            this.button4.TabIndex = 108;
            this.button4.Text = "          Print";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox5.Location = new System.Drawing.Point(163, 46);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(223, 20);
            this.textBox5.TabIndex = 107;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(0, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1092, 35);
            this.label7.TabIndex = 111;
            this.label7.Text = "Client Cleared Equipment Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kdvclientequipmentgrid
            // 
            this.kdvclientequipmentgrid.AllowUserToAddRows = false;
            this.kdvclientequipmentgrid.AllowUserToDeleteRows = false;
            this.kdvclientequipmentgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdvclientequipmentgrid.Location = new System.Drawing.Point(2, 71);
            this.kdvclientequipmentgrid.Name = "kdvclientequipmentgrid";
            this.kdvclientequipmentgrid.ReadOnly = true;
            this.kdvclientequipmentgrid.Size = new System.Drawing.Size(1084, 266);
            this.kdvclientequipmentgrid.TabIndex = 110;
            this.kdvclientequipmentgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kdvclientequipmentgrid_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(783, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 120;
            this.label4.Text = "Total residual amount Kshs:";
            // 
            // txtresamnt
            // 
            this.txtresamnt.Location = new System.Drawing.Point(942, 341);
            this.txtresamnt.Multiline = true;
            this.txtresamnt.Name = "txtresamnt";
            this.txtresamnt.Size = new System.Drawing.Size(110, 19);
            this.txtresamnt.TabIndex = 121;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(656, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 21);
            this.button1.TabIndex = 122;
            this.button1.Text = " Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmviewcleareditemsadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtresamnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttamnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtletally);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kdvclientequipmentgrid);
            this.Name = "frmviewcleareditemsadmin";
            this.Load += new System.EventHandler(this.frmviewcleareditemsadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvclientequipmentgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttamnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtletally;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        internal System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdvclientequipmentgrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtresamnt;
        private System.Windows.Forms.Button button1;
    }
}