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
using MySql.Data.MySqlClient;
using System.Configuration;
namespace JobCardSystem.Forms
{
    public partial class frmcheckconn : MetroFramework.Forms.MetroForm 
    {
        private string conn;
        private MySqlConnection connect;
        public frmcheckconn ()
        {
            InitializeComponent ();
        }

        private void label1_Click (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            db_connection ();
            this.Hide ();
            frmlogin frm = new frmlogin ();
            frm.Show ();

        }
        private void db_connection ()
        {
            try
            {
                conn = "Server=127.0.0.1;Port=3306;Database=jobauto;Uid=root;Pwd=;Encrypt=true;";
                connect = new MySqlConnection (conn);
                connect.Open ();
                MetroFramework.MetroMessageBox.Show (this, "Connection successful", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
            catch (Exception)

            {
                MetroFramework.MetroMessageBox.Show (this, "Failed to connect to database,contact administrator", "Automated Job  Card System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close ();
                Application.Exit ();
                return;
            }
        }

        private void button2_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (textBox1.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty field Server address", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (textBox2.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty field Port Number", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (textBox3.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty field Database name", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (textBox4.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty field Username", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            try
            {
                conn = "Server="+textBox1.Text+ ";Port=" + textBox2.Text + ";Database=" + textBox3.Text + ";Uid=" + textBox4.Text + ";Pwd=;Encrypt=true;";
                connect = new MySqlConnection (conn);
                connect.Open ();
                MetroFramework.MetroMessageBox.Show (this, "Connection successful", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)

            {
                MetroFramework.MetroMessageBox.Show (this, "Failed to connect to database,contact administrator", "Automated Job  Card System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close ();
                Application.Exit ();
                return;
            }
        }
        private void clear()
        {
            textBox1.Clear ();
            textBox2.Clear ();
            textBox3.Clear ();
            textBox4.Clear ();


        }

        private void frmcheckconn_Load (object sender, EventArgs e)
        {
            Timer MyTimer = new Timer ();
            MyTimer.Interval = (5 * 60 * 1000); // 5 mins
            MyTimer.Tick += new EventHandler (timer1_Tick);
            MyTimer.Start ();
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
            }
            */
        }
    }
}
