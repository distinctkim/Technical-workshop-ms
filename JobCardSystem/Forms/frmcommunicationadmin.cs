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
    public partial class frmcommunicationadmin : MetroFramework.Forms.MetroForm 
    {
        public frmcommunicationadmin ()
        {
            InitializeComponent ();
        }

        private void label1_Click (object sender, EventArgs e)
        {
            frmInternalCommadmin intern = new Forms.frmInternalCommadmin();
            intern.Show ();
            this.Hide ();
        }

        private void label2_Click (object sender, EventArgs e)
        {
            frmExternalCommAdmin ext = new frmExternalCommAdmin ();
            ext.Show ();
            this.Hide ();
        }

        private void Button2_Click (object sender, EventArgs e)
        {
            frmadminhome op = new Forms.frmadminhome();
            op.Show ();
            this.Hide ();
        }

        private void timer1_Tick (object sender, EventArgs e)
        {
            /*{
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
            }*/
        }

        private void frmcommunicationadmin_Load (object sender, EventArgs e)
        {
            Timer MyTimer = new Timer ();
            MyTimer.Interval = (5 * 60 * 1000); // 5 mins
            MyTimer.Tick += new EventHandler (timer1_Tick);
            MyTimer.Start ();
        }
    }
}
