namespace JobCardSystem.Forms
{
    partial class frmfaultdictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfaultdictionary));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kdvfaultdictionary = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnexptexcel = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtfaulttally = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kdvfaultdictionary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsearch.Location = new System.Drawing.Point(85, 47);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(271, 20);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 71;
            this.label13.Text = "Search  :";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(1, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(738, 36);
            this.label7.TabIndex = 69;
            this.label7.Text = "Fault Dictionary";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kdvfaultdictionary
            // 
            this.kdvfaultdictionary.AllowUserToAddRows = false;
            this.kdvfaultdictionary.AllowUserToDeleteRows = false;
            this.kdvfaultdictionary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kdvfaultdictionary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.kdvfaultdictionary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdvfaultdictionary.Location = new System.Drawing.Point(3, 70);
            this.kdvfaultdictionary.Name = "kdvfaultdictionary";
            this.kdvfaultdictionary.ReadOnly = true;
            this.kdvfaultdictionary.Size = new System.Drawing.Size(732, 268);
            this.kdvfaultdictionary.TabIndex = 68;
            // 
            // btnexptexcel
            // 
            this.btnexptexcel.BackColor = System.Drawing.SystemColors.Info;
            this.btnexptexcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnexptexcel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnexptexcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexptexcel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexptexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexptexcel.Image")));
            this.btnexptexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexptexcel.Location = new System.Drawing.Point(526, 44);
            this.btnexptexcel.Name = "btnexptexcel";
            this.btnexptexcel.Size = new System.Drawing.Size(85, 24);
            this.btnexptexcel.TabIndex = 2;
            this.btnexptexcel.Text = "          Csv";
            this.btnexptexcel.UseVisualStyleBackColor = false;
            this.btnexptexcel.Click += new System.EventHandler(this.btnexptexcel_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.Info;
            this.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnprint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprint.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.Location = new System.Drawing.Point(402, 44);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(95, 24);
            this.btnprint.TabIndex = 1;
            this.btnprint.Text = "          Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(701, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtfaulttally
            // 
            this.txtfaulttally.Location = new System.Drawing.Point(85, 341);
            this.txtfaulttally.Name = "txtfaulttally";
            this.txtfaulttally.Size = new System.Drawing.Size(74, 20);
            this.txtfaulttally.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Record Tally:";
            // 
            // frmfaultdictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 365);
            this.Controls.Add(this.txtfaulttally);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexptexcel);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kdvfaultdictionary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmfaultdictionary";
            this.Load += new System.EventHandler(this.frmfaultdictionary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kdvfaultdictionary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexptexcel;
        private System.Windows.Forms.Button btnprint;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdvfaultdictionary;
        private System.Windows.Forms.TextBox txtfaulttally;
        private System.Windows.Forms.Label label1;
    }
}