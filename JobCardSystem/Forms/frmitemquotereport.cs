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

using Excel = Microsoft.Office.Interop.Excel;
namespace JobCardSystem.Forms
{
    public partial class frmitemquotereport : MetroFramework.Forms.MetroForm 
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
        public frmitemquotereport ()
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
        private void frmitemquotereport_Load (object sender, EventArgs e)
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
                    adapter = new MySqlDataAdapter ("select * from tblquote", connect);
                    DS = new DataSet ();
                    adapter.Fill (DS);
                    kdvquoteinfo.DataSource = DS.Tables [0];

                    kdvquoteinfo.Columns [1].HeaderText = "Rid";
                    kdvquoteinfo.Columns [2].HeaderText = "Eid";
                    kdvquoteinfo.Columns [3].HeaderText = "Equipmentname";
                    kdvquoteinfo.Columns [4].HeaderText = "Equipmentserial";
                    kdvquoteinfo.Columns [5].HeaderText = "ClientName";
                    kdvquoteinfo.Columns [6].HeaderText = "ClientEmail";

                    kdvquoteinfo.Columns [7].HeaderText = "ReportedIssue";
                    kdvquoteinfo.Columns [8].HeaderText = "Diagnosis";
                    kdvquoteinfo.Columns [9].HeaderText = "Category 1";
                    kdvquoteinfo.Columns [10].HeaderText = "Category 2";
                    kdvquoteinfo.Columns [11].HeaderText = "Hardware";
                    kdvquoteinfo.Columns [12].HeaderText = "Software";
                    kdvquoteinfo.Columns [13].HeaderText = "QuoteAmount";
                    kdvquoteinfo.Columns [14].HeaderText = "TaxRate";
                    kdvquoteinfo.Columns [15].HeaderText = "TaxAmount";
                    kdvquoteinfo.Columns [16].HeaderText = "Total";

                    //close connection
                    this.CloseConnection ();
                }
                this.kdvquoteinfo.Columns [0].Visible = false;
                this.kdvquoteinfo.Columns [1].Visible = false;
                this.kdvquoteinfo.Columns [2].Visible = false;
                //this.kdvquoteinfo.Columns [7].Visible = false;
                this.kdvquoteinfo.Columns [10].Visible = false;
                this.kdvquoteinfo.Columns [9].Visible = false;
                //this.kdvquoteinfo.Columns [10].Visible = false;
                this.kdvquoteinfo.Columns [12].Visible = false;
                countreq ();

            }
            catch (Exception ex)
            {
                writeErrorLog (ex.Message);
            }
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
            if (kdvquoteinfo.Rows.Count > 0)

            {

                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application ();

                XcelApp.Application.Workbooks.Add (Type.Missing);



                for (int i = 1; i < kdvquoteinfo.Columns.Count + 1; i++)

                {

                    XcelApp.Cells [1, i] = kdvquoteinfo.Columns [i - 1].HeaderText;

                }



                for (int i = 0; i < kdvquoteinfo.Rows.Count; i++)

                {

                    for (int j = 0; j < kdvquoteinfo.Columns.Count; j++)

                    {

                        XcelApp.Cells [i + 2, j + 1] = kdvquoteinfo.Rows [i].Cells [j].Value.ToString ();

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
            string query = string.Format ("Select * from tblquote where cname like '%{0}%'", txtclient.Text);
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvquoteinfo.DataSource = dt;
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
    }
}
