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
using Excel = Microsoft.Office.Interop.Excel;
namespace JobCardSystem.Forms
{
    public partial class frmItemdiagnosisreport : MetroFramework.Forms.MetroForm
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
        public frmItemdiagnosisreport ()
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

        private void frmItemdiagnosisreport_Load (object sender, EventArgs e)
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
                    adapter = new MySqlDataAdapter ("select * from tblequipdiagnosis", connect);
                    DS = new DataSet ();
                    adapter.Fill (DS);
                    kdvequipdiagnosis.DataSource = DS.Tables [0];
                    kdvequipdiagnosis.Columns [1].HeaderText = "Issue";
                    kdvequipdiagnosis.Columns [2].HeaderText = "Findings";
                    kdvequipdiagnosis.Columns [3].HeaderText = "Status";
                    kdvequipdiagnosis.Columns [4].HeaderText = "AssignedTechnician";
                    kdvequipdiagnosis.Columns [5].HeaderText = "Duration";
                    kdvequipdiagnosis.Columns [6].HeaderText = "ResponseTime";
                    kdvequipdiagnosis.Columns [7].HeaderText = "Reason";
                    kdvequipdiagnosis.Columns [8].HeaderText = "Comment";
                    kdvequipdiagnosis.Columns [9].HeaderText = "EquipID";
                    kdvequipdiagnosis.Columns [10].HeaderText = "Equipment";
                    kdvequipdiagnosis.Columns [11].HeaderText = "Serial";
                    kdvequipdiagnosis.Columns [12].HeaderText = "ClientName";
                    kdvequipdiagnosis.Columns [13].HeaderText = "Urgency";
                    kdvequipdiagnosis.Columns [14].HeaderText = "Email";

                    //close connection
                    this.CloseConnection ();
                }
                this.kdvequipdiagnosis.Columns [0].Visible = false;
                this.kdvequipdiagnosis.Columns [7].Visible = false;
                this.kdvequipdiagnosis.Columns [8].Visible = false;

                int sum = 0;
                for (int i = 0; i < kdvequipdiagnosis.Rows.Count; ++i)
                {
                    int tmp = 0;
                    int.TryParse (kdvequipdiagnosis.Rows [i].Cells [1].Value.ToString (), out tmp);
                    sum += tmp;
                }
                count ();
            }
            catch (Exception ex)
            {
                writeErrorLog (ex.Message);

            }
        }
        public void count ()
        {
            txtdtally.Text = DS.Tables [0].Rows.Count.ToString ();
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
                        MessageBox.Show ("Cannot connect to server. Contact administrator");
                        writeErrorLog (ex.Message);
                        break;
                    case 1045:
                        MessageBox.Show ("Invalid username/password, please try again");
                        writeErrorLog (ex.Message);
                        break;
                    default:
                        MessageBox.Show (ex.Message);
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

                //MessageBox.Show (ex.Message);
                return false;
            }
        }

        private void txtfrom_TextChanged (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblequipdiagnosis where client like '%{0}%'", txtclient.Text);
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvequipdiagnosis.DataSource = dt;
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

        private void button2_Click (object sender, EventArgs e)
        {
            if (kdvequipdiagnosis.Rows.Count > 0)

            {

                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application ();

                XcelApp.Application.Workbooks.Add (Type.Missing);



                for (int i = 1; i < kdvequipdiagnosis.Columns.Count + 1; i++)

                {

                    XcelApp.Cells [1, i] = kdvequipdiagnosis.Columns [i - 1].HeaderText;

                }



                for (int i = 0; i < kdvequipdiagnosis.Rows.Count; i++)

                {

                    for (int j = 0; j < kdvequipdiagnosis.Columns.Count; j++)

                    {

                        XcelApp.Cells [i + 2, j + 1] = kdvequipdiagnosis.Rows [i].Cells [j].Value.ToString ();

                    }

                }

                XcelApp.Columns.AutoFit ();

                XcelApp.Visible = true;

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

