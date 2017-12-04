using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;
namespace LMS
{
    public partial class UserForm : Form
    {
        Member member;
        public UserForm(Member member)
        {
            InitializeComponent();
            userButton.Paint += UserButton_Paint;
            userButton.Text = member.username;
            this.member = member;
            bookControlForUser.Show();
            issueControlForUser.Hide();
            issueControlForUser.memberId = member.id;
        }

        private void UserButton_Paint(object sender, PaintEventArgs e)
        {
            Font stringFont = new Font("Century Gothic", 9);
            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString(member.username, stringFont);
            userButton.Width = Convert.ToInt32(stringSize.Width) + 3;
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            sidePanel.Top = bookButton.Top;
            bookControlForUser.Show();
            issueControlForUser.Hide();
            
        }

        private void issueButton_Click(object sender, EventArgs e)
        {
            sidePanel.Top = issueButton.Top;
            issueControlForUser.Show();
            bookControlForUser.Hide();
            
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            userMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void editInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalInfoForm personalInfoForm = new PersonalInfoForm(this.member.id);
            personalInfoForm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Close();
        }
    }
}
