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

    public partial class frmsetuptarrifs : MetroFramework.Forms.MetroForm
    {
        private string conn;
        private MySqlConnection connect;
        // MySqlTransaction tr = null;
        //MySqlCommand cmd;
        // MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
       // private string server;
       // private string database;
       // private string uid;
       // private string password;
        MySqlTransaction tr = null;


        public frmsetuptarrifs ()
        {
            InitializeComponent ();
        }

        private void GroupBox1_Enter (object sender, EventArgs e)
        {

        }
        private void db_connection ()
        {
            try
            {
                conn = "Server=localhost;Database=jobauto;Uid=root;Pwd=;";
                connect = new MySqlConnection (conn);
                connect.Open ();
               
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

        private void cmdTest_Click (object sender, EventArgs e)
        {
            
            try
            {
               
            }
            catch (Exception)
            {

            }
        }
        

        private void cmdSave_Click (object sender, EventArgs e)
        {

        }

        private void frmDatabase_Load (object sender, EventArgs e)
        {
            //selectCombo ();
            btnUpdate.Visible = false;
        }
        private void clear ()
        {
            txtid.Clear ();
            txtdesc.Clear ();
            txtprice.Clear ();
            txtStid.Clear ();
            cmbxdept.ResetText ();
        }
        private void button4_Click (object sender, EventArgs e)
        {
            this.Hide ();
            gridfresh ();
            frmloadtarrifgrid tarrifgrid = new frmloadtarrifgrid ();
            tarrifgrid.Show ();
            
        }

        private void Button2_Click (object sender, EventArgs e)
        {
            this.Hide ();
            frmadminhome adm = new frmadminhome ();
            adm.Show ();
           
        }

        private void Button1_Click (object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty (txtStid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtprice.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtdesc.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxdept.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                try
                {
                    db_connection ();
                    MySqlCommand cmd = new MySqlCommand ("select * from  tbltarrifs where id = '" + txtid.Text + "'", connect);
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
                        "INSERT INTO  tbltarrifs (" + "  stockid " + "," + "tdesc" + "," + "servicename" + "," + "price" + ") VALUES (" + "  @stockid " + "," + "@tdesc" + "," + "@servicename" + "," + "  @price" + ")";
                        mySqlCommand.Parameters.Add ("@stockid", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@stockid"].Value = txtStid.Text;
                        mySqlCommand.Parameters.Add ("@tdesc", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@tdesc"].Value =  txtdesc.Text;
                        mySqlCommand.Parameters.Add ("@servicename", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@servicename"].Value = cmbxdept.Text;
                        mySqlCommand.Parameters.Add ("@price", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@price"].Value = txtprice.Text;

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
        private void gridfresh ()
        {
            frmloadtarrifgrid select = new Forms.frmloadtarrifgrid();
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tbltarrifs");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            select.kdvtarrifinfo.DataSource = dt;
        }
        /*public void selectCombo ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT deptname FROM tbldept;";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                cmbxdept.Items.Add (rowz);
            }
            connection.Close ();
        }*/
       
        private void txtdesc_KeyPress (object sender, KeyPressEventArgs e)
        {

            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdesc.Clear ();
                //MessageBox.Show ("enter characters only");
            }
        }

        private void txtprice_KeyPress (object sender, KeyPressEventArgs e)
        {

            if (e.Handled = !(char.IsDigit (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MetroFramework.MetroMessageBox.Show (this, "Enter numbers only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtprice.Clear ();
                //MessageBox.Show ("enter characters only");
            }
        }

        private void btnUpdate_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtdesc.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtprice.Text))
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

                    cmd.CommandText = "UPDATE tbltarrifs SET stockid= " + "  @sid " + ",  tdesc = " + "  @tdesc " + " , price =" + "  @price " + " WHERE id= '" + this.txtid.Text + "';";
                    cmd.Parameters.AddWithValue ("@sid", txtStid.Text);
                    cmd.Parameters.AddWithValue ("@tdesc", txtdesc.Text);
                    cmd.Parameters.AddWithValue ("@price", txtprice.Text);
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

        private void button7_Click (object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            Button1.Visible = false;
            enable ();
        }
        private void enable()
        {
            txtdesc.Enabled = true;
            txtprice.Enabled = true;
            txtStid.Enabled = true;
            txtid.Enabled = true;
        }
        private void btnAdd_Click (object sender, EventArgs e)
        {
            clear ();
            enable ();
            Button1.Visible = true;
            btnUpdate.Visible = false;
            cmbxdept.Enabled = true;

        }

        private void txtStid_KeyPress (object sender, KeyPressEventArgs e)
        {

        }

        private void cmbxdept_SelectedIndexChanged (object sender, EventArgs e)
        {

        }
    }
}
