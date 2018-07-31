using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using System.IO;
using System.Diagnostics;

namespace JobCardSystem.Forms
{
    public partial class frmbackupdb : MetroFramework.Forms.MetroForm
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public frmbackupdb ()
        {
            InitializeComponent ();
        }
        /// <summary>
        /// Function to capture and append errors to a file for easier  debugging
        /// </summary>
        /// <param name="strErrorText"></param>
        public static void writeErrorLog (string strErrorText)
        {
            try
            {
                ///Declare the filename from the errorlog
                string strFileName = "errorlog.txt";
                /*Declare the folder where the logfile has to be stored*/
                string strPath = Application.StartupPath;
                //Write the error text and the current date-time to the error file
                System.IO.File.AppendAllText (strPath + "\\" + strFileName, strErrorText + " - " + DateTime.Now.ToString ());
            }
            catch (Exception ex)
            {
                writeErrorLog ("Error in writeErrorLog: " + ex.Message);

            }
        }

        private void metroButton1_Click (object sender, EventArgs e)
        {
            Backup ();
        }
        //Initialize values
        private void Initialize ()
        {
            server = "localhost";
            database = "jobauto";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection (connectionString);
        }

        private void frmbackupdb_Load (object sender, EventArgs e)
        {
            Initialize ();
            Time ();
        }
        private void Time()
        {
            Timer MyTimer = new Timer ();
            MyTimer.Interval = (1 * 60 * 1000); // 1 mins
            MyTimer.Tick += new EventHandler (timer1_Tick);
            MyTimer.Enabled = true;
            MyTimer.Start ();
        }
        //open connection to database
        private bool OpenConnection ()
        {
            try
            {
                connection.Open ();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show ("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show ("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection ()
        {
            try
            {
                connection.Close ();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show (ex.Message);
                return false;
            }
        }
        //Backup
        public void Backup ()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "D:\\jobautobackup" + year + "-" + month + "-" + day +
                "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter (path);



                ProcessStartInfo psi = new ProcessStartInfo ();
                //psi.FileName = "mysqldump";
                psi.FileName = "C:\\xampp\\mysql\\bin\\mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format (@"-u{0} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start (psi);

                string output;
                output = process.StandardOutput.ReadToEnd ();
                file.WriteLine (output);
                process.WaitForExit ();
                MessageBox.Show ("Success , backup successful!");
                MessageBox.Show ("Check your file on:D:\\jobautobackup", "TWMS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MessageBox.Show (path, "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                file.Close ();
              
                process.Close ();
            }
            catch (IOException ex)
            {
                writeErrorLog (ex.Message);
                MessageBox.Show ("Error , unable to backup!");
            }
        }

        private void btncancel_Click (object sender, EventArgs e)
        {
            frmadminhome frm = new Forms.frmadminhome ();
            frm.Show ();
            this.Hide();

        }
        private void mytimerEvent (object sender, EventArgs e)
        {
            MessageBox.Show ("Hey ! Closing this one");
            this.Close ();
        }
        private void timer1_Tick (object sender, EventArgs e)
        {
            /*{
                DialogResult dialogresult = MetroFramework.MetroMessageBox.Show (this, "Session timeout backup service!,do you want to continue using it", "Automated Job  Card System", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogresult == DialogResult.Yes)
                {
                    //timer1.Start ();
                    // Have the timer fire repeated events (true is the default)
                    Time ();
                    //frmlogin At = new frmlogin ();
                    //At.Show ();
                    //this.Hide ();
                    // return;
                }
                else if (dialogresult == DialogResult.No)
                {
                    MessageBox.Show ("Goodbye", "Time Elapsed");
                    frmlogin At = new frmlogin ();
                    At.Show ();
                   
                    this.timer1 = new System.Windows.Forms.Timer (this.components);
                    this.Hide ();
                    //this.Close ();
                }
            }
            */
        }
    }
}
