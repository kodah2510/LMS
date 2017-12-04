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
using BLL;
using ValueObject;
namespace LMS
{
    public partial class SignUpForm : Form
    {
        MemberBLL memberBll = new MemberBLL();
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validateInput(string username, string password, string retypePassword, string email)
        {
            if(String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if(!Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
                {
                    MessageBox.Show("Invalid username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if(String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(String.IsNullOrEmpty(retypePassword))
            {
                MessageBox.Show("Retype password required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(String.Compare(password, retypePassword) == -1)
            {
                MessageBox.Show("Password and retype password did not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        private void signInButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;
            string retypePassword = retypePasswordTextbox.Text;
            string email = emailTextbox.Text;

            if(validateInput(username, password, retypePassword, email))
            {
                Member member = new Member(username, password, email, false);
                int res = memberBll.Insert(member);
                if(res != 0)
                {
                    MessageBox.Show("Sign up succeeded");
                    this.Close();
                }
            }
        }
    }
}
