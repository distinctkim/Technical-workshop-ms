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
    public partial class frmconfirmequipmentgrid : MetroFramework.Forms.MetroForm 
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
        public frmconfirmequipmentgrid ()
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
            string query = string.Format ("Select * from tblconequip");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvequipcon.DataSource = dt;

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

        private void pictureBox1_Click (object sender, EventArgs e)
        {
            frmconfirmequipment frm = new frmconfirmequipment ();
            frm.Show ();
            this.Hide ();

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

        private void frmconfirmequipmentgrid_Load (object sender, EventArgs e)
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
                    adapter = new MySqlDataAdapter ("select * from tblconequip", connect);
                    DS = new DataSet ();
                    adapter.Fill (DS);
                    kdvequipcon.DataSource = DS.Tables [0];
                    kdvequipcon.Columns [1].HeaderText = "Qid";
                    kdvequipcon.Columns [2].HeaderText = "Rid";
                    kdvequipcon.Columns [3].HeaderText = "Eid";
                    kdvequipcon.Columns [4].HeaderText = "EquipmentName";
                    kdvequipcon.Columns [5].HeaderText = "Equipmentserial";
                    kdvequipcon.Columns [6].HeaderText = "Client";
                    kdvequipcon.Columns [7].HeaderText = "Email";

                    kdvequipcon.Columns [8].HeaderText = "Issue";
                    kdvequipcon.Columns [9].HeaderText = "Diagnosis";
                    kdvequipcon.Columns [10].HeaderText = "HDWItem";
                    kdvequipcon.Columns [11].HeaderText = "SFTItem";
                    kdvequipcon.Columns [12].HeaderText = "SerialNo";
                    kdvequipcon.Columns [13].HeaderText = "Status";
                    kdvequipcon.Columns [14].HeaderText = "Technician";
                    kdvequipcon.Columns [15].HeaderText = "Summary";
                    kdvequipcon.Columns [16].HeaderText = "Notes";
                    kdvequipcon.Columns [17].HeaderText = "Date";
                    kdvequipcon.Columns [18].HeaderText = "Quote Amount";
                    kdvequipcon.Columns [19].HeaderText = "Rate";
                    kdvequipcon.Columns [20].HeaderText = "Tax Amount";
                    kdvequipcon.Columns [21].HeaderText = "Gross Amount";

                    //close connection
                    this.CloseConnection ();
                    countreq ();
                }
                this.kdvequipcon.Columns [0].Visible = false;
                this.kdvequipcon.Columns [1].Visible = false;
                this.kdvequipcon.Columns [2].Visible = false;
                this.kdvequipcon.Columns [3].Visible = false;
            }
            catch (Exception ex)
            {
                writeErrorLog (ex.Message);
            }
           /* Timer MyTimer = new Timer ();
            MyTimer.Interval = (5 * 60 * 1000); // 5 mins
            MyTimer.Tick += new EventHandler (timer1_Tick);
            MyTimer.Start ();*/
        }

        private void btnprint_Click (object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter ();

            printer.Title = "Equipment Confirmation Report";

            printer.SubTitle = "Equipment Summary";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = false;

            printer.HeaderCellAlignment = StringAlignment.Center;

            printer.Footer = "DIAMOND SYSTEMS LIMITED";

            printer.FooterSpacing = 10;



            printer.PrintDataGridView (kdvequipcon);
        }

        private void kdvequipcon_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            frmconfirmequipment select = new Forms.frmconfirmequipment ();
            select.txtrcid.Text = kdvequipcon.CurrentRow.Cells [0].Value.ToString ();
            select.cmbxqid.Text = kdvequipcon.CurrentRow.Cells [1].Value.ToString ();
            select.txtrid.Text = kdvequipcon.CurrentRow.Cells [2].Value.ToString ();
            select.txtequipmentid.Text = kdvequipcon.CurrentRow.Cells [3].Value.ToString ();
            select.txtequipmentname.Text = kdvequipcon.CurrentRow.Cells [4].Value.ToString ();
            select.txtequipmentserial.Text = kdvequipcon.CurrentRow.Cells [5].Value.ToString ();
            select.txtclientname.Text = kdvequipcon.CurrentRow.Cells [6].Value.ToString ();
            select.txtclientemail.Text = kdvequipcon.CurrentRow.Cells [7].Value.ToString ();
            select.txtreportedproblem.Text = kdvequipcon.CurrentRow.Cells [8].Value.ToString ();
            select.txtdiagnosisdone.Text = kdvequipcon.CurrentRow.Cells [9].Value.ToString ();
            select.txthditems.Text = kdvequipcon.CurrentRow.Cells [10].Value.ToString ();
            select.txtsftitems.Text = kdvequipcon.CurrentRow.Cells [11].Value.ToString ();
            select.txthwserial.Text = kdvequipcon.CurrentRow.Cells [12].Value.ToString ();
            select.cmbxstatus.Text = kdvequipcon.CurrentRow.Cells [13].Value.ToString ();
            select.cmbxassignedtech.Text = kdvequipcon.CurrentRow.Cells [14].Value.ToString ();
            select.cmbxtechsum.Text = kdvequipcon.CurrentRow.Cells [15].Value.ToString ();
            select.txtnotes.Text = kdvequipcon.CurrentRow.Cells [16].Value.ToString ();
            select.txtdate.Text = kdvequipcon.CurrentRow.Cells [17].Value.ToString ();
            select.txtqamnt.Text = kdvequipcon.CurrentRow.Cells [18].Value.ToString ();
            select.txttaxrate.Text = kdvequipcon.CurrentRow.Cells [19].Value.ToString ();
            select.txttxamnt.Text = kdvequipcon.CurrentRow.Cells [20].Value.ToString ();
            select.txtgamnt.Text = kdvequipcon.CurrentRow.Cells [21].Value.ToString ();

            //keen ();
            select.ShowDialog ();
            fillgrid ();
            this.Close ();
        
        }

        private void textBox5_TextChanged (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblconequip where cname like '%{0}%'", textBox5.Text);
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvequipcon.DataSource = dt;
        }

        private void btnsearch_Click (object sender, EventArgs e)
        {

        }

        private void btnexport_Click (object sender, EventArgs e)
        {
            if (kdvequipcon.Rows.Count > 0)

            {

                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application ();

                XcelApp.Application.Workbooks.Add (Type.Missing);



                for (int i = 1; i < kdvequipcon.Columns.Count + 1; i++)

                {

                    XcelApp.Cells [1, i] = kdvequipcon.Columns [i - 1].HeaderText;

                }



                for (int i = 0; i < kdvequipcon.Rows.Count; i++)

                {

                    for (int j = 0; j < kdvequipcon.Columns.Count; j++)

                    {

                        XcelApp.Cells [i + 2, j + 1] = kdvequipcon.Rows [i].Cells [j].Value.ToString ();

                    }

                }

                XcelApp.Columns.AutoFit ();

                XcelApp.Visible = true;

            }

        }

        private void timer1_Tick (object sender, EventArgs e)
        {

            /*{
                DialogResult dialogresult = MetroFramework.MetroMessageBox.Show (this, "Session timeout!,do you want to continue using it", "Automated Job  Card System", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogresult == DialogResult.Yes)
                {
                    //timer1.Start ();

                    frmlogin At = new frmlogin ();
                    At.Show ();
                    this.Hide ();
                    // return;
                }
                else if (dialogresult == DialogResult.No)
                {
                    MessageBox.Show ("Goodbye", "Time Elapsed");
                    this.Close ();
                }
            }
            */
        }
    }
  }

