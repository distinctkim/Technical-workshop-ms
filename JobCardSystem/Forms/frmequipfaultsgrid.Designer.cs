namespace JobCardSystem.Forms
{
    partial class frmequipfaultsgrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmequipfaultsgrid));
            this.label7 = new System.Windows.Forms.Label();
            this.kdvequipfaults = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtfaulttally = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kdvequipfaults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(0, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(737, 36);
            this.label7.TabIndex = 20;
            this.label7.Text = "Fault Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kdvequipfaults
            // 
            this.kdvequipfaults.AllowUserToAddRows = false;
            this.kdvequipfaults.AllowUserToDeleteRows = false;
            this.kdvequipfaults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kdvequipfaults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.kdvequipfaults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdvequipfaults.Location = new System.Drawing.Point(5, 74);
            this.kdvequipfaults.Name = "kdvequipfaults";
            this.kdvequipfaults.ReadOnly = true;
            this.kdvequipfaults.Size = new System.Drawing.Size(730, 271);
            this.kdvequipfaults.TabIndex = 19;
            this.kdvequipfaults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kdvequipfaults_CellContentClick);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsearch.Location = new System.Drawing.Point(186, 47);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(252, 20);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Search By FaultDescription  :";
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
            this.button1.Location = new System.Drawing.Point(583, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "          Csv";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.button4.Location = new System.Drawing.Point(458, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 24);
            this.button4.TabIndex = 1;
            this.button4.Text = "          Print";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(701, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtfaulttally
            // 
            this.txtfaulttally.Location = new System.Drawing.Point(82, 347);
            this.txtfaulttally.Name = "txtfaulttally";
            this.txtfaulttally.Size = new System.Drawing.Size(74, 20);
            this.txtfaulttally.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Record Tally:";
            // 
            // frmequipfaultsgrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 372);
            this.Controls.Add(this.txtfaulttally);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kdvequipfaults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmequipfaultsgrid";
            this.Load += new System.EventHandler(this.frmequipfaultsgrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kdvequipfaults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdvequipfaults;
        private System.Windows.Forms.TextBox txtfaulttally;
        private System.Windows.Forms.Label label1;
    }
}