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
using DGVPrinterHelper;
using MySql.Data.MySqlClient;
namespace JobCardSystem.Forms
{
    public partial class frmloadtarrifgrid : MetroFramework.Forms.MetroForm
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
        public frmloadtarrifgrid ()
        {
            InitializeComponent ();
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

        private void kryptonDataGridView1_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            frmsetuptarrifs select = new frmsetuptarrifs ();
            select.txtid.Text = kdvtarrifinfo.CurrentRow.Cells [0].Value.ToString ();
            select.txtStid.Text = kdvtarrifinfo.CurrentRow.Cells [1].Value.ToString ();
            select.cmbxdept.Text = kdvtarrifinfo.CurrentRow.Cells [2].Value.ToString ();
            select.txtdesc.Text = kdvtarrifinfo.CurrentRow.Cells [3].Value.ToString ();
            select.txtprice.Text = kdvtarrifinfo.CurrentRow.Cells [4].Value.ToString ();
            

            //keen ();
            select.txtid.Enabled = false;
            select.txtStid.Enabled = false;
            select.cmbxdept.Enabled = false;
            select.txtdesc.Enabled = false;
            select.txtprice.Enabled = false;
          
           
            select.ShowDialog ();
            this.Close ();
        }

        private void pictureBox1_Click (object sender, EventArgs e)
        {
            this.Hide ();
            frmsetuptarrifs tarrif = new frmsetuptarrifs  ();
           tarrif.Show ();
        }

        private void button4_Click (object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter ();

            printer.Title = "COMPANY EQUIPMENT TARRIF INFORMATION REPORT";

            printer.SubTitle = "CLIENT TARRIF INFORMATION SUMMARY";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.FitBlackBox;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = false;

            printer.HeaderCellAlignment = StringAlignment.Center;

            printer.Footer = "DIAMOND SYSTEMS LIMITED";

            printer.FooterSpacing = 10;



            printer.PrintDataGridView (kdvtarrifinfo);
        }

        private void textBox5_TextChanged (object sender, EventArgs e)
        {
            {
                db_connection ();
                MySqlConnection sqlcon = new MySqlConnection (conn);
                sqlcon.Open ();
                string query = string.Format ("Select * from tbltarrifs where tdesc like '%{0}%'", textBox5.Text);
                MySqlCommand cmd = new MySqlCommand (query, sqlcon);
                MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
                DataTable dt = new DataTable ();
                adpt.Fill (dt);
                kdvtarrifinfo.DataSource = dt;
                //fillgrid ();
            }
        }
        private void fillgrid ()
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tbltarrifs");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvtarrifinfo.DataSource = dt;

        }

        private void frmloadtarrifgrid_Load (object sender, EventArgs e)
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
                    adapter = new MySqlDataAdapter ("select * from tbltarrifs", connect);
                    DS = new DataSet ();
                    adapter.Fill (DS);
                    kdvtarrifinfo.DataSource = DS.Tables [0];
                    kdvtarrifinfo.Columns [1].HeaderText = "ItemRef";
                    kdvtarrifinfo.Columns [2].HeaderText = "Tarrif Description";
                    kdvtarrifinfo.Columns [3].HeaderText = "Service Name";
                    kdvtarrifinfo.Columns [4].HeaderText = "Unit Price";



                    //close connection
                    this.CloseConnection ();
                }
                this.kdvtarrifinfo.Columns [0].Visible = false;
                int sum = 0;
                for (int i = 0; i < kdvtarrifinfo.Rows.Count; ++i)
                {
                    int tmp = 0;
                    int.TryParse (kdvtarrifinfo.Rows [i].Cells [1].Value.ToString (), out tmp);
                    sum += tmp;
                }
                fillgrid ();
                countreq ();
            }
            catch (Exception ex)
            {
                writeErrorLog (ex.Message);
            }
        }
        public void countreq ()
        {
            txttatally.Text = DS.Tables [0].Rows.Count.ToString ();
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

        private void button3_Click (object sender, EventArgs e)
        {

        }

        private void button2_Click (object sender, EventArgs e)
        {
            if (kdvtarrifinfo.Rows.Count > 0)

            {

                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application ();

                XcelApp.Application.Workbooks.Add (Type.Missing);



                for (int i = 1; i < kdvtarrifinfo.Columns.Count + 1; i++)

                {

                    XcelApp.Cells [1, i] = kdvtarrifinfo.Columns [i - 1].HeaderText;

                }



                for (int i = 0; i < kdvtarrifinfo.Rows.Count; i++)

                {

                    for (int j = 0; j < kdvtarrifinfo.Columns.Count; j++)

                    {

                        XcelApp.Cells [i + 2, j + 1] = kdvtarrifinfo.Rows [i].Cells [j].Value.ToString ();

                    }

                }

                XcelApp.Columns.AutoFit ();

                XcelApp.Visible = true;

            }
        }
    }
 }

