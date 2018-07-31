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
using System.Configuration;
using Tulpep.NotificationWindow;

namespace JobCardSystem.Forms
{
    public partial class frmlogin : MetroFramework.Forms.MetroForm 
    {
        /// <summary>
        /// Initialization of the connection variable
        /// </summary>
        private string conn;
        private MySqlConnection connect;
        MySqlTransaction tr = null;
        string s1;
        int Counter = 0;
        
        public frmlogin ()
        {
            InitializeComponent ();
        }
        /// <summary>
        /// Timer event settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmlogin_Load (object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToInt32(1).ToString();
                txtcounters.Visible = false;
                textBox2.Visible = false;
                mtlogintime.Text = DateTime.Now.ToLongTimeString ();
                mtdate.Text = DateTime.Today.ToShortDateString ();
                timer2.Start ();
                Timer MyTimer = new Timer ();
                MyTimer.Interval = (5 * 60 * 1000); // 5 mins
                MyTimer.Tick += new EventHandler (timer1_Tick);
                MyTimer.Start ();
                PopupNotifier popup = new PopupNotifier ();
                popup.Image = Properties.Resources.Excel_2013;
                popup.TitleText = "TWMS";
                popup.ContentText = "To Start select user role";
                popup.Popup ();
            }
           catch(Exception ex)
            {
                writeErrorLog ("Error in frmlogin_Load: " + ex.Message);

            }
        }
        /// <summary>
        /// Intialization of the timer event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick (object sender, EventArgs e)
        {
            DialogResult dialogresult=MetroFramework.MetroMessageBox.Show (this, "Session timeout!,do you want to continue using it", "Automated Job  Card System", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
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
        /// <summary>
        /// Function to connect to database
        /// </summary>
        private void db_connection ()
        {
            try
            {
                conn = "Server=localhost;Database=jobauto;Uid=root;Pwd=;";
                connect = new MySqlConnection (conn);
                connect.Open ();
                
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
        /// Function to validate the entered values correspondence to the ones in the database using parameters,thus avoiding sql injection threat.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        private bool validate_login (string user, string pass, string role,string stamp)
        {

            db_connection ();
            MySqlCommand cmd = new MySqlCommand ();
            cmd.CommandTimeout = 60;
            cmd.CommandText = "Select * from login where username=@user AND password=@pass AND usertype=@role";
            cmd.Parameters.AddWithValue ("@user", user);
            cmd.Parameters.AddWithValue ("@pass", Security.HashSHA1(pass));
            cmd.Parameters.AddWithValue ("@role", role);
            cmd.Parameters.AddWithValue ("@stampvalue", stamp);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader ();
            if (login.Read ())
            {

                connect.Close ();
                return true;
            }
            else
            {
                connect.Close ();
                return false;

            }
        }

        /// <summary>
        /// Function to clear the textboxes
        /// </summary>
        public void clear ()
        {
            txtuser.Clear ();
            txtpass.Clear ();

        }
        /// <summary>
        /// Function to clear usertextbox
        /// </summary>

        public void clearu()
        {
            txtuser.Clear ();
        }
        /// <summary>
        /// Fuction to clear password textbox
        /// </summary>
        
        public void clearp()
        {
            txtpass.Clear ();
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
        /// <summary>
        /// Handling the login button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnlogin_Click (object sender, EventArgs e)
        {
            try
            {

                string user = txtuser.Text;
                string pass = txtpass.Text;
                string role = cmbxrole.Text;
                string stamp = textBox1.Text;
                // string role = string.Empty;
                if (user == "" || pass == "" || role == "")
                {
                    MetroFramework.MetroMessageBox.Show (this, "Empty Fields Detected ! Please fill up all the fields", "AJCS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtuser.Focus ();
                    // MessageBox.Show ("Empty Fields Detected ! Please fill up all the fields");
                   
                    return;
                }
                if (pass.Length < 4)
                {
                    MetroFramework.MetroMessageBox.Show (this, "Password length not met", "ATWS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clearp ();
                    return;
                }
                bool r = validate_login (user, pass, role, stamp);
                if (r)
                {// MessageBox.Show ("Correct Login Credentials");
                    if (role == "Admin")
                    {
                        db_connection ();
                        // role =  ["UserRole"].ToString ();
                        MySqlCommand cmd = new MySqlCommand ();
                        cmd.CommandText = "Select usertype from login where usertype= 'Admin' and stampvalue = '0'";
                        cmd.Parameters.AddWithValue ("@user", user);
                        cmd.Parameters.AddWithValue ("@pass",Security.HashSHA1( pass));
                        cmd.Parameters.AddWithValue ("@role", role);
                        cmd.Parameters.AddWithValue ("@stampvalue",stamp);
                        cmd.Connection = connect;

                        insertlogindate ();
                        MetroFramework.MetroMessageBox.Show (this, txtuser.Text, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmadminhome main = new Forms.frmadminhome ();
                        main.Text = txtuser.Text;
                        main.Show ();
                        this.Visible = false;
                        
                    }
                        if (role == "User")
                        {
                            db_connection ();
                            // role =  ["UserRole"].ToString ();
                            MySqlCommand cmd1 = new MySqlCommand ();
                            cmd1.CommandText = "Select usertype from login where usertype= 'User' and stampvalue = '0'";
                            cmd1.Parameters.AddWithValue ("@user", user);
                            cmd1.Parameters.AddWithValue ("@pass", pass);
                            cmd1.Parameters.AddWithValue ("@role", role);
                            cmd1.Parameters.AddWithValue ("@stampvalue",stamp);

                            cmd1.Connection = connect;

                            insertlogindate();
                            MetroFramework.MetroMessageBox.Show (this, txtuser.Text, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UserDisplayName.displayName = txtuser.Text;
                            Home mam = new Home ();
                            mam.Text = txtuser.Text;
                            mam.Show ();
                            this.Hide ();
                           
                        }
                    }

                    else
                    {
                        insertlogindate ();
                        MetroFramework.MetroMessageBox.Show (this, "Incorrect Login Credentials", "ATWS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        clear ();
                        Counter = Counter + 1;
                        txtcounters.Text = Counter.ToString ();
                        s1 = Convert.ToString (3 - Counter);
                        if (Counter == 3)
                        {
                           updatelogactivity ();

                            MetroFramework.MetroMessageBox.Show (this, "You have no more attempts left", "ATWS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            updatelogactivity ();
                            this.Close();
                        Application.Exit ();
                        }
                        //MessageBox.Show ("Incorrect Login Credentials");
                    }
                    connect.Close ();
             //   }
            }
            catch (Exception ex)
            {
                writeErrorLog (ex.Message);
            }
           
           }
        

        /// <summary>
        /// Keypress event that check for validity of the input to the required text type for that textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtuser_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                //MessageBox.Show ("enter characters only");
                MetroFramework.MetroMessageBox.Show (this, "Enter characters only", "ATWS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }


        /// <summary>
        /// click event to close the form if it is not in use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btncancel_Click (object sender, EventArgs e)
        {
            this.Close ();
            Application.Exit ();
        }
        public class UserDisplayName
        {
            public static string displayName;
        }

        private void txtpass_Click (object sender, EventArgs e)
        {

        }

        private void llnewuser_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        /// <summary>
        /// Function to capture and append errors to a file for easier  debugging
        /// </summary>
        /// <param name="strErrorText"></param>
        public  static void writeErrorLog(string strErrorText)
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
            catch(Exception ex)
            {
                writeErrorLog ("Error in writeErrorLog: "+ ex.Message);

            }
        }

        private void panel1_Paint (object sender, PaintEventArgs e)
        {
            textBox1.Visible = false;
        }

        private void linkLabel1_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide ();
            frmcheckconn open = new frmcheckconn ();
            open.Show ();
            
        }
        private void insertlogindate()
        {
            try
            
                {
                    db_connection ();
                    MySqlCommand mySqlCommand = connect.CreateCommand ();
                    mySqlCommand.CommandText =
                    "INSERT INTO tbluseractivity (" + " username " + "," + " usertype " + " , " + " logindate " + "," + " logintime " + ") VALUES (" + "  @username " + "," + "  @usertype " + "," + "  @logindate" + "," + "  @logintime" + ")";
                    mySqlCommand.Parameters.Add ("@username", MySqlDbType.VarChar, 250);
                    mySqlCommand.Parameters ["@username"].Value = txtuser.Text;
                    mySqlCommand.Parameters.Add ("@usertype", MySqlDbType.VarChar, 250);
                    mySqlCommand.Parameters ["@usertype"].Value = cmbxrole.Text;
                    mySqlCommand.Parameters.Add ("@logindate", MySqlDbType.VarChar, 250);
                    mySqlCommand.Parameters ["@logindate"].Value = mtdate.Text;
                    mySqlCommand.Parameters.Add ("@logintime", MySqlDbType.VarChar, 250);
                    mySqlCommand.Parameters ["@logintime"].Value = mtlogintime.Text;

                    mySqlCommand.ExecuteNonQuery ();
                    //Console.WriteLine ("Successfully added row to Customers table");
                    //MetroFramework.MetroMessageBox.Show (this, "Successfully saved", "Automated Job  Card System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clear ();
                    connect.Close ();

                    // Add 
                }
            
            catch (Exception ex)
            {
               writeErrorLog(ex.Message);
            }
            connect.Close ();
        }
        private void updatelogactivity()
        {
            if (String.IsNullOrEmpty (txtuser.Text))
            {
                //.MetroMessageBox.Show (this, "Empty fields detected", "Automated Technical workshop System", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    cmd.CommandText = "UPDATE login SET stampvalue =" + "  @stampvalue " + " WHERE username= '" + this.txtuser.Text + "';";
                    cmd.Parameters.AddWithValue ("@stampvalue", textBox1.Text);
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

        private void txtuser_Click (object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged (object sender, EventArgs e)
        {
           
            
            
        }

        private void llforgotpass_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide ();
            frmforgotpassword frm = new Forms.frmforgotpassword ();
            frm.Show ();
        }

        private void timer2_Tick (object sender, EventArgs e)
        {
            mtlogintime.Text = DateTime.Now.ToLongTimeString ();

        }
    }
 }

  
