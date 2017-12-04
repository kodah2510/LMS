using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ValueObject;
namespace MemberControl
{
    public partial class MemberControl: UserControl
    {
        MemberBLL memberBll = new MemberBLL();
        public MemberControl()
        {
            InitializeComponent();
        }
        private void BindData()
        {
            DataTable dt = memberBll.GetAll();
            memberDataGridView.DataSource = dt;
        }
        private void MemberControl_Load(object sender, EventArgs e)
        {
            this.BindData();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.BindData();
        }
       
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = memberDataGridView.SelectedCells[0];
            DataGridViewRow row = memberDataGridView.Rows[cell.RowIndex];
            int id = (int)row.Cells[0].Value;
            int res = memberBll.Delete(id);
            if(res == 1)
            {
                MessageBox.Show("Delete Success");
                BindData();
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = memberDataGridView.SelectedCells[0];
            DataGridViewRow row = memberDataGridView.Rows[cell.RowIndex];
            int id = (int)row.Cells[0].Value;
            PersonalInfoForm personalInfoForm = new PersonalInfoForm(id);
            personalInfoForm.Show();

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            InsertMemberForm insertMemberForm = new InsertMemberForm();
            insertMemberForm.Show();
            insertMemberForm.FormClosed += InsertMemberForm_FormClosed;
        }

        private void InsertMemberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BindData();
        }

        private void searchTextbox_Click(object sender, EventArgs e)
        {
            if(String.Compare(searchTextbox.Text, "Search") == 0)
            {
                searchTextbox.Text = "";
            }
        }
        private bool validateInput(string input)
        {
            if(String.IsNullOrEmpty(input))
            {
                MessageBox.Show("Empty input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Search(string input)
        {
            if(validateInput(input))
            {
                DataTable res = memberBll.GetMemberByUsername(input);
                memberDataGridView.DataSource = res;
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            Search(searchTextbox.Text);
        }

        private void searchTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Search(searchTextbox.Text);
            }
        }
    }
}
