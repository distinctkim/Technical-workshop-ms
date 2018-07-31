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
namespace JobCardSystem.Forms
{
    public partial class frmconfirmedItemsreport : MetroFramework.Forms.MetroForm 
    {
        private string conn;
        private MySqlConnection connect;
        //MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
        private string server;
        private string database;
        private string uid;
        private string password;
        DataSet DS;
        public frmconfirmedItemsreport ()
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

        private void frmconfirmedItemsreport_Load (object sender, EventArgs e)
        {

            try
            {
                server = "localhost";
                database = "jobauto";
                uid = "root";
                password = "";

                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                connect = new MySqlConnection (connectionString);
                if (this.OpenConnection () == true)
                {
                    adapter = new MySqlDataAdapter ("select * from tblconequip WHERE status = 'Completed'", connect);
                    DS = new DataSet ();
                    adapter.Fill (DS);
                    kdvequipcon.DataSource = DS.Tables [0];
                    kdvequipcon.Columns [1].HeaderText = "Qid";
                    kdvequipcon.Columns [2].HeaderText = "Rid";
                    kdvequipcon.Columns [3].HeaderText = "Eid";
                    kdvequipcon.Columns [4].HeaderText = "EquipmentName";
                    kdvequipcon.Columns [5].HeaderText = "Equipmentserial";
                    kdvequipcon.Columns [6].HeaderText = "Client";
                    kdvequipcon.Columns [7].HeaderText = "Email";
                    kdvequipcon.Columns [8].HeaderText = "Issue";
                    kdvequipcon.Columns [9].HeaderText = "Diagnosis";
                    kdvequipcon.Columns [10].HeaderText = "HDWItem";
                    kdvequipcon.Columns [11].HeaderText = "SFTItem";
                    kdvequipcon.Columns [12].HeaderText = "SerialNo";
                    kdvequipcon.Columns [13].HeaderText = "Status";
                    kdvequipcon.Columns [14].HeaderText = "Technician";
                    kdvequipcon.Columns [15].HeaderText = "Summary";
                    kdvequipcon.Columns [16].HeaderText = "Notes";
                    kdvequipcon.Columns [17].HeaderText = "Date";

                    //close connection
                    this.CloseConnection ();
                    countreq ();
                }
                this.kdvequipcon.Columns [0].Visible = false;
            }
            catch (Exception ex)
            {
                writeErrorLog (ex.Message);
            }
            Timer MyTimer = new Timer ();
            MyTimer.Interval = (5 * 60 * 1000); // 5 mins
            MyTimer.Tick += new EventHandler (timer1_Tick);
            MyTimer.Start ();
        }
        public void countreq ()
        {
            txtqtally.Text = DS.Tables [0].Rows.Count.ToString ();
        }
        //open connection to database
        private bool OpenConnection ()
        {
            try
            {
                connect.Open ();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        writeErrorLog (ex.Message);
                        MessageBox.Show ("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        writeErrorLog (ex.Message);
                        MessageBox.Show ("Invalid username/password, please try again");
                        break;
                    default:
                        writeErrorLog (ex.Message);
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
                connect.Close ();
                return true;
            }
            catch (MySqlException ex)
            {
                writeErrorLog (ex.Message);
                return false;
            }
        }

        private void button2_Click (object sender, EventArgs e)
        {
            if (kdvequipcon.Rows.Count > 0)

            {

                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application ();

                XcelApp.Application.Workbooks.Add (Type.Missing);



                for (int i = 1; i < kdvequipcon.Columns.Count + 1; i++)

                {

                    XcelApp.Cells [1, i] = kdvequipcon.Columns [i - 1].HeaderText;

                }



                for (int i = 0; i < kdvequipcon .Rows.Count; i++)

                {

                    for (int j = 0; j < kdvequipcon.Columns.Count; j++)

                    {

                        XcelApp.Cells [i + 2, j + 1] = kdvequipcon.Rows [i].Cells [j].Value.ToString ();

                    }

                }

                XcelApp.Columns.AutoFit ();

                XcelApp.Visible = true;

            }
        }

        private void txtclient_TextChanged (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblconequip where cname like '%{0}%'", txtclient.Text);
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvequipcon.DataSource = dt;
        }
        private void db_connection ()
        {
            try
            {
                conn = "Server=localhost;Database=jobauto;Uid=root;Pwd=;";
                connect = new MySqlConnection (conn);
                connect.Open ();
                //MessageBox.Show ("be");
            }
            catch (Exception ex)

            {
                writeErrorLog (ex.Message);
                MetroFramework.MetroMessageBox.Show (this, "Failed to connect to database", "Automated Job  Card System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close ();
                Application.Exit ();
                return;
            }
        }

        private void pictureBox1_Click (object sender, EventArgs e)
        {
            frmreportsmenu frm = new Forms.frmreportsmenu ();
            frm.Show ();
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

    }
}
