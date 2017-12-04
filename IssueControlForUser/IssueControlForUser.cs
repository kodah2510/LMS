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
namespace IssueControlForUser
{
    public partial class IssueControlForUser: UserControl
    {
        IssueBLL issueBll = new IssueBLL();
        public int memberId { get; set; }
        public IssueControlForUser()
        {
            InitializeComponent();
            
        }
        private void BindData()
        {
            issueDataGridView.DataSource = issueBll.GetByMemberId(this.memberId);
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void IssueControlForUser_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
