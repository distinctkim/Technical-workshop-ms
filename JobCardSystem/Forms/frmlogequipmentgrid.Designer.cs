namespace JobCardSystem.Forms
{
    partial class frmlogequipmentgrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogequipmentgrid));
            this.label7 = new System.Windows.Forms.Label();
            this.kdvclientequipmentgrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtletally = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kdvclientequipmentgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(1, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1026, 35);
            this.label7.TabIndex = 15;
            this.label7.Text = "Client Equipment Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kdvclientequipmentgrid
            // 
            this.kdvclientequipmentgrid.AllowUserToAddRows = false;
            this.kdvclientequipmentgrid.AllowUserToDeleteRows = false;
            this.kdvclientequipmentgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdvclientequipmentgrid.Location = new System.Drawing.Point(-1, 70);
            this.kdvclientequipmentgrid.Name = "kdvclientequipmentgrid";
            this.kdvclientequipmentgrid.ReadOnly = true;
            this.kdvclientequipmentgrid.Size = new System.Drawing.Size(1023, 266);
            this.kdvclientequipmentgrid.TabIndex = 14;
            this.kdvclientequipmentgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kdvclientequipmentgrid_CellContentClick);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox5.Location = new System.Drawing.Point(173, 43);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(223, 20);
            this.textBox5.TabIndex = 0;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label13.Location = new System.Drawing.Point(23, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Search By Clientname :";
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
            this.button2.Location = new System.Drawing.Point(596, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 20);
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
            this.button4.Location = new System.Drawing.Point(462, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 21);
            this.button4.TabIndex = 1;
            this.button4.Text = "          Print";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(986, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtletally
            // 
            this.txtletally.Location = new System.Drawing.Point(84, 338);
            this.txtletally.Multiline = true;
            this.txtletally.Name = "txtletally";
            this.txtletally.Size = new System.Drawing.Size(74, 17);
            this.txtletally.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Record Tally:";
            // 
            // frmlogequipmentgrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 359);
            this.Controls.Add(this.txtletally);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kdvclientequipmentgrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogequipmentgrid";
            this.Load += new System.EventHandler(this.frmlogequipmentgrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kdvclientequipmentgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdvclientequipmentgrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox textBox5;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtletally;
        private System.Windows.Forms.Label label1;
    }
}