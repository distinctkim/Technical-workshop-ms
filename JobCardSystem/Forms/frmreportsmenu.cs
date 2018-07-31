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
    public partial class frmreportsmenu : MetroFramework.Forms.MetroForm 
    {
        public frmreportsmenu ()
        {
            InitializeComponent ();
        }

        private void metroTile1_Click (object sender, EventArgs e)
        {
            frmItemlogreport log = new Forms.frmItemlogreport ();
            log.Show ();
            this.Hide ();
        }

        private void metroTile2_Click (object sender, EventArgs e)
        {
            frmItemdiagnosisreport log = new frmItemdiagnosisreport ();
            log.Show ();
            this.Hide ();
        }

        private void metroTile3_Click (object sender, EventArgs e)
        {
            frmitemrequirementsreport  req = new Forms.frmitemrequirementsreport ();
            req.Show ();
            this.Hide ();

        }

        private void metroTile4_Click (object sender, EventArgs e)
        {
            frmitemquotereport  quo = new frmitemquotereport ();
            quo.Show ();
            this.Hide ();

        }

        private void metroTile5_Click (object sender, EventArgs e)
        {
            frmconfirmedItemsreport frm = new frmconfirmedItemsreport ();
            frm.Show ();
            this.Hide ();
        }

        private void pictureBox1_Click (object sender, EventArgs e)
        {
          

        }

        private void frmreportsmenu_Load (object sender, EventArgs e)
        {
           
        }

        private void metroTile6_Click (object sender, EventArgs e)
        {
            frmpendingItemsreport frm = new frmpendingItemsreport ();
            frm.Show ();
            this.Hide ();
        }

        private void flowLayoutPanel1_Paint (object sender, PaintEventArgs e)
        {

        }

        private void metroTile9_Click (object sender, EventArgs e)
        {
            this.Hide ();
            frmadminhome frm = new frmadminhome ();
            frm.Show ();
        }

        private void metroTile7_Click (object sender, EventArgs e)
        {
            this.Hide ();
            frmviewcleareditemsadmin frm = new Forms.frmviewcleareditemsadmin ();
            frm.Show ();
                      
        }

        private void metroTile8_Click (object sender, EventArgs e)
        {
            this.Hide ();
            frmviewuncleareditems frm = new frmviewuncleareditems ();
            frm.Show ();
      
        }

        private void metroTile10_Click (object sender, EventArgs e)
        {
            frmviewpickeditems frm = new Forms.frmviewpickeditems ();
            frm.Show ();
            this.Hide ();
        }
    }
}
