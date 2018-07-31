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
using DGVPrinterHelper;

namespace JobCardSystem.Forms
{
    public partial class frmfaultdictionary : MetroFramework.Forms.MetroForm 
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
        public frmfaultdictionary ()
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

        private void frmfaultdictionary_Load (object sender, EventArgs e)
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
                    adapter = new MySqlDataAdapter ("select * from tblfaults", connect);
                    DS = new DataSet ();
                    adapter.Fill (DS);
                    kdvfaultdictionary.DataSource = DS.Tables [0];
                    kdvfaultdictionary.Columns [1].HeaderText = "Fault Description";
                    kdvfaultdictionary.Columns [2].HeaderText = "Solution Design";
                    kdvfaultdictionary.Columns [3].HeaderText = "Create Date";


                    //close connection
                    this.CloseConnection ();
                }
                this.kdvfaultdictionary.Columns [0].Visible = false;
                countfaults ();

            }
            catch (Exception ex)
            {
                writeErrorLog (ex.Message);
            }
        }
        public void countfaults()
        {
            txtfaulttally.Text = DS.Tables [0].Rows.Count.ToString ();
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

        private void btnprint_Click (object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter ();

            printer.Title = "FAULT INFORMATION REPORT";

            printer.SubTitle = "FAULT INFORMATION SUMMARY";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.FitBlackBox;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = false;

            printer.HeaderCellAlignment = StringAlignment.Center;

            printer.Footer = "DIAMOND SYSTEMS LIMITED";

            printer.FooterSpacing = 10;



            printer.PrintDataGridView (kdvfaultdictionary);
        }
        private void fillfaultgrid ()
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblfaults");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvfaultdictionary.DataSource = dt;

        }

        private void txtsearch_TextChanged (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblfaults where fdesc like '%{0}%'", txtsearch.Text);
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvfaultdictionary.DataSource = dt;
            //fillfaultgrid ();
        }

        private void btnsearch_Click (object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click (object sender, EventArgs e)
        {
            Home shw = new Home ();
            shw.Show ();
            this.Hide ();
        }

        private void button2_Click (object sender, EventArgs e)
        {

        }

        private void btnexptexcel_Click (object sender, EventArgs e)
        {
            if (kdvfaultdictionary.Rows.Count > 0)

            {

                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application ();

                XcelApp.Application.Workbooks.Add (Type.Missing);



                for (int i = 1; i < kdvfaultdictionary.Columns.Count + 1; i++)

                {

                    XcelApp.Cells [1, i] = kdvfaultdictionary.Columns [i - 1].HeaderText;

                }



                for (int i = 0; i < kdvfaultdictionary.Rows.Count; i++)

                {

                    for (int j = 0; j < kdvfaultdictionary .Columns.Count; j++)

                    {

                        XcelApp.Cells [i + 2, j + 1] = kdvfaultdictionary.Rows [i].Cells [j].Value.ToString ();

                    }

                }

                XcelApp.Columns.AutoFit ();

                XcelApp.Visible = true;

            }

        }
    }
 }
 

