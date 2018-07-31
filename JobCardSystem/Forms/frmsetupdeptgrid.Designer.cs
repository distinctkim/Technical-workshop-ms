namespace JobCardSystem.Forms
{
    partial class frmsetupdeptgrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsetupdeptgrid));
            this.btnexcel = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kdvdept = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.txtdtally = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pckbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kdvdept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckbx)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexcel
            // 
            this.btnexcel.BackColor = System.Drawing.SystemColors.Info;
            this.btnexcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnexcel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexcel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcel.Location = new System.Drawing.Point(543, 41);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(85, 20);
            this.btnexcel.TabIndex = 2;
            this.btnexcel.Text = "          Csv";
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
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
            this.btnprint.Location = new System.Drawing.Point(421, 41);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(95, 20);
            this.btnprint.TabIndex = 1;
            this.btnprint.Text = "          Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsearch.Location = new System.Drawing.Point(140, 41);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(225, 20);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(0, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(733, 31);
            this.label7.TabIndex = 68;
            this.label7.Text = "Department Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kdvdept
            // 
            this.kdvdept.AllowUserToAddRows = false;
            this.kdvdept.AllowUserToDeleteRows = false;
            this.kdvdept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kdvdept.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kdvdept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdvdept.Location = new System.Drawing.Point(0, 66);
            this.kdvdept.Name = "kdvdept";
            this.kdvdept.ReadOnly = true;
            this.kdvdept.Size = new System.Drawing.Size(728, 256);
            this.kdvdept.TabIndex = 67;
            this.kdvdept.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kdvdept_CellContentClick);
            // 
            // txtdtally
            // 
            this.txtdtally.Location = new System.Drawing.Point(85, 325);
            this.txtdtally.Multiline = true;
            this.txtdtally.Name = "txtdtally";
            this.txtdtally.Size = new System.Drawing.Size(74, 17);
            this.txtdtally.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Record Tally:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 150;
            this.label1.Text = "Search By Department:";
            // 
            // pckbx
            // 
            this.pckbx.Image = ((System.Drawing.Image)(resources.GetObject("pckbx.Image")));
            this.pckbx.Location = new System.Drawing.Point(691, 5);
            this.pckbx.Name = "pckbx";
            this.pckbx.Size = new System.Drawing.Size(37, 31);
            this.pckbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pckbx.TabIndex = 151;
            this.pckbx.TabStop = false;
            this.pckbx.Click += new System.EventHandler(this.pckbx_Click);
            // 
            // frmsetupdeptgrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 345);
            this.Controls.Add(this.pckbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdtally);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kdvdept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmsetupdeptgrid";
            this.Load += new System.EventHandler(this.frmsetupdeptgrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kdvdept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexcel;
        //private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnprint;
        internal System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label7;
        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView kdvdept;
        private System.Windows.Forms.TextBox txtdtally;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pckbx;
    }
}