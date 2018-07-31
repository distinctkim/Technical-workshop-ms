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
    public partial class frmmanageusers : MetroFramework.Forms.MetroForm
    {
        private string conn;
        private MySqlConnection connect;
        public frmmanageusers ()
        {
            InitializeComponent ();
        }

        private void btnSave_Click (object sender, EventArgs e)
        {
            try
            {

                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into jobauto.tbl_setup(itemname) values('" + this.txtUsername.Text + "') ;";
                //,model,serialno,action,issuedto,dept,condition
                //'" + this.kryptonTextBox1.Text + "','" + this.kryptonTextBox2.Text + "','" + this.comboBox1.Text + "','" + this.kryptonComboBox3.Text + "','" + this.kryptonComboBox4.Text + "','" + this.kryptonComboBox5.Text + "'
                //username,password,user_role
                //,'" + this.txtlastname.Text + "','" + this.txtusername.Text + "','" + this.txtpassword.Text + "'
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection (MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand (Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open ();
                MyReader2 = MyCommand2.ExecuteReader ();     // Here our query will be executed and data saved into the database.
                MessageBox.Show ("Data Saved Successfully", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clear ();
                //fetchitem ();

                while (MyReader2.Read ())
                {

                }
                MyConn2.Close ();
            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.Message);
            }
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

        private void frmmanageusers_Load (object sender, EventArgs e)
        {

        }

        private void btnCancel_Click (object sender, EventArgs e)
        {

        }
    }
  }

