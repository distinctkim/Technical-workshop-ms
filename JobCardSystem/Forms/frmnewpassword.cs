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
namespace JobCardSystem.Forms
{
    public partial class frmnewpassword : MetroFramework.Forms.MetroForm 
    {
        private string conn;
        private MySqlConnection connect;
        // MySqlTransaction tr = null;
        //MySqlCommand cmd;
        //MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
        //private string server;
        //private string database;
        //private string uid;
        //private string password;
        MySqlTransaction tr = null;
        public frmnewpassword ()
        {
            InitializeComponent ();
        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Function to connect to the database for crud operations
        /// </summary>
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
        private  bool Validate(String pass, String confirm)
        {
            return String.IsNullOrEmpty (pass) == false && pass == confirm;
        }

        private void btnsubmit_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtuserid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (String.IsNullOrEmpty (txtusername.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtnewpass.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (String.IsNullOrEmpty (txtverify.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (Validate(txtnewpass.Text, txtverify.Text) == false)
            {
                MetroFramework.MetroMessageBox.Show (this, "Passwords Do not Match", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtverify.Clear ();
                return;

            }

            else
            {
                try
                {
                    db_connection ();

                    tr = connect.BeginTransaction ();

                    MySqlCommand cmd = new MySqlCommand ();
                    cmd.Connection = connect;
                    cmd.Transaction = tr;

                    cmd.CommandText = "UPDATE login SET username= " + "  @uname " + ",  password = " + "  @pass " + " WHERE idno= '" + this.txtuserid.Text + "';";
                    cmd.Parameters.AddWithValue ("@uname", txtusername.Text);
                    cmd.Parameters.AddWithValue ("@pass", txtnewpass.Text);
                   
                    cmd.ExecuteNonQuery ();
                    MetroFramework.MetroMessageBox.Show (this, "Record updated successfully", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear ();
                    //gridfresh ();
                    tr.Commit ();


                    // Add 

                }
                catch (MySqlException ex)
                {

                    writeErrorLog (ex.Message);
                    tr.Rollback ();
                }
                finally
                {
                    if (conn != null)
                        connect.Close ();
                }
            }
        }

        private void btncancel_Click (object sender, EventArgs e)
        {
            clear ();
            frmlogin frm = new Forms.frmlogin ();
            frm.Show ();
            this.Hide ();

        }
        private void clear()
        {
            txtnewpass.Clear ();
            txtuserid.Clear ();
            txtusername.Clear ();
            txtverify.Clear ();
        }

        private void cbxshowpass_CheckedChanged (object sender, EventArgs e)
        {
            if(cbxshowpass.Checked)
            {
                txtnewpass.UseSystemPasswordChar = false;
                txtverify.UseSystemPasswordChar = false;
            }
            else
            {
                txtnewpass.UseSystemPasswordChar = true;
                txtverify.UseSystemPasswordChar = true;
            }
        }
    }
}
