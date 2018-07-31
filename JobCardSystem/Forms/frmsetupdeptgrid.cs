using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;
using System.Windows.Forms;
using DGVPrinterHelper;


namespace JobCardSystem.Forms
{
   

    public partial class frmsetupdeptgrid : MetroFramework.Forms.MetroForm 
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
        public frmsetupdeptgrid ()
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

        private void frmsetupdeptgrid_Load (object sender, EventArgs e)
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
                    adapter = new MySqlDataAdapter ("select * from tbldept", connect);
                    DS = new DataSet ();
                    adapter.Fill (DS);
                    kdvdept.DataSource = DS.Tables [0];
                    kdvdept.Columns [1].HeaderText = "Department Name";
                    kdvdept.Columns [2].HeaderText = "Create Date";

                    //close connection
                    this.CloseConnection ();
                    countreq ();
                }
                this.kdvdept.Columns [0].Visible = false;

            }
            catch (Exception ex)
            {
                writeErrorLog (ex.Message);
            }
        }
        public void countreq ()
        {
            txtdtally.Text = DS.Tables [0].Rows.Count.ToString ();
        }
        private void kdvdept_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            frmsetupdepartments select = new frmsetupdepartments ();
            select.txtid.Text = kdvdept.CurrentRow.Cells [0].Value.ToString ();
            select.txtshiftdesc.Text = kdvdept.CurrentRow.Cells [1].Value.ToString ();
            select.txtcreatedate.Text = kdvdept.CurrentRow.Cells [2].Value.ToString ();
            keen ();
            select.ShowDialog ();
            filldeptgrid ();
            this.Close ();
        }
        private void keen ()
        {
            frmsetupdepartments select = new frmsetupdepartments ();
            select.txtid.Enabled = false;
            select.txtshiftdesc.Enabled = false;
            select.txtcreatedate.Enabled = false;
        }
        private void filldeptgrid ()
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tbldept");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvdept.DataSource = dt;

        }

        private void btnprint_Click (object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter ();

            printer.Title = "COMPANY DEPARTMENTS INFORMATION REPORT";

            printer.SubTitle = "DEPARTMENT INFORMATION SUMMARY";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.FitBlackBox;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = false;

            printer.HeaderCellAlignment = StringAlignment.Center;

            printer.Footer = "DIAMOND SYSTEMS LIMITED";

            printer.FooterSpacing = 10;



            printer.PrintDataGridView (kdvdept);
        }

        private void txtsearch_TextChanged (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tbldept where deptname like '%{0}%'", txtsearch.Text);
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvdept.DataSource = dt;
            //filldeptgrid ();
        }

        private void btnexcel_Click (object sender, EventArgs e)
        {
            if (kdvdept.Rows.Count > 0)

            {

                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application ();

                XcelApp.Application.Workbooks.Add (Type.Missing);



                for (int i = 1; i < kdvdept.Columns.Count + 1; i++)

                {

                    XcelApp.Cells [1, i] = kdvdept.Columns [i - 1].HeaderText;

                }



                for (int i = 0; i < kdvdept.Rows.Count; i++)

                {

                    for (int j = 0; j < kdvdept.Columns.Count; j++)

                    {

                        XcelApp.Cells [i + 2, j + 1] = kdvdept.Rows [i].Cells [j].Value.ToString ();

                    }

                }

                XcelApp.Columns.AutoFit ();

                XcelApp.Visible = true;

            }
        }

        private void pictureBox1_Click (object sender, EventArgs e)
        {

        }
  

        private void btnsearch_Click (object sender, EventArgs e)
        {

        }

        private void pckbx_Click (object sender, EventArgs e)
        {
            frmsetupdepartments depts = new Forms.frmsetupdepartments ();
            depts.Show ();
            this.Hide ();
        }
    }
 }
