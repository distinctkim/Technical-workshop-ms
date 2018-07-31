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
using Tulpep.NotificationWindow;

namespace JobCardSystem.Forms
{
    public partial class Home : MetroFramework.Forms.MetroForm 
    {
        public Home ()
        {
            InitializeComponent ();
        }
        public class UserDisplayName
        {
            public static string displayName;
        }
        private void Home_Load (object sender, EventArgs e)
        {
            txtuser.Text = UserDisplayName.displayName;
            this.txtuser.Show ();
            txtuser.Text = "Logged in As: User";
            pictureBox9.Visible = false;
            timer1.Start ();
            timer5.Start ();
            //mldate.Text =  DateTime.Now.ToLongDateString  ();
            //mltime.Text =  DateTime.Now.ToLongTimeString  ();
            //frmlogin.displayname = txtuser.Text;
        }

        private void pictureBox10_Click (object sender, EventArgs e)
        {
            //241, 534
           
            if (pnl1.Height == 534 & pnl1.Width == 241)
            {
                pnl1.Height = 534;
                pnl1.Width = 45;
                pictureBox9.Visible = true;
                pictureBox10.Visible = false;
            }
            else
            {

                pnl1.Height = 534;
                pnl1.Width = 241;


            }
        }

        private void pictureBox9_Click (object sender, EventArgs e)
        {
            if (pnl1.Height == 534 & pnl1.Width == 45)
            {
                pnl1.Height = 534;
                pnl1.Width = 241;
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
            }
            else
            {

                pnl1.Height = 534;
                pnl1.Width = 45;


            }

        }

        private void metroTile15_Click (object sender, EventArgs e)
        {

        }

        private void metroTile9_Click (object sender, EventArgs e)
        {
            frmsetupequipmentfaults faultset = new frmsetupequipmentfaults ();
            faultset.Show ();
            this.Hide ();
        }

        private void mltime_Click (object sender, EventArgs e)
        {

        }

        private void metroTile12_Click (object sender, EventArgs e)
        {
            frmusers usm = new frmusers ();
            usm.Show ();
            this.Hide ();

        }

        private void metroTile13_Click (object sender, EventArgs e)
        {
            frmsetuptarrifs tarrifset = new frmsetuptarrifs ();
            tarrifset.Show ();
            this.Hide ();

        }

        private void materialLabel1_Click (object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click (object sender, EventArgs e)
        {

        }

        private void timer1_Tick (object sender, EventArgs e)
        {

          
            /* if(metroTile8.BackColor==Color.Green )
             {
                 metroTile8.Text = "Client Section";
                 metroTile8.BackColor =Color.Brown ;
                 metroTile8.UseTileImage = false;
             }
             else
             {
                 metroTile8.Text = "Setup Clients";
                 metroTile8.BackColor = Color.ForestGreen;
                 metroTile8.UseTileImage = true;
                 metroTile8.Refresh ();
             }
             if (metroTile9.BackColor == Color.Fuchsia)
             {
                 metroTile9.Text = "E-Fault Details";
                 metroTile9.BackColor = Color.Blue;
                 metroTile9.UseTileImage = false;
             }
             else
             {
                 metroTile9.Text = "E-Faults Setup";
                 metroTile9.BackColor = Color.WhiteSmoke;
                 metroTile9.UseTileImage = true;
                 metroTile9.Refresh ();
             }
             if (metroTile10.BackColor == Color.WhiteSmoke)
             {
                 metroTile10.Text = "Shifts Section";
                 metroTile10.BackColor = Color.Indigo;
                 metroTile10.UseTileImage = false;
             }
             else
             {
                 metroTile10.Text = "Set Up Shifts";
                 metroTile10.BackColor = Color.Bisque;
                 metroTile10.UseTileImage = true;
                 metroTile10.Refresh ();
             }
             if (metroTile13.BackColor == Color.WhiteSmoke)
             {
                 metroTile13.Text = "Tarrif Detail Section";
                 metroTile13.BackColor = Color.CadetBlue;
                 metroTile13.UseTileImage = false;
             }
             else
             {
                 metroTile13.Text = "Set Up Tarrifs";
                 metroTile13.BackColor = Color.WhiteSmoke;
                 metroTile13.UseTileImage = true;
                 metroTile13.Refresh ();
             }
             if (metroTile14.BackColor == Color.WhiteSmoke)
             {
                 metroTile14.Text = "Message broadcast";
                 metroTile14.BackColor = Color.Orchid ;
                 metroTile14.UseTileImage = false;
             }
             else
             {
                 metroTile14.Text = "Communication";
                 metroTile14.BackColor = Color.WhiteSmoke;
                 metroTile14.UseTileImage = true;
                 metroTile14.Refresh ();
             }
             if (metroTile11.BackColor == Color.Azure)
             {
                 metroTile11.Text = "Equipment Status Section";
                 metroTile11.BackColor = Color.LemonChiffon;
                 metroTile11.UseTileImage = false;
             }
             else
             {
                 metroTile11.Text = "Equipment Status";
                 metroTile11.BackColor = Color.Chartreuse;
                 metroTile11.UseTileImage = true;
                 metroTile11.Refresh ();
             }
             if (metroTile12.BackColor == Color.WhiteSmoke)
             {
                 metroTile12.Text = "User Detail SetUp";
                 metroTile12.BackColor = Color.Aquamarine;
                 metroTile12.UseTileImage = false;
             }
             else
             {
                 metroTile12.Text = "Manage Users";
                 metroTile12.BackColor = Color.WhiteSmoke;
                 metroTile12.UseTileImage = true;
                 metroTile12.Refresh ();
             }
           */
        }

        private void metroTile8_Click (object sender, EventArgs e)
        {
            frmcreatecustomer customlog = new frmcreatecustomer ();
            customlog.Show ();
            this.Hide ();
        }

        private void pnl1_Paint (object sender, PaintEventArgs e)
        {

        }

        private void materialFlatButton1_Click (object sender, EventArgs e)
        {
            frmlogequipment equiplog = new frmlogequipment ();
            equiplog.Show ();
            //this.Hide ();
        }

        private void materialFlatButton2_Click (object sender, EventArgs e)
        {
            frmequipmentdiagnosis equipdiagnose = new frmequipmentdiagnosis ();
            equipdiagnose.Show ();
            this.Hide ();
        }

        private void materialFlatButton3_Click (object sender, EventArgs e)
        {
            frmrequirements equipreq = new frmrequirements ();
            equipreq.Show ();
            this.Hide ();

        }

        private void metroTile10_Click (object sender, EventArgs e)
        {
            frmsetupshifts shiftset = new frmsetupshifts ();
            shiftset.Show ();
            this.Hide ();

        }

        private void metroTile11_Click (object sender, EventArgs e)
        {
            frmequipmentstatus setstatus = new frmequipmentstatus ();
            setstatus.Show ();
            this.Hide ();
        }

        private void metroTile14_Click (object sender, EventArgs e)
        {
            frmcommunication comm = new Forms.frmcommunication ();
            comm.Show ();
            this.Hide ();

        }

        private void metroTile15_Click_1 (object sender, EventArgs e)
        {
           
        }

        private void metroTile8_Click_1 (object sender, EventArgs e)
        {
           
            frmcreatecustomer customer = new frmcreatecustomer ();
            customer.Show ();
            this.Hide ();
        }

        private void metroTile15_Click_2 (object sender, EventArgs e)
        {
            MessageBox.Show ("Goodbye", "JobCard System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = false;
            this.Hide();
            frmlogin frm = new frmlogin ();
            frm.Show ();
            

        }

        private void timer2_Tick (object sender, EventArgs e)
        {

        }

        private void metroTile9_Click_1 (object sender, EventArgs e)
        {
            this.Hide ();
            frmsetupequipmentfaults faults = new frmsetupequipmentfaults ();
            faults.Show ();
           
        }

        private void metroTile12_Click_1 (object sender, EventArgs e)
        {
            this.Hide ();
            frmmanageusers users = new frmmanageusers ();
            users.Show ();

        }

        private void metroTile10_Click_1 (object sender, EventArgs e)
        {
            this.Hide ();
            frmsetupshifts shift = new frmsetupshifts ();
            shift.Show ();
        }
        private void materialFlatButton4_Click (object sender, EventArgs e)
        {
            this.Hide ();
            frmviewloggedequip loggedtasks = new Forms.frmviewloggedequip();
            loggedtasks.Show ();

        }

        private void metroTile11_Click_1 (object sender, EventArgs e)
        {
            this.Hide ();
            frmequipmentstatus status = new Forms.frmequipmentstatus ();
            status.Show ();
            
        }

        private void metroTile14_Click_1 (object sender, EventArgs e)
        {
            this.Hide ();
            frmcommunication comm = new frmcommunication ();
            comm.Show ();
        }

        private void metroTile13_Click_1 (object sender, EventArgs e)
        {
            this.Hide ();
            frmsetuptarrifs tarrif = new frmsetuptarrifs ();
            tarrif.Show ();
        }

        private void timer3_Tick (object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Today.ToLongDateString ();
            
        }

        private void timer4_Tick (object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString ();
        }

        private void materialFlatButton1_Click_1 (object sender, EventArgs e)
        {
            this.Hide ();
            frmcreatecustomer customer = new frmcreatecustomer ();
            customer.Show ();
        }

        private void mtcalc_Click (object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start (@"calc.exe");
        }

        private void mtworddoc_Click (object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start (@"Winword.exe");
        }

        private void materialFlatButton2_Click_1 (object sender, EventArgs e)
        {
            frmquote myquote = new frmquote ();
            myquote.Show ();
            this.Hide ();
        }

        private void mfbfaultdict_Click (object sender, EventArgs e)
        {
            frmfaultdictionary frm = new Forms.frmfaultdictionary ();
            frm.Show ();
            this.Hide ();

        }

        private void pictureBox6_Click (object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip ();
            ToolTip1.SetToolTip (this.pictureBox6, "Client setup");
        }

        private void pictureBox2_Click (object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip ();
            //ToolTip1.SetToolTip (this.pictureBox2, "Receive new equipment");
        }

        private void pictureBox3_Click (object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip ();
            ToolTip1.SetToolTip (this.pictureBox3, "Equipment Diagnosis");
        }

        private void pictureBox5_Click (object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip ();
            ToolTip1.SetToolTip (this.pictureBox5, "Equipment Requirements");
        }

        private void pictureBox12_Click (object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip ();
            ToolTip1.SetToolTip (this.pictureBox12, "Quote Management");
        }

        private void pictureBox4_Click (object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip ();
            ToolTip1.SetToolTip (this.pictureBox4, "View Logged Task");
        }

        private void pictureBox7_Click (object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip ();
            ToolTip1.SetToolTip (this.pictureBox7, "Fault Dictionary");
        }

        private void pictureBox8_Click (object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip ();
            ToolTip1.SetToolTip (this.pictureBox8, "Training & Videos");
        }

        private void mfbtrainvids_Click (object sender, EventArgs e)
        {
            frmconfirmequipment con = new frmconfirmequipment ();
            con.Show ();
            this.Hide ();

        }
        private void pictureBox8_Click_1 (object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip ();
            ToolTip1.SetToolTip (this.pictureBox8, "ConfirmEquipment");
        }

        private void statusStrip1_ItemClicked (object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox13_Click (object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip ();
            ToolTip1.SetToolTip (this.pictureBox13, "Receive new equipment");

        }

        private void materialFlatButton3_Click_1 (object sender, EventArgs e)
        {
            frmlogequipment frm = new frmlogequipment ();
            frm.Show ();
            this.Hide ();

        }

        private void metroTile1_Click (object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier ();
            popup.Image = Properties.Resources.Group1;
            popup.TitleText = "TWMS";
            popup.ContentText = "Access tutorials on diagnosis of computer and printer hardware and their repair procedures";
            popup.Popup ();
            frmtrainingvideos frm = new Forms.frmtrainingvideos ();
            frm.Show ();
            this.Hide ();
        }

        private void materialFlatButton4_Click_1 (object sender, EventArgs e)
        {
            frmloginaccount frm = new frmloginaccount ();
            frm.Show ();
            this.Hide ();
        }

        private void timer5_Tick (object sender, EventArgs e)
        {
           
           
        }

        private void materialFlatButton5_Click (object sender, EventArgs e)
        {
            frmviewcleareditems frm = new frmviewcleareditems ();
            frm.Show ();
            this.Hide ();
        }

        private void pictureBox17_Click (object sender, EventArgs e)
        {

        }

        private void materialFlatButton6_Click (object sender, EventArgs e)
        {
            frmitempickup frm = new frmitempickup ();
            frm.Show ();
            this.Hide ();
        }
    }
}
