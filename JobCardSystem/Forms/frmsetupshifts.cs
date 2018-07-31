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
using System.Diagnostics;

namespace JobCardSystem.Forms
{
    public partial class frmsetupshifts : MetroFramework.Forms.MetroForm
    {
        private string conn;
        private MySqlConnection connect;
        //MySqlTransaction tr = null;
        //MySqlCommand cmd;
        //MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
        MySqlTransaction tr = null;

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
        public frmsetupshifts ()
        {
            InitializeComponent ();
        }

        private void frmsetupshifts_Load (object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            Button1.Visible = true;
            txtcreatedate.Text = DateTime.Today.ToShortDateString ();
            txtcreatedate.Enabled = false;
        }

        private void Button2_Click (object sender, EventArgs e)
        {
            Home viewhome = new Home ();
            viewhome.Show ();
            this.Hide ();
        }

        private void button4_Click (object sender, EventArgs e)
        {
            frmshiftInfoGrid frm = new frmshiftInfoGrid ();
            frm.Show ();
            this.Hide ();

        }
        private void errorlog()
        {
            string source = "DemoTestApplication";
            string log = "DemoEventLog";
            EventLog demoLog = new EventLog (log);
            demoLog.Source = source;
            demoLog.WriteEntry ("This is the first message to the log", EventLogEntryType.Information);
        }

        private void Button1_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtshiftdesc.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtcreatedate.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            else
            {
                try
                {
                    db_connection ();
                    MySqlCommand cmd = new MySqlCommand ("select * from tblshift where sid = '" + txtid.Text + "'", connect);
                    MySqlDataAdapter da = new MySqlDataAdapter (cmd);
                    DataSet ds1 = new DataSet ();
                    da.Fill (ds1);
                    int i = ds1.Tables [0].Rows.Count;
                    if (i > 0)
                    {
                        //MessageBox.Show ("Record exists");
                        MetroFramework.MetroMessageBox.Show (this, "Record exists already", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MetroFramework.MetroMessageBox.Show (this, "Click edit to the update record", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorlog ();
                        // Exist
                    }
                    else
                    {
                        db_connection ();
                        MySqlCommand mySqlCommand = connect.CreateCommand ();
                        mySqlCommand.CommandText =
                        "INSERT INTO tblshift (" + "  shiftdesc " + "," + "createdate" + ") VALUES (" + "  @ishift " + "," + "  @idesc " + ")";
                        mySqlCommand.Parameters.Add ("@ishift", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@ishift"].Value = txtshiftdesc.Text;
                        mySqlCommand.Parameters.Add ("@idesc", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@idesc"].Value = txtcreatedate.Text;
                 
                        mySqlCommand.ExecuteNonQuery ();
                        //Console.WriteLine ("Successfully added row to Customers table");
                        MetroFramework.MetroMessageBox.Show (this, "Successfully saved", "Automated Job  Card System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear ();
                        connect.Close ();

                        // Add 
                    }
                }
                catch (Exception ex)
                {
                    writeErrorLog (ex.Message);
                }
                connect.Close ();
            }
            
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
        private void clear()
        {
            txtid.Clear ();
            txtcreatedate.Clear ();
            txtshiftdesc.Clear ();
        }

        private void btnUpdate_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtshiftdesc.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtcreatedate.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    cmd.CommandText = "UPDATE tblshift SET shiftdesc= " + "  @shiftdesc " + " WHERE sid= '" + this.txtid.Text + "';";
                    cmd.Parameters.AddWithValue ("@shiftdesc", txtshiftdesc.Text);
                    cmd.ExecuteNonQuery ();
                    MetroFramework.MetroMessageBox.Show (this, "Record updated successfully", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear ();
                    tr.Commit ();
                    // Add 
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message);
                }
                connect.Close ();
            }

        }


        private void GroupBox1_Enter (object sender, EventArgs e)
        {

        }

        private void button7_Click (object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            Button1.Visible = false;

        }

        private void btnAdd_Click (object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            Button1.Visible = true;
            clearfields ();
            txtcreatedate.Text = DateTime.Today.ToShortDateString ();
        }
        private void clearfields()
        {
            txtcreatedate.Clear ();
            txtid.Clear ();
            txtshiftdesc.Clear ();

        }
    }
}
