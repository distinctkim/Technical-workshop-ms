namespace JobCardSystem.Forms
{
    partial class frmequipdiagnosisgrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmequipdiagnosisgrid));
            this.label7 = new System.Windows.Forms.Label();
            this.kdvequipdiagnosis = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtdiagnosistally = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kdvequipdiagnosis)).BeginInit();
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
            this.label7.Size = new System.Drawing.Size(1039, 35);
            this.label7.TabIndex = 15;
            this.label7.Text = "Equipment Diagnosis Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kdvequipdiagnosis
            // 
            this.kdvequipdiagnosis.AllowUserToAddRows = false;
            this.kdvequipdiagnosis.AllowUserToDeleteRows = false;
            this.kdvequipdiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdvequipdiagnosis.Location = new System.Drawing.Point(0, 72);
            this.kdvequipdiagnosis.Name = "kdvequipdiagnosis";
            this.kdvequipdiagnosis.ReadOnly = true;
            this.kdvequipdiagnosis.Size = new System.Drawing.Size(1039, 289);
            this.kdvequipdiagnosis.TabIndex = 14;
            this.kdvequipdiagnosis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kdvequipdiagnosis_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1002, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(79, 47);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(297, 21);
            this.textBox5.TabIndex = 0;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Search By  :";
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
            this.button4.Location = new System.Drawing.Point(435, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 24);
            this.button4.TabIndex = 1;
            this.button4.Text = "          Print";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.button1.Location = new System.Drawing.Point(565, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "          Csv";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtdiagnosistally
            // 
            this.txtdiagnosistally.Location = new System.Drawing.Point(78, 364);
            this.txtdiagnosistally.Name = "txtdiagnosistally";
            this.txtdiagnosistally.Size = new System.Drawing.Size(74, 20);
            this.txtdiagnosistally.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Record Tally:";
            // 
            // frmequipdiagnosisgrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 384);
            this.Controls.Add(this.txtdiagnosistally);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kdvequipdiagnosis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmequipdiagnosisgrid";
            this.Load += new System.EventHandler(this.frmequipdiagnosisgrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kdvequipdiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdvequipdiagnosis;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox textBox5;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdiagnosistally;
        private System.Windows.Forms.Label label1;
    }
}