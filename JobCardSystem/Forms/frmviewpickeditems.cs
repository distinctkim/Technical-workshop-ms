﻿using System;
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
    public partial class frmviewpickeditems : MetroFramework.Forms.MetroForm 
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
        public frmviewpickeditems ()
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
        private void load()
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
                    adapter = new MySqlDataAdapter ("select * from tblcleareditems WHERE pickupstatus = 'Picked'", connect);
                    DS = new DataSet ();
                    adapter.Fill (DS);
                    kdvclientequipmentgrid.DataSource = DS.Tables [0];
                    kdvclientequipmentgrid.Columns [1].HeaderText = "BillID";
                    kdvclientequipmentgrid.Columns [2].HeaderText = "ConfirmationID";
                    kdvclientequipmentgrid.Columns [3].HeaderText = "PickupDate";
                    kdvclientequipmentgrid.Columns [4].HeaderText = "ConfirmationDate";
                    kdvclientequipmentgrid.Columns [5].HeaderText = "BillingDate";
                    kdvclientequipmentgrid.Columns [6].HeaderText = "EquipmentID";
                    kdvclientequipmentgrid.Columns [7].HeaderText = "EquipmentName";
                    kdvclientequipmentgrid.Columns [8].HeaderText = "EquipmentSerial";
                    kdvclientequipmentgrid.Columns [9].HeaderText = "ClientName";
                    kdvclientequipmentgrid.Columns [10].HeaderText = "ClientEmail";
                    kdvclientequipmentgrid.Columns [11].HeaderText = "QuoteAmount";
                    kdvclientequipmentgrid.Columns [12].HeaderText = "TaxRate";
                    kdvclientequipmentgrid.Columns [13].HeaderText = "TaxAmount";
                    kdvclientequipmentgrid.Columns [14].HeaderText = "GrossAmount";
                    kdvclientequipmentgrid.Columns [15].HeaderText = "PaidAmount";
                    kdvclientequipmentgrid.Columns [16].HeaderText = "Balance";
                    kdvclientequipmentgrid.Columns [17].HeaderText = "Status";
                    kdvclientequipmentgrid.Columns [18].HeaderText = "PickupStatus";




                    //close connection
                    this.CloseConnection ();
                }
                this.kdvclientequipmentgrid.Columns [0].Visible = false;
                this.kdvclientequipmentgrid.Columns [1].Visible = false;
                this.kdvclientequipmentgrid.Columns [2].Visible = false;
                this.kdvclientequipmentgrid.Columns [4].Visible = false;
                this.kdvclientequipmentgrid.Columns [5].Visible = false;
                this.kdvclientequipmentgrid.Columns [6].Visible = false;
                countreq ();

            }
            catch (Exception ex)
            {
                writeErrorLog (ex.Message);
            }
        }

        private void frmviewpickeditems_Load (object sender, EventArgs e)
        {
          
        }
        public void countreq ()
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

        private void button4_Click (object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter ();

            printer.Title = "COMPANY PICKED CLIENT EQUIPMENT INFORMATION REPORT";

            printer.SubTitle = " PICKED CLIENT EQUIPMENT INFORMATION SUMMARY";

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

        private void button2_Click (object sender, EventArgs e)
        {
            if (kdvclientequipmentgrid.Rows.Count > 0)

            {

                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application ();

                XcelApp.Application.Workbooks.Add (Type.Missing);



                for (int i = 1; i < kdvclientequipmentgrid.Columns.Count + 1; i++)

                {

                    XcelApp.Cells [1, i] = kdvclientequipmentgrid.Columns [i - 1].HeaderText;

                }



                for (int i = 0; i < kdvclientequipmentgrid.Rows.Count; i++)

                {

                    for (int j = 0; j < kdvclientequipmentgrid.Columns.Count; j++)

                    {

                        XcelApp.Cells [i + 2, j + 1] = kdvclientequipmentgrid.Rows [i].Cells [j].Value.ToString ();

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

        private void kdvclientequipmentgrid_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblcleareditems where cname like '%{0}%'", textBox5.Text);
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvclientequipmentgrid.DataSource = dt;
        }

        private void button1_Click (object sender, EventArgs e)
        {
            load ();
        }
    }
}