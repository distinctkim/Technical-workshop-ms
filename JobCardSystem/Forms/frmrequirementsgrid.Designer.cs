namespace JobCardSystem.Forms
{
    partial class frmrequirementsgrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrequirementsgrid));
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kdvequipreq = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtutally = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kdvequipreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(127, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(268, 21);
            this.textBox5.TabIndex = 0;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(0, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1028, 35);
            this.label7.TabIndex = 69;
            this.label7.Text = "Equipment Repair Requirements";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kdvequipreq
            // 
            this.kdvequipreq.AllowUserToAddRows = false;
            this.kdvequipreq.AllowUserToDeleteRows = false;
            this.kdvequipreq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kdvequipreq.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.kdvequipreq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdvequipreq.Location = new System.Drawing.Point(1, 72);
            this.kdvequipreq.Name = "kdvequipreq";
            this.kdvequipreq.ReadOnly = true;
            this.kdvequipreq.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.kdvequipreq.Size = new System.Drawing.Size(1017, 243);
            this.kdvequipreq.TabIndex = 68;
            this.kdvequipreq.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kdvequipreq_CellContentClick);
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.SystemColors.Info;
            this.btnexport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnexport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnexport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Image = ((System.Drawing.Image)(resources.GetObject("btnexport.Image")));
            this.btnexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexport.Location = new System.Drawing.Point(536, 45);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(85, 23);
            this.btnexport.TabIndex = 2;
            this.btnexport.Text = "          Csv";
            this.btnexport.UseVisualStyleBackColor = false;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
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
            this.btnprint.Location = new System.Drawing.Point(420, 44);
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
            this.pictureBox1.Location = new System.Drawing.Point(986, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtutally
            // 
            this.txtutally.Location = new System.Drawing.Point(86, 319);
            this.txtutally.Multiline = true;
            this.txtutally.Name = "txtutally";
            this.txtutally.Size = new System.Drawing.Size(74, 17);
            this.txtutally.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Record Tally:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 150;
            this.label1.Text = "Search By Clientname:";
            // 
            // frmrequirementsgrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtutally);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kdvequipreq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmrequirementsgrid";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.frmrequirementsgrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kdvequipreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnprint;
        internal System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdvequipreq;
        private System.Windows.Forms.TextBox txtutally;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}