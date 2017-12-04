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
namespace IssueControl
{
    public partial class returnBookForm : Form
    {
        int memberId;
        PenaltyInfoBLL penaltyInfoBll = new PenaltyInfoBLL();
        IssueBLL issueBll = new IssueBLL();
        //get penalty info from the database

        public returnBookForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
        }

        private void returnBookForm_Load(object sender, EventArgs e)
        {
            //fill the issue table 
            DataTable issueRes = issueBll.GetByMemberId(this.memberId);
            issueDataGridView.DataSource = issueRes;
            //fill the penalty info 
            DataTable res = penaltyInfoBll.GetByMemberId(this.memberId);
            if(res.Rows.Count != 0)
            {
                DateTime dueDate = (DateTime)res.Rows[0]["DueDate"];
                int bookCount = (int)res.Rows[0]["Amount"];
                int days = DateTime.Now.Subtract(dueDate).Days;
                int fine = (int)res.Rows[0]["Fine"];

                dueDateTextBox.Text = dueDate.ToShortDateString();
                bookCountTextBox.Text = bookCount.ToString();
                daysTextBox.Text = days.ToString();
                fineTextBox.Text = fine.ToString();
            }
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            /* Need to review  the delete procedure in issue table
             * 
             *
             */
            int res = issueBll.Delete(Convert.ToInt32(issueDataGridView.Rows[0].Cells["MemberId"].Value));
           
            if(res != 0 )
            {
                MessageBox.Show("Delete Succeeded");
                this.Close();
            }
        }
        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
