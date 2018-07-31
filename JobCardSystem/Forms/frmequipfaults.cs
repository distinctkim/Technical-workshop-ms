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

namespace JobCardSystem.Forms
{
    public partial class frmequipfaults : MetroFramework.Forms.MetroForm 
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
        public frmequipfaults ()
        {
            InitializeComponent ();
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

        private void txtfaultdesc_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfaultdesc.Clear ();
                //MessageBox.Show ("enter characters only");
            }
        }
        private void gridfresh ()
        {
            frmequipfaultsgrid select = new Forms.frmequipfaultsgrid ();
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblfaults");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            select.kdvequipfaults.DataSource = dt;
        }
        private void frmequipfaults_Load (object sender, EventArgs e)
        {
            txtcreatedate.Text = DateTime.Today.ToShortDateString ();
            txtid.Enabled = false;
            Button1.Visible = true;
            button3.Visible = false;
        }
        private void clear ()
        {
            txtid.Clear ();
            txtfaultdesc.Clear ();
            txtcreatedate.Clear ();
            cmbxsolutiondesign.ResetText ();

        }

        private void button3_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtfaultdesc.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxsolutiondesign.Text))
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

                    cmd.CommandText = "UPDATE tblfaults SET fdesc= " + "  @fdesc " + ",  fsoln = " + "  @fsoln " + " ,cdate =" + "  @cdate " + " WHERE id= '" + this.txtid.Text + "';";
                    cmd.Parameters.AddWithValue ("@fdesc", txtfaultdesc.Text);
                    cmd.Parameters.AddWithValue ("@fsoln", cmbxsolutiondesign.Text);
                    cmd.Parameters.AddWithValue ("@cdate",txtcreatedate.Text);
                    cmd.ExecuteNonQuery ();
                    MetroFramework.MetroMessageBox.Show (this, "Record updated successfully", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear ();
                    gridfresh ();
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

        private void Button1_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtfaultdesc.Text))
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
                    MySqlCommand cmd = new MySqlCommand ("select * from  tblfaults where id = '" + txtid.Text + "'", connect);
                    MySqlDataAdapter da = new MySqlDataAdapter (cmd);
                    DataSet ds1 = new DataSet ();
                    da.Fill (ds1);
                    int i = ds1.Tables [0].Rows.Count;
                    if (i > 0)
                    {
                        //MessageBox.Show ("Record exists");
                        MetroFramework.MetroMessageBox.Show (this, "Record exists already", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MetroFramework.MetroMessageBox.Show (this, "Click edit to the update record", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Exist
                    }
                    else
                    {
                        db_connection ();
                        MySqlCommand mySqlCommand = connect.CreateCommand ();
                        mySqlCommand.CommandText =
                        "INSERT INTO  tblfaults (" + "  fdesc " + "," + "fsoln" + "," + "cdate" + ") VALUES (" + "  @fdesc " + "," + "@fsoln" + "," + "  @cdate " + ")";
                        mySqlCommand.Parameters.Add ("@fdesc", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@fdesc"].Value = txtfaultdesc.Text;
                        mySqlCommand.Parameters.Add ("@fsoln", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@fsoln"].Value = cmbxsolutiondesign.Text;
                        mySqlCommand.Parameters.Add ("@cdate", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@cdate"].Value = txtcreatedate.Text;

                        mySqlCommand.ExecuteNonQuery ();
                        //Console.WriteLine ("Successfully added row to Customers table");
                        MetroFramework.MetroMessageBox.Show (this, "Successfully saved", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear ();
                        gridfresh ();
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

        private void cmbxsolutiondesign_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfaultdesc.Clear ();
                //MessageBox.Show ("enter characters only");
            }
        }

        private void button4_Click (object sender, EventArgs e)
        {
            frmequipfaultsgrid frm = new frmequipfaultsgrid ();
            frm.Show ();
            this.Hide ();
        }

        private void btnAdd_Click (object sender, EventArgs e)
        {
            Button1.Visible = true;
            txtcreatedate.Text = DateTime.Today.ToShortDateString ();
            //btndelete.Visible = false;
            button3.Visible = false;
            txtfaultdesc.Enabled = true;
            clear ();
            enable ();
        }
       private void enable()
        {
            txtid.Enabled = true;
            txtfaultdesc.Enabled = true;
            txtcreatedate.Enabled = true;
            cmbxsolutiondesign.Enabled = true;
        }
      

        private void btnUpdate_Click (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection connection = null;
            if (String.IsNullOrEmpty (txtfaultdesc.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields department name detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtcreatedate.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty field date detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxsolutiondesign.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty field date detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
                try
                {

                    connection = new MySqlConnection (conn);
                    connection.Open ();
                    MySqlCommand cmd = new MySqlCommand ();
                    cmd.Connection = connection;
                    cmd.CommandText = "delete from tblfaults where id='" + txtid.Text + "';";

                    cmd.ExecuteNonQuery ();
                    MetroFramework.MetroMessageBox.Show (this, "Department deleted successfully", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear ();
                    gridfresh ();
                }
                catch (Exception ex)
                {
                    writeErrorLog (ex.Message);
                }

                finally
                {
                    if (connection != null)
                        connection.Close ();
                }
           
        }

        private void button7_Click (object sender, EventArgs e)
        {
            Button1.Visible = false;
            button3.Visible = true;
        }

        private void Button2_Click (object sender, EventArgs e)
        {
            Home hme = new Forms.Home ();
            hme.Show ();
            this.Hide ();
        }

        private void GroupBox1_Enter (object sender, EventArgs e)
        {

        }
    }
}
