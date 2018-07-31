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
    public partial class frmcustomergrid : MetroFramework.Forms.MetroForm
    {
        private string conn;
        private MySqlConnection connect;
        
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
        private string server;
        private string database;
        private string uid;
        private string password;
        DataSet DS;
        public frmcustomergrid ()
        {
            InitializeComponent ();
            kdvcustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //SELECTION MODE
            kdvcustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kdvcustomer.MultiSelect = false; 
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

        private void frmcustomergrid_Load (object sender, EventArgs e)
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
                    adapter = new MySqlDataAdapter ("select * from tblcustomer", connect);
                  
                    DS = new DataSet ();
                    adapter.Fill (DS);
                    kdvcustomer.DataSource = DS.Tables [0];
                    kdvcustomer.Columns [1].HeaderText = "Name";
                    kdvcustomer.Columns [2].HeaderText = "Email";
                    kdvcustomer.Columns [3].HeaderText = "Telephone";
                    kdvcustomer.Columns [4].HeaderText = "Date";
                    kdvcustomer.Columns [5].HeaderText = "CreatedBy";
                    kdvcustomer.Columns [6].HeaderText = "Town";
                    kdvcustomer.Columns [7].HeaderText = "City";
                    kdvcustomer.Columns [8].HeaderText = "Street";
                    kdvcustomer.Columns [9].HeaderText = "Building";
                    kdvcustomer.Columns [10].HeaderText = "Address";
                    kdvcustomer.Columns [11].HeaderText = "Channel";

                    //close connection
                    this.CloseConnection ();
                }
                this.kdvcustomer.Columns [0].Visible = false;
                this.kdvcustomer.Columns [6].Visible = false;
                this.kdvcustomer.Columns [7].Visible = false;
                this.kdvcustomer.Columns [8].Visible = false;
                int sum = 0;
                for (int i = 0; i < kdvcustomer.Rows.Count; ++i)
                {
                    int tmp = 0;
                    int.TryParse (kdvcustomer.Rows [i].Cells [1].Value.ToString (), out tmp);
                    sum += tmp;
                }
                textBox1.Text = sum.ToString ();
                count ();
            }
            catch (Exception ex)
            {
                writeErrorLog (ex.Message);

            }
         }
        public void count()
        {
            textBox1.Text = DS.Tables [0].Rows.Count.ToString ();
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
                MessageBox.Show (ex.Message);
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

        private void kdvcustomer_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            frmcreatecustomer select = new frmcreatecustomer ();
            select.txtid.Text = kdvcustomer.CurrentRow.Cells [0].Value.ToString ();
            select.txtcustomername.Text = kdvcustomer.CurrentRow.Cells [1].Value.ToString ();
            select.txtcomemail.Text = kdvcustomer.CurrentRow.Cells [2].Value.ToString ();
            select.txtmobileno.Text = kdvcustomer.CurrentRow.Cells [3].Value.ToString ();
            select.txtCdate.Text = kdvcustomer.CurrentRow.Cells [4].Value.ToString ();
            select.cmbxcreatedby.Text = kdvcustomer.CurrentRow.Cells [5].Value.ToString ();
            select.cmbxtown.Text = kdvcustomer.CurrentRow.Cells [6].Value.ToString ();
            select.txtcity.Text = kdvcustomer.CurrentRow.Cells [7].Value.ToString ();
            select.txtstreet.Text = kdvcustomer.CurrentRow.Cells [8].Value.ToString ();
            select.txtbuilding.Text = kdvcustomer.CurrentRow.Cells [9].Value.ToString ();
            select.txtpostaladdress.Text = kdvcustomer.CurrentRow.Cells [10].Value.ToString ();
            select.cmbxcontact.Text = kdvcustomer.CurrentRow.Cells [11].Value.ToString ();

            select.ShowDialog ();
            keen ();
            
            select.txtid.Enabled=false;
            select.txtcustomername.Enabled = false;
            select.txtcomemail.Enabled = false;
            select.txtmobileno.Enabled = false;
            select.txtCdate.Enabled = false;
            select.cmbxcreatedby.Enabled = false;
            select.cmbxtown.Enabled = false;
            select.txtcity.Enabled = false ;
            select.txtstreet.Enabled = false;
            select.txtbuilding.Enabled = false;
            select.txtpostaladdress.Enabled = false;
            select.cmbxcontact.Enabled = false;

            //select.ShowDialog ();
            this.Close ();
        }
        private void keen()
        {
            frmcreatecustomer select = new frmcreatecustomer ();
            select.txtid.Enabled = false;
            select.txtcustomername.Enabled = false;
            select.txtcomemail.Enabled = false;
            select.txtmobileno.Enabled = false;
            select.txtCdate.Enabled = false;
            select.cmbxcreatedby.Enabled = false;
            select.cmbxtown.Enabled = false;
            select.txtcity.Enabled = false;
            select.txtstreet.Enabled = false;
            select.txtbuilding.Enabled = false;
            select.txtpostaladdress.Enabled = false;
            select.cmbxcontact.Enabled = false;
        }

        private void button3_Click (object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter ();

            printer.Title = "CUSTOMER INFORMATION REPORT";

            printer.SubTitle = "CUSTOMER INFORMATION SUMMARY";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = false;

            printer.HeaderCellAlignment = StringAlignment.Center;

            printer.Footer = "DIAMOND SYSTEMS LIMITED";

            printer.FooterSpacing = 10;



            printer.PrintDataGridView (kdvcustomer);
        }

        private void pictureBox1_Click (object sender, EventArgs e)
        {
            frmcreatecustomer frm = new frmcreatecustomer ();
            frm.Show ();
            this.Hide ();
        }

        private void button2_Click (object sender, EventArgs e)
        {
            //string connector_string = "datasource = localhost;port=3306;username=root;password=;";
           
        }
        private void fillgrid()
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblcustomer");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvcustomer.DataSource = dt;

        }

        private void txtcustomersearch_TextChanged (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblcustomer where companyname like '%{0}%'", txtcustomersearch.Text);
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvcustomer.DataSource = dt;
            //fillgrid ();
        }

        private void button1_Click (object sender, EventArgs e)
        {
            if (kdvcustomer.Rows.Count > 0)

            {

                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application ();

                XcelApp.Application.Workbooks.Add (Type.Missing);



                for (int i = 1; i < kdvcustomer.Columns.Count + 1; i++)

                {

                    XcelApp.Cells [1, i] = kdvcustomer.Columns [i - 1].HeaderText;

                }



                for (int i = 0; i < kdvcustomer.Rows.Count; i++)

                {

                    for (int j = 0; j < kdvcustomer.Columns.Count; j++)

                    {

                        XcelApp.Cells [i + 2, j + 1] = kdvcustomer.Rows [i].Cells [j].Value.ToString ();

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

