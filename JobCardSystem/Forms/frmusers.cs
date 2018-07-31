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
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using JobCardSystem.Forms;

namespace JobCardSystem.Forms
{
    public partial class frmusers : MetroFramework.Forms.MetroForm 
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


        public frmusers ()
        {
            InitializeComponent ();
        }

        private void GroupBox1_Enter (object sender, EventArgs e)
        {

        }
        public void selectCombodept ()
        {
            db_connection ();
            MySqlConnection connection = new MySqlConnection (conn);
            string command = "SELECT deptname FROM tbldept;";
            MySqlDataAdapter da = new MySqlDataAdapter (command, connection);
            DataTable dt = new DataTable ();
            da.Fill (dt);
            //MessageBox.Show ("Break");
            foreach (DataRow row in dt.Rows)
            {
                string rowz = string.Format ("{0}", row.ItemArray [0]);
                cmbxdept.Items.Add (rowz);
            }
            connection.Close ();
        }

        private void frmusers_Load (object sender, EventArgs e)
        {
            selectCombodept ();
            
        }
        public class Security
        {
            public static string HashSHA1 (string value)
            {
                var sha1 = System.Security.Cryptography.SHA1.Create ();
                var inputBytes = Encoding.ASCII.GetBytes (value);
                var hash = sha1.ComputeHash (inputBytes);

                var sb = new StringBuilder ();
                for (var i = 0; i < hash.Length; i++)
                {
                    sb.Append (hash [i].ToString ("X2"));
                }
                return sb.ToString ();
            }
        }

        private void txtname_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MessageBox.Show ("enter characters only");
            }
        }

        private void txtmobileno_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber (e.KeyChar) & (Keys)e.KeyChar != Keys.Back & (Keys)e.KeyChar != Keys.Enter)
            {

                e.Handled = true;
                MessageBox.Show ("Enter numbers only");
            }

            base.OnKeyPress (e);
        }

        private void txtmobileno_TextChanged (object sender, EventArgs e)
        {
            if (txtmobileno.Text.Length > 10)
            {

                MessageBox.Show ("Invalid Mobile Number !!");
                txtmobileno.Clear ();
                txtmobileno.Focus ();
            }
        }

        private void txtmobileno_Leave (object sender, EventArgs e)
        {
            Regex mRegxExpression;

            if (txtemail.Text.Trim () != string.Empty)

            {

                mRegxExpression = new Regex (@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch (txtemail.Text.Trim ()))

                {

                    MessageBox.Show ("E-mail address format is not correct.", "Twms", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtemail.Focus ();
                    txtemail.Clear ();

                }

            }
        }

        private void txtuname_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MessageBox.Show ("enter characters only");
            }
        }

      /*  private void txtpass_KeyPress (object sender, KeyPressEventArgs e)
        {
            string Password = txtpass.Text;

            bool ValidPassword = Regex.IsMatch (Password, @"^.{6,}(?<=\d.*)(?<=[^a-zA-Z0-9].*)$");

        }*/

        private void txtpass_TextChanged (object sender, EventArgs e)
        {
            string Password = txtpass.Text;

            bool ValidPassword = Password.Any (char.IsDigit)
                && !Password.All (char.IsLetterOrDigit)
                && Password.Length >= 6;
        }

        private void sqlabC_GroupBox1_Click (object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged (object sender, EventArgs e)
        {

        }
        private void keen ()
        {
            frmusers select = new frmusers ();
            select.txtid.Enabled = false;
            select.txtname.Enabled = false;
            select.cmbxdept.Enabled = false;
            select.txtmobileno.Enabled = false;
            select.txtemail.Enabled = false;
            select.cmbxdesig.Enabled = false;
            select.txtuname.Enabled = false;
            select.txtpass.Enabled = false;
            select.cmbxurole.Enabled = false;

        }
        private void btnuserinfo_Click (object sender, EventArgs e)
        {
            
            frmmanageusersgrid usergrid = new Forms.frmmanageusersgrid ();
            usergrid.Show ();
            keen ();
            this.Hide();
        }
        private void gridfresh ()
        {
            frmmanageusersgrid select = new Forms.frmmanageusersgrid ();
            db_connection ();
            MySqlConnection sqlcon = new MySqlConnection (conn);
            sqlcon.Open ();
            string query = string.Format ("Select * from login");
            MySqlCommand cmd = new MySqlCommand (query, sqlcon);
            MySqlDataAdapter adpt = new MySqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            adpt.Fill (dt);
            select.kdvusergrid.DataSource = dt;
        }

        public bool ValidatePassword (string password)
        {
            string patternPassword = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$";
            if (!string.IsNullOrEmpty (password))
            {
                if (!Regex.IsMatch (password, patternPassword))
                {
                    return false;
                }

            }
            return true;
        }
        private bool Validate (String pass, String confirm)
        {
            return String.IsNullOrEmpty (pass) == false && pass == confirm;
        }
        public string encryptpass (string password)
        {
            string msg = "";
            byte [] encode = new byte [password.Length];
            encode = Encoding.UTF8.GetBytes (password);
            msg = Convert.ToBase64String (encode);
            return msg;
        }
       

        private void Button1_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (String.IsNullOrEmpty (cmbxdept.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtmobileno.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtemail.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxdesig.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (cmbxurole.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtuname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtpass.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtconpass.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxstamp.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (cmbxstamp.TextLength<7)
            {
                MetroFramework.MetroMessageBox.Show (this, "ID Number should be atleast seven characters", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (cmbxstamp.TextLength >8)
            {
                MetroFramework.MetroMessageBox.Show (this, "ID Number should not be more than eight characters", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
           /* if (ValidatePassword (txtpass.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, " Password must be at least 4 characters, no more than 8 characters, and must include at least one upper case letter, one lower case letter, and one numeric digit.", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (ValidatePassword (txtconpass.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, " Password must be at least 4 characters, no more than 8 characters, and must include at least one upper case letter, one lower case letter, and one numeric digit.", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }*/
            if (Validate(txtpass.Text, txtconpass.Text) == false)
            {
                MetroFramework.MetroMessageBox.Show (this, "Passwords Do not Match", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Clear ();
                txtconpass.Clear ();
                return;

            }
            if (IsPasswordValid (txtpass.Text) == false)
            {
                MetroFramework.MetroMessageBox.Show (this, "Password should have atleast a number,uppercaseletter and lowercaseletter ", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Clear ();
                txtconpass.Clear ();
                return;

            }



            else
            {
                try
                {
                    db_connection ();
                    MySqlCommand cmd = new MySqlCommand ("select * from login where id = '" + txtid.Text + "'", connect);
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
                        string pass = txtpass.Text;
                        mySqlCommand.CommandText =
                        "INSERT INTO login  (" + "  empname " + "," + "empdept" + "," + "empmno" + "," + "empmail" + "," + "empdesg" + "," + "username" + "," + "password" + "," + "usertype" + "," + "idno" + ") VALUES (" + "  @empname " + "," + "  @empdept " + "," + "@empmno" + "," + "@empmail" + "," + "@empdesg" + "," + "@username" + "," + "@password" + "," + "@usertype" + " , " + "@stampvalue" + ")";
                        mySqlCommand.Parameters.Add ("@empname", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@empname"].Value = txtname.Text;
                        mySqlCommand.Parameters.Add ("@empdept", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@empdept"].Value = cmbxdept.Text;
                        mySqlCommand.Parameters.Add ("@empmno", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@empmno"].Value = txtmobileno.Text;
                        mySqlCommand.Parameters.Add ("@empmail", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@empmail"].Value = txtemail.Text;
                        mySqlCommand.Parameters.Add ("@empdesg", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@empdesg"].Value = cmbxdesig.Text;
                        mySqlCommand.Parameters.Add ("@username", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@username"].Value = txtuname.Text;
                        mySqlCommand.Parameters.Add ("@password", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@password"].Value = Security.HashSHA1 (pass);
                        mySqlCommand.Parameters.Add ("@usertype", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@usertype"].Value = cmbxurole.Text;
                        mySqlCommand.Parameters.Add ("@stampvalue", MySqlDbType.VarChar, 250);
                        mySqlCommand.Parameters ["@stampvalue"].Value = cmbxstamp.Text;



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
        public static bool IsPasswordValid (string password)
        {
            if (string.IsNullOrEmpty (password))
                return false;

            byte n = 0;
            if (password.Any (c => char.IsUpper (c)))
                n++;
            if (password.Any (c => char.IsLower (c)))
                n++;
            if (password.Any (c => char.IsNumber (c)))
                n++;

            if (n > 2)
                return true;

            if (password.Contains ("~") || password.Contains ("@")) //...and so on
                n++;

            //...

            return n > 2;
        }
        private void clear ()
        {
            //frmcreatecustomer select = new frmcreatecustomer ();
            txtid.Clear ();
            txtname.Clear ();
            cmbxdept.ResetText ();
            txtmobileno.Clear ();
            txtemail.Clear ();
            cmbxdesig.ResetText ();
            cmbxurole.ResetText ();
            txtuname.Clear ();
            txtpass.Clear ();
            txtconpass.Clear ();
            cmbxstamp.Clear ();
        }

        private void btnUpdate_Click (object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txtname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (String.IsNullOrEmpty (cmbxdept.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtmobileno.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtemail.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (cmbxdesig.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (cmbxurole.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtuname.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty (txtpass.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (String.IsNullOrEmpty (txtconpass.Text))
            {
                MetroFramework.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((txtpass.Text!= txtconpass.Text))
                {
                    MetroFramework.MetroMessageBox.Show (this, "Passwords do not match", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    cmd.CommandText = "UPDATE login SET empdept= " + "  @empdept " + ",  empmno = " + "  @empmno " + " ,  empmail = " + "  @empmail " + ", empdesg = " + "  @empdesg " + ", password =" + "  @password " + "  WHERE Id= '" + this.txtid.Text + "';";
                    cmd.Parameters.AddWithValue ("@empdept", cmbxdept.Text);
                    cmd.Parameters.AddWithValue ("@empmno", txtmobileno.Text);
                    cmd.Parameters.AddWithValue ("@empmail", txtemail.Text);
                    cmd.Parameters.AddWithValue ("@password", txtpass.Text);
                    cmd.Parameters.AddWithValue ("@empdesg", cmbxdesig.Text);
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
       
        private void Button2_Click (object sender, EventArgs e)
        {

            frmadminhome frm = new Forms.frmadminhome ();
            frm.Show ();
            this.Hide ();
          
            
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

        private void btnAdd_Click (object sender, EventArgs e)
        {
            kenable ();
            Button1.Visible = true;
            btnUpdate.Visible = false;
            clear ();
        }
        /*private void clearfields ()
        {
            txtconpass.Clear ();
            txtemail.Clear ();
            txtmobileno.Clear ();
            txtid.Clear ();
            txtname.Clear ();
            txtpass.Clear ();
            txtuname.Clear ();
            cmbxdept.ResetText ();
            cmbxdesig.ResetText ();
            cmbxstamp.Clear ();
            cmbxurole.ResetText ();

        }*/
        private void kenable ()
        {
            
            txtid.Enabled = false;
            txtconpass.Enabled = true;
            txtemail.Enabled = true;
            txtmobileno.Enabled = true;
            txtname.Enabled = true;
            cmbxdept.Enabled = true;
            cmbxdesig.Enabled = true;
            cmbxurole.Enabled = true;
            txtpass.Enabled = true;
            txtuname.Enabled = true;
            
        }

        private void button3_Click (object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            Button1.Visible = false;
            txtname.Enabled = false;
            txtemail.Enabled = true;
            txtid.Enabled = false;
            txtconpass.Enabled = true;
            txtmobileno.Enabled = true;
            txtpass.Enabled = true;
            cmbxurole.Enabled = true;
            cmbxdept.Enabled = true;
            cmbxdesig.Enabled = true;

        }

        private void groupBox2_Enter (object sender, EventArgs e)
        {

        }

        private void cmbxstamp_TextChanged (object sender, EventArgs e)
        {

        }

        private void cmbxstamp_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber (e.KeyChar) & (Keys)e.KeyChar != Keys.Back & (Keys)e.KeyChar != Keys.Enter)
            {

                e.Handled = true;
                //MessageBox.Show ("enter numbers only");
                MetroFramework.MetroMessageBox.Show (this, "Enter numbers only", "TWMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            base.OnKeyPress (e);
        }

        private void txtemail_Leave (object sender, EventArgs e)
        {
            String UserEmail = txtemail.Text;
            if (IsValidEmailId (UserEmail))
            {
                //MessageBox.Show ("This email is correct formate");
            }
            else
            {
                MessageBox.Show ("This email isn't correct formate");
                txtemail.Clear ();
            }
        }

        private void cmbxstamp_Leave (object sender, EventArgs e)
        {
            if (cmbxstamp.TextLength > 8)
            {
                MetroFramework.MetroMessageBox.Show (this, "ID Number should not be more than eight characters", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbxstamp.Clear ();
                return;

            }

        }
    }
 }

