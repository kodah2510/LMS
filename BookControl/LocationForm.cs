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
namespace BookControl
{
    public partial class LocationForm : Form
    {
        LocationBLL locationBll = new LocationBLL();
        int bookId;
        public LocationForm(int id)
        {
            InitializeComponent();
            this.bookId = id;
        }
        private void BindData(DataTable dt)
        {
            locationDataGridView.DataSource = dt;
        }
        private void Location_Load(object sender, EventArgs e)
        {
            BindData(locationBll.GetById(this.bookId));

        }
       
        private void insertButton_Click(object sender, EventArgs e)
        {
            InsertLocation insertLocation = new InsertLocation(this.bookId);
            insertLocation.Show();
            insertLocation.FormClosed += InsertLocation_FormClosed;
        }

        private void InsertLocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindData(locationBll.GetById(this.bookId));
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            locationBll.Delete(this.bookId);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
