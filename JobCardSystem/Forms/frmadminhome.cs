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
    public partial class frmadminhome : MetroFramework.Forms.MetroForm
    {
        public frmadminhome ()
        {
            InitializeComponent ();
        }

        private void metroTile1_Click (object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start (@"Winword.exe");
        }

        private void metroTile2_Click (object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start (@"calc.exe");
        }

        private void metroTile15_Click (object sender, EventArgs e)
        {
            DialogResult dialogresult = MetroFramework.MetroMessageBox.Show (this, "Will you back-up your working database before you leave?", "Automated Job  Card System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                //timer1.Start ();

               frmbackupdb At = new frmbackupdb ();
                At.Show ();
                this.Hide ();
                // return;
            }
            else if (dialogresult == DialogResult.No)
            {
                MessageBox.Show ("Thank you.Goodbye", "Workshop management system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide ();
                //Application.Exit ();
                calllogin ();
            }
           
        }
        private void calllogin ()
        {
            frmlogin login = new frmlogin ();
            login.Show ();

        }

        private void metroTile13_Click (object sender, EventArgs e)
        {
            frmsetuptarrifs tarrif = new frmsetuptarrifs ();
            tarrif.Show ();
            this.Hide ();
        }

        private void metroTile14_Click (object sender, EventArgs e)
        {
            frmcommunicationadmin comm = new frmcommunicationadmin ();
            comm.Show ();
            this.Hide ();
        }

        private void metroTile12_Click (object sender, EventArgs e)
        {
            frmusers manageuser = new frmusers ();
            manageuser.Show ();
            this.Hide ();
        }

        private void metroTile3_Click (object sender, EventArgs e)
        {
            frmlogequipgridadmin equip = new frmlogequipgridadmin ();
            equip.Show ();
            this.Hide ();
        }

        private void timer1_Tick (object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Today.ToLongDateString ();
        }

        private void timer2_Tick (object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString ();

        }

        private void flowLayoutPanel1_Paint (object sender, PaintEventArgs e)
        {

        }

        private void frmadminhome_Load (object sender, EventArgs e)
        {
            metroLabel1.Text = "Logged in As: Administrator";
            Timer MyTimer = new Timer ();
            MyTimer.Interval = (5 * 60 * 1000); // 5 mins
            MyTimer.Tick += new EventHandler (timer3_Tick);
            MyTimer.Start ();
        }

        private void metroTile4_Click (object sender, EventArgs e)
        {
            this.Hide ();
            frmreportsmenu frm = new Forms.frmreportsmenu ();
            frm.Show ();

        }

        private void toolStripStatusLabel2_Click (object sender, EventArgs e)
        {

        }

        private void metroTile5_Click (object sender, EventArgs e)
        {
            frmsetupdepartments dept = new frmsetupdepartments ();
            dept.Show ();
            this.Close ();
        }

        private void metroTile6_Click (object sender, EventArgs e)
        {
            frmbackupdb frm = new frmbackupdb ();
            frm.Show ();
            this.Hide ();
        }

        private void timer3_Tick (object sender, EventArgs e)
        {
         /*
            {
                DialogResult dialogresult = MetroFramework.MetroMessageBox.Show (this, "Session timeout!,do you want to continue using it", "Automated Job  Card System", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogresult == DialogResult.Yes)
                {
                    //timer1.Start ();

                    frmlogin At = new frmlogin ();
                    At.Show ();
                    this.Hide ();
                    // return;
                }
                else if (dialogresult == DialogResult.No)
                {
                    MessageBox.Show ("Goodbye", "Time Elapsed");
                    this.Close ();
                }
            }
            */
        }
    }
}

