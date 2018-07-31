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
using DGVPrinterHelper;
using MetroFramework.Forms;



namespace JobCardSystem.Forms
{
    public partial class frmlogequipgridadmin : MetroFramework.Forms.MetroForm
    {
        private string conn;
        private MySqlConnection connect;
       // MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
        private string server;
        private string database;
        private string uid;
        private string password;
        DataSet DS;
        MySqlCommand command;
        //MySqlDataAdapter adapter;
        DataTable table;
        public frmlogequipgridadmin ()
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
        private void frmlogequipgridadmin_Load (object sender, EventArgs e)
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
                    adapter = new MySqlDataAdapter ("select * from tbllogjb", connect);
                    DS = new DataSet ();
                    adapter.Fill (DS);
                    kdvclientequipmentgrid.DataSource = DS.Tables [0];
                    kdvclientequipmentgrid.Columns [1].HeaderText = "Group";
                    kdvclientequipmentgrid.Columns [2].HeaderText = "Description";
                    kdvclientequipmentgrid.Columns [3].HeaderText = "Model no";
                    kdvclientequipmentgrid.Columns [4].HeaderText = "Serial";
                    kdvclientequipmentgrid.Columns [5].HeaderText = "Issue";
                    kdvclientequipmentgrid.Columns [6].HeaderText = "Service Date";
                    kdvclientequipmentgrid.Columns [7].HeaderText = "Shift";
                    kdvclientequipmentgrid.Columns [8].HeaderText = "CreatedBy";
                    kdvclientequipmentgrid.Columns [9].HeaderText = "Status";
                    kdvclientequipmentgrid.Columns [10].HeaderText = "Id";

                    kdvclientequipmentgrid.Columns [11].HeaderText = "Client";
                    kdvclientequipmentgrid.Columns [12].HeaderText = "E-mail";
                    kdvclientequipmentgrid.Columns [13].HeaderText = "Mobile Number";
                    kdvclientequipmentgrid.Columns [14].HeaderText = "Contact mode";
                    kdvclientequipmentgrid.Columns [15].HeaderText = "Urgency";


                    //close connection
                    this.CloseConnection ();
                }
                this.kdvclientequipmentgrid.Columns [0].Visible = false;
                this.kdvclientequipmentgrid.Columns [10].Visible = false;
                this.kdvclientequipmentgrid.Columns [6].Visible = false;
                this.kdvclientequipmentgrid.Columns [7].Visible = false;
                this.kdvclientequipmentgrid.Columns [8].Visible = false;
                countequip ();

            }
            catch (Exception ex)
            {
                writeErrorLog (ex.Message);
            }
        }
        public void countequip ()
        {
            txtletally.Text = DS.Tables [0].Rows.Count.ToString ();
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
        public void searchData (string valueToSearch)
        {

            db_connection ();
            string query = "Select * from tbllogjb WHERE clientname like '%" + valueToSearch + "%'";
            command = new MySqlCommand (query, connect);
            adapter = new MySqlDataAdapter (command);
            table = new DataTable ();
            adapter.Fill (table);
            kdvclientequipmentgrid.DataSource = table;
        }
        private void textBox5_TextChanged (object sender, EventArgs e)
        {
            string valueToSearch = textBox5.Text.ToString ();
            searchData (valueToSearch);

            /*db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tbllogjb where clientname like '%{0}%'", textBox5.Text);
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvclientequipmentgrid.DataSource = dt;
            fillgrid ();*/
        }
        private void fillgrid ()
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tbllogjb");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvclientequipmentgrid.DataSource = dt;

        }

        private void pictureBox1_Click (object sender, EventArgs e)
        {
            frmadminhome frm = new frmadminhome ();
            frm.Show ();
            this.Hide ();
        }

        private void button4_Click (object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter ();

            printer.Title = "DSL CLIENT EQUIPMENT INFORMATION REPORT";

            printer.SubTitle = "CLIENT EQUIPMENT INFORMATION SUMMARY";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.FitBlackBox;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = false;

            printer.HeaderCellAlignment = StringAlignment.Center;

            printer.Footer = "DIAMOND SYSTEMS LIMITED";

            printer.FooterSpacing = 10;



            printer.PrintDataGridView (kdvclientequipmentgrid);
        }

        private void button3_Click (object sender, EventArgs e)
        {

        }

        private void kdvclientequipmentgrid_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
