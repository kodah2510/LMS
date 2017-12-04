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
using BLL;
namespace LMS
{
    public partial class AdminForm : Form
    {
        Member member;
        public AdminForm(Member member)
        {
            InitializeComponent();
            this.member = member;
            userButton.Text = member.username;

            issueControl.Hide();
            memberControl.Hide();
            bookControl.Show();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            sidePanel.Width = bookButton.Width;
            sidePanel.Left = bookButton.Left;

            issueControl.Hide();
            memberControl.Hide();
            bookControl.Show();
        }

        private void memberButton_Click(object sender, EventArgs e)
        {
            sidePanel.Width = memberButton.Width;
            sidePanel.Left = memberButton.Left;

            issueControl.Hide();
            bookControl.Hide();
            memberControl.Show();
        }

        private void issueButton_Click(object sender, EventArgs e)
        {
            sidePanel.Width = issueButton.Width;
            sidePanel.Left = issueButton.Left;

            memberControl.Hide();
            bookControl.Hide();
            issueControl.Show();
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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void editInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalInfoForm personalInfoForm = new PersonalInfoForm(this.member.id);
            personalInfoForm.Show();
        }
    }
}
