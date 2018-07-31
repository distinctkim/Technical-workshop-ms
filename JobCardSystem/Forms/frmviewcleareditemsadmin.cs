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
using DGVPrinterHelper;

namespace JobCardSystem.Forms
{
    public partial class frmviewcleareditemsadmin : MetroFramework.Forms.MetroForm
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
        public frmviewcleareditemsadmin ()
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

        private void frmviewcleareditems_Load (object sender, EventArgs e)
        {
           
        }
        public void total ()
        {
            double sum = 0;
            for (int i = 0; i < kdvclientequipmentgrid.Rows.Count; ++i)
            {
                sum += Convert.ToDouble (kdvclientequipmentgrid.Rows [i].Cells [22].Value);
            }
            txttamnt.Text = sum.ToString ();

        }
        public void totalre ()
        {
            double sum = 0;
            for (int i = 0; i < kdvclientequipmentgrid.Rows.Count; ++i)
            {
                sum += Convert.ToDouble (kdvclientequipmentgrid.Rows [i].Cells [23].Value);
            }
            txtre.Text = sum.ToString ();

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
                    adapter = new MySqlDataAdapter ("select * from tblbill WHERE status = 'Item Cleared'", connect);
                    DS = new DataSet ();
                    adapter.Fill (DS);
                    kdvclientequipmentgrid.DataSource = DS.Tables [0];
                    kdvclientequipmentgrid.Columns [1].HeaderText = "ConfirmID";
                    kdvclientequipmentgrid.Columns [2].HeaderText = "QuoteID";
                    kdvclientequipmentgrid.Columns [3].HeaderText = "RequirementID";
                    kdvclientequipmentgrid.Columns [4].HeaderText = "EquipmentID";
                    kdvclientequipmentgrid.Columns [5].HeaderText = "Equipmentname";
                    kdvclientequipmentgrid.Columns [6].HeaderText = "EquipmentSerial";
                    kdvclientequipmentgrid.Columns [7].HeaderText = "ClientName";
                    kdvclientequipmentgrid.Columns [8].HeaderText = "ClientEmail";
                    kdvclientequipmentgrid.Columns [9].HeaderText = "Issue";
                    kdvclientequipmentgrid.Columns [10].HeaderText = "Diagnosis";
                    kdvclientequipmentgrid.Columns [11].HeaderText = "HardwareItems";
                    kdvclientequipmentgrid.Columns [12].HeaderText = "SoftwareItems";
                    kdvclientequipmentgrid.Columns [13].HeaderText = "HardwareSerial";
                    kdvclientequipmentgrid.Columns [14].HeaderText = "Progress Status";
                    kdvclientequipmentgrid.Columns [15].HeaderText = "Assigned Technician";
                    kdvclientequipmentgrid.Columns [16].HeaderText = "Technician Summary";
                    kdvclientequipmentgrid.Columns [17].HeaderText = "Notes";
                    kdvclientequipmentgrid.Columns [18].HeaderText = "QuoteAmount";
                    kdvclientequipmentgrid.Columns [19].HeaderText = "TaxRate";
                    kdvclientequipmentgrid.Columns [20].HeaderText = "TaxAmount";
                    kdvclientequipmentgrid.Columns [21].HeaderText = "GrossAmount";
                    kdvclientequipmentgrid.Columns [22].HeaderText = "Paid Amount";
                    kdvclientequipmentgrid.Columns [23].HeaderText = "Balance";
                    kdvclientequipmentgrid.Columns [24].HeaderText = "Status";
                    kdvclientequipmentgrid.Columns [25].HeaderText = "BillingDate";
                    kdvclientequipmentgrid.Columns [26].HeaderText = "QuoteDate";


                    //close connection
                    this.CloseConnection ();
                }
                this.kdvclientequipmentgrid.Columns [0].Visible = false;
                this.kdvclientequipmentgrid.Columns [1].Visible = false;
                this.kdvclientequipmentgrid.Columns [2].Visible = false;
                this.kdvclientequipmentgrid.Columns [3].Visible = false;
                this.kdvclientequipmentgrid.Columns [4].Visible = false;
                this.kdvclientequipmentgrid.Columns [5].Visible = false;
                this.kdvclientequipmentgrid.Columns [18].Visible = false;
                countreq ();
                total ();
                totalre ();
                txtresamnt.Text = Convert.ToString (Convert.ToDouble (txttamnt.Text) - Convert.ToDouble (txtre.Text));

            }
            catch (Exception ex)
            {
                writeErrorLog (ex.Message);
            }
        }

        private void frmviewcleareditemsadmin_Load (object sender, EventArgs e)
        {
            load ();
        }

        private void button4_Click (object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter ();

            printer.Title = "COMPANY CLEARED CLIENT EQUIPMENT INFORMATION REPORT";

            printer.SubTitle = " CLEARED CLIENT EQUIPMENT INFORMATION SUMMARY";

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
            this.Hide ();
            frmreportsmenu frm = new Forms.frmreportsmenu ();
            frm.Show ();
        }

        private void kdvclientequipmentgrid_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("select * from tblbill where cname like '%{0}%'", textBox5.Text);
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
