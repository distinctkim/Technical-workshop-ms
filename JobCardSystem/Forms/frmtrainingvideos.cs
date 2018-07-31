using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace JobCardSystem.Forms
{
    public partial class frmtrainingvideos : MetroFramework.Forms.MetroForm 
    {
        public frmtrainingvideos ()
        {
            InitializeComponent ();
        }

        private void metroTile1_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show ("Workstation repair and diagnostic training videos", "TWMS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                System.Diagnostics.Process.Start ("https://www.youtube.com/watch?v=rHtK_Gs4uws");
               
        }

        private void metroTile2_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show ("Networking devices repair and diagnostic training videos", "TWMS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                System.Diagnostics.Process.Start ("https://www.youtube.com/watch?v=V2yhVdxSWQI");

        }

        private void metroTile7_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show ("General failures troubleshooting and training videos", "TWMS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                System.Diagnostics.Process.Start ("https://www.youtube.com/watch?v=IX5SGXQ_Fss");


        }

        private void metroTile3_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show ("Copier repair and diagnostic training videos", "TWMS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                System.Diagnostics.Process.Start ("https://www.youtube.com/watch?v=-iG2IMw3dRI");


        }

        private void metroTile4_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show ("Printer repair and diagnostic training videos", "TWMS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                System.Diagnostics.Process.Start ("https://www.youtube.com/watch?v=6RDcyNC7y9Q");

            
        }

        private void flowLayoutPanel1_Paint (object sender, PaintEventArgs e)
        {

        }

        private void metroTile10_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show ("Photocopier diagnostic and Training videos", "TWMS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                System.Diagnostics.Process.Start ("https://www.youtube.com/watch?v=enm8uzLGT-s");


        }

        private void metroTile5_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show ("Scanner repair and diagnostics training videos", "TWMS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                System.Diagnostics.Process.Start ("https://www.youtube.com/watch?v=zK6cRmvlmIc");

            
        }

        private void metroTile6_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show ("Laptop repair training videos", "TWMS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                System.Diagnostics.Process.Start ("https://www.youtube.com/watch?v=Tvyul44hMIs&list=PLolXZ_FSzSVXjYq3Li9naG572dabEoQvg");


        }

        private void metroTile8_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show ("Monitor repairs and diagnostic training videos", "TWMS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                System.Diagnostics.Process.Start (" https://www.youtube.com/watch?v=D475G5nC8u0");

           
        }

        private void metroTile9_Click (object sender, EventArgs e)
        {
            if (MessageBox.Show ("Laptop issues diagnostic and training videos", "TWMS", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                System.Diagnostics.Process.Start ("https://www.youtube.com/watch?v=SYRWIdQonoI");

            
        }

        private void metroTile11_Click (object sender, EventArgs e)
        {
            Home frm = new Home ();
            frm.Show ();
            this.Hide ();
        }
    }
}
