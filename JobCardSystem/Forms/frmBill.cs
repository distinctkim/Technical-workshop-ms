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
    public partial class frmBill : MetroFramework.Forms.MetroForm 
    {

        /// <summary>
        /// Initialization of the connection variable
        /// </summary>
       // private string server;
       // private string database;
        //private string uid;
        //private string password;
        private string conn;
        private MySqlConnection connect;
        //MySqlTransaction tr = null;
        //MySqlCommand cmd;
        //MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
        MySqlTransaction tr = null;
        public frmBill ()
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


        private void cmbxrcid_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (cmbxrcid.SelectedIndex < 0)
            {
                // Don't want to suffer database hit if nothing is selected
                // Simply clear text boxes and return
                txtequipmentname.Text = "";
                //AddressBox.Text = "";
            }
            else
            {
                MySqlConnection cs = new MySqlConnection (conn);
                cs.Open ();

                DataSet ds = new DataSet ();

                // You only need to select the address since you already have the name unless 
                // they are displayed differently and you want the database display to show
                MySqlDataAdapter da = new MySqlDataAdapter ("Select * from tblconequip WHERE rcid='" + cmbxrcid.Text + "'", cs);

                MySqlCommandBuilder cmd = new MySqlCommandBuilder (da);

                da.Fill (ds);

                //NameBox.Text = comboBox1.Text;
                txtqid.Text = ds.Tables [0].Rows [0] ["qid"].ToString ();
                txtrid.Text = ds.Tables [0].Rows [0] ["rid"].ToString ();
                txtequipmentid.Text = ds.Tables [0].Rows [0] ["eid"].ToString ();
                txtequipmentname.Text = ds.Tables [0].Rows [0] ["ename"].ToString ();
                txtequipmentserial.Text = ds.Tables [0].Rows [0] ["eserial"].ToString ();
                txtclientname.Text = ds.Tables [0].Rows [0] ["cname"].ToString ();
                txtclientemail.Text = ds.Tables [0].Rows [0] ["clientemail"].ToString ();
                txtdiagnosisdone.Text = ds.Tables [0].Rows [0] ["ddone"].ToString ();
                txtreportedproblem.Text = ds.Tables [0].Rows [0] ["rproblem"].ToString ();
                txthditems.Text = ds.Tables [0].Rows [0] ["hitm"].ToString ();
                txtsftitems.Text = ds.Tables [0].Rows [0] ["sitm"].ToString ();
                txthwserial.Text = ds.Tables [0].Rows [0] ["hserial"].ToString ();

                cmbxstatus.Text = ds.Tables [0].Rows [0] ["status"].ToString ();
                cmbxassignedtech.Text = ds.Tables [0].Rows [0] ["techas"].ToString ();
                cmbxtechsum.Text = ds.Tables [0].Rows [0] ["techsum"].ToString ();
                txtnotes.Text = ds.Tables [0].Rows [0] ["notes"].ToString ();
                txtdate.Text = ds.Tables [0].Rows [0] ["date"].ToString ();

                txtqamnt.Text = ds.Tables [0].Rows [0] ["qamnt"].ToString ();
                txttaxrate.Text = ds.Tables [0].Rows [0] ["tax"].ToString ();
                txttxamnt.Text = ds.Tables [0].Rows [0] ["taxamnt"].ToString ();
                txtgamnt.Text = ds.Tables [0].Rows [0] ["gamnt"].ToString ();


            }
        }

        private void textBox2_TextChanged (object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty (txttxamnt.Text)) && (!string.IsNullOrEmpty (txtqamnt.Text)))
            {
               // double positive = 13.45;
               // double negative = -32.56;
               // double zero = 0;

               // string format = "+#.##;-#.##;(0)";

               // Console.WriteLine (positive.ToString (format));
               // Console.WriteLine (negative.ToString (format));
               // Console.WriteLine (zero.ToString (format));
                // txttxamnt.Text = Convert.ToString (Convert.ToInt32 (txtqamnt.Text) * Convert.ToInt32 (txttaxrate.Text) / 100).ToString();
               // txtbalance.Text = (Convert.ToInt32 (txtgamnt.Text) - Convert.ToInt32 (txtpamnt.Text)).ToString ();
                // txtbalance.Text = (positive.ToString (format));
                // txtbalance.Text = (negative.ToString (format));
                // txtbalance.Text = (zero.ToString (format));
               
            }
            else
            {
                txtpamnt.Text = "0";
            }
        }
        public int Discount
        {
            get
            {
                int discount;
                return int.TryParse (txtbalance.Text, out discount) ? discount : 0;
            }
        }

        private void frmBill_Load (object sender, EventArgs e)
        {
            selectComboID ();
            btnupdate.Visible = false;
            txtbilldate.Text = DateTime.Today.ToShortDateString ();
        }
        public void selectComboID ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT rcid FROM tblconequip;";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                cmbxrcid.Items.Add (rowz);
            }
            connection.Close ();
        }

        private void txtbalance_TextChanged (object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse (txtbalance.Text, out value))
            {
                if (value >= 0)
                {
                    txtbalance.BackColor = System.Drawing.Color.Green;
                    txtstatus.Text = "ItemCleared";
                }
                else
                {

                    txtbalance.BackColor = System.Drawing.Color.Red;
                    txtstatus.Text = "NotCleared";

                }
            }
        }

        private void button5_Click (object sender, EventArgs e)
        {
            //txtbalance.Text = "0";
            //txtpamnt.Text="0";
            int a = Convert.ToInt32 (txtgamnt.Text);
            int b = Convert.ToInt32 (txtpamnt.Text);
            int c = b - a;
            txtbalance.Text = Convert.ToString (c);
        }

        private void txtgamnt_TextChanged (object sender, EventArgs e)
        {

        }
        private void clear ()
        {
            cmbxtechsum.ResetText ();
            cmbxstatus.ResetText ();
            cmbxrcid.ResetText ();
            cmbxassignedtech.ResetText ();
            txtbid.Clear();
            txtclientemail.Clear ();
            txtclientname.Clear ();
            txtdate.Clear ();
            txtdiagnosisdone.Clear ();
            txtequipmentid.Clear ();
            txtequipmentname.Clear ();
            txtequipmentserial.Clear ();
            txtgamnt.Clear ();
            txthditems.Clear ();
            txthwserial.Clear ();
            txtnotes.Clear ();
            txtpamnt.Clear ();
            txtqamnt.Clear ();
            txtqid.Clear ();
            txtreportedproblem.Clear ();
            txtrid.Clear ();
            txtsftitems.Clear ();
            txtstatus.Clear ();
            txttaxrate.Clear ();
            txttxamnt.Clear ();
            txtbalance.Clear ();
            txtdate.Clear ();
            txtbilldate.Clear ();

            //txtdate.Text = DateTime.Today.ToShortDateString ();
        }
        private void button13_Click (object sender, EventArgs e)
        {
          
            if (String.IsNullOrEmpty (cmbxrcid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (String.IsNullOrEmpty (cmbxassignedtech.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxstatus.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxtechsum.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtpamnt.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txthditems.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtequipmentserial.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txthwserial.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtnotes.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtpamnt.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtreportedproblem.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtrid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtstatus.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtsftitems.Text))
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
            if (String.IsNullOrEmpty (txtbalance.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
           if (String.IsNullOrEmpty (txtbilldate.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtclientemail.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtclientname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtdate.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtdiagnosisdone.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtequipmentname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtequipmentid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                try
                {
                    db_connection ();
                    MySqlCommand cmd = new MySqlCommand ("select * from tblbill where bid = '" + txtbid.Text + "'", connect);
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
                        "INSERT INTO tblbill(" + "  rcid " + "," + "  bdate " + "," + "  invdate " + "," + "  invid " + "," + "  rid " + "," + "  eid " + "," + "  ename " + "," + "  eserial " + "," + " cname " + "," + "  cmail " + "," + " rproblem " + "," + "  ddone " + "," + " hitms " + "," + "  sitms " + "," + " hwsno " + "," + "  progressstatus " + "," + " atech " + "," + "tsumm " + "," + " notes " + "," + " qamnt " + "," + " trate " + "," + "  tamnt " + "," + " gamnt " + "," + "pamnt " + "," + " balance " + "," + " status " + ") VALUES (" + "  @rcid " + "," + "  @bdate " + "," + "  @invdate " + "," + "  @invid " + "," + "  @rid " + "," + "  @eid " + "," + "  @ename " + "," + "  @eserial " + "," + "  @cname " + "," + "  @cmail " + "," + "  @rproblem " + "," + "  @ddone " + "," + "  @hitms " + "," + "  @sitms " + "," + "  @hwsno " + "," + "  @progressstatus" + "," + "  @atech " + "," + "  @tsumm " + "," + "  @notes " + "," + "  @qamnt" + "," + "  @trate " + "," + "  @tamnt" + "," + "  @gamnt " + "," + "  @pamnt" + "," + "  @balance " + "," + "  @status" + ")";
                        mySqlCommand.Parameters.Add ("@rcid", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@rcid"].Value = cmbxrcid.Text;
                        mySqlCommand.Parameters.Add ("@bdate", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@bdate"].Value = txtbilldate.Text;
                        mySqlCommand.Parameters.Add ("@invdate", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@invdate"].Value = txtdate.Text;

                        mySqlCommand.Parameters.Add ("@invid", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@invid"].Value = txtqid.Text;
                        mySqlCommand.Parameters.Add ("@rid", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@rid"].Value = txtrid.Text;
                        mySqlCommand.Parameters.Add ("@eid", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@eid"].Value = txtequipmentid.Text;
                        mySqlCommand.Parameters.Add ("@ename", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@ename"].Value = txtequipmentname.Text;
                        mySqlCommand.Parameters.Add ("@eserial", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@eserial"].Value = txtequipmentserial.Text;
                        mySqlCommand.Parameters.Add ("@cname", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@cname"].Value = txtclientname.Text;
                        mySqlCommand.Parameters.Add ("@cmail", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@cmail"].Value = txtclientemail.Text;
                        mySqlCommand.Parameters.Add ("@rproblem", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@rproblem"].Value = txtreportedproblem.Text;
                        mySqlCommand.Parameters.Add ("@ddone", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@ddone"].Value = txtdiagnosisdone.Text;
                        mySqlCommand.Parameters.Add ("@hitms", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@hitms"].Value = txthditems.Text;
                        mySqlCommand.Parameters.Add ("@sitms", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@sitms"].Value = txtsftitems.Text;
                        mySqlCommand.Parameters.Add ("@hwsno", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@hwsno"].Value = txthwserial.Text;
                        mySqlCommand.Parameters.Add ("@progressstatus", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@progressstatus"].Value = cmbxstatus.Text;
                        mySqlCommand.Parameters.Add ("@atech", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@atech"].Value = cmbxassignedtech.Text;
                        mySqlCommand.Parameters.Add ("@tsumm", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@tsumm"].Value = cmbxtechsum.Text;
                        mySqlCommand.Parameters.Add ("@notes", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@notes"].Value = txtnotes.Text;
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





                        mySqlCommand.ExecuteNonQuery ();
                        //Console.WriteLine ("Successfully added row to Customers table");
                        MetroFramework.MetroMessageBox.Show (this, "Successfully saved", "Automated Job  Card System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear ();
                        connect.Close ();
                        txtstatus.BackColor = System.Drawing.Color.White;
                        txtstatus.Clear ();
                        txtbilldate.Text = DateTime.Today.ToShortDateString ();
                        // Add 
                    }
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

        private void txtdiagnosisdone_TextChanged (object sender, EventArgs e)
        {

        }

        private void btnupdate_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (cmbxrcid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (String.IsNullOrEmpty (cmbxassignedtech.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxstatus.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxtechsum.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtpamnt.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txthditems.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtequipmentserial.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txthwserial.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtnotes.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtpamnt.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtreportedproblem.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtrid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtstatus.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtsftitems.Text))
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
            if (String.IsNullOrEmpty (txtbalance.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtbid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtbilldate.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtclientemail.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtclientname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtdate.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtdiagnosisdone.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtequipmentname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtequipmentid.Text))
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

                    cmd.CommandText = "UPDATE tblbill SET pamnt= " + "  @pamnt " + ", balance = " + "  @balance " + " , status = " + "  @status " + " WHERE bid= '" + this.txtbid.Text + "';";
                    cmd.Parameters.AddWithValue ("@pamnt", txtpamnt.Text);
                    cmd.Parameters.AddWithValue ("@balance",txtbalance.Text);
                    cmd.Parameters.AddWithValue ("@status", txtstatus.Text);
                  
                
                    cmd.ExecuteNonQuery ();

                    tr.Commit ();
                    MetroFramework.MetroMessageBox.Show (this, "Record updated successfully", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear ();

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

        private void button6_Click (object sender, EventArgs e)
        {
            btnupdate.Visible = true;
            button13.Visible = false;
        }

        private void button8_Click (object sender, EventArgs e)
        {
            clear ();
            txtbilldate.Text = DateTime.Today.ToShortDateString ();
        }

        private void button10_Click (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection connection = null;
            
                try
                {

                    connection = new MySqlConnection (conn);
                    connection.Open ();
                    MySqlCommand cmd = new MySqlCommand ();
                    cmd.Connection = connection;
                    cmd.CommandText = "delete from tblbill where bid='" + txtbid.Text + "';";

                    cmd.ExecuteNonQuery ();
                    MetroFramework.MetroMessageBox.Show (this, "Bill deleted", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        

        private void button12_Click (object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.Show ();
            this.Hide ();

        }

        private void button11_Click (object sender, EventArgs e)
        {
            frmbillinfogrid frm = new frmbillinfogrid ();
            frm.Show ();
            this.Hide ();
        }

        private void txtstatus_TextChanged (object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {
            txtpamnt.Text = Convert.ToString (Convert.ToInt32 (txtpamnt.Text) + Convert.ToInt32 (txttopup.Text)).ToString ();
               
        }

        private void txtqamnt_TextChanged (object sender, EventArgs e)
        {

        }
    }
    
}
