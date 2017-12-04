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
    public partial class FineInfoForm : Form
    {
        PenaltyInfoBLL penaltyInfoBll = new PenaltyInfoBLL();
        public FineInfoForm()
        {
            InitializeComponent();
        }

        private void FineInfoForm_Load(object sender, EventArgs e)
        {
            fineInfoDataGridView.DataSource = penaltyInfoBll.GetAll();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            fineInfoDataGridView.DataSource = penaltyInfoBll.GetAll();
        }
    }
}
