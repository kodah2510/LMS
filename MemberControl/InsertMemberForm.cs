using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ValueObject;
using System.Text.RegularExpressions;

namespace MemberControl
{
    public partial class InsertMemberForm : Form
    {
        MemberBLL memberBll = new MemberBLL();
        public InsertMemberForm()
        {
            InitializeComponent();
        }
        private bool validateInput(string username, string password, string retypePassword, string email)
        {
            //validate username
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Invalid username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //validate password
            if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Invalid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(!Regex.IsMatch(retypePassword, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Invalid retype password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(String.Compare(password, retypePassword) == -1)
            {
                MessageBox.Show("password and retype password did not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void insertButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string retypePassword = retypePasswordTextBox.Text;
            string email = emailTextBox.Text;

            if(validateInput(username, password, retypePassword, email))
            {
                Member member = new Member(username, password, email, true);
                int res = memberBll.Insert(member);
                if(res != 0)
                {
                    MessageBox.Show("Insert succeeded");
                    this.Close();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
