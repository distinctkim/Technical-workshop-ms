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
using Tulpep.NotificationWindow;
namespace JobCardSystem.Forms
{
    public partial class frmitempickup : MetroFramework.Forms.MetroForm 
    {
        private string conn;
        private MySqlConnection connect;
        //MySqlTransaction tr = null;
        //MySqlCommand cmd;
       // MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
       // MySqlTransaction tr = null;

        public frmitempickup ()
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

        private void frmitemclearance_Load (object sender, EventArgs e)
        {
            selectComboID ();
            selectComboStatus ();
            txtcleardate.Text = DateTime.Today.ToShortDateString ();
            txtcleardate.Enabled = false;
            cmbxbid.Enabled = false;
            txttopup.Visible = false;
            label29.Visible = false;
           
        }
        public void selectComboID ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT bid FROM tblbill;";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                cmbxbid.Items.Add (rowz);
            }
            connection.Close ();
        }
        public void selectComboStatus ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT status FROM tblbill WHERE status = 'ItemCleared';";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                cmbxstid.Items.Add (rowz);
            }
            connection.Close ();
          
        }

        private void cmbxrcid_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (cmbxbid.SelectedIndex < 0)
            {
                // Don't want to suffer database hit if nothing is selected
                // Simply clear text boxes and return
                 
                //AddressBox.Text = "";
            }
            else
            {
                MySqlConnection cs = new MySqlConnection (conn);
                cs.Open ();

                DataSet ds = new DataSet ();

                // You only need to select the address since you already have the name unless 
                // they are displayed differently and you want the database display to show
                MySqlDataAdapter da = new MySqlDataAdapter ("Select * from tblbill WHERE bid='" + cmbxbid.Text + "'", cs);
                //select* from tblbill WHERE status = 'Item Cleared
                MySqlCommandBuilder cmd = new MySqlCommandBuilder (da);

                da.Fill (ds);

                //NameBox.Text = comboBox1.Text;
                txtcid.Text = ds.Tables [0].Rows [0] ["rcid"].ToString (); 
                txtequipmentid.Text = ds.Tables [0].Rows [0] ["eid"].ToString ();
                txtequipmentname.Text = ds.Tables [0].Rows [0] ["ename"].ToString ();
                txtequipmentserial.Text = ds.Tables [0].Rows [0] ["eserial"].ToString ();
                txtclientname.Text = ds.Tables [0].Rows [0] ["cname"].ToString ();
                txtclientemail.Text = ds.Tables [0].Rows [0] ["cmail"].ToString ();
                txtdate.Text = ds.Tables [0].Rows [0] ["invdate"].ToString ();
                txtbilldate.Text = ds.Tables [0].Rows [0] ["bdate"].ToString ();
                txtqamnt.Text = ds.Tables [0].Rows [0] ["qamnt"].ToString ();
                txttaxrate.Text = ds.Tables [0].Rows [0] ["trate"].ToString ();
                txttxamnt.Text = ds.Tables [0].Rows [0] ["tamnt"].ToString ();
                txtgamnt.Text = ds.Tables [0].Rows [0] ["gamnt"].ToString ();
                txtpamnt.Text = ds.Tables [0].Rows [0] ["pamnt"].ToString ();
                txtbalance.Text = ds.Tables [0].Rows [0] ["balance"].ToString ();
                txtstatus.Text = ds.Tables [0].Rows [0] ["status"].ToString ();


            }
        }

        private void button12_Click (object sender, EventArgs e)
        {

            this.Hide ();
            Home frm = new Home ();
            frm.Show ();

        }

        private void btnsaveclearance_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (cmbxbid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtcid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            else
            {
                try
                {
                    db_connection ();
                    MySqlCommand cmd = new MySqlCommand ("select * from tblcleareditems where clearanceid = '" + txtclearanceid.Text + "'", connect);
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
                        "INSERT INTO tblcleareditems(" + "  bid " + "," + "  cid " + "," + "  cdate " + "," + "  condate " + "," + " bdate " + "," + "  eid " + "," + "  ename " + "," + "  eserial " + "," + " cname " + "," + "  clientemail " + "," + "qamnt" + "," + "trate " + "," + " tamnt " + "," + "  gamnt " + "," + " pamnt " + "," + " balance " + "," + " status " + "," + "pickupstatus " + ") VALUES (" + "  @bid " + "," + "  @cid " + "," + "  @cdate " + "," + "  @condate " + "," + "  @bdate " + "," + "  @eid " + "," + "  @ename " + "," + "  @eserial " + "," + "  @cname " + "," + "  @clientemail " + "," + "  @qamnt" + "," + "  @trate " + "," + "  @tamnt" + "," + "  @gamnt " + "," + "  @pamnt " + "," + "  @balance" + "," + "  @status" + "," + "  @pickupstatus" + ")";
                        mySqlCommand.Parameters.Add ("@bid", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@bid"].Value = cmbxbid.Text;
                        mySqlCommand.Parameters.Add ("@cid", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@cid"].Value = txtcid.Text;
                        mySqlCommand.Parameters.Add ("@cdate", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@cdate"].Value = txtcleardate.Text;
                        mySqlCommand.Parameters.Add ("@condate", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@condate"].Value = txtdate.Text;
                        mySqlCommand.Parameters.Add ("@bdate", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@bdate"].Value = txtbilldate.Text;
                        mySqlCommand.Parameters.Add ("@eid", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@eid"].Value = txtequipmentid.Text;
                        mySqlCommand.Parameters.Add ("@ename", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@ename"].Value = txtequipmentname.Text;
                        mySqlCommand.Parameters.Add ("@eserial", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@eserial"].Value = txtequipmentserial.Text;
                        mySqlCommand.Parameters.Add ("@cname", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@cname"].Value = txtclientname.Text;
                        mySqlCommand.Parameters.Add ("@clientemail", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@clientemail"].Value = txtclientemail.Text;
                        mySqlCommand.Parameters.Add ("@qamnt", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@qamnt"].Value = txtqamnt.Text;
                        mySqlCommand.Parameters.Add ("@trate", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@trate"].Value = txttaxrate.Text;
                        mySqlCommand.Parameters.Add ("@tamnt", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@tamnt"].Value = txttxamnt.Text;
                        mySqlCommand.Parameters.Add ("@gamnt", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@gamnt"].Value = txtgamnt.Text;
                        mySqlCommand.Parameters.Add ("@pamnt", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@pamnt"].Value = txtpamnt.Text;
                        mySqlCommand.Parameters.Add ("@balance", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@balance"].Value = txtbalance.Text;
                        mySqlCommand.Parameters.Add ("@status", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@status"].Value = txtstatus.Text;
                        mySqlCommand.Parameters.Add ("@pickupstatus", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@pickupstatus"].Value = cmbxpickup.Text;


                        mySqlCommand.ExecuteNonQuery ();
                        //Console.WriteLine ("Successfully added row to Customers table");
                        MetroFramework.MetroMessageBox.Show (this, "Successfully saved", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear ();
                        connect.Close ();
                        txtstatus.BackColor = System.Drawing.Color.White;
                        txtstatus.Clear ();
                          // Add 
                    }
                }
                catch (MySqlException ex)
                {

                    writeErrorLog (ex.Message);
                   
                }
                finally
                {
                    if (conn != null)
                        connect.Close ();
                }
            }
        }

        private void cmbxstid_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (cmbxstid.SelectedIndex < 0)
            {
                // Don't want to suffer database hit if nothing is selected
                // Simply clear text boxes and return

                //AddressBox.Text = "";
            }
            else
            {
                MySqlConnection cs = new MySqlConnection (conn);
                cs.Open ();

                DataSet ds = new DataSet ();

                // You only need to select the address since you already have the name unless 
                // they are displayed differently and you want the database display to show
                MySqlDataAdapter da = new MySqlDataAdapter ("Select * from tblbill WHERE status='" + cmbxstid.Text + "'", cs);
                //select* from tblbill WHERE status = 'Item Cleared
                MySqlCommandBuilder cmd = new MySqlCommandBuilder (da);

                da.Fill (ds);

                //NameBox.Text = comboBox1.Text;
                txtcid.Text = ds.Tables [0].Rows [0] ["rcid"].ToString ();
                txtequipmentid.Text = ds.Tables [0].Rows [0] ["eid"].ToString ();
                txtequipmentname.Text = ds.Tables [0].Rows [0] ["ename"].ToString ();
                txtequipmentserial.Text = ds.Tables [0].Rows [0] ["eserial"].ToString ();
                txtclientname.Text = ds.Tables [0].Rows [0] ["cname"].ToString ();
                txtclientemail.Text = ds.Tables [0].Rows [0] ["cmail"].ToString ();
                txtdate.Text = ds.Tables [0].Rows [0] ["invdate"].ToString ();
                txtbilldate.Text = ds.Tables [0].Rows [0] ["bdate"].ToString ();
                txtqamnt.Text = ds.Tables [0].Rows [0] ["qamnt"].ToString ();
                txttaxrate.Text = ds.Tables [0].Rows [0] ["trate"].ToString ();
                txttxamnt.Text = ds.Tables [0].Rows [0] ["tamnt"].ToString ();
                txtgamnt.Text = ds.Tables [0].Rows [0] ["gamnt"].ToString ();
                txtpamnt.Text = ds.Tables [0].Rows [0] ["pamnt"].ToString ();
                txtbalance.Text = ds.Tables [0].Rows [0] ["balance"].ToString ();
                txtstatus.Text = ds.Tables [0].Rows [0] ["status"].ToString ();
                cmbxbid.Text = ds.Tables [0].Rows [0] ["bid"].ToString ();


            }
        }
        public void clear()
        {
            cmbxpickup.ResetText ();
            cmbxstid.ResetText ();
            txtclearanceid.Clear ();
            txtbalance.Clear ();
            txtbilldate.Clear ();
            txtcid.Clear ();
            txtclientemail.Clear ();
            txtclientname.Clear ();
            txtdate.Clear ();
            txtgamnt.Clear ();
            txtpamnt.Clear ();
            txtstatus.Clear ();
            txtqamnt.Clear ();
            cmbxbid.ResetText ();
            txttaxrate.Clear ();
            txttxamnt.Clear ();
            txtequipmentid.Clear ();
            txtequipmentname.Clear ();
            txtequipmentserial.Clear ();
            txttxamnt.Clear ();
            txtbilldate.Clear ();
        }
        private void button8_Click (object sender, EventArgs e)
        {
            clear ();

        }

        private void btnupdate_Click (object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier ();
            popup.Image = Properties.Resources.Excel_2013;
            popup.TitleText = "TWMS";
            popup.ContentText = "To delete click clearedItems button select record then use the delete button to delete";
            popup.Popup ();

            if (String.IsNullOrEmpty (cmbxbid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (String.IsNullOrEmpty (txtcid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtcleardate.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtdate.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtbilldate.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtequipmentid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtequipmentname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtequipmentserial.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtclientname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtclientemail.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxpickup.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtqamnt.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txttaxrate.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txttxamnt.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtgamnt.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtpamnt.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtbalance.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtstatus.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            else
            {
                db_connection ();
                MySqlConnection connection = null;

                try
                {

                    connection = new MySqlConnection (conn);
                    connection.Open ();
                    MySqlCommand cmd = new MySqlCommand ();
                    cmd.Connection = connection;
                    cmd.CommandText = "delete from tblcleareditems where clearanceid='" + txtclearanceid.Text + "';";

                    cmd.ExecuteNonQuery ();
                    MetroFramework.MetroMessageBox.Show (this, "Pickup Summary deleted", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear ();

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

        }
        private void btnloadcleared_Click (object sender, EventArgs e)
        {
            frmviewpickeditemstech frm = new Forms.frmviewpickeditemstech ();
            frm.Show ();
            this.Hide ();
        }
    }
}
