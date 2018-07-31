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
using DGVPrinterHelper;

namespace JobCardSystem.Forms
{
    public partial class frmequipmentdiagnosis : MetroFramework.Forms.MetroForm 
    {
        /// <summary>
        /// Initialization of the connection variable
        /// </summary>
        private string conn;
        private MySqlConnection connect;
      
        //MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
        private string server;
        private string database;
        private string uid;
        private string password;
        MySqlTransaction tr = null;
        MySqlCommand command;
        DataTable table;
        public frmequipmentdiagnosis ()
        {
            InitializeComponent ();
        }

        private void frmequipmentdiagnosis_Load (object sender, EventArgs e)
        {
            selectCombotechassigned ();
            selectCombostatus ();
            customergrid ();
            btnUpdate.Visible = false;
            //fillgrid ();
        }
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


        private void Button1_Click (object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty (txtclientname.Text))
           {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (String.IsNullOrEmpty (txtdiagnosisdone.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtduration.Text))
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
            if (String.IsNullOrEmpty (txtreportedproblem.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txturgency.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxcomment.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxprogress.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxreason.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxresponsetime.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxtechassigned.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
          


            else
            {
                try
                {
                    db_connection ();
                    MySqlCommand cmd = new MySqlCommand ("select * from tblequipdiagnosis where edid = '" + txtedid.Text + "'", connect);
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
                        "INSERT INTO tblequipdiagnosis(" + "  rproblem " + "," + "dfind" + "," + "pstatus" + "," + "techassign" + "," + "taskduration" + "," + "rtime" + "," + "reason" + "," + "comment" + "," + "eid" + "," + "ename" + "," + "eserial" + "," + "client" + ", " + "urgency" + "," + "email" + ") VALUES (" + "  @rproblem " + "," + "  @dfind " + "," + "@pstatus" + "," + "@techassign" + "," + "@taskduration" + "," + "@rtime" + "," + "@reason" + "," + "@comment" + "," + "@eid" + "," + "@ename" + "," + "@eserial" + "," + "@client" + "," + "@urgency" + "," + "@email" + ")";
                        mySqlCommand.Parameters.Add ("@rproblem", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@rproblem"].Value = txtreportedproblem.Text;
                        mySqlCommand.Parameters.Add ("@dfind", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@dfind"].Value = txtdiagnosisdone.Text;
                        mySqlCommand.Parameters.Add ("@pstatus", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@pstatus"].Value = cmbxprogress.Text;
                        mySqlCommand.Parameters.Add ("@techassign", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@techassign"].Value = cmbxtechassigned.Text;
                        mySqlCommand.Parameters.Add ("@taskduration", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@taskduration"].Value = txtduration.Text;
                        mySqlCommand.Parameters.Add ("@rtime", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@rtime"].Value = cmbxresponsetime.Text;
                        mySqlCommand.Parameters.Add ("@reason", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@reason"].Value = cmbxreason.Text;
                        mySqlCommand.Parameters.Add ("@comment", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@comment"].Value = cmbxcomment.Text;
                        mySqlCommand.Parameters.Add ("@eid", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@eid"].Value = txtequipmentid.Text;
                        mySqlCommand.Parameters.Add ("@ename", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@ename"].Value = txtequipmentname.Text;
                        mySqlCommand.Parameters.Add ("@eserial", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@eserial"].Value = txtequipmentserial.Text;
                        mySqlCommand.Parameters.Add ("@client", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@client"].Value = txtclientname.Text;
                        mySqlCommand.Parameters.Add ("@urgency", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@urgency"].Value = txturgency.Text;
                        mySqlCommand.Parameters.Add ("@email", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@email"].Value = txtclientemail.Text;

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

        private void clear ()
        {
            //frmcreatecustomer select = new frmcreatecustomer ();
            txtedid.Clear ();
            txturgency.Clear ();
            txtreportedproblem.Clear ();
            txtequipmentserial.Clear ();
            txtequipmentname.Clear ();
            cmbxcomment.ResetText ();
            cmbxprogress.ResetText ();
            txtequipmentid.Clear ();
            txtclientname.Clear ();
            txtduration.Clear ();
            txtdiagnosisdone.Clear ();
            cmbxtechassigned.ResetText ();
            cmbxresponsetime.ResetText ();
            cmbxreason.ResetText ();
            txtclientemail.Clear ();
        }
        private void customergrid ()
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
                adapter = new MySqlDataAdapter ("select * from tbllogjb", connect);
                DataSet DS = new DataSet ();
                adapter.Fill (DS);
                kdvequip .DataSource = DS.Tables [0];
                kdvequip.Columns [1].HeaderText = "Group";
                kdvequip.Columns [2].HeaderText = "Details";
                kdvequip.Columns [3].HeaderText = "Model No";
                kdvequip.Columns [4].HeaderText = "Serial";
                kdvequip.Columns [5].HeaderText = "Reported Problem";
                kdvequip.Columns [6].HeaderText = "Service Date";
                kdvequip.Columns [7].HeaderText = "Shift";
                kdvequip.Columns [8].HeaderText = "CreatedBy";
                kdvequip.Columns [9].HeaderText = "Status";
                kdvequip.Columns [10].HeaderText = "Cid";
                kdvequip.Columns [11].HeaderText = "ClientName";
                kdvequip.Columns [12].HeaderText = "E-Mail Address";
                kdvequip.Columns [13].HeaderText = "Mobile Number";
                kdvequip.Columns [14].HeaderText = "Contact Via";
                kdvequip.Columns [15].HeaderText = "Urgency";

                //close connection
                this.CloseConnection ();
            }
            this.kdvequip.Columns [0].Visible = false;
            this.kdvequip.Columns [1].Visible = false;
            this.kdvequip.Columns [6].Visible = false;
            this.kdvequip.Columns [7].Visible = false;
            this.kdvequip.Columns [8].Visible = false;
            this.kdvequip.Columns [9].Visible = false;
            //this.kdvequip.Columns [11].Visible = false;
            this.kdvequip.Columns [12].Visible = false;
            this.kdvequip.Columns [13].Visible = false;
            //this.kdvequip.Columns [14].Visible = false;
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
                        writeErrorLog (ex.Message);
                        break;
                    case 1045:
                        MessageBox.Show ("Invalid username/password, please try again");
                        writeErrorLog (ex.Message);
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
        /// <summary>
        /// Function to select Technician name and display it on the form control:cmbxtechassigned
        /// </summary>
        public void selectCombotechassigned ()
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
                cmbxtechassigned.Items.Add (rowz);
            }
            connection.Close ();
        }
        /// <summary>
        /// Function to select  Status description and display it on the form control:cmbxprogress
        /// </summary>
        public void selectCombostatus ()
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
                cmbxprogress.Items.Add (rowz);
            }
            connection.Close ();
        }
        private void GroupBox1_Enter (object sender, EventArgs e)
        {

        }

        private void Button2_Click (object sender, EventArgs e)
        {
            this.Hide ();
            Home frm = new Home ();
            frm.Show ();
           
        }

        private void button4_Click (object sender, EventArgs e)
        {
            this.Hide ();
            frmequipdiagnosisgrid diagnosisgrid = new frmequipdiagnosisgrid ();
            diagnosisgrid.Show ();
        }

        private void kdvequip_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            txtequipmentid.Text = kdvequip.CurrentRow.Cells [0].Value.ToString ();
            txtequipmentname.Text = kdvequip.CurrentRow.Cells [2].Value.ToString ();
            txtequipmentserial.Text = kdvequip.CurrentRow.Cells [4].Value.ToString ();
            txtclientname.Text = kdvequip.CurrentRow.Cells [11].Value.ToString ();
            txtreportedproblem.Text = kdvequip.CurrentRow.Cells [5].Value.ToString ();
            txturgency.Text = kdvequip.CurrentRow.Cells [15].Value.ToString ();
            txtclientemail.Text = kdvequip.CurrentRow.Cells [12].Value.ToString ();
        }

        private void button7_Click (object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            txtedid.Enabled = false;
            txtreportedproblem.Enabled = true;
            txtdiagnosisdone.Enabled = true;
            cmbxprogress.Enabled = true;
            cmbxtechassigned.Enabled = true;
            txtduration.Enabled = true;
            cmbxresponsetime.Enabled = true;
            cmbxreason.Enabled = true;
            cmbxcomment.Enabled = true;
          
            Button1.Visible = false;
        }

        private void btnAdd_Click (object sender, EventArgs e)
        {
            clear ();
            Button1.Visible = true;
            btnUpdate.Visible = false;
            txtedid.Enabled = false;
            txtreportedproblem.Enabled = true;
            txtdiagnosisdone.Enabled = true;
            cmbxprogress.Enabled = true;
            cmbxtechassigned.Enabled = true;
            txtduration.Enabled = true;
            cmbxresponsetime.Enabled = true;
            cmbxreason.Enabled = true;
            cmbxcomment.Enabled = true;
            txtequipmentid.Enabled = true;
            txtequipmentname.Enabled = true;
            txtequipmentserial.Enabled = true;
            txtclientname.Enabled = true;
            txturgency.Enabled = true;
            txtclientemail.Enabled = true;

        }

        private void btnUpdate_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtclientname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (String.IsNullOrEmpty (txtdiagnosisdone.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtduration.Text))
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
            if (String.IsNullOrEmpty (txtreportedproblem.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txturgency.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxcomment.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxprogress.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxreason.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxresponsetime.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxtechassigned.Text))
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

                    cmd.CommandText = "UPDATE tblequipdiagnosis SET rproblem= " + "  @rproblem " + ",  dfind = " + "  @dfind " + " , taskduration = " + "  @taskduration " + ", pstatus = " + "  @pstatus " + ", comment =" + "  @comment " + " WHERE edid= '" + this.txtedid.Text + "';";
                    cmd.Parameters.AddWithValue ("@rproblem", txtreportedproblem.Text);
                    cmd.Parameters.AddWithValue ("@dfind", txtdiagnosisdone.Text);
                    cmd.Parameters.AddWithValue ("@taskduration", txtduration.Text);
                    cmd.Parameters.AddWithValue ("@pstatus", cmbxprogress.Text);
                    cmd.Parameters.AddWithValue ("@comment", cmbxcomment.Text);
                    cmd.ExecuteNonQuery ();
                    MetroFramework.MetroMessageBox.Show (this, "Record updated successfully", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear ();
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

        private void txtdiagnosisdone_KeyPress (object sender, KeyPressEventArgs e)
        {
          if  (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiagnosisdone.Clear ();
                //MessageBox.Show ("enter characters only");
            }
        }

        private void txtpriority_TextChanged (object sender, EventArgs e)
        {

        }

        private void button6_Click (object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter ();

            printer.Title = "Client Equipment Report";

            printer.SubTitle = "Equipment Information Summary";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = false;

            printer.HeaderCellAlignment = StringAlignment.Center;

            printer.Footer = "DIAMOND SYSTEMS LIMITED";

            printer.FooterSpacing = 10;



            printer.PrintDataGridView (kdvequip);
        }

        private void button8_Click (object sender, EventArgs e)
        {
            this.Hide ();
            frmrequirements frm = new frmrequirements ();
            frm.Show ();
            
        }
        public void searchData (string valueToSearch)
        {

            db_connection ();
            string query = "Select * from tblequipdiagnosis WHERE client like '%" + valueToSearch + "%'";
            command = new MySqlCommand (query, connect);
            adapter = new MySqlDataAdapter (command);
            table = new DataTable ();
            adapter.Fill (table);
            kdvequip.DataSource = table;
        }

        private void textBox7_TextChanged (object sender, EventArgs e)
        {
            //string valueToSearch = textBox7.Text.ToString ();
            //searchData (valueToSearch);
            /*
                        string valueToSearch = textBox7.Text.ToString ();
                        searchData (valueToSearch);
                        db_connection ();
                        adapter = new MySqlDataAdapter ("Select * from tblequipdiagnosis where rproblem like '%{0}%'", textBox7.Text);
                        dt = new DataTable ();
                        adapter.Fill (dt);
                        kdvequip.DataSource = dt;
                        connect.Close ();
                       /*
                        /*{
                            db_connection ();
                            MySqlConnection sqlcon = new MySqlConnection (conn);
                            sqlcon.Open ();
                            string query = string.Format ("Select * from tblequipdiagnosis where rproblem like '%{0}%'", textBox7.Text);
                            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
                            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
                            DataTable dt = new DataTable ();
                            adpt.Fill (dt);
                            kdvequip.DataSource = dt;
                            fillgrid ();
                        }*/
        }
        private void fillgrid ()
        {
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from tblequipdiagnosis");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            kdvequip.DataSource = dt;

        }

        private void button3_Click (object sender, EventArgs e)
        {
            if (kdvequip.Rows.Count > 0)

            {

                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application ();

                XcelApp.Application.Workbooks.Add (Type.Missing);



                for (int i = 1; i < kdvequip.Columns.Count + 1; i++)

                {

                    XcelApp.Cells [1, i] = kdvequip.Columns [i - 1].HeaderText;

                }



                for (int i = 0; i < kdvequip.Rows.Count; i++)

                {

                    for (int j = 0; j < kdvequip.Columns.Count; j++)

                    {

                        XcelApp.Cells [i + 2, j + 1] = kdvequip.Rows [i].Cells [j].Value.ToString ();

                    }

                }

                XcelApp.Columns.AutoFit ();

                XcelApp.Visible = true;

            }

        }

        private void label4_Click (object sender, EventArgs e)
        {

        }

        private void cmbxreason_SelectedIndexChanged (object sender, EventArgs e)
        {

        }
    }
}

