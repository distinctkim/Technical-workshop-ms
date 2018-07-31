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
using System.Text.RegularExpressions;
using MetroFramework.Forms;
using DGVPrinterHelper;
using System.IO;

namespace JobCardSystem.Forms
{
    public partial class frmlogequipment : MetroFramework.Forms.MetroForm
    {
        private string conn;
        private MySqlConnection connect;
        MySqlTransaction tr = null;
        //MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
        private string server;
        private string database;
        private string uid;
        private string password;
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
        public frmlogequipment ()
        {
            InitializeComponent ();
        }

        private void lblPath_Click (object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged (object sender, EventArgs e)
        {

        }

        private void label3_Click (object sender, EventArgs e)
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

        private void frmlogequipment_Load (object sender, EventArgs e)
        {
            txtsdate.Text = DateTime.Today.ToShortDateString ();
            txtitemdesc.Focus ();
            txtsdate.Enabled = false;
            customergrid ();
            selectCombo ();
            selectComboStatus ();
            selectCombocreatedby ();
            btnUpdate.Visible = false;
        }
        public void selectCombo ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT shiftdesc FROM tblshift;";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                cmbxshift.Items.Add (rowz);
            }
            connection.Close ();
        }
        public void selectComboStatus ()
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
        public void selectCombocreatedby ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT empname FROM login WHERE empdesg = 'Technician';";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                cmbxcreatedby.Items.Add (rowz);
            }
            connection.Close ();
        }
        private void customergrid()
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
                adapter = new MySqlDataAdapter ("select * from tblcustomer", connect);
                DataSet DS = new DataSet ();
                adapter.Fill (DS);
                kdvcustomer.DataSource = DS.Tables [0];
                kdvcustomer.Columns [1].HeaderText = "Name";
                kdvcustomer.Columns [2].HeaderText = "Email";
                kdvcustomer.Columns [3].HeaderText = "Telephone";
                kdvcustomer.Columns [4].HeaderText = "Date";
                kdvcustomer.Columns [5].HeaderText = "CreatedBy";
                kdvcustomer.Columns [6].HeaderText = "Town";
                kdvcustomer.Columns [7].HeaderText = "City";
                kdvcustomer.Columns [8].HeaderText = "Street";
                kdvcustomer.Columns [9].HeaderText = "Building";
                kdvcustomer.Columns [10].HeaderText = "Address";
                kdvcustomer.Columns [11].HeaderText = "Channel";

                //close connection
                this.CloseConnection ();
            }
            this.kdvcustomer.Columns [0].Visible = false;
            this.kdvcustomer.Columns [6].Visible = false;
            this.kdvcustomer.Columns [7].Visible = false;
            this.kdvcustomer.Columns [8].Visible = false;
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
                        writeErrorLog (ex.Message);
                        MessageBox.Show ("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        writeErrorLog (ex.Message);
                        MessageBox.Show ("Invalid username/password, please try again");
                        break;
                    default:
                        writeErrorLog (ex.Message);
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
                writeErrorLog (ex.Message);
                return false;
            }
        }


       
        private void groupBox2_Enter (object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter (object sender, EventArgs e)
        {

        }

        private void Button2_Click (object sender, EventArgs e)
        {
          
            Home viewhome = new Home ();
            viewhome.Show ();
            this.Hide ();
        }

        private void Button1_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (cmbxitemgroup.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (String.IsNullOrEmpty (cmbxcreatedby.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxshift.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtclientname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (cmbxurgency.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtemail.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtequipmentserial.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtitemdesc.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtmobileno.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtmodelno.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtreportedproblem.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtsdate.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxstatus.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtcontactvia.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            else
            {
                try
                {
                    db_connection ();
                    MySqlCommand cmd = new MySqlCommand ("select * from tbllogjb where lid = '" + txtid.Text + "'", connect);
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
                        "INSERT INTO tbllogjb (" + "  igroup " + "," + "idesc" + "," + "mdno" + "," + "sno" + "," + "rprob" + "," + "sdate" + "," + "shift" + "," + "createdby" + "," + "status" + "," + "idcustom" + "," + "clientname" + "," + "eaddress" + "," + "mno" + "," + "conv" + "," + "urgency" + ") VALUES (" + "  @igroup " + "," + "  @idesc " + "," + "@mdno" + "," + "@sno" + "," + "@rprob" + "," + "@sdate" + "," + "@shift" + "," + "@createdby" + "," + "@status" + "," + "@idcustom" + "," + "@clientname" + "," + "@eaddress" + "," + "@mno" + "," + "@conv" + "," + "@urgency" + ")";
                        mySqlCommand.Parameters.Add ("@igroup", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@igroup"].Value = cmbxitemgroup.Text;
                        mySqlCommand.Parameters.Add ("@idesc", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@idesc"].Value = txtitemdesc.Text;
                        mySqlCommand.Parameters.Add ("@mdno", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@mdno"].Value = txtmodelno.Text;
                        mySqlCommand.Parameters.Add ("@sno", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@sno"].Value = txtequipmentserial.Text;
                        mySqlCommand.Parameters.Add ("@rprob", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@rprob"].Value = txtreportedproblem.Text;
                        mySqlCommand.Parameters.Add ("@sdate", MySqlDbType.Date);
                        mySqlCommand.Parameters ["@sdate"].Value = txtsdate.Text;
                        mySqlCommand.Parameters.Add ("@shift", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@shift"].Value = cmbxshift.Text;
                        mySqlCommand.Parameters.Add ("@createdby", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@createdby"].Value = cmbxcreatedby.Text;
                        mySqlCommand.Parameters.Add ("@status", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@status"].Value = cmbxstatus.Text;
                        mySqlCommand.Parameters.Add ("@idcustom", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@idcustom"].Value = txtidcustom.Text;
                        mySqlCommand.Parameters.Add ("@clientname", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@clientname"].Value = txtclientname.Text;
                        mySqlCommand.Parameters.Add ("@eaddress", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@eaddress"].Value = txtemail.Text;
                        mySqlCommand.Parameters.Add ("@mno", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@mno"].Value = txtmobileno.Text;
                        mySqlCommand.Parameters.Add ("@conv", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@conv"].Value = txtcontactvia.Text;
                        mySqlCommand.Parameters.Add ("@urgency", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@urgency"].Value = cmbxurgency.Text;

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
        private void clear()
        {
            cmbxitemgroup.ResetText ();
            cmbxcreatedby.ResetText ();
            cmbxshift.ResetText ();
            cmbxstatus.ResetText ();
            cmbxurgency.ResetText ();
            txtclientname.Clear ();
            txtcontactvia.Clear ();
            txtemail.Clear ();
            txtequipmentserial.Clear ();
            txtid.Clear ();
            txtitemdesc.Clear ();
            txtmobileno.Clear ();
            txtmodelno.Clear ();
            txtreportedproblem.Clear ();
            txtsdate.Clear ();
            txtidcustom.Clear ();
            txtsdate.Text = DateTime.Today.ToShortDateString ();
        }
        private void button4_Click (object sender, EventArgs e)
        {
            frmlogequipmentgrid equipinfo = new frmlogequipmentgrid ();
            equipinfo.Show ();
            this.Hide ();
        }

        private void txtitemdesc_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtitemdesc.Clear ();
                //MessageBox.Show ("enter characters only");
            }
        }

        private void txtmodelno_KeyPress (object sender, KeyPressEventArgs e)
        {

        }

        private void txtreportedproblem_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtreportedproblem.Clear ();
                //MessageBox.Show ("enter characters only");
            }
        }

        private void txtclientname_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtclientname.Clear ();
                //MessageBox.Show ("enter characters only");
            }
        }

        private void txtemail_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Clear ();
                //MessageBox.Show ("enter characters only");
            }
        }
        private void phonevalidate ()
        {
            string phonePattern = @"^[2-9]\d{2}-\d{3}-\d{4}$"; // US Phone number pattern   
            bool isPhoneValid = Regex.IsMatch (txtmobileno.Text, phonePattern);
            if (!isPhoneValid)
            {
                MessageBox.Show ("Please enter a valid phone number");
            }
        }
        private void txtmobileno_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber (e.KeyChar) & (Keys)e.KeyChar != Keys.Back & (Keys)e.KeyChar != Keys.Enter)
            {

                e.Handled = true;
                //MessageBox.Show ("enter numbers only");
                MetroFramework.MetroMessageBox.Show (this, "Enter numbers only", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phonevalidate ();
            }

            base.OnKeyPress (e);
        }

        private void label15_Click (object sender, EventArgs e)
        {

        }

        private void kdvcustomer_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            //frmcreatecustomer select = new frmcreatecustomer ();
            txtidcustom.Text = kdvcustomer.CurrentRow.Cells [0].Value.ToString ();
            txtclientname.Text = kdvcustomer.CurrentRow.Cells [1].Value.ToString ();
            txtemail.Text = kdvcustomer.CurrentRow.Cells [2].Value.ToString ();
            txtmobileno.Text = kdvcustomer.CurrentRow.Cells [3].Value.ToString ();
            txtcontactvia.Text = kdvcustomer.CurrentRow.Cells [11].Value.ToString ();
           
        }

        private void cmbxshift_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private void button7_Click (object sender, EventArgs e)
        {
            frmequipmentdiagnosis diagnose = new Forms.frmequipmentdiagnosis ();
            diagnose.Show ();
            this.Hide();
        }

        private void textBox7_TextChanged (object sender, EventArgs e)
        {
            
        }
        private void fillgrid ()
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tbllogjb");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvcustomer.DataSource = dt;

        }

        private void txtmobileno_TextChanged (object sender, EventArgs e)
        {

        }

        private void button5_Click (object sender, EventArgs e)
        {
            /*{
                db_connection ();
                MySqlConnection sqlcon = new MySqlConnection (conn);
                sqlcon.Open ();
                string query = string.Format ("Select * from tbllogjb where clientname like '%{0}%'", textBox7.Text);
                MySqlCommand cmd = new MySqlCommand (query, sqlcon);
                MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
                DataTable dt = new DataTable ();
                adpt.Fill (dt);
                kdvcustomer.DataSource = dt;
                //customergrid ();
                //fillgrid ();
            }*/
        }

        private void btnAdd_Click (object sender, EventArgs e)
        {
            clear ();
            btnUpdate.Visible = false;
            Button1.Visible = true;
        }

        private void button8_Click (object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            Button1.Visible = false;
        }

        private void btnUpdate_Click (object sender, EventArgs e)

        {
            if (String.IsNullOrEmpty (cmbxitemgroup.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (String.IsNullOrEmpty (cmbxcreatedby.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxshift.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtclientname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (cmbxurgency.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtemail.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtequipmentserial.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtitemdesc.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtmobileno.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtmodelno.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtreportedproblem.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtsdate.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxstatus.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtcontactvia.Text))
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

                    cmd.CommandText = "UPDATE tbllogjb SET igroup= " + "  @igroup " + ",  idesc = " + "  @idesc " + " , mdno = " + "  @mdno " + ", sno = " + "  @sno " + ", rprob =" + "  @rprob " + " WHERE lid= '" + this.txtid.Text + "';";
                    cmd.Parameters.AddWithValue ("@igroup", cmbxitemgroup.Text);
                    cmd.Parameters.AddWithValue ("@idesc", txtitemdesc.Text);
                    cmd.Parameters.AddWithValue ("@mdno", txtmodelno.Text);
                    cmd.Parameters.AddWithValue ("@sno", txtequipmentserial.Text);
                    cmd.Parameters.AddWithValue ("@rprob", txtreportedproblem.Text);
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
        private void cmbxstatus_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private void button6_Click (object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter ();

            printer.Title = "COMPANY CLIENT EQUIPMENT INFORMATION REPORT";

            printer.SubTitle = "RECEIVED CLIENT EQUIPMENT INFORMATION SUMMARY";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.FitBlackBox;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = false;

            printer.HeaderCellAlignment = StringAlignment.Center;

            printer.Footer = "DIAMOND SYSTEMS LIMITED";

            printer.FooterSpacing = 10;



            printer.PrintDataGridView (kdvcustomer);
        }

        private void button3_Click (object sender, EventArgs e)
        {
           
           // Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
           // Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            object misValue = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Range chartRange;
           

            if (kdvcustomer.Rows.Count > 0)

            {
               
                 Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application ();
                 XcelApp = new Microsoft.Office.Interop.Excel.Application ();
                 //xlWorkBook = XcelApp.Workbooks.Add (misValue);
               // xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item (1);


                XcelApp.Application.Workbooks.Add (Type.Missing);



                for (int i = 1; i < kdvcustomer.Columns.Count + 1; i++)

                {

                    XcelApp.Cells [1, i] = kdvcustomer.Columns [i - 1].HeaderText;

                }



                for (int i = 0; i < kdvcustomer.Rows.Count; i++)

                {

                    for (int j = 0; j < kdvcustomer.Columns.Count; j++)

                    {

                        XcelApp.Cells [i + 2, j + 1] = kdvcustomer.Rows [i].Cells [j].Value.ToString ();

                    }

                }

                XcelApp.Columns.AutoFit ();

               
                chartRange = XcelApp.get_Range ("A1", "P1");
                chartRange.Font.Bold = true;
                XcelApp.Visible = true;
                //chartRange = XcelApp.get_Range ("H1");
                //chartRange.FormulaR1C1 = "RECEIVED EQUIPMENT LIST";
                chartRange.HorizontalAlignment = 3;
                chartRange.VerticalAlignment = 3;
                chartRange.Interior.Color = System.Drawing.ColorTranslator.ToOle (System.Drawing.Color.CadetBlue);
                chartRange.Font.Color = System.Drawing.ColorTranslator.ToOle (System.Drawing.Color.Crimson);
                chartRange.Font.Size = 15;
               


            }
        }
    }
}
