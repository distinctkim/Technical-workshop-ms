using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobCardSystem.Forms
{
    public partial class frmsplashscreen : Form
    {
        public frmsplashscreen ()
        {
            InitializeComponent ();
        }

        private void timer1_Tick (object sender, EventArgs e)
        {
            try
            {

                rectangleShape2.Width += 1;
                if (rectangleShape2.Width >= 651)
                {

                    timer1.Stop ();
                    show ();
                }
            }

            catch (Exception)

            {
                return;
            }

        }
        public void show ()
        {

            frmlogin  log = new frmlogin ();
            log.Show ();
            this.Hide ();
        }

        private void rectangleShape1_Click (object sender, EventArgs e)
        {

        }

        private void frmsplashscreen_Load (object sender, EventArgs e)
        {
            timer1.Start ();
        }
    }
}
