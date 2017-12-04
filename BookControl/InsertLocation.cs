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

namespace BookControl
{
    public partial class InsertLocation : Form
    {
        string name;
        int bookId;
        LocationBLL locationBll = new LocationBLL();
        BookBLL bookBll = new BookBLL();
        public InsertLocation(string name)
        {
            InitializeComponent();
            this.name = name;
        }
        public InsertLocation(int id)
        {
            InitializeComponent();
            this.bookId = id;
        }

        private void InsertLocation_Load(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(this.name))
            {
                DataTable res = bookBll.GetBookByName(name);
                if(res.Rows.Count != 0)
                {
                    bookIdTextbox.Text = res.Rows[0]["BookId"].ToString();
                }
            }
            else
            {
                bookIdTextbox.Text = this.bookId.ToString();
            }
            bookIdTextbox.Enabled = false;
        }
        private bool validateInput(string row, string col, string shelf, string section)
        {
            int res;
            if(!int.TryParse(row, out res))
            {
                MessageBox.Show("Invalid row value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(!int.TryParse(col, out res))
            {
                MessageBox.Show("Invalid col value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(col, out res))
            {
                MessageBox.Show("Invalid shelf value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(col, out res))
            {
                MessageBox.Show("Invalid section value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

      

        private void insertLocationButton_Click_1(object sender, EventArgs e)
        {
            string row = rowTextbox.Text;
            string col = colTextbox.Text;
            string shelf = shelfTextbox.Text;
            string section = sectionTextbox.Text;

            if (this.validateInput(row, col, shelf, section))
            {
                ValueObject.Location location =
                    new ValueObject.Location(int.Parse(bookIdTextbox.Text), int.Parse(row), int.Parse(col), int.Parse(shelf), int.Parse(section));
                int res = locationBll.Insert(location);
                if (res != 0)
                {
                    MessageBox.Show("Insert succeeded");
                    this.Close();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
