namespace JobCardSystem.Forms
{
    partial class frmloadreqgrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmloadreqgrid));
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kdvreqinfo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.txtreqtally = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvreqinfo)).BeginInit();
            this.SuspendLayout();
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
            this.button2.Location = new System.Drawing.Point(544, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 21);
            this.button2.TabIndex = 2;
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
            this.button4.Location = new System.Drawing.Point(419, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 21);
            this.button4.TabIndex = 1;
            this.button4.Text = "          Print";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox5.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBox5.Location = new System.Drawing.Point(95, 46);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(294, 21);
            this.textBox5.TabIndex = 0;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label13.Location = new System.Drawing.Point(10, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 71;
            this.label13.Text = "Search By  :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(996, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(-2, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1035, 35);
            this.label7.TabIndex = 69;
            this.label7.Text = "Requirements Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kdvreqinfo
            // 
            this.kdvreqinfo.AllowUserToAddRows = false;
            this.kdvreqinfo.AllowUserToDeleteRows = false;
            this.kdvreqinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kdvreqinfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.kdvreqinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdvreqinfo.Location = new System.Drawing.Point(6, 73);
            this.kdvreqinfo.Name = "kdvreqinfo";
            this.kdvreqinfo.ReadOnly = true;
            this.kdvreqinfo.Size = new System.Drawing.Size(1017, 259);
            this.kdvreqinfo.TabIndex = 68;
            this.kdvreqinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kdvreqinfo_CellContentClick);
            // 
            // txtreqtally
            // 
            this.txtreqtally.Location = new System.Drawing.Point(90, 333);
            this.txtreqtally.Multiline = true;
            this.txtreqtally.Name = "txtreqtally";
            this.txtreqtally.Size = new System.Drawing.Size(74, 17);
            this.txtreqtally.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Record Tally:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmloadreqgrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 351);
            this.Controls.Add(this.txtreqtally);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kdvreqinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmloadreqgrid";
            this.Load += new System.EventHandler(this.frmloadreqgrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvreqinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        internal System.Windows.Forms.TextBox textBox5;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdvreqinfo;
        private System.Windows.Forms.TextBox txtreqtally;
        private System.Windows.Forms.Label label1;
    }
}