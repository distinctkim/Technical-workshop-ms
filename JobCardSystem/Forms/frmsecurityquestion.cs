using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobCardSystem.Forms
{
    public partial class frmsecurityquestion : Form
    {

        private string conn;
        private MySqlConnection connect;
        //MySqlTransaction tr = null;
        //MySqlCommand cmd;
        //MySqlDataAdapter adapter;
        DataTable dt = new DataTable ();
        MySqlTransaction tr = null;
        MySqlDataAdapter adapter;
        DataTable table = new DataTable ();
        public frmsecurityquestion ()
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

        private void frmsecurityquestion_Load (object sender, EventArgs e)
        {
            selectComboID ();
        }
        public void selectComboID ()
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
                cmbxuser.Items.Add (rowz);
            }
            connection.Close ();
        }

        private void button1_Click (object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter ("SELECT `answer`, `securityquestion` FROM `login` WHERE `empname` = '" + cmbxuser.Text + "'", conn);
            adapter.Fill (table);

            if (table.Rows.Count <= 0)
            {

                lblmessage.ForeColor = Color.Red;
                lblmessage.Text = "Username Or Password Are Invalid";
               
            }
            else
            {

                lblmessage.ForeColor = Color.Green;
                lblmessage.Text = "Login Successfully";
               
            }

            table.Clear ();
        }
    }
}
