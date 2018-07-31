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
    public partial class frmsetupequipmentfaults : MetroFramework.Forms.MetroForm
    {

        private string conn;
        private MySqlConnection connect;
        //MySqlTransaction tr = null;
        //MySqlCommand cmd;
        //MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
        public frmsetupequipmentfaults ()
        {
            InitializeComponent ();
        }

        private void frmsetupequipmentfaults_Load (object sender, EventArgs e)
        {

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

        private void button4_Click (object sender, EventArgs e)
        {
            frmequipfaultsgrid frm = new frmequipfaultsgrid();
            frm.Show ();
            this.Hide ();

        }

        private void Button2_Click (object sender, EventArgs e)
        {
            this.Hide ();
            Home hom = new Forms.Home ();
            hom.Show ();
        }

        private void btnUpdate_Click (object sender, EventArgs e)
        {

        }

        private void Button1_Click (object sender, EventArgs e)
        {
             if (String.IsNullOrEmpty (txtfaultdesc.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    db_connection ();
                    MySqlCommand cmd = new MySqlCommand ("select * from tbldept where id = '" + txtfaultid.Text + "'", connect);
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
                        "INSERT INTO tbldept (" + "  deptname " + "," + "createdate" + ") VALUES (" + "  @idept " + "," + "  @idate " + ")";
                        mySqlCommand.Parameters.Add ("@idept", MySqlDbType.VarChar, 250);
                        //mySqlCommand.Parameters ["@idept"].Value = txtshiftdesc.Text;
                        mySqlCommand.Parameters.Add ("@idate", MySqlDbType.VarChar, 250);
                        //mySqlCommand.Parameters ["@idate"].Value = txtcreatedate.Text;

                        mySqlCommand.ExecuteNonQuery ();
                        //Console.WriteLine ("Successfully added row to Customers table");
                        MetroFramework.MetroMessageBox.Show (this, "Successfully saved", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear ();
                        //gridfresh ();
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
    }
}
