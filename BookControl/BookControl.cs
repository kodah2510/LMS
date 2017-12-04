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
namespace BookControl
{
    public partial class BookControl: UserControl
    {
        BookBLL bookBll = new BookBLL();
        LocationBLL locationBll = new LocationBLL();
        public BookControl()
        {
            InitializeComponent();
           
        }
        public void BindData(DataTable dt)
        {
            dataGridView_Book.DataSource = dt;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string name = searchTextbox.Text;
            searchForBook(name);
        }
        private void insertButton_Click(object sender, EventArgs e)
        {
            InsertBook insertForm = new InsertBook();
            insertForm.Show();
            insertForm.FormClosed += InsertForm_FormClosed;
        }

        private void InsertForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BindData(bookBll.GetAll());
        }
        private Book GetBookFromSelectedRow(DataGridViewRow selectedRow)
        {
            Book selectedBook = new Book();
            selectedBook.id = (int)selectedRow.Cells["BookId"].Value;
            selectedBook.name = (string)selectedRow.Cells["Name"].Value;
            selectedBook.type = (string)selectedRow.Cells["Type"].Value;
            selectedBook.author = (string)selectedRow.Cells["Author"].Value;
            selectedBook.amount = (int)selectedRow.Cells["Amount"].Value;
            return selectedBook;
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if(dataGridView_Book.SelectedCells.Count != 0)
            {
                Book selectedBook = GetBookFromSelectedRow(dataGridView_Book.Rows[dataGridView_Book.SelectedCells[0].RowIndex]);
                UpdateForm updateForm = new UpdateForm(selectedBook, dataGridView_Book);
                updateForm.Show();
                updateForm.FormClosed += UpdateForm_FormClosed;
            }
            else
            {
                MessageBox.Show("Please select a book to update");
            }
        }

        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.BindData(bookBll.GetAll());
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridView_Book.SelectedCells[0];
            DataGridViewRow row = dataGridView_Book.Rows[cell.RowIndex];
            Book selectedBook = GetBookFromSelectedRow(row);
            int res = bookBll.Delete(selectedBook.id);
            if(res != 0)
            {
                MessageBox.Show("Delete succeeded");
                BindData(bookBll.GetAll());
            }
        }
        private void locateButton_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridView_Book.SelectedCells[0];
            DataGridViewRow row = dataGridView_Book.Rows[cell.RowIndex];
            Book selectedBook = GetBookFromSelectedRow(row);
            LocationForm locationForm = new LocationForm(selectedBook.id);
            locationForm.Show();
        }
        private void BookControl_Load(object sender, EventArgs e)
        {
            this.BindData(bookBll.GetAll());
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.BindData(bookBll.GetAll());
        }
        private void searchTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                string name = searchTextbox.Text;
                searchForBook(name);
            }
        }
        private void searchForBook(string name)
        {
            DataTable res = bookBll.GetBookByName(name);
            dataGridView_Book.DataSource = res;
        }

        private void searchTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            if(String.Compare(searchTextbox.Text, "Search") != -1) {
                searchTextbox.Text = "";
            }
        }
    }
}
