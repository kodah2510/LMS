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
namespace BookControlForUser
{
    public partial class BookControlForUser: UserControl
    {
        BookBLL bookBll = new BookBLL();
        public BookControlForUser()
        {
            InitializeComponent();
        }
        private void BindData()
        {
            bookDataGridView.DataSource = bookBll.GetAll();
        }
        public void BindData(DataTable dt)
        {
            bookDataGridView.DataSource = dt;
        }
        private void Search(string input, string category)
        {
            switch(category)
            {
                case "Book":
                    this.BindData(bookBll.GetBookByName(input));
                    break;
                case "Author":
                    this.BindData(bookBll.GetBookByAuthor(input));
                    break;
                case "Type":
                    this.BindData(bookBll.GetBookByType(input));
                    break;
            }
        }
        private void searchTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                this.Search(searchTextbox.Text, searchComboBox.Text);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Search(searchTextbox.Text, searchComboBox.Text);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void BookControlForUser_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void searchTextbox_Click(object sender, EventArgs e)
        {
            if(String.Compare(searchTextbox.Text, "Search") == 0)
            {
                searchTextbox.Text = "";
            }
        }
    }
}
