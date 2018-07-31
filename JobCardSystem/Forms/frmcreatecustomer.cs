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
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using JobCardSystem.Forms;

namespace JobCardSystem.Forms
{
    public partial class frmcreatecustomer : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Initialization of the connection variable
        /// </summary>
        private string conn;
        private MySqlConnection connect;
        MySqlTransaction tr = null;
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


        public frmcreatecustomer ()
        {
            InitializeComponent ();
           
           
        }

        private void frmcreatecustomer_Load (object sender, EventArgs e)
        {
            /*Timer MyTimer = new Timer ();
            MyTimer.Interval = (5 * 60 * 1000); // 5 mins
            MyTimer.Tick += new EventHandler (timer1_Tick);
            MyTimer.Start ();*/
            txtid.Enabled = false;
            txtcustomername.Focus ();
            selectCombocreatedby ();
        }
        public void selectCombocreatedby ()
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
                cmbxcreatedby.Items.Add (rowz);
            }
            connection.Close ();
        }
        private void GroupBox1_Enter (object sender, EventArgs e)
        {
            txtCdate.Text = DateTime.Today.ToShortDateString ();
            txtcustomername.Focus ();
            txtCdate.Enabled = false;
            btnUpdate.Visible = false;
        }
        /// <summary>
        /// Fucntion to capture application errors and append them to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void Button1_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtcustomername.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
           
           
            if (String.IsNullOrEmpty (txtcomemail.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtmobileno.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtCdate.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxcreatedby.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (cmbxtown.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
            if (String.IsNullOrEmpty (txtcity.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtbuilding.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;

            }
            if (String.IsNullOrEmpty (cmbxcontact.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            else
            {
                try
                {
                    db_connection ();
                    MySqlCommand cmd = new MySqlCommand ("select * from tblcustomer where id = '" + txtid.Text + "'", connect);
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
                        "INSERT INTO tblcustomer (" + "  companyname " + "," + "companyemail" + "," + "officetel" + "," + "createdate" + "," + "createdby" + "," + "town" + "," + "city" + "," + "street" + "," + "building" + "," + "postaladdress" + "," + "commode" + ") VALUES (" + "  @companyname " + "," + "  @companyemail " + "," + "@officetel" + "," + "@createdate" + "," + "@createdby" + "," + "@town" + "," + "@city" + "," + "@street" + "," + "@building" + "," + "@postaladdress" + "," + "@commode" + ")";
                        mySqlCommand.Parameters.Add ("@companyname", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@companyname"].Value = txtcustomername.Text;
                        mySqlCommand.Parameters.Add ("@companyemail", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@companyemail"].Value = txtcomemail.Text;
                        mySqlCommand.Parameters.Add ("@officetel", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@officetel"].Value = txtmobileno.Text;
                        mySqlCommand.Parameters.Add ("@createdate", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@createdate"].Value = txtCdate.Text;
                        mySqlCommand.Parameters.Add ("@createdby", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@createdby"].Value = cmbxcreatedby.Text;
                        mySqlCommand.Parameters.Add ("@town", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@town"].Value = cmbxtown.Text;
                        mySqlCommand.Parameters.Add ("@city", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@city"].Value = txtcity.Text;
                        mySqlCommand.Parameters.Add ("@street", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@street"].Value = txtstreet.Text;
                        mySqlCommand.Parameters.Add ("@building", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@building"].Value = txtbuilding.Text;
                        mySqlCommand.Parameters.Add ("@postaladdress", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@postaladdress"].Value = txtpostaladdress.Text;
                        mySqlCommand.Parameters.Add ("@commode", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@commode"].Value = cmbxcontact.Text;
                        //mySqlCommand.Parameters.Add ("@commode", MySqlDbType.VarChar, 250);
                        //mySqlCommand.Parameters ["@commode"].Value = cbmobileno.Text;




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

        private void txtcomemail_Leave (object sender, EventArgs e)
        {
            String UserEmail = txtcomemail.Text;
            if (IsValidEmailId (UserEmail))
            {
                //MessageBox.Show ("This email is correct formate");
            }
            else
            {
                MessageBox.Show ("This email isn't correct formate");
                txtcomemail.Clear ();
            }
        }
        private void phonevalidate ()
        {
            string phonePattern = @"^[2-9]\d{2}-\d{3}-\d{4}$"; //Phone number pattern   
            bool isPhoneValid = Regex.IsMatch (txtmobileno.Text, phonePattern);
            if (!isPhoneValid)
            {
                MessageBox.Show ("Please enter a valid phone number");
               
            }
        }
        private void txtofficetelephone_KeyPress (object sender, KeyPressEventArgs e)
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

        private void txtofficetelephone_TextChanged (object sender, EventArgs e)
        {
            if (txtmobileno.Text.Length > 13)
            {

                //MessageBox.Show ("Invalid Mobile Number !!");
                MetroFramework.MetroMessageBox.Show (this, "Invalid Mobile Number !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmobileno.Clear ();
                txtmobileno.Focus ();
            }
        }

        private void txtcustomername_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcustomername.Clear ();
                //MessageBox.Show ("enter characters only");
            }
        }

        private void txtcity_TextChanged (object sender, EventArgs e)
        {

        }

        private void txtcity_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //MessageBox.Show ("enter characters only");
                
            }
        }

        private void txtstreet_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
               
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show ("enter characters only");
            }
        }

        private void txtbuilding_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show ("enter characters only");
            }
        }

        private void cmbxcontact_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only !!", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // MessageBox.Show ("enter characters only");
            }
        }

        private void button4_Click (object sender, EventArgs e)
        {
            keen ();
            frmcustomergrid cusgrid = new Forms.frmcustomergrid ();
            cusgrid.Show ();
            this.Hide ();         
            btnUpdate.Enabled = true;
            cmbxcreatedby.Enabled = false;
        }

        private void cmbxcreatedby_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private void txtcomemail_KeyDown (object sender, KeyEventArgs e)
        {
           
        }

        private void Button2_Click (object sender, EventArgs e)
        {
            Home hom = new Home ();
            hom.Show ();
            this.Hide ();
        }

        private void btnAdd_Click (object sender, EventArgs e)
        {
            clear ();
            kenable ();
            cmbxcreatedby.Enabled = true;
            txtCdate.Enabled = false;
            txtCdate.Text = DateTime.Today.ToShortDateString ();
            btnUpdate.Visible  = false;
            Button1.Visible = true;
            Button1.Enabled = true;
        }
        private void keen ()
        {
            frmcreatecustomer select = new frmcreatecustomer ();
            select.txtid.Enabled = false;
            select.txtcustomername.Enabled = false;
            select.txtcomemail.Enabled = false;
            select.txtmobileno.Enabled = false;
            select.txtCdate.Enabled = false;
            select.cmbxcreatedby.Enabled = false;
            select.cmbxtown.Enabled = false;
            select.txtcity.Enabled = false;
            select.txtstreet.Enabled = false;
            select.txtbuilding.Enabled = false;
            select.txtpostaladdress.Enabled = false;
            select.cmbxcontact.Enabled = false;
        }
        private void kenable ()
        {
            frmcreatecustomer select = new frmcreatecustomer ();
            select.txtid.Enabled = true;
            select.txtcustomername.Enabled = true;
            select.txtcomemail.Enabled = true;
            select.txtmobileno.Enabled = true;
            select.txtCdate.Enabled = true;
            select.cmbxcreatedby.Enabled = true;
            select.cmbxtown.Enabled = true;
            select.txtcity.Enabled = true;
            select.txtstreet.Enabled = true;
            select.txtbuilding.Enabled = true;
            select.txtpostaladdress.Enabled = true;
            select.cmbxcontact.Enabled = true;
        }
        private void clear ()
        {
            //frmcreatecustomer select = new frmcreatecustomer ();
            txtid.Clear ();
            txtcustomername.Clear ();
            txtcomemail.Clear ();
            txtmobileno.Clear ();
            txtCdate.Clear ();
            cmbxcreatedby.ResetText ();
            cmbxtown.ResetText ();
            txtcity.ResetText();
            txtstreet.Clear();
            txtbuilding.Clear();
            txtpostaladdress.Clear();
            cmbxcontact.ResetText();
        }

        private void btnUpdate_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtcustomername.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Technical workshop management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (String.IsNullOrEmpty (txtcomemail.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Technical workshop management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtmobileno.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Technical workshop management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxcreatedby.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Technical workshop management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (cmbxtown.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Technical workshop management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtcity.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Technical workshop management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtbuilding.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Technical workshop management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxcontact.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Technical workshop management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                cmd.CommandText = "UPDATE tblcustomer SET companyemail= " + "  @companyemail " + ",  officetel = " + "  @officetel " + " ,  town = " + "  @town " + ", city =" + "  @city " + " ,  building = " + "  @building " + " ,  commode = " + "  @commode " + "WHERE Id= '" + this.txtid.Text+ "';";
                cmd.Parameters.AddWithValue ("@companyemail", txtcomemail.Text);
                cmd.Parameters.AddWithValue ("@officetel", txtmobileno.Text);
                cmd.Parameters.AddWithValue ("@town", cmbxtown.Text);
                cmd.Parameters.AddWithValue ("@city", txtcity.Text);
                cmd.Parameters.AddWithValue ("@building", txtbuilding.Text);
                cmd.Parameters.AddWithValue ("@commode", cmbxcontact.Text);
                cmd.ExecuteNonQuery ();
                MetroFramework.MetroMessageBox.Show (this, "Record updated successfully", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear ();
                tr.Commit ();
                
            }
            catch (MySqlException ex)
            {
                    writeErrorLog (ex.Message);
                    tr.Rollback();
            }
            finally
            {
                if (conn != null)
                    connect.Close ();
            }
        }

        private void button3_Click (object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
           // txtid.Enabled  = true;
            txtcustomername.Enabled = false;
            txtcomemail.Enabled = true;
            txtmobileno.Enabled = true;
            txtCdate.Enabled = false;
            cmbxcreatedby.Enabled = false;
            cmbxtown.Enabled = true;
            txtcity.Enabled = true;
            txtstreet.Enabled = false;
            txtbuilding.Enabled = true;
            txtpostaladdress.Enabled = true;
            cmbxcontact.Enabled = true;
        }

        private void button5_Click (object sender, EventArgs e)
        {
            this.Hide ();
            frmlogequipment frm = new Forms.frmlogequipment ();
            frm.Show ();
           
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

        private void txtcomemail_KeyPress (object sender, KeyPressEventArgs e)
        {
            /*string email = txtcomemail.Text;
            Regex regex = new Regex (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match (email);
            if (match.Success)
            {
                //MetroFramework.MetroMessageBox.Show (this, "Valid Email address.", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show (this, "Email Address Invalid.", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcomemail.Clear ();
                txtcomemail.Focus ();
                return;
            }
            */
        }

        private void txtcomemail_TextChanged (object sender, EventArgs e)
        {
           
        }
        public static bool IsValidEmailId (string InputEmail)
        {
            Regex regex = new Regex (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match (InputEmail);
            if (match.Success)
                return true;
            else
                return false;
        }
        /*public static bool IsValidEmailId (string InputEmail)
        {
            Regex regex = new Regex (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match (InputEmail);
            if (match.Success)
                return true;
            else
                return false;
        }
        */
    }
  }


