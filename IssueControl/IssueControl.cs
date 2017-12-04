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
namespace IssueControl
{
    public partial class IssueControl: UserControl
    {
        IssueBLL issueBll = new IssueBLL();
        public IssueControl()
        {
            InitializeComponent();
            searchComboBox.Text = "Book";
        }
        private void BindData()
        {
            issueDataGridView.DataSource = issueBll.GetAll();
            issueDataGridView.Columns["MemberId"].Visible = false;
            issueDataGridView.Columns["BookId"].Visible = false;
        }
        private void IssueControl_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void searchTextbox_Click(object sender, EventArgs e)
        {
            if(String.Compare(searchTextbox.Text, "Search") != -1)
            {
                searchTextbox.Text = "";
            }
        }

        private void searchTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                this.Search(searchTextbox.Text, searchComboBox.Text);   
            }
        }
        private void Search(string input, string type)
        {
            switch(type)
            {
                case "Book":
                    DataTable bookRes = issueBll.SearchForBook(input);
                    issueDataGridView.DataSource = bookRes;
                    break;
                case "Member":
                    DataTable memberRes = issueBll.SearchForMember(input);
                    issueDataGridView.DataSource = memberRes;
                    break;
                default:
                    break;
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Search(searchTextbox.Text, searchComboBox.Text);
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            if(issueDataGridView.SelectedCells[0].Value != null)
            {
                DataGridViewCell cell = issueDataGridView.SelectedCells[0];
                DataGridViewRow row = issueDataGridView.Rows[cell.RowIndex];
                string message = "You have chosen user " + row.Cells["Username"].Value.ToString();
                DialogResult res = MessageBox.Show(message, "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(res.Equals(DialogResult.Yes))
                {
                    //get the memberId
                    returnBookForm returnBookForm = new returnBookForm((int)row.Cells["MemberId"].Value);
                    returnBookForm.Show();
                    returnBookForm.FormClosed += ReturnBookForm_FormClosed;
                }
            }
            else
            {
                MessageBox.Show("Please select an issue");
                return;
            }
            
        }

        private void ReturnBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindData();
        }

        private void fineInfoButton_Click(object sender, EventArgs e)
        {
            FineInfoForm fineInfoForm = new FineInfoForm();
            fineInfoForm.Show();
        }

        private void borrowBookButton_Click(object sender, EventArgs e)
        {
            BorrowBookForm borrowBookForm = new BorrowBookForm();
            borrowBookForm.Show();
            borrowBookForm.FormClosed += BorrowBookForm_FormClosed;

        }

        private void BorrowBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindData();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
