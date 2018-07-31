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
    public partial class frmforgotpassword : MetroFramework.Forms.MetroForm 
    {
        private string conn;
        private MySqlConnection connect;
       
        DataTable dt = new DataTable ();
       
        public frmforgotpassword ()
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


        private void btnsubmit_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtuserid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (txtuserid.Text.Length < 7)
            {
                MetroFramework.MetroMessageBox.Show (this, "ID No length not valid!", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            else
                try
                {
                    db_connection ();
                    MySqlCommand cmd = new MySqlCommand ("select * from login where idno = '" + txtuserid.Text + "'", connect);
                    MySqlDataAdapter da = new MySqlDataAdapter (cmd);
                    DataSet ds1 = new DataSet ();
                    da.Fill (ds1);
                    int i = ds1.Tables [0].Rows.Count;
                    if (i > 0)
                    {
                        //MessageBox.Show ("Record exists");
                        MetroFramework.MetroMessageBox.Show (this, "User exists proceed to reset your password");
                        clear ();
                        this.Hide ();
                        frmnewpassword frm = new frmnewpassword ();
                        frm.Show ();
                        /* if (result == DialogResult.Yes)
                         {
                             frmnewpassword frm = new frmnewpassword ();
                             frm.Show ();
                             //this.Hide ();
                             //code for Yes
                         }*/
                        // Exist
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show (this, "User does not exists contact admin to create your account", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        clear ();
                        this.Hide ();
                        frmlogin frm = new frmlogin ();
                        frm.Show ();


                    }
                }
                catch (Exception ex)
                {
                    writeErrorLog (ex.Message);
                }

        }
        private void clear()
        {
           
            txtuserid.Clear ();
           
        }

        private void txtuserid_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber (e.KeyChar) & (Keys)e.KeyChar != Keys.Back & (Keys)e.KeyChar != Keys.Enter)
            {

                e.Handled = true;
                //MessageBox.Show ("enter numbers only");
                MetroFramework.MetroMessageBox.Show (this, "Enter numbers only", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            base.OnKeyPress (e);
        }

        private void btncancel_Click (object sender, EventArgs e)
        {
            txtuserid.Clear ();
            this.Hide ();
            frmlogin frm = new frmlogin ();
            frm.Show ();
           
        }
    }
 }
