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
    public partial class frmloadreqgrid : MetroFramework.Forms.MetroForm
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
        public frmloadreqgrid ()
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

        private void frmloadreqgrid_Load (object sender, EventArgs e)
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
                    adapter = new MySqlDataAdapter ("select * from tblreq", connect);
                    DataSet DS = new DataSet ();
                    adapter.Fill (DS);
                    kdvreqinfo.DataSource = DS.Tables [0];
                    kdvreqinfo.Columns [1].HeaderText = "Did";
                    kdvreqinfo.Columns [2].HeaderText = "EquipmentName";
                    kdvreqinfo.Columns [3].HeaderText = "EquipmentSerial";
                    kdvreqinfo.Columns [4].HeaderText = "ClientName";
                    kdvreqinfo.Columns [5].HeaderText = "ReportedProblem";
                    kdvreqinfo.Columns [6].HeaderText = "Diagnosis";
                    kdvreqinfo.Columns [7].HeaderText = "Category 1";
                    kdvreqinfo.Columns [8].HeaderText = "HardwareItem";
                    kdvreqinfo.Columns [9].HeaderText = "Category 2";
                    kdvreqinfo.Columns [10].HeaderText = "SoftwareItem";
                    kdvreqinfo.Columns [11].HeaderText = "Notes";
                    kdvreqinfo.Columns [12].HeaderText = "Create Date";


                    //close connection
                    this.CloseConnection ();
                }
                this.kdvreqinfo.Columns [0].Visible = false;
                this.kdvreqinfo.Columns [7].Visible = false;
                this.kdvreqinfo.Columns [9].Visible = false;
                this.kdvreqinfo.Columns [11].Visible = false;
                countreq ();
               

            }
            catch (Exception ex)
            {
                writeErrorLog(ex.Message);
            }
        }
        public void countreq ()
        {
            txtreqtally.Text = DS.Tables [0].Rows.Count.ToString ();
        }

        private void kdvreqinfo_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            frmrequirements select = new frmrequirements ();
            select.txtrid.Text = kdvreqinfo.CurrentRow.Cells [0].Value.ToString ();
            select.cmbxdid.Text = kdvreqinfo.CurrentRow.Cells [1].Value.ToString ();
            select.txtequipmentid.Text = kdvreqinfo.CurrentRow.Cells [2].Value.ToString ();
            select.txtequipmentname.Text = kdvreqinfo.CurrentRow.Cells [3].Value.ToString ();
            select.txtequipmentserial.Text = kdvreqinfo.CurrentRow.Cells [4].Value.ToString ();
            select.txtclientname.Text = kdvreqinfo.CurrentRow.Cells [5].Value.ToString ();
            select.txtreportedproblem.Text = kdvreqinfo.CurrentRow.Cells [6].Value.ToString ();
            select.txtdiagnosisdone.Text = kdvreqinfo.CurrentRow.Cells [7].Value.ToString ();
            select.cmbxhdw.Text = kdvreqinfo.CurrentRow.Cells [8].Value.ToString ();
            select.txthditems.Text = kdvreqinfo.CurrentRow.Cells [9].Value.ToString ();
            select.cmbxsft.Text = kdvreqinfo.CurrentRow.Cells [10].Value.ToString ();
            select.txtsftitems.Text = kdvreqinfo.CurrentRow.Cells [11].Value.ToString ();
            select.txtnotes.Text = kdvreqinfo.CurrentRow.Cells [12].Value.ToString ();
            select.txtdate.Text = kdvreqinfo.CurrentRow.Cells [13].Value.ToString ();
            this.Close ();

        }

        private void textBox5_TextChanged (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblreq where cname like '%{0}%'", textBox5.Text);
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvreqinfo.DataSource = dt;
        }

        private void pictureBox1_Click (object sender, EventArgs e)
        {

        }

        private void button4_Click (object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter ();

            printer.Title = "COMPANY CLIENT EQUIPMENT INFORMATION REPORT";

            printer.SubTitle = "CLIENT EQUIPMENT REQUIREMENTS INFORMATION SUMMARY";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.FitBlackBox;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = false;

            printer.HeaderCellAlignment = StringAlignment.Center;

            printer.Footer = "DIAMOND SYSTEMS LIMITED";

            printer.FooterSpacing = 10;



            printer.PrintDataGridView (kdvreqinfo);
        }

        private void button2_Click (object sender, EventArgs e)
        {
            if (kdvreqinfo.Rows.Count > 0)

            {

                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application ();

                XcelApp.Application.Workbooks.Add (Type.Missing);



                for (int i = 1; i <kdvreqinfo.Columns.Count + 1; i++)

                {

                    XcelApp.Cells [1, i] = kdvreqinfo.Columns [i - 1].HeaderText;

                }



                for (int i = 0; i < kdvreqinfo.Rows.Count; i++)

                {

                    for (int j = 0; j < kdvreqinfo.Columns.Count; j++)

                    {

                        XcelApp.Cells [i + 2, j + 1] = kdvreqinfo.Rows [i].Cells [j].Value.ToString ();

                    }

                }

                XcelApp.Columns.AutoFit ();

                XcelApp.Visible = true;

            }
        }

        private void label1_Click (object sender, EventArgs e)
        {

        }

        private void button3_Click (object sender, EventArgs e)
        {

        }
    }
}
