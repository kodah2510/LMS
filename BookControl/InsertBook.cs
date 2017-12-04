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
    public partial class InsertBook : Form
    {
        BookBLL bookBll = new BookBLL();
        public InsertBook()
        {
            InitializeComponent();
        }
      
        private void InsertLocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private bool validateInput(string name, string author, string type, string amount, string cost)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name field is empty");
                return false;
            }
            if (String.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Author field is empty");
                return false;

            }
            if (String.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("Type field is empty");
                return false;

            }
            if (String.IsNullOrWhiteSpace(amount))
            {
                MessageBox.Show("Amount field is empty");
                return false;
            }
            else
            {
                int res;
                if (!int.TryParse(amount, out res))
                {
                    MessageBox.Show("Invalid Amount value");
                    return false;

                }
                return true;
            }
            if(String.IsNullOrEmpty(cost))
            {
                int res;
                if(!int.TryParse(cost, out res))
                {
                    MessageBox.Show("Invalid Cost value");
                    return false;
                }
            }
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {

            string name = nameTextbox.Text;
            string author = authorTextbox.Text;
            string type = typeTextbox.Text;
            string amount = amountTextbox.Text;
            string cost = costTextBox.Text;
            if (this.validateInput(name, author, type, amount, cost))
            {
                Book newBook = new Book(name, author, type, int.Parse(amount), int.Parse(cost));
                int res = bookBll.Insert(newBook);
                if (res == 1)
                {
                    InsertLocation insertLocation = new InsertLocation(name);
                    insertLocation.Show();
                    insertLocation.FormClosed += InsertLocation_FormClosed;
                }
            }
        }
    }
}
