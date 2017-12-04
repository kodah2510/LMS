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
    public partial class UpdateLocation : Form
    {
        LocationBLL locationBll = new LocationBLL();
        ValueObject.Location location;
        public UpdateLocation(ValueObject.Location location)
        {
            InitializeComponent();
            this.location = location;
        }
        private bool validateInput(string row, string col, string shelf, string section)
        {
            int res;
            if(String.Compare(row, location.row.ToString()) != -1)
            {
                MessageBox.Show("Same value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if(!int.TryParse(row, out res))
                {
                    MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (String.Compare(col, location.col.ToString()) != -1)
            {
                MessageBox.Show("Same value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!int.TryParse(col, out res))
                {
                    MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (String.Compare(shelf, location.shelf.ToString()) != -1)
            {
                MessageBox.Show("Same value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!int.TryParse(shelf, out res))
                {
                    MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (String.Compare(section, location.section.ToString()) != -1)
            {
                MessageBox.Show("Same value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!int.TryParse(section, out res))
                {
                    MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;

        }
        
        private void UpdateLocation_Load(object sender, EventArgs e)
        {
            bookIdTextbox.Text = location.id.ToString();
            rowTextbox.Text = location.row.ToString();
            colTextbox.Text = location.col.ToString();
            shelfTextbox.Text = location.shelf.ToString();
            sectionTextbox.Text = location.section.ToString();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int res = locationBll.Update(this.location);
            if (res != 0)
            {
                MessageBox.Show("Update succeeded");
                this.Close();
            }
            else
            {
                MessageBox.Show("Update failed");
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
