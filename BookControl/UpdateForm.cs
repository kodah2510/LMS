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
    public partial class UpdateForm : Form
    {
        Book selectedBook;
        BookBLL bookbll = new BookBLL();
        DataGridView gridView;
        public UpdateForm(Book book, DataGridView gridView)
        {
            InitializeComponent();
            selectedBook = book;
            this.gridView = gridView;
        }
        private void UpdateForm_Load(object sender, EventArgs e)
        {
            nameTextbox.Text = selectedBook.name;
            authorTextbox.Text = selectedBook.author;
            typeTextbox.Text = selectedBook.type;
            amountTextbox.Text = selectedBook.amount.ToString();
            costTextBox.Text = selectedBook.cost.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string name = nameTextbox.Text;
            string author = authorTextbox.Text;
            string type = typeTextbox.Text;
            int amount = int.Parse(amountTextbox.Text);
            int cost = int.Parse(costTextBox.Text);

            Book updateBook = new Book(selectedBook.id, name, author, type, amount, cost);
            int res = bookbll.Update(updateBook);
            if (res == 1)
            {
                MessageBox.Show("Update success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
