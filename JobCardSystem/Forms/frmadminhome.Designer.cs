namespace JobCardSystem.Forms
{
    partial class frmadminhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadminhome));
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile13 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile14 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile12 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile15 = new MetroFramework.Controls.MetroTile();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.metroPanel1.Controls.Add(this.pictureBox2);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 5);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(888, 106);
            this.metroPanel1.TabIndex = 39;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(304, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(319, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.metroTile2);
            this.flowLayoutPanel1.Controls.Add(this.metroTile1);
            this.flowLayoutPanel1.Controls.Add(this.metroTile13);
            this.flowLayoutPanel1.Controls.Add(this.metroTile6);
            this.flowLayoutPanel1.Controls.Add(this.metroTile14);
            this.flowLayoutPanel1.Controls.Add(this.metroTile5);
            this.flowLayoutPanel1.Controls.Add(this.metroTile12);
            this.flowLayoutPanel1.Controls.Add(this.metroTile3);
            this.flowLayoutPanel1.Controls.Add(this.metroTile4);
            this.flowLayoutPanel1.Controls.Add(this.metroTile15);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 117);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(888, 380);
            this.flowLayoutPanel1.TabIndex = 40;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.metroTile2.ForeColor = System.Drawing.Color.Navy;
            this.metroTile2.Location = new System.Drawing.Point(3, 3);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(170, 181);
            this.metroTile2.TabIndex = 0;
            this.metroTile2.Text = "   Calculator";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.metroTile1.ForeColor = System.Drawing.Color.Navy;
            this.metroTile1.Location = new System.Drawing.Point(179, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(170, 181);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Create Word Document";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile13
            // 
            this.metroTile13.ActiveControl = null;
            this.metroTile13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.metroTile13.ForeColor = System.Drawing.Color.Navy;
            this.metroTile13.Location = new System.Drawing.Point(355, 3);
            this.metroTile13.Name = "metroTile13";
            this.metroTile13.Size = new System.Drawing.Size(170, 181);
            this.metroTile13.TabIndex = 2;
            this.metroTile13.Text = "  Tarrif SetUp";
            this.metroTile13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile13.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile13.TileImage")));
            this.metroTile13.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile13.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile13.UseCustomBackColor = true;
            this.metroTile13.UseCustomForeColor = true;
            this.metroTile13.UseSelectable = true;
            this.metroTile13.UseTileImage = true;
            this.metroTile13.Click += new System.EventHandler(this.metroTile13_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.metroTile6.ForeColor = System.Drawing.Color.Navy;
            this.metroTile6.Location = new System.Drawing.Point(531, 3);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(170, 181);
            this.metroTile6.TabIndex = 3;
            this.metroTile6.Text = "        Back-Up Service";
            this.metroTile6.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile6.TileImage")));
            this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile6.UseCustomBackColor = true;
            this.metroTile6.UseCustomForeColor = true;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.UseStyleColors = true;
            this.metroTile6.UseTileImage = true;
            this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // metroTile14
            // 
            this.metroTile14.ActiveControl = null;
            this.metroTile14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.metroTile14.ForeColor = System.Drawing.Color.Navy;
            this.metroTile14.Location = new System.Drawing.Point(707, 3);
            this.metroTile14.Name = "metroTile14";
            this.metroTile14.Size = new System.Drawing.Size(170, 181);
            this.metroTile14.TabIndex = 4;
            this.metroTile14.Text = "   Communication";
            this.metroTile14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile14.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile14.TileImage")));
            this.metroTile14.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile14.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile14.UseCustomBackColor = true;
            this.metroTile14.UseCustomForeColor = true;
            this.metroTile14.UseSelectable = true;
            this.metroTile14.UseTileImage = true;
            this.metroTile14.Click += new System.EventHandler(this.metroTile14_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.metroTile5.ForeColor = System.Drawing.Color.Navy;
            this.metroTile5.Location = new System.Drawing.Point(3, 190);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(170, 181);
            this.metroTile5.TabIndex = 5;
            this.metroTile5.Text = "Departments";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile5.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile5.TileImage")));
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseCustomBackColor = true;
            this.metroTile5.UseCustomForeColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseStyleColors = true;
            this.metroTile5.UseTileImage = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile12
            // 
            this.metroTile12.ActiveControl = null;
            this.metroTile12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.metroTile12.ForeColor = System.Drawing.Color.Navy;
            this.metroTile12.Location = new System.Drawing.Point(179, 190);
            this.metroTile12.Name = "metroTile12";
            this.metroTile12.Size = new System.Drawing.Size(170, 181);
            this.metroTile12.TabIndex = 6;
            this.metroTile12.Text = "     Manage Users";
            this.metroTile12.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile12.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile12.TileImage")));
            this.metroTile12.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile12.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile12.UseCustomBackColor = true;
            this.metroTile12.UseCustomForeColor = true;
            this.metroTile12.UseSelectable = true;
            this.metroTile12.UseStyleColors = true;
            this.metroTile12.UseTileImage = true;
            this.metroTile12.Click += new System.EventHandler(this.metroTile12_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.metroTile3.ForeColor = System.Drawing.Color.Navy;
            this.metroTile3.Location = new System.Drawing.Point(355, 190);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(170, 181);
            this.metroTile3.TabIndex = 7;
            this.metroTile3.Text = "View Logged Tasks";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseStyleColors = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.metroTile4.ForeColor = System.Drawing.Color.Navy;
            this.metroTile4.Location = new System.Drawing.Point(531, 190);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(170, 181);
            this.metroTile4.TabIndex = 8;
            this.metroTile4.Text = "Reports";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile4.UseCustomBackColor = true;
            this.metroTile4.UseCustomForeColor = true;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile15
            // 
            this.metroTile15.ActiveControl = null;
            this.metroTile15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.metroTile15.ForeColor = System.Drawing.Color.Navy;
            this.metroTile15.Location = new System.Drawing.Point(707, 190);
            this.metroTile15.Name = "metroTile15";
            this.metroTile15.Size = new System.Drawing.Size(170, 181);
            this.metroTile15.TabIndex = 9;
            this.metroTile15.Text = "  Exit";
            this.metroTile15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile15.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile15.TileImage")));
            this.metroTile15.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile15.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile15.UseCustomBackColor = true;
            this.metroTile15.UseCustomForeColor = true;
            this.metroTile15.UseSelectable = true;
            this.metroTile15.UseTileImage = true;
            this.metroTile15.Click += new System.EventHandler(this.metroTile15_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(536, 13);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(145, 22);
            this.statusStrip1.TabIndex = 41;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(720, 13);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(145, 22);
            this.statusStrip2.TabIndex = 42;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.statusStrip2);
            this.groupBox1.Location = new System.Drawing.Point(3, 497);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 39);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 43;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // frmadminhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 538);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmadminhome";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.frmadminhome_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile13;
        private MetroFramework.Controls.MetroTile metroTile14;
        private MetroFramework.Controls.MetroTile metroTile12;
        private MetroFramework.Controls.MetroTile metroTile15;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTile metroTile6;
        private System.Windows.Forms.Timer timer3;
    }
}