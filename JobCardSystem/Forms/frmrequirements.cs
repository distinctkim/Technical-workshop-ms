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
    

    public partial class frmrequirements : MetroFramework.Forms.MetroForm
    {
        private string conn;
        private MySqlConnection connect;
        // MySqlTransaction tr = null;
        //MySqlCommand cmd;
        //MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
        // private string server;
        // private string database;
        // private string uid;
        // private string password;
        MySqlTransaction tr = null;
        public frmrequirements ()
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
        private void comboBox1_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (cmbxdid.SelectedIndex < 0)
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
                MySqlDataAdapter da = new MySqlDataAdapter ("Select * from tblequipdiagnosis WHERE edid='" + cmbxdid.Text + "'", cs);

                MySqlCommandBuilder cmd = new MySqlCommandBuilder (da);

                da.Fill (ds);

                //NameBox.Text = comboBox1.Text;
                txtequipmentid.Text = ds.Tables [0].Rows [0] ["eid"].ToString ();
                txtequipmentname.Text = ds.Tables [0].Rows [0] ["ename"].ToString ();
                txtequipmentserial.Text = ds.Tables [0].Rows [0] ["eserial"].ToString ();
                txtclientname.Text = ds.Tables [0].Rows [0] ["client"].ToString ();
                txtdiagnosisdone.Text = ds.Tables [0].Rows [0] ["dfind"].ToString ();
                txtreportedproblem.Text = ds.Tables [0].Rows [0] ["rproblem"].ToString ();
                txtclientemail.Text = ds.Tables [0].Rows [0] ["email"].ToString ();
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
                writeErrorLog ("Error in writeErrorLog: " + ex.Message+ Environment.NewLine);

            }
        }

        private void Button1_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtequipmentid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtdate.Text))
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
            if (String.IsNullOrEmpty (txtreportedproblem.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtdiagnosisdone.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxhdw.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txthditems.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxsft.Text))
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
                    MySqlCommand cmd = new MySqlCommand ("select * from  tblreq where rid = '" + txtrid.Text + "'", connect);
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
                        "INSERT INTO  tblreq (" + "  did " + "," + "eid" + "," + "ename" + "," + "eserial" + "," + "cname" + "," + "clientemail" + "," + "rproblem" + "," + "ddone" + "," + "cathdw" + "," + "itmhdw" + "," + "catsft" + "," + "itmsft" + "," + "notes" + "," + "redate" + ") VALUES (" + "  @did " + "," + "@eid" + "," + "  @ename " + "," + "  @eserial " + "," + "  @cname " + "," + "  @clientemail " + "," + "  @rproblem " + "," + "  @ddone " + "," + "  @cathdw " + "," + "  @itmhdw " + "," + "  @catsft " + "," + "  @itmsft " + "," + "  @notes " + "," + "  @redate " + ")";
                        mySqlCommand.Parameters.Add ("@did", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@did"].Value = cmbxdid.Text;
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
                        mySqlCommand.Parameters.Add ("@cathdw", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@cathdw"].Value = cmbxhdw.Text;
                        mySqlCommand.Parameters.Add ("@itmhdw", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@itmhdw"].Value = txthditems.Text;
                        mySqlCommand.Parameters.Add ("@catsft", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@catsft"].Value = cmbxsft.Text;
                        mySqlCommand.Parameters.Add ("@itmsft", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@itmsft"].Value = txtsftitems.Text;
                        mySqlCommand.Parameters.Add ("@notes", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@notes"].Value = txtnotes.Text;
                        mySqlCommand.Parameters.Add ("@redate", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@redate"].Value = txtdate.Text;

                        mySqlCommand.ExecuteNonQuery ();
                        //Console.WriteLine ("Successfully added row to Customers table");
                        MetroFramework.MetroMessageBox.Show (this, "Successfully saved", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearfields();
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
            frmrequirementsgrid select = new Forms.frmrequirementsgrid ();
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblreq");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            select.kdvequipreq.DataSource = dt;
        }
        private void Panel1_Paint (object sender, PaintEventArgs e)
        {

        }
        public void selectCombostatus ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT edid FROM tblequipdiagnosis;";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                cmbxdid.Items.Add (rowz);
            }
            connection.Close ();
        }
        private void frmrequirements_Load (object sender, EventArgs e)
        {
            selectCombostatus();
            btnupdate.Visible = false;
            //button3.Visible = false;
            Button1.Visible = true;
            txtdate.Text = DateTime.Today.ToShortDateString ();
            gridfresh ();
        }
        /// <summary>
        /// Not in use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbxdid_SelectedValueChanged (object sender, EventArgs e)
        {
            if (cmbxdid.SelectedIndex < 0)
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
                MySqlDataAdapter da = new MySqlDataAdapter ("Select ename from tblequipdiagnosis WHERE edid='" + cmbxdid.Text + "'", cs);

                MySqlCommandBuilder cmd = new MySqlCommandBuilder (da);

                da.Fill (ds);

                //NameBox.Text = comboBox1.Text;
                txtequipmentname.Text = ds.Tables [0].Rows [0] ["ename"].ToString ();
            }
        }

        private void label5_Click (object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click (object sender, EventArgs e)
        {

        }

        private void cmbxitmhd_MouseClick (object sender, MouseEventArgs e)
        {
           
    }

        private void cmbxitmhd_SelectedIndexChanged (object sender, EventArgs e)
        {
          

        }

        private void button5_Click (object sender, EventArgs e)
        {
            if (this.cmbxitmhd.SelectedItem == null)
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                StringBuilder sb = new StringBuilder ();
                sb.AppendLine (cmbxitmhd.SelectedItem.ToString ());
                //sb.AppendLine (cmbxitmhd.SelectedItem.ToString ());
                txthditems.Text += sb.ToString ();
                cmbxitmhd.ResetText ();
            }
        }

        private void txtitems_TextChanged (object sender, EventArgs e)
        {

        }

        private void button6_Click (object sender, EventArgs e)
        {
            if (this.cmbxitmsft.SelectedItem==null )
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                StringBuilder sb = new StringBuilder ();
                sb.AppendLine (cmbxitmsft.SelectedItem.ToString ());
                //sb.AppendLine (cmbxitmhd.SelectedItem.ToString ());
                txtsftitems.Text += sb.ToString ();
                cmbxitmsft.ResetText ();
            }
        }

        private void btnAdd_Click (object sender, EventArgs e)
        {
            clearfields ();
            //button3.Visible = false;
            Button1.Visible = true;
            btnupdate.Visible = false;
        }
        private void clearfields()
        {
            txtrid.Clear ();
            cmbxdid.ResetText ();
            txtequipmentid.Clear ();
            txtequipmentname.Clear ();
            txtequipmentserial.Clear ();
            txtclientname.Clear ();
            txtclientemail.Clear ();
            txtreportedproblem.Clear ();
            txtdiagnosisdone.Clear ();
            cmbxhdw.ResetText ();
            cmbxitmhd.ResetText ();
            txthditems.Clear ();
            cmbxsft.ResetText ();
            txtsftitems.Clear ();
            txtnotes.Clear ();
        }

        private void button7_Click (object sender, EventArgs e)
        {
            btnupdate.Visible = true;
            Button1.Visible = false;

        }
       

        private void Button2_Click (object sender, EventArgs e)
        {
           
            Home hom = new Forms.Home ();
            hom.Show ();
            this.Hide();
        }

        private void button3_Click (object sender, EventArgs e)
        {
           
        }

        private void button4_Click (object sender, EventArgs e)
        {
            frmrequirementsgrid gridshw = new Forms.frmrequirementsgrid ();
            gridshw.Show ();
            this.Hide ();
        }

        private void btndelete_Click (object sender, EventArgs e)
        {
            db_connection ();
            MySqlConnection connection = null;
            if (String.IsNullOrEmpty (cmbxdid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields department name detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtrid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty field date detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtequipmentid.Text))
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
                    cmd.CommandText = "delete from tblreq where rid='" + txtrid.Text + "';";

                    cmd.ExecuteNonQuery ();
                    MetroFramework.MetroMessageBox.Show (this, "Requirements deleted successfully", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearfields ();
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

        private void btnupdate_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (cmbxdid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields department name detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtrid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty field date detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtequipmentid.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty field equipmentid detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxhdw.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty field category1 detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxsft.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty field category2 detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtsftitems.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty field Software Item detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txthditems.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty field Hardware Item detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtnotes.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty field notes detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                cmd.CommandText = "UPDATE tblreq SET cathdw= " + "  @cathdw " + " , itmhdw= " + "  @itmhdw " + " , catsft= " + "  @catsft " + " , itmsft= " + "  @itmsft " + ",notes= " + "  @notes " + " WHERE rid= '" + this.txtrid.Text + "';";
                cmd.Parameters.AddWithValue ("@cathdw", cmbxhdw.Text);
                cmd.Parameters.AddWithValue ("@itmhdw", txthditems.Text);
                cmd.Parameters.AddWithValue ("@catsft", cmbxsft.Text);
                cmd.Parameters.AddWithValue ("@itmsft", txtsftitems.Text);
                cmd.Parameters.AddWithValue ("@notes", txtnotes.Text);

                cmd.ExecuteNonQuery ();
                MetroFramework.MetroMessageBox.Show (this, "Record updated successfully", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearfields ();
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
    }
}
