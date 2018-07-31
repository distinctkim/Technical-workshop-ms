using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JobCardSystem.Forms
{
    public partial class frmUserManager : Form
    {
        public frmUserManager ()
        {
            InitializeComponent ();
        }

        private void label1_Click (object sender, EventArgs e)
        {

        }

        private void panel1_Paint (object sender, PaintEventArgs e)
        {

        }

        private void label3_Click (object sender, EventArgs e)
        {

        }

        private void label2_Click (object sender, EventArgs e)
        {

        }

        private void label4_Click (object sender, EventArgs e)
        {

        }

        private void label5_Click (object sender, EventArgs e)
        {

        }

        private void button2_Click (object sender, EventArgs e)
        {

        }

        private void button3_Click (object sender, EventArgs e)
        {

        }

        private void button4_Click (object sender, EventArgs e)
        {
            this.Hide ();
            Home  frm = new Home  ();
            frm.Show ();
        }

        private void button1_Click (object sender, EventArgs e)
        {
            if (txtpassword.Text == "" || txtconfirmpassword.Text == "")
            {
                MessageBox.Show ("Please enter values");
                return;
            }
            if (txtpassword.Text != txtconfirmpassword.Text)
            {
                MessageBox.Show ("confirm password not matching with new passsword");
                txtconfirmpassword.Focus ();
                return;
            }
        }
        public static bool IsStrongPassword (string txtpassword)
        {
            // Minimum and Maximum Length of field - 6 to 12 Characters
            if (txtpassword.Length < 6 || txtpassword.Length > 12)
                return false;

            // Special Characters - Not Allowed
            // Spaces - Not Allowed
            if (!(txtpassword.All (c => char.IsLetter (c) || char.IsDigit (c))))
                return false;

            // Numeric Character - At least one character
            if (!txtpassword.Any (c => char.IsDigit (c)))
                return false;

            // At least one Capital Letter
            if (!txtpassword.Any (c => char.IsUpper (c)))
                return false;

            // Repetitive Characters - Allowed only two repetitive characters
            var repeatCount = 0;
            var lastChar = '\0';
            foreach (var c in txtpassword)
            {
                if (c == lastChar)
                    repeatCount++;
                else
                    repeatCount = 0;
                if (repeatCount == 2)
                    return false;
                lastChar = c;
            }

            return true;
        }
        private bool ValidatePassword (string txtpassword, out string ErrorMessage)
        {
            var input = txtpassword;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace (input))
            {
                throw new Exception ("Password should not be empty");
            }

            var hasNumber = new Regex (@"[0-9]+");
            var hasUpperChar = new Regex (@"[A-Z]+");
            var hasMiniMaxChars = new Regex (@".{8,8}");
            var hasLowerChar = new Regex (@"[a-z]+");
            var hasSymbols = new Regex (@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch (input))
            {
                ErrorMessage = "Password should contain At least one lower case letter";
                return false;
            }
            else if (!hasUpperChar.IsMatch (input))
            {
                ErrorMessage = "Password should contain At least one upper case letter";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch (input))
            {
                ErrorMessage = "Password should not be less than or greater than 8 characters";
                return false;
            }
            else if (!hasNumber.IsMatch (input))
            {
                ErrorMessage = "Password should contain At least one numeric value";
                return false;
            }

            else if (!hasSymbols.IsMatch (input))
            {
                ErrorMessage = "Password should contain At least one special case characters";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmUserManager_Load (object sender, EventArgs e)
        {
            
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

        private void button1_Click_1 (object sender, EventArgs e)
        {
           
        }

        private void txtdesignation_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MessageBox.Show ("enter characters only");
            }
        }

        private void txtusername_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter (e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress (e);
                MessageBox.Show ("enter characters only");
            }
        }

        private void txtmobile_KeyPress (object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber (e.KeyChar) & (Keys)e.KeyChar != Keys.Back & (Keys)e.KeyChar != Keys.Enter)
            {

                e.Handled = true;
                MessageBox.Show ("enter numbers only");
            }

            base.OnKeyPress (e);
           
        }

        private void txtmobile_TextChanged (object sender, EventArgs e)
        {
            if (txtmobile.Text.Length > 10)
            {

                MessageBox.Show ("Invalid Mobile Number !!");

                txtmobile.Focus ();
            }
        }

        private void txtemail_TextChanged (object sender, EventArgs e)
        {
            
        }

        private void txtemail_Validating (object sender, CancelEventArgs e)
        {
           
        }

        private void txtemail_Leave (object sender, EventArgs e)
        {
            Regex mRegxExpression;

            if (txtemail.Text.Trim () != string.Empty)

            {

                mRegxExpression = new Regex (@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch (txtemail.Text.Trim ()))

                {

                    MessageBox.Show ("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtemail.Focus ();
                    txtemail.Clear ();

                }

            }
        }

        private void txtpassword_KeyPress (object sender, KeyPressEventArgs e)
        {

            string Password = txtpassword.Text;

            bool ValidPassword = Regex.IsMatch (Password, @"^.{6,}(?<=\d.*)(?<=[^a-zA-Z0-9].*)$");

        }

        private void txtpassword_TextChanged (object sender, EventArgs e)
        {
            
            string Password = txtpassword.Text;

            bool ValidPassword = Password.Any (char.IsDigit)
                && !Password.All (char.IsLetterOrDigit)
                && Password.Length >= 6;
        }

        private void txtname_TextChanged (object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged (object sender, EventArgs e)
        {

        }
    }
}
