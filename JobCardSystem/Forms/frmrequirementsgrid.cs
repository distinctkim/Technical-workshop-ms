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
    public partial class frmrequirementsgrid : MetroFramework.Forms.MetroForm 
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
        public frmrequirementsgrid ()
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
        private void fillgrid ()
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblreq");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvequipreq.DataSource = dt;

        }
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

        private void btnprint_Click (object sender, EventArgs e)
        {

            DGVPrinter printer = new DGVPrinter ();

            printer.Title = "Equipment Requirements Report";

            printer.SubTitle = "Requirements Information Summary";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = false;

            printer.HeaderCellAlignment = StringAlignment.Center;

            printer.Footer = "DIAMOND SYSTEMS LIMITED";

            printer.FooterSpacing = 10;



            printer.PrintDataGridView (kdvequipreq);
        }

        private void kdvequipreq_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            frmrequirements select = new frmrequirements ();
            select.txtrid.Text = kdvequipreq.CurrentRow.Cells [0].Value.ToString ();
            select.cmbxdid.Text = kdvequipreq.CurrentRow.Cells [1].Value.ToString ();
            select.txtequipmentid.Text = kdvequipreq.CurrentRow.Cells [2].Value.ToString ();
            select.txtequipmentname.Text = kdvequipreq.CurrentRow.Cells [3].Value.ToString ();
            select.txtequipmentserial.Text = kdvequipreq.CurrentRow.Cells [4].Value.ToString ();
            select.txtclientname.Text = kdvequipreq.CurrentRow.Cells [5].Value.ToString ();
            select.txtclientemail.Text = kdvequipreq.CurrentRow.Cells [6].Value.ToString ();
            select.txtreportedproblem.Text = kdvequipreq.CurrentRow.Cells [7].Value.ToString ();
            select.txtdiagnosisdone.Text = kdvequipreq.CurrentRow.Cells [8].Value.ToString ();
            select.cmbxhdw.Text = kdvequipreq.CurrentRow.Cells [9].Value.ToString ();
            select.txthditems.Text = kdvequipreq.CurrentRow.Cells [10].Value.ToString ();
            select.cmbxsft.Text = kdvequipreq.CurrentRow.Cells [11].Value.ToString ();
            select.txtsftitems.Text = kdvequipreq.CurrentRow.Cells [12].Value.ToString ();
            select.txtnotes.Text = kdvequipreq.CurrentRow.Cells [13].Value.ToString ();
            select.txtdate.Text = kdvequipreq.CurrentRow.Cells [14].Value.ToString ();


            //keen ();
            select.ShowDialog ();
            fillgrid ();
            this.Close ();
        }


        private void frmrequirementsgrid_Load (object sender, EventArgs e)
        {
            //fillgrid ();
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
                    DS = new DataSet ();
                    adapter.Fill (DS);
                    kdvequipreq.DataSource = DS.Tables [0];
                    kdvequipreq.Columns [1].HeaderText = "Did";
                    kdvequipreq.Columns [2].HeaderText = "Eid";
                    kdvequipreq.Columns [3].HeaderText = "EquipmentName";
                    kdvequipreq.Columns [4].HeaderText = "Equipmentserial";
                    kdvequipreq.Columns [5].HeaderText = "Client";
                    kdvequipreq.Columns [6].HeaderText = "Email";
                    kdvequipreq.Columns [7].HeaderText = "Issue";
                    kdvequipreq.Columns [8].HeaderText = "Diagnosis";
                    kdvequipreq.Columns [9].HeaderText = "CategoryHDW";
                    kdvequipreq.Columns [10].HeaderText = "HDWItem";
                    kdvequipreq.Columns [11].HeaderText = "CategorySFT";
                    kdvequipreq.Columns [12].HeaderText = "SFTItem";
                    kdvequipreq.Columns [13].HeaderText = "Notes";
                    kdvequipreq.Columns [14].HeaderText = "Date";

                    //close connection
                    this.CloseConnection ();
                    countreq ();
                }
                this.kdvequipreq.Columns [0].Visible = false;
                this.kdvequipreq.Columns [1].Visible = false;
                this.kdvequipreq.Columns [2].Visible = false;

            }
            catch (Exception ex)
            {
                writeErrorLog (ex.Message);
            }
        }
        public void countreq ()
        {
            txtutally.Text = DS.Tables [0].Rows.Count.ToString ();
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

        private void pictureBox1_Click (object sender, EventArgs e)
        {
            frmrequirements fm = new frmrequirements ();
            fm.Show ();
            this.Hide ();
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
            kdvequipreq.DataSource = dt;
            //fillfaultgrid ();
        }
        private void fillfaultgrid ()
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblreq");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvequipreq.DataSource = dt;

        }

        private void btnsearch_Click (object sender, EventArgs e)
        {

        }

        private void btnexport_Click (object sender, EventArgs e)
        {
            if (kdvequipreq.Rows.Count > 0)

            {

                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application ();

                XcelApp.Application.Workbooks.Add (Type.Missing);



                for (int i = 1; i < kdvequipreq.Columns.Count + 1; i++)

                {

                    XcelApp.Cells [1, i] = kdvequipreq.Columns [i - 1].HeaderText;

                }



                for (int i = 0; i < kdvequipreq.Rows.Count; i++)

                {

                    for (int j = 0; j < kdvequipreq.Columns.Count; j++)

                    {

                        XcelApp.Cells [i + 2, j + 1] = kdvequipreq.Rows [i].Cells [j].Value.ToString ();

                    }

                }

                XcelApp.Columns.AutoFit ();

                XcelApp.Visible = true;

            }
        }
    }
  }
 

