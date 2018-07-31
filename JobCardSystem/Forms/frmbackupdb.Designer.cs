namespace JobCardSystem.Forms
{
    partial class frmbackupdb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbackupdb));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Gray;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(79, 81);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(179, 42);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Back-Up Working Database";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Location = new System.Drawing.Point(-2, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(347, 47);
            this.Panel1.TabIndex = 28;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(3, 1);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(42, 42);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 3;
            this.PictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database Back-up Service";
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Cambria", 9F);
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(272, 152);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(69, 24);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "Exit";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmbackupdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 178);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmbackupdb";
            this.Load += new System.EventHandler(this.frmbackupdb_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Timer timer1;
    }
}