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
    public partial class frmquote : MetroFramework.Forms.MetroForm 
    {
        /// <summary>
        /// Initialization of the connection variable
        /// </summary>
        private string server;
        private string database;
        private string uid;
        private string password;
        private string conn;
        private MySqlConnection connect;
        //MySqlTransaction tr = null;
        //MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
        MySqlTransaction tr = null;
        public frmquote ()
        {
            InitializeComponent ();
        }
        //
        void EnterValuesToDatagridView (object sender, EventArgs e)
        {
            // TODO: Implement Button1Click

            //
            // Variable for storing new row number in grid
            //
            int Row = 0;

            //
            // Check whether the user has entered all the values
            //
            if (comboBox1.Text != "" & textBox2.Text != "")
            {

                //
                // Add new row to DataGridView where the values
                // are to be entered
                //
                kdvtarrif.Rows.Add ();

                //
                // Get Row number ,
                // it is reduced by two because
                // the first row number is zero, after adding
                // new row to allready
                // existing one.
                //
                Row = kdvtarrif.Rows.Count - 2;

                //
                // Store values from text boxes to DataGridView
                //
                kdvtarrif [0, Row].Value = comboBox2.Text;
                kdvtarrif [1, Row].Value = textBox2.Text;
                kdvtarrif.Refresh ();

                //
                // This is optional
                // Clear text boxes
                //
                //textBox1.Text = "";
                textBox2.Text = "";

            }

            //
            // If all text boxes are not filled in
            //
            else
            {
                MessageBox.Show ("You did not entered values to all text boxes",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged (object sender, EventArgs e)
        {

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
        public void autonumber ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT max(qid)+1 FROM tbltarrifs;";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                //txtqid.Text = dt[0].ToString ();
            }
            connection.Close ();
        }

        public void selectComboservice ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT servicename FROM tbltarrifs;";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                comboBox2.Items.Add (rowz);
            }
            connection.Close ();
        }

        private void frmrequirements_Load (object sender, EventArgs e)
        {
           // shiftgrid ();
            selectComboID ();
            selectComboservice ();
            btnupdate.Visible = false;
            //button3.Visible = false;
            button5.Visible = false;
            button9.Visible = false;
            txttaxrate.Text = Convert.ToInt32(16).ToString();
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
        public void selectComboID ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT rid FROM tblreq;";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                comboBox1.Items.Add (rowz);
            }
            connection.Close ();
        }
        private void shiftgrid ()
        {
            server = "localhost";
            database = "jobauto";
            uid = "root";
            password = "";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connect = new MySqlConnection (connectionString);
            if (this.OpenConnection () == true)
            {
                adapter = new MySqlDataAdapter ("select * from tbltarrifs", connect);
                DataSet DS = new DataSet ();
                adapter.Fill (DS);
                kdvtarrif.DataSource = DS.Tables [0];
                kdvtarrif.Columns [1].HeaderText = "Stockid";
                kdvtarrif.Columns [2].HeaderText = "Tarrif Description";
                kdvtarrif.Columns [3].HeaderText = "ServiceName";
                kdvtarrif.Columns [4].HeaderText = "Unit Price";



                //close connection
                this.CloseConnection ();
            }
            this.kdvtarrif.Columns [0].Visible = false;
        }
        //open connection to database
        private bool OpenConnection ()
        {
            try
            {
                connect.Open ();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show ("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show ("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show (ex.Message);
                        break;
                }
                return false;
            }
        }
        //Close connection
        private bool CloseConnection ()
        {
            try
            {
                connect.Close ();
                return true;
            }
            catch (MySqlException ex)
            {
               writeErrorLog(ex.Message);
                return false;
            }
        }

        private void button4_Click (object sender, EventArgs e)
        {
            frmquoteInfoGrid quote = new Forms.frmquoteInfoGrid ();
            quote.Show ();
            this.Hide ();
        }

        private void comboBox1_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
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
                MySqlDataAdapter da = new MySqlDataAdapter ("Select * from tblreq WHERE rid='" + comboBox1.Text + "'", cs);

                MySqlCommandBuilder cmd = new MySqlCommandBuilder (da);

                da.Fill (ds);

                //NameBox.Text = comboBox1.Text;
               // txtequipmentid.Text = ds.Tables [0].Rows [0] ["eid"].ToString ();
                txtequipmentid.Text = ds.Tables [0].Rows [0] ["eid"].ToString ();
                txtequipmentname.Text = ds.Tables [0].Rows [0] ["ename"].ToString ();
                txtequipmentserial.Text = ds.Tables [0].Rows [0] ["eserial"].ToString ();
                txtclientname.Text = ds.Tables [0].Rows [0] ["cname"].ToString ();
                txtclientemail.Text = ds.Tables [0].Rows [0] ["clientemail"].ToString ();
                txtreportedproblem.Text = ds.Tables [0].Rows [0] ["rproblem"].ToString ();
                txtdiagnosisdone.Text = ds.Tables [0].Rows [0] ["ddone"].ToString ();
                txtcathd.Text = ds.Tables [0].Rows [0] ["cathdw"].ToString ();
              txtcatsft.Text = ds.Tables [0].Rows [0] ["catsft"].ToString ();
              txthditems.Text = ds.Tables [0].Rows [0] ["itmhdw"].ToString ();
              txtsftitems.Text = ds.Tables [0].Rows [0] ["itmsft"].ToString ();
            }
        }
        private void kdvtarrif_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            
            /*
            decimal amount = 0;
            //dataGridView1.Rows.Add (SNoTextBox.Text, PriceTextBox.Text, QtyTextBox.Text);

            foreach (DataGridViewRow row in kdvtarrif.Rows)
            {
                row.Cells [kdvtarrif.Columns ["price"].Index].Value = (Convert.ToDouble (row.Cells [kdvtarrif.Columns ["price"].Index].Value));

                amount += Convert.ToDecimal (row.Cells [kdvtarrif.Columns ["price"].Index].Value);
            }
            txtqamnt.Text = amount.ToString ();

            */



        }
        /*if (e.ColumnIndex == 4)
           {
               txtqamnt.Text = (from DataGridViewRow r in kdvtarrif.Rows
                                select Convert.ToDouble (r.Cells [e.ColumnIndex].Value))
                                .Sum ().ToString ();
           }
           */
        private void cmbxhdw_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private void Button1_Click (object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty (comboBox1.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtclientname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtcathd.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtcatsft.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtgamnt.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtdiagnosisdone.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtequipmentid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtequipmentserial.Text))
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
            if (String.IsNullOrEmpty (txthditems.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtsftitems.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            else
            {
                try
                {
                    db_connection ();
                    MySqlCommand cmd = new MySqlCommand ("select * from tblquote where qid = '" + txtqid.Text + "'", connect);
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
                        "INSERT INTO tblquote  (" + "  rid " + "," + "eid" + "," + "ename" + "," + "eserial" + "," + "cname" + "," + "clientemail" + "," + "rproblem" + "," + "ddone" + "," + "cat1" + "," + "cat2" + "," + "hditems" + "," + "sftitems" + "," + "qamnt" + "," + "taxrate" + "," + "taxamnt" + "," + "gamnt" + ") VALUES (" + "  @rid " + "," + "  @eid " + "," + "@ename" + "," + "@eserial" + "," + "@cname" + "," + "@clientemail" + "," + "@rproblem" + "," + "@ddone" + "," + "@cat1" + "," + "@cat2" + "," + "@hditems" + "," + "@sftitems" + "," + "@qamnt" + "," + "@taxrate" + "," + "@taxamnt" + "," + "@gamnt" + ")";
                        mySqlCommand.Parameters.Add ("@rid", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@rid"].Value = comboBox1.Text;
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
                        mySqlCommand.Parameters.Add ("@cat1", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@cat1"].Value = txtcathd.Text;
                        mySqlCommand.Parameters.Add ("@cat2", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@cat2"].Value = txtcatsft.Text;
                        mySqlCommand.Parameters.Add ("@hditems", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@hditems"].Value = txthditems.Text;
                        mySqlCommand.Parameters.Add ("@sftitems", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@sftitems"].Value = txthditems.Text;
                        mySqlCommand.Parameters.Add ("@qamnt", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@qamnt"].Value = txtqamnt.Text;
                        mySqlCommand.Parameters.Add ("@taxrate", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@taxrate"].Value = txttaxrate.Text;
                        mySqlCommand.Parameters.Add ("@taxamnt", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@taxamnt"].Value = txttxamnt.Text;
                        mySqlCommand.Parameters.Add ("@gamnt", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@gamnt"].Value = txtgamnt.Text;





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

        private void textBox8_TextChanged (object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty (txtqamnt.Text)))
            {
            
               
            }
        }

        private void txttxamnt_TextChanged (object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty (txttxamnt.Text)) && (!string.IsNullOrEmpty (txtqamnt.Text)))
            {
               // txttxamnt.Text = Convert.ToString (Convert.ToInt32 (txtqamnt.Text) * Convert.ToInt32 (txttaxrate.Text) / 100).ToString();
               // txtgamnt.Text = (Convert.ToInt32 (txttxamnt.Text) + Convert.ToInt32 (txtqamnt.Text)).ToString ();

            }
        }
        private void txtgamnt_TextChanged (object sender, EventArgs e)
        {
           
        }

        private void txttxamnt_KeyPress (object sender, KeyPressEventArgs e)
        {
            if ((!string.IsNullOrEmpty (txttxamnt.Text)) && (!string.IsNullOrEmpty (txtqamnt.Text)))
            {
                txtgamnt.Text += Convert.ToString (Convert.ToInt32 (txtqamnt.Text) + Convert.ToInt32 (txttxamnt.Text));
                //txtgamnt.Text = (Convert.ToInt32 (txtad.Text) + Convert.ToInt32 (txtqamnt.Text)).ToString ();
                // lblTax.Text = "Your tax bill would be $";
            }
        }

        private void txtqamnt_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber (e.KeyChar) & (Keys)e.KeyChar != Keys.Back & (Keys)e.KeyChar != Keys.Enter)
            {

                e.Handled = true;
                MessageBox.Show ("Enter numbers only");
            }

            base.OnKeyPress (e);
        }

        private void txtad_TextChanged (object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty (txttxamnt.Text)) && (!string.IsNullOrEmpty (txtqamnt.Text)))
            {
               // txtqamnt.Text = txtad.Text;
               txtgamnt.Text = (Convert.ToInt32 (txtqamnt.Text) + Convert.ToInt32 (txtqamnt.Text)).ToString ();

            }
        }

        private void txttaxrate_TextChanged (object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty (txttxamnt.Text)) && (!string.IsNullOrEmpty (txtqamnt.Text)))
            {
                // txtqamnt.Text = txtad.Text;
                // txtgamnt.Text = (Convert.ToInt32 (txtad.Text) + Convert.ToInt32 (txtqamnt.Text)).ToString ();
                //txttxamnt.Text += Convert.ToString (Convert.ToInt32 (txtqamnt.Text) * Convert.ToInt32 (txttaxrate.Text) / 100);


            }

        }

        private void button3_Click (object sender, EventArgs e)
        {
            //txttxamnt.Text += Convert.ToString (Convert.ToInt32 (txtqamnt.Text) * Convert.ToInt32 (txttaxrate.Text) / 100);
            txttxamnt.Text = Convert.ToString (Convert.ToInt32 (txtqamnt.Text) * Convert.ToInt32 (txttaxrate.Text) / 100).ToString ();
            //txttxamnt.Text = Convert.ToString (Convert.ToInt32 (txtqamnt.Text) * Convert.ToInt32 (txttaxrate.Text) / 100).ToString ();
            txtgamnt.Text = (Convert.ToInt32 (txttxamnt.Text) + Convert.ToInt32 (txtqamnt.Text)).ToString ();


        }

        private void button5_Click (object sender, EventArgs e)
        {
            txtgamnt.Text = (Convert.ToInt32 (txttxamnt.Text) + Convert.ToInt32 (txtqamnt.Text)).ToString ();
        }

        private void textBox2_TextChanged_1 (object sender, EventArgs e)
        {
           

        }

        private void button6_Click (object sender, EventArgs e)
        {
            
        }

        private void button7_Click (object sender, EventArgs e)
        {
            btnupdate.Visible = true;
            Button1.Visible = false;
        }

        private void Button2_Click (object sender, EventArgs e)
        {
            Home shw = new Forms.Home ();
            shw.Show ();
            this.Hide ();
        }

        private void button6_Click_1 (object sender, EventArgs e)
        {
            /*int sum = 0;

            for (int i = 0; i < kdvtarrif.Rows.Count; ++i)

            {

                sum += Convert.ToInt32 (kdvtarrif.Rows [i].Cells [4].Value);

            }

            txtqamnt.Text = "Total sum is:" + sum.ToString ();
            */
            //txtqamnt.Text = Convert.ToString (Convert.ToDouble (txtsum1.Text) + Convert.ToDouble (txtsum2.Text));
            
        }

        private void btnupdate_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtqamnt.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (String.IsNullOrEmpty (txtgamnt.Text))
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

                    cmd.CommandText = "UPDATE tblquote SET qamnt= " + "  @qamnt " + ",  taxamnt = " + "  @taxamnt " + " ,  gamnt = " + "  @gamnt " + " WHERE qid= '" + this.txtqid.Text + "';";
                    cmd.Parameters.AddWithValue ("@qamnt", txtqamnt.Text);
                    cmd.Parameters.AddWithValue ("@taxamnt",txttxamnt.Text);
                    cmd.Parameters.AddWithValue ("@gamnt", txtgamnt.Text);
                    
                    cmd.ExecuteNonQuery ();
                    MetroFramework.MetroMessageBox.Show (this, "Record updated successfully", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear ();
                    gridfresh ();
                    tr.Commit ();

                }
                catch (MySqlException ex)
                {
                    //MessageBox.Show (ex.Message.ToString ());
                    writeErrorLog (ex.Message);
                    tr.Rollback ();
                }
                finally
                {
                    if (conn != null)
                        connect.Close ();
                }
        }

        private void kdvtarrif_CellValueChanged (object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click (object sender, EventArgs e)
        {
            clear ();
            Button1.Visible = true;
            btnupdate.Visible = false;
        }
        private void clear ()
        {
            txtqid.Clear ();
            comboBox1.ResetText ();
            txtreportedproblem.Clear ();
            txtqamnt.Clear ();
            txtequipmentid.Clear ();
            txtequipmentname.Clear ();
            txtequipmentserial.Clear ();
            txtdiagnosisdone.Clear ();
            txtclientname.Clear ();
            txtclientemail.Clear ();
            txtcatsft.Clear ();
            txtcathd.Clear ();
            txtgamnt.Clear ();
            txthditems.Clear ();
            txtsftitems.Clear ();
            txttxamnt.Clear ();
            
        }
        private void gridfresh ()
        {
            frmquoteInfoGrid select = new Forms.frmquoteInfoGrid ();
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblquote");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            select.kdvquoteinfo.DataSource = dt;
        }

        private void btndelete_Click (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection connection = null;
            if (String.IsNullOrEmpty (txtqid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
          
            else
                try
                {

                    connection = new MySqlConnection (conn);
                    connection.Open ();
                    MySqlCommand cmd = new MySqlCommand ();
                    cmd.Connection = connection;
                    cmd.CommandText = "delete from tblquote where qid='" + txtqid.Text + "';";

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

        private void txtdiagnosisdone_TextChanged (object sender, EventArgs e)
        {

        }

        private void button6_Click_2 (object sender, EventArgs e)
        {
            //Check if all the textbox's are not blank. 
            //if not then execute the below lines
            if (String.IsNullOrEmpty (textBox2.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
                 if (String.IsNullOrEmpty (comboBox2.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else

            kdvtarrif.Rows.Add (1);
            int row = kdvtarrif.Rows.Count - 1;
            kdvtarrif.Rows [row].Cells [0].Value = Convert.ToString (comboBox2.Text);
            kdvtarrif.Rows [row].Cells [1].Value = Convert.ToString (textBox2.Text);
            double sum = 0;
            for (int i = 0; i < kdvtarrif.Rows.Count; ++i)
            {
                sum += Convert.ToDouble (kdvtarrif.Rows [i].Cells [1].Value);
            }
            txtqamnt.Text = sum.ToString ();
            comboBox2.ResetText ();
            textBox2.Clear ();
            //kdvtarrif.Rows [row].Cells [2].Value = Convert.ToString (TextBox3.Text);
            //kdvtarrif.Rows [row].Cells [3].Value = Convert.ToString (TextBox4.Text);
        }

        private void button8_Click (object sender, EventArgs e)
        {
            int rowIndex = kdvtarrif.CurrentCell.RowIndex;
            kdvtarrif.Rows.RemoveAt (rowIndex);
        }

        private void button9_Click (object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < kdvtarrif.Rows.Count; ++i)
            {
                sum += Convert.ToDouble (kdvtarrif.Rows [i].Cells [1].Value);
            }
            txtqamnt.Text = sum.ToString ();
        }

        private void button10_Click (object sender, EventArgs e)
        {
          /*
            //textBox1.Text = dtr ["CustomerID"].ToString ();
            int id;
            id = 7;
            string ID = "PA-" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "-" + id;
            id++;
            txtqid.Text = id.ToString ();
            //MessageBox.Show (ID);*/
        }
        /*if (e.ColumnIndex == 4)
{
txtqamnt.Text 
= (from DataGridViewRow r in kdvtarrif.Rows
select Convert.ToDouble (r.Cells [e.ColumnIndex].Value))
.Sum ().ToString ();
}
*/
    }
}
