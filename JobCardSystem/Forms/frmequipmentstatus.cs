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
    public partial class frmequipmentstatus : MetroFramework.Forms.MetroForm
    {
        private string conn;
        private MySqlConnection connect;
        /*MySqlTransaction tr = null;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;*/
        DataTable dt = new DataTable ();

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
                MetroFramework.MetroMessageBox.Show (this, "Failed to connect to database", "Automated Job  Card System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                writeErrorLog (ex.Message);
                this.Close ();
                Application.Exit ();
                return;
            }
        }
        /// <summary>
        /// Function that appends errors to a file for easier debugging
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
        public frmequipmentstatus ()
        {
            InitializeComponent ();
        }

        private void GroupBox1_Enter (object sender, EventArgs e)
        {

        }

        private void Button1_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtstatus.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            else
            {
                try
                {
                    db_connection ();
                    MySqlCommand cmd = new MySqlCommand ("select * from tblstatus where id = '" + txtid.Text + "'", connect);
                    MySqlDataAdapter da = new MySqlDataAdapter (cmd);
                    DataSet ds1 = new DataSet ();
                    da.Fill (ds1);
                    int i = ds1.Tables [0].Rows.Count;
                    if (i > 0)
                    {
                        //MessageBox.Show ("Record exists");
                        MetroFramework.MetroMessageBox.Show (this, "Record exists already", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MetroFramework.MetroMessageBox.Show (this, "Click edit to the delete status record", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Exist
                    }
                    else
                    {
                        db_connection ();
                        MySqlCommand mySqlCommand = connect.CreateCommand ();
                        mySqlCommand.CommandText =
                        "INSERT INTO tblstatus (" + "  status " + ") VALUES (" + "  @istatus " + ")";
                        mySqlCommand.Parameters.Add ("@istatus", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@istatus"].Value = txtstatus.Text;
                        
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
        private void clear ()
        {
           txtid.Clear ();
           txtstatus .Clear ();
           
        }
        private void Button2_Click (object sender, EventArgs e)
        {
            Home viewhome = new Forms.Home ();
            viewhome.Show ();
            this.Hide ();
        }

        private void button4_Click (object sender, EventArgs e)
        {
            frmequipmentstatusgrid frm = new Forms.frmequipmentstatusgrid ();
            frm.Show ();
            
        }

        private void btnUpdate_Click (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection connection = null;
            if (String.IsNullOrEmpty (txtstatus.Text))
                    {
                        MetroFramework.MetroMessageBox.Show (this, "Empty fields department name detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                        try
                        {
                       
                            connection = new MySqlConnection (conn);
                            connection.Open ();
                            MySqlCommand cmd = new MySqlCommand ();
                            cmd.Connection = connection;
                            cmd.CommandText = "delete from tblstatus where id='" + txtid.Text + "';";

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
        private void gridfresh ()
            {
                 frmequipmentstatusgrid select = new Forms.frmequipmentstatusgrid ();
                 db_connection ();
                 MySqlConnection sqlcon = new MySqlConnection (conn);
                 sqlcon.Open ();
                 string query = string.Format ("Select * from tblstatus");
                 MySqlCommand cmd = new MySqlCommand (query, sqlcon);
                 MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
                 DataTable dt = new DataTable ();
                 adpt.Fill (dt);
                 select.kdvequipstatus.DataSource = dt;
             }
        private void txtstatus_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtstatus.Clear ();
                //MessageBox.Show ("enter characters only");
            }
        }

        private void frmequipmentstatus_Load (object sender, EventArgs e)
        {

        }
    }
}
