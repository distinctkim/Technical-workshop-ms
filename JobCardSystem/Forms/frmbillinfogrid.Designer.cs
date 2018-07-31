namespace JobCardSystem.Forms
{
    partial class frmbillinfogrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbillinfogrid));
            this.txtutally = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kdvequipcon = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvequipcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtutally
            // 
            this.txtutally.Location = new System.Drawing.Point(86, 349);
            this.txtutally.Multiline = true;
            this.txtutally.Name = "txtutally";
            this.txtutally.Size = new System.Drawing.Size(92, 17);
            this.txtutally.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Record Tally:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.btnexport.Location = new System.Drawing.Point(595, 43);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(103, 24);
            this.btnexport.TabIndex = 98;
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
            this.btnprint.Location = new System.Drawing.Point(461, 43);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(113, 24);
            this.btnprint.TabIndex = 97;
            this.btnprint.Text = "          Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(125, 46);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(315, 21);
            this.textBox5.TabIndex = 96;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 102;
            this.label13.Text = "Search By Client:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1045, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(1, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1081, 35);
            this.label7.TabIndex = 100;
            this.label7.Text = "Bill Information ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kdvequipcon
            // 
            this.kdvequipcon.AllowUserToAddRows = false;
            this.kdvequipcon.AllowUserToDeleteRows = false;
            this.kdvequipcon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kdvequipcon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.kdvequipcon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdvequipcon.Location = new System.Drawing.Point(8, 73);
            this.kdvequipcon.Name = "kdvequipcon";
            this.kdvequipcon.ReadOnly = true;
            this.kdvequipcon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.kdvequipcon.Size = new System.Drawing.Size(1073, 272);
            this.kdvequipcon.TabIndex = 99;
            this.kdvequipcon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kdvequipcon_CellContentClick);
            // 
            // frmbillinfogrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 368);
            this.Controls.Add(this.txtutally);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kdvequipcon);
            this.Name = "frmbillinfogrid";
            this.Load += new System.EventHandler(this.frmbillinfogrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvequipcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtutally;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnprint;
        internal System.Windows.Forms.TextBox textBox5;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdvequipcon;
        private System.Windows.Forms.Timer timer1;
    }
}