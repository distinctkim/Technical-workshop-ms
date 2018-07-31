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
    public partial class frmconfirmequipment : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Initialization of the connection variable
        /// </summary>

        private string conn;
        private MySqlConnection connect;
        //MySqlTransaction tr = null;
        //MySqlCommand cmd;
        //MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
        MySqlTransaction tr = null;
        public frmconfirmequipment ()
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

        public void selectComboID ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT qid FROM tblquote;";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                cmbxqid.Items.Add (rowz);
            }
            connection.Close ();
        }
        public void selectTechname ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT empname FROM login;";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                cmbxassignedtech.Items.Add (rowz);
            }
            connection.Close ();
        }
        public void fillstatus ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT status FROM tblstatus;";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                cmbxstatus.Items.Add (rowz);
            }
            connection.Close ();
        }

        private void frmconfirmequipment_Load (object sender, EventArgs e)
        {
            Timer MyTimer = new Timer ();
            MyTimer.Interval = (5 * 60 * 1000); // 5 mins
            MyTimer.Tick += new EventHandler (timer1_Tick);
            MyTimer.Start ();
            txtdate.Text = DateTime.Today.ToShortDateString ();
            selectComboID ();
            selectTechname ();
            fillstatus ();
        }

        private void panel1_Paint (object sender, PaintEventArgs e)
        {

        }

        private void cmbxqid_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (cmbxqid.SelectedIndex < 0)
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
                MySqlDataAdapter da = new MySqlDataAdapter ("Select * from tblquote WHERE qid='" + cmbxqid.Text + "'", cs);

                MySqlCommandBuilder cmd = new MySqlCommandBuilder (da);

                da.Fill (ds);

                //NameBox.Text = comboBox1.Text;
                txtrid.Text = ds.Tables [0].Rows [0] ["rid"].ToString ();
                txtequipmentid.Text = ds.Tables [0].Rows [0] ["eid"].ToString ();
                txtequipmentname.Text = ds.Tables [0].Rows [0] ["ename"].ToString ();
                txtequipmentserial.Text = ds.Tables [0].Rows [0] ["eserial"].ToString ();
                txtclientname.Text = ds.Tables [0].Rows [0] ["cname"].ToString ();
                txtclientemail.Text = ds.Tables [0].Rows [0] ["clientemail"].ToString ();
                txtdiagnosisdone.Text = ds.Tables [0].Rows [0] ["ddone"].ToString ();
                txtreportedproblem.Text = ds.Tables [0].Rows [0] ["rproblem"].ToString ();
                txthditems.Text = ds.Tables [0].Rows [0] ["hditems"].ToString ();
                txtsftitems.Text = ds.Tables [0].Rows [0] ["sftitems"].ToString ();
                txtqamnt.Text = ds.Tables [0].Rows [0] ["qamnt"].ToString ();
                txttaxrate.Text = ds.Tables [0].Rows [0] ["taxrate"].ToString ();
                txttxamnt.Text = ds.Tables [0].Rows [0] ["taxamnt"].ToString ();
                txtgamnt.Text = ds.Tables [0].Rows [0] ["gamnt"].ToString ();

            }
        }

        private void cmbxstatus_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private void Button2_Click (object sender, EventArgs e)
        {
            Home shw = new Home ();
            shw.Show ();
            this.Hide ();


        }

        private void btnAdd_Click (object sender, EventArgs e)
        {
            clear ();
            btnupdate.Visible = false;
            Button1.Visible = true;
            txtdate.Text = DateTime.Today.ToShortDateString ();

        }
        private void clear ()
        {
            txtclientname.Clear ();
            txtclientemail.Clear ();
            txtdiagnosisdone.Clear ();
            txtequipmentid.Clear ();
            txtequipmentname.Clear ();
            txtequipmentserial.Clear ();
            txthditems.Clear ();
            txthwserial.Clear ();
            txtnotes.Clear ();
            txtrcid.Clear ();
            txtreportedproblem.Clear ();
            txtrid.Clear ();
            txtsftitems.Clear ();
            cmbxassignedtech.ResetText ();
            cmbxqid.ResetText ();
            cmbxstatus.ResetText ();
            cmbxtechsum.ResetText ();
            txtdate.Clear ();
        }

        private void button7_Click (object sender, EventArgs e)
        {
            btnupdate.Visible = true;
            Button1.Visible = false;
        }

        private void Button1_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtclientname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (String.IsNullOrEmpty (txtrid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtequipmentid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txthwserial.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxstatus.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (cmbxassignedtech.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (cmbxtechsum.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    db_connection ();
                    MySqlCommand cmd = new MySqlCommand ("select * from tblconequip where rcid = '" + txtrcid.Text + "'", connect);
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
                        "INSERT INTO tblconequip  (" + "  qid " + "," + "rid" + "," + "eid" + "," + "ename" + "," + "eserial" + "," + "cname" + "," + "clientemail" + "," + "rproblem" + "," + "ddone" + "," + "hitm" + "," + "sitm" + "," + "hserial" + "," + "status" + "," + "techas" + "," + "techsum" + "," + "notes" + "," + "date" + "," + "qamnt" + "," + "tax" + "," + "taxamnt" + "," + "gamnt" + ") VALUES (" + "  @qid " + "," + "  @rid " + "," + "@eid" + "," + "@ename" + "," + "@eserial" + "," + "@cname" + "," + "@clientemail" + "," + "@rproblem" + "," + "@ddone" + "," + "@hitm" + "," + "@sitm" + "," + "@hserial" + "," + "@status" + "," + "@techas" + "," + "@techsum" + "," + "@notes" + "," + "@date" + "," + "@qamnt" + "," + "@tax" + "," + "@taxamnt" + "," + "@gamnt" + ")";
                        mySqlCommand.Parameters.Add ("@qid", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@qid"].Value = cmbxqid.Text;
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
                        mySqlCommand.Parameters.Add ("@clientemail", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@clientemail"].Value = txtclientemail.Text;
                        mySqlCommand.Parameters.Add ("@rproblem", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@rproblem"].Value = txtreportedproblem.Text;
                        mySqlCommand.Parameters.Add ("@ddone", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@ddone"].Value = txtdiagnosisdone.Text;
                        mySqlCommand.Parameters.Add ("@hitm", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@hitm"].Value = txthditems.Text;
                        mySqlCommand.Parameters.Add ("@sitm", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@sitm"].Value = txtsftitems.Text;
                        mySqlCommand.Parameters.Add ("@hserial", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@hserial"].Value = txthwserial.Text;
                        mySqlCommand.Parameters.Add ("@status", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@status"].Value = cmbxstatus.Text;
                        mySqlCommand.Parameters.Add ("@techas", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@techas"].Value = cmbxassignedtech.Text;
                        mySqlCommand.Parameters.Add ("@techsum", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@techsum"].Value = cmbxtechsum.Text;
                        mySqlCommand.Parameters.Add ("@notes", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@notes"].Value = txtnotes.Text;
                        mySqlCommand.Parameters.Add ("@date", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@date"].Value = txtdate.Text;
                        mySqlCommand.Parameters.Add ("@qamnt", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@qamnt"].Value = txtqamnt.Text;
                        mySqlCommand.Parameters.Add ("@tax", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@tax"].Value = txttaxrate.Text;
                        mySqlCommand.Parameters.Add ("@taxamnt", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@taxamnt"].Value = txttxamnt.Text;
                        mySqlCommand.Parameters.Add ("@gamnt", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@gamnt"].Value = txtgamnt.Text;








                        mySqlCommand.ExecuteNonQuery ();
                        //Console.WriteLine ("Successfully added row to Customers table");
                        MetroFramework.MetroMessageBox.Show (this, "Successfully saved", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnupdate_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtclientname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (String.IsNullOrEmpty (txtrid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtequipmentid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txthwserial.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxstatus.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (cmbxassignedtech.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (cmbxtechsum.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else

                try
                {
                    db_connection ();

                    tr = connect.BeginTransaction ();

                    MySqlCommand cmd = new MySqlCommand ();
                    cmd.Connection = connect;
                    cmd.Transaction = tr;

                    cmd.CommandText = "UPDATE tblconequip SET hserial= " + "  @hserial " + ",  status = " + "  @status " + " ,  techas = " + "  @techas " + ", techsum  =" + "  @techsum " + " WHERE rcid= '" + this.txtrcid.Text + "';";
                    cmd.Parameters.AddWithValue ("@hserial", txthwserial.Text);
                    cmd.Parameters.AddWithValue ("@status", cmbxstatus.Text);
                    cmd.Parameters.AddWithValue ("@techas", cmbxassignedtech.Text);
                    cmd.Parameters.AddWithValue ("@techsum", cmbxtechsum.Text);
                    //cmd.Parameters.AddWithValue ("@building", txtbuilding.Text);
                    //cmd.Parameters.AddWithValue ("@commode", cmbxcontact.Text);
                    cmd.ExecuteNonQuery ();
                    MetroFramework.MetroMessageBox.Show (this, "Record updated successfully", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear ();
                    tr.Commit ();

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

        private void button4_Click (object sender, EventArgs e)
        {
            frmconfirmequipmentgrid frm = new frmconfirmequipmentgrid ();
            frm.Show ();
            this.Hide ();
        }

        private void timer1_Tick (object sender, EventArgs e)
        {
            /*{
                DialogResult dialogresult = MetroFramework.MetroMessageBox.Show (this, "Session timeout!,do you want to continue using it", "Automated Job  Card System", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogresult == DialogResult.Yes)
                {
                    //timer1.Start ();

                    frmlogin At = new frmlogin ();
                    At.Show ();
                    this.Hide ();
                    // return;
                }
                else if (dialogresult == DialogResult.No)
                {
                    MessageBox.Show ("Goodbye", "Time Elapsed");
                    this.Close ();
                }
            }
            */
        }

        private void textBox2_TextChanged (object sender, EventArgs e)
        {
          
        }

        private void txtgamnt_TextChanged (object sender, EventArgs e)
        {

        }

        private void txtbalance_TextChanged (object sender, EventArgs e)
        {

        }
        
    }
}
