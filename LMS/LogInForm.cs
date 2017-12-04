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

namespace LMS
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            if(Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("Capslock is on");
            }
        }
        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;
            MemberBLL memberBll = new MemberBLL();
            DataTable res_username = memberBll.GetMemberByUsername(username);
            if(res_username.Rows.Count == 0) 
            {
                MessageBox.Show("Unknown User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                DataTable res_member = memberBll.GetMember(username, password);
                if(res_member.Rows.Count == 0)
                {
                    MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Member member = new Member();
                    member.id = (int)res_member.Rows[0]["Id"];
                    member.username = username;
                    member.password = password;
                    member.email = (string)res_member.Rows[0]["Email"];
                    member.isAdmin = (bool)res_member.Rows[0]["Type"];
                    MessageBox.Show("Success");
                    if (member.isAdmin)
                    {
                        AdminForm adminForm = new AdminForm(member);
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        UserForm userForm = new UserForm(member);
                        userForm.Show();
                        this.Hide();
                    }
                    
                }
               
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
