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
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Globalization;
using System.Text.RegularExpressions;
namespace JobCardSystem.Forms
{
    public partial class frmExternalcomm : MetroFramework.Forms.MetroForm
    {
        private string conn;
        private MySqlConnection connect;
        //MySqlTransaction tr = null;
        //MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
        private string server;
        private string database;
        private string uid;
        private string password;
        //MailMessage message;
        //SmtpClient smtp;
        public frmExternalcomm ()
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
            catch (Exception)

            {
                MetroFramework.MetroMessageBox.Show (this, "Failed to connect to database", "Automated Job  Card System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close ();
                Application.Exit ();
                return;
            }
        }

        private void Panel1_Paint (object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click (object sender, EventArgs e)
        {
            this.Hide ();
            frmcommunication commmain = new frmcommunication ();
            commmain.Show ();
        }

        private void frmExternalcomm_Load (object sender, EventArgs e)
        {
            selectCombo ();
            customergrid ();
            
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
        private void customergrid ()
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
                DataSet DS = new DataSet ();
                adapter.Fill (DS);
                kdvcustomer.DataSource = DS.Tables [0];
                kdvcustomer.Columns [1].HeaderText = "Qid";
                kdvcustomer.Columns [2].HeaderText = "Rid";
                kdvcustomer.Columns [3].HeaderText = "Eid";
                kdvcustomer.Columns [4].HeaderText = "EquipmentName";
                kdvcustomer.Columns [5].HeaderText = "Equipmentserial";
                kdvcustomer.Columns [6].HeaderText = "Client";
                kdvcustomer.Columns [7].HeaderText = "Email";
                kdvcustomer.Columns [8].HeaderText = "Issue";
                kdvcustomer.Columns [9].HeaderText = "Diagnosis";
                kdvcustomer.Columns [10].HeaderText = "HDWItem";
                kdvcustomer.Columns [11].HeaderText = "SFTItem";
                kdvcustomer.Columns [12].HeaderText = "SerialNo";
                kdvcustomer.Columns [13].HeaderText = "Status";
                kdvcustomer.Columns [14].HeaderText = "Technician";
                kdvcustomer.Columns [15].HeaderText = "Summary";
                kdvcustomer.Columns [16].HeaderText = "Notes";

                //close connection
                this.CloseConnection ();
            }
            this.kdvcustomer.Columns [0].Visible = false;
            this.kdvcustomer.Columns [1].Visible = false;
            //this.kdvcustomer.Columns [6].Visible = false;
            this.kdvcustomer.Columns [7].Visible = false;
            this.kdvcustomer.Columns [8].Visible = false;
            this.kdvcustomer.Columns [9].Visible = false;
            //this.kdvequip.Columns [11].Visible = false;
            this.kdvcustomer.Columns [12].Visible = false;
            //this.kdvcustomer.Columns [13].Visible = false;
            //this.kdvequip.Columns [14].Visible = false;
        }
        public void selectCombo ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT companyemail FROM tblcustomer;";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                txtTo.Items.Add (rowz);
            }
            connection.Close ();
        }

        private void linkLabel1_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog ();
        }

        private void openFileDialog1_FileOk (object sender, CancelEventArgs e)
        {
            foreach (string filePath in openFileDialog1.FileNames)
            {
                if (File.Exists (filePath))
                {
                    string fileName = Path.GetFileName (filePath);
                    lblattachment.Text += fileName + Environment.NewLine;
                }
            }
        }

        private void Button1_Click (object sender, EventArgs e)
        {
            using (MailMessage mm = new MailMessage (txtEmail.Text.Trim (), txtTo.Text.Trim ()))
            {
                mm.Subject = txtSubject.Text;
                mm.Body = txtBody.Text;
                foreach (string filePath in openFileDialog1.FileNames)
                {
                    if (File.Exists (filePath))
                    {
                        string fileName = Path.GetFileName (filePath);
                        mm.Attachments.Add (new Attachment (filePath));
                    }
                }
               
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient ();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential (txtEmail.Text.Trim (), txtPassword.Text.Trim ());
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send (mm);
                //MessageBox.Show ("Email sent.", "Message");
                MetroFramework.MetroMessageBox.Show (this, "Email sent.", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear ();
            }
        }

        private void clear()
        {
            txtTo.ResetText ();
            txtBody.Clear ();
            txtEmail.Clear ();
            txtPassword.Clear ();
            txtSubject.Clear ();
        }
        private void groupBox2_Enter (object sender, EventArgs e)
        {

        }

        private void cmbxto_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private void kdvcustomer_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            txtTo.Text = kdvcustomer.CurrentRow.Cells [7].Value.ToString ();
            txtSubject.Text = kdvcustomer.CurrentRow.Cells [4].Value.ToString ();
            txtBody.Text = kdvcustomer.CurrentRow.Cells [13].Value.ToString ();
        }

        private void textBox7_TextChanged (object sender, EventArgs e)
        {
            {
                db_connection ();
                MySqlConnection sqlcon = new MySqlConnection (conn);
                sqlcon.Open ();
                string query = string.Format ("Select * from  tblconequip where status like '%{0}%'", textBox7.Text);
                MySqlCommand cmd = new MySqlCommand (query, sqlcon);
                MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
                DataTable dt = new DataTable ();
                adpt.Fill (dt);
                kdvcustomer.DataSource = dt;
                //fillgrid ();
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
            kdvcustomer.DataSource = dt;

        }
    }
}

