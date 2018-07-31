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
namespace JobCardSystem.Forms
{
  
    public partial class frmInternalComm : MetroFramework.Forms.MetroForm 
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
        public frmInternalComm ()
        {
            InitializeComponent ();
        }

        private void Button2_Click (object sender, EventArgs e)
        {
            this.Hide ();
            frmcommunication commmain = new frmcommunication ();
            commmain.Show ();
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
        public void selectCombo ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT empmail FROM login;";
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
        private void loadgrid()
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
        private void frmInternalComm_Load (object sender, EventArgs e)
        {
            loadgrid ();
            selectCombo ();
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
                writeErrorLog (ex.Message);

                //MessageBox.Show (ex.Message);
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

        private void textBox7_TextChanged (object sender, EventArgs e)
        {

            {
                db_connection ();
                MySqlConnection sqlcon = new MySqlConnection (conn);
                sqlcon.Open ();
                string query = string.Format ("Select * from  tblreq where cname like '%{0}%'", textBox7.Text);
                MySqlCommand cmd = new MySqlCommand (query, sqlcon);
                MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
                DataTable dt = new DataTable ();
                adpt.Fill (dt);
                kdvequipreq.DataSource = dt;
                //fillgrid ();
            }
        }

        private void kdvequipreq_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            //txtTo.Text = kdvequipreq.CurrentRow.Cells [7].Value.ToString ();
            txtsubject.Text = kdvequipreq.CurrentRow.Cells [3].Value.ToString ();
            txtBody.Text = kdvequipreq.CurrentRow.Cells [8].Value.ToString ();

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
                mm.Subject = txtsubject.Text;
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
        private void clear ()
        {
            txtTo.ResetText ();
            txtBody.Clear ();
            txtEmail.Clear ();
            txtPassword.Clear ();
            txtsubject.Clear ();
        }

        private void lblattachment_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog ();
        }
    }
}
