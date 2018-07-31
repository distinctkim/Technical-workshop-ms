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
using JobCardSystem.Forms;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;

namespace JobCardSystem.Forms
{
  
    public partial class frmmanageusersgrid : MetroFramework.Forms.MetroForm 
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

        public frmmanageusersgrid ()
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

        private void metroTile2_Click (object sender, EventArgs e)
        {
            frmUserManager frm = new Forms.frmUserManager ();
            frm.Show ();
            
        }

        private void metroTile5_Click (object sender, EventArgs e)
        {
            Home frm = new Forms.Home ();
            frm.Show ();
            this.Hide ();

        }
        private void fillgrid ()
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from login");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvusergrid.DataSource = dt;

        }
        private string Decryptdata (string encryptpwd)
        {
            string decryptpwd = string.Empty;
            UTF8Encoding encodepwd = new UTF8Encoding ();
            Decoder Decode = encodepwd.GetDecoder ();
            byte [] todecode_byte = Convert.FromBase64String (encryptpwd);
            int charCount = Decode.GetCharCount (todecode_byte, 0, todecode_byte.Length);
            char [] decoded_char = new char [charCount];
            Decode.GetChars (todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decryptpwd = new String (decoded_char);
            return decryptpwd;
        }
        private void frmusermain_Load (object sender, EventArgs e)
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
                    adapter = new MySqlDataAdapter ("select * from login", connect);
                    DS = new DataSet ();
                    adapter.Fill (DS);
                    kdvusergrid.DataSource = DS.Tables [0];
                    kdvusergrid.Columns [1].HeaderText = "Name";
                    kdvusergrid.Columns [2].HeaderText = "Department";
                    kdvusergrid.Columns [3].HeaderText = "MobileNo";
                    kdvusergrid.Columns [4].HeaderText = "Mail";
                    kdvusergrid.Columns [5].HeaderText = "Designation";
                    kdvusergrid.Columns [6].HeaderText = "Username";
                    kdvusergrid.Columns [7].HeaderText = "Password";
                    kdvusergrid.Columns [8].HeaderText = "Confirm Password";
                    kdvusergrid.Columns [9].HeaderText = "ID Number";
                    kdvusergrid.Columns [10].HeaderText = "Security Question";
                    kdvusergrid.Columns [11].HeaderText = "Answer";
                    // kdvcustomer.Columns [11].HeaderText = "Channel";

                    //close connection
                    this.CloseConnection ();
                }
                this.kdvusergrid.Columns [0].Visible = false;
                this.kdvusergrid.Columns [5].Visible = false;
                this.kdvusergrid.Columns [7].Visible = false;
                this.kdvusergrid.Columns [8].Visible = false;
                this.kdvusergrid.Columns [10].Visible = false;
                this.kdvusergrid.Columns [11].Visible = false;

                countreq ();
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

        private void metroTile3_Click (object sender, EventArgs e)
        {
            
        }

        private void label2_Click (object sender, EventArgs e)
        {

        }

        private void kryptonDataGridView1_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            frmusers select = new frmusers();
            select.txtid.Text = kdvusergrid.CurrentRow.Cells [0].Value.ToString ();
            select.txtname.Text = kdvusergrid.CurrentRow.Cells [1].Value.ToString ();
            select.cmbxdept.Text = kdvusergrid.CurrentRow.Cells [2].Value.ToString ();
            select.txtmobileno.Text = kdvusergrid.CurrentRow.Cells [3].Value.ToString ();
            select.txtemail.Text = kdvusergrid.CurrentRow.Cells [4].Value.ToString ();
            select.cmbxdesig.Text = kdvusergrid.CurrentRow.Cells [5].Value.ToString ();
            select.txtuname.Text = kdvusergrid.CurrentRow.Cells [6].Value.ToString ();
            select.txtpass.Text = kdvusergrid.CurrentRow.Cells [7].Value.ToString ();
            select.cmbxurole.Text = kdvusergrid.CurrentRow.Cells [8].Value.ToString ();
            select.cmbxstamp.Text = kdvusergrid.CurrentRow.Cells [9].Value.ToString ();
            /*select.txtpostaladdress.Text = kdvcustomer.CurrentRow.Cells [10].Value.ToString ();
            select.cmbxcontact.Text = kdvcustomer.CurrentRow.Cells [11].Value.ToString ();*/
            //keen ();
            select.txtid.Enabled = false;
            select.txtname.Enabled = false;
            select.cmbxdept.Enabled = false;
            select.txtmobileno.Enabled = false;
            select.txtemail.Enabled = false;
            select.cmbxdesig.Enabled = false;
            select.txtuname.Enabled = false;
            select.txtpass.Enabled = false;
            select.cmbxurole.Enabled = false;
           
            select.ShowDialog ();
            this.Close ();
            //this.Close ();
        }
       
        private void keen ()
        {
            frmusers select = new frmusers ();
            select.txtid.Enabled = false;
            select.txtname.Enabled = false;
            select.cmbxdept.Enabled = false;
            select.txtmobileno.Enabled = false;
            select.txtemail.Enabled = false;
            select.cmbxdesig.Enabled = false;
            select.txtuname.Enabled = false;
            select.txtpass.Enabled = false;
            select.cmbxurole.Enabled = false;
            select.cmbxstamp.Enabled = true;
        }

        private void button4_Click (object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter ();

            printer.Title = "Company Users Credentials REPORT";

            printer.SubTitle = "User Information Summary";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = false;

            printer.HeaderCellAlignment = StringAlignment.Center;

            printer.Footer = "DIAMOND SYSTEMS LIMITED";

            printer.FooterSpacing = 10;



            printer.PrintDataGridView (kdvusergrid);
        }

        private void pictureBox1_Click (object sender, EventArgs e)
        {
            frmusers frm = new Forms.frmusers ();
            frm.Show ();
            this.Hide ();
        }

        private void textBox5_TextChanged (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from login where username like '%{0}%'", textBox5.Text);
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvusergrid.DataSource = dt;
            fillgrid ();
        }

        private void button3_Click (object sender, EventArgs e)
        {

        }

        private void button2_Click (object sender, EventArgs e)
        {
            if (kdvusergrid.Rows.Count > 0)

            {

                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application ();

                XcelApp.Application.Workbooks.Add (Type.Missing);



                for (int i = 1; i < kdvusergrid.Columns.Count + 1; i++)

                {

                    XcelApp.Cells [1, i] = kdvusergrid.Columns [i - 1].HeaderText;

                }



                for (int i = 0; i < kdvusergrid.Rows.Count; i++)

                {

                    for (int j = 0; j < kdvusergrid.Columns.Count; j++)

                    {

                        XcelApp.Cells [i + 2, j + 1] = kdvusergrid.Rows [i].Cells [j].Value.ToString ();

                    }

                }

                XcelApp.Columns.AutoFit ();

                XcelApp.Visible = true;

            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            
        }
    }
  }

