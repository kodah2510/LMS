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
namespace IssueControl
{
    public partial class BorrowBookForm : Form
    {
        MemberBLL memberBll = new MemberBLL();
        BookBLL bookBll = new BookBLL();
        IssueBLL issueBll = new IssueBLL();
        int depositFee;
        int issueFee;
        int bookCount;
        int total;
        TimeSpan issueTime;
       
        const int MAX_BOOKS = 10;
        const int BASE_ISSUE_FEE = 10000;

        public BorrowBookForm()
        {
            InitializeComponent();
            depositFee = 0;
            issueFee = 0;
            bookCount = 0;
            total = 0;
        }

        private bool validateInput(string username, string book, string amount, DateTime issueDate, DateTime dueDate)
        {
            DataTable bookRes;
            //validate username
            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                DataTable memberRes = memberBll.GetMemberByUsername(username);
                if (memberRes.Rows.Count == 0)
                {
                    MessageBox.Show("Username doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            //validate book id
            if (String.IsNullOrEmpty(book))
            {
                MessageBox.Show("Book Id required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int bookIdRes;
                if (!int.TryParse(book, out bookIdRes))
                {
                    MessageBox.Show("Invalid book id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    bookRes = bookBll.GetById(int.Parse(book));
                    if (bookRes.Rows.Count == 0)
                    {
                        MessageBox.Show("Book doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            if(String.IsNullOrEmpty(amount))
            {
                MessageBox.Show("Amount required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                int amountRes;
                if(!int.TryParse(amount, out amountRes))
                {
                    MessageBox.Show("Invalid amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if(bookRes.Rows.Count != 0)
                    {
                        if(int.Parse(amount) > (int)bookRes.Rows[0]["Amount"])
                        {
                            MessageBox.Show("Borrowed amount larger than available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            
            TimeSpan res = dueDate.Subtract(issueDate);
            if(res.Days <= 0  )
            {
                MessageBox.Show("Invalid due date ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(res.Days > 10)
            {
                MessageBox.Show("Cannot borrow books over 10 days", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                issueTime = res;
            }
            return true;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string bookId = bookIdTextBox.Text;
            string amount = amountTextBox.Text;

            DateTime issueDate = issueDateTimePicker.Value;
            DateTime dueDate = dueDateTimePicker.Value;
            
            if(validateInput(username, bookId, amount, issueDate, dueDate))
            {
                //fill in the issue table below
                //check in the previous issues, are there any duplicate to the new one
                DataTable memberRes = memberBll.GetMemberByUsername(username);
                string memberId = memberRes.Rows[0]["Id"].ToString();
                DataTable bookRes = bookBll.GetById(int.Parse(bookId));
                string bookName = bookRes.Rows[0]["Name"].ToString();


                int cost = (int)bookRes.Rows[0]["Cost"];
                int amountInt = int.Parse(amount);
                bool noAdd = false;
                if (issueDataGridView.Rows[0].Cells[0].Value != null)
                {
                    foreach (DataGridViewRow row in issueDataGridView.Rows)
                    {
                        if(row.Cells[0].Value != null)
                        {
                            if (String.Compare(row.Cells["BookId"].Value.ToString(), bookId) == 0)
                            {
                                int curAmount = Convert.ToInt32(row.Cells["Amount"].Value);
                                curAmount += amountInt;
                                row.Cells["Amount"].Value = curAmount;
                                row.Cells["DueDate"].Value = dueDate;
                                noAdd = true;
                                break;
                            }
                        }
                    }
                    if (!noAdd)
                    {
                        object[] values =
                        {
                                memberId,
                                bookId,
                                username,
                                bookName,
                                amount,
                                cost,
                                dueDate
                            };
                        issueDataGridView.Rows.Add(values);
                    }
                }
                else
                {
                    object[] values =
                    {
                        memberId,
                        bookId,
                        username,
                        bookName,
                        amount,
                        cost,
                        dueDate
                    };
                    issueDataGridView.Rows.Add(values);
                   
                }
                depositFee += cost * amountInt;
                issueFee += BASE_ISSUE_FEE * amountInt;
                bookCount += amountInt;
                total = depositFee + issueFee; 

                if(bookCount > MAX_BOOKS)
                {
                    MessageBox.Show("Reach maximum books can borrow", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bookCount -= amountInt;
                    return;
                }

                countBookTextBox.Text = issueDataGridView.Rows.Count.ToString();
                depositsFeeTextBox.Text = depositFee.ToString();
                issueFeeTextBox.Text = issueFee.ToString();
                totalTextBox.Text = total.ToString();

            }
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            //send to database
            int insertRes = 0;
            foreach(DataGridViewRow row in issueDataGridView.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    Issue issue = new Issue();
                    issue.memberId = Convert.ToInt32(row.Cells["MemberId"].Value);
                    issue.bookId = Convert.ToInt32(row.Cells["BookId"].Value);
                    issue.amount = Convert.ToInt32(row.Cells["Amount"].Value);
                    issue.issueDate = issueDateTimePicker.Value;
                    issue.dueDate = dueDateTimePicker.Value;
                    try
                    {
                        insertRes += issueBll.Insert(issue);
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        string mess = "";
                        foreach (var err in ex.Errors)
                        {
                            mess += err.ToString() + "\n";
                        }
                        MessageBox.Show(mess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
              
            }
            if(insertRes != 0)
            {
                MessageBox.Show(insertRes.ToString() + "Issues inserted");
                this.Close();
            }

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            issueDateTimePicker.Value = DateTime.Now;
            depositsFeeTextBox.Text = "0";
            issueFeeTextBox.Text = "0";
            totalTextBox.Text = "0";
            countBookTextBox.Text = depositFee.ToString();
            issueDataGridView.Rows.Clear();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = issueDataGridView.SelectedCells[0];
            DataGridViewRow row = issueDataGridView.Rows[cell.RowIndex];

            int bookCost = (int)row.Cells["Cost"].Value;
            int bookAmount = Convert.ToInt32(row.Cells["Amount"].Value); // cannot cast because amount is string 
            
            issueDataGridView.Rows.RemoveAt(cell.RowIndex);
            //update the field
            countBookTextBox.Text = issueDataGridView.RowCount.ToString();
            depositFee -= bookCost * bookAmount;
            issueFee -= BASE_ISSUE_FEE * bookAmount;
            total = depositFee + issueFee;
            bookCount -= bookAmount;
            //re fill the textbox
            depositsFeeTextBox.Text = depositFee.ToString();
            issueFeeTextBox.Text = issueFee.ToString();
            totalTextBox.Text = total.ToString();
            countBookTextBox.Text = bookCount.ToString();
        }
    }
}
