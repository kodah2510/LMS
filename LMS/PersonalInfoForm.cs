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
using System.Text.RegularExpressions;

namespace LMS
{
    public partial class PersonalInfoForm : Form
    {
        int memberId;
        PersonalInfoBLL personalInfoBll = new PersonalInfoBLL();
        bool isUpdateButtonClicked = false;
        PersonalInfo tmpPersonalInfo = new PersonalInfo();
        public PersonalInfoForm(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            memberIdTextBox.Text = this.memberId.ToString();

        }
      
        private bool validateInput(string fullname, string age, string occupation)
        {
            int res;
            //validate fullname
            if (!Regex.IsMatch(fullname, @"^[a-zA-Z]"))
            {
                MessageBox.Show("Invalid fullname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(age, out res))
            {
                MessageBox.Show("Invalid age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(occupation, @"^[a-zA-Z]"))
            {
                MessageBox.Show("Invalid occupation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
      
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!this.isUpdateButtonClicked)
            {
                updateButton.Text = "Submit";
                fullNameTextBox.Enabled = true;
                ageTextBox.Enabled = true;
                occupationTextBox.Enabled = true;

                this.isUpdateButtonClicked = true;
            }
            else
            {
                string fullname = fullNameTextBox.Text;
                string age = ageTextBox.Text;
                string occupation = occupationTextBox.Text;
                if (validateInput(fullname, age, occupation))
                {
                    DataTable isExist = personalInfoBll.GetById(this.memberId);
                    //if there's exist an instance --> update
                    if (isExist.Rows.Count != 0)
                    {
                        int res = personalInfoBll.Update(new PersonalInfo(this.memberId, fullname, int.Parse(age), occupation));
                        if (res != 0)
                        {
                            MessageBox.Show("Update succeeded");
                            updateButton.Text = "Update";
                            fullNameTextBox.Enabled = false;
                            ageTextBox.Enabled = false;
                            occupationTextBox.Enabled = false;
                        }
                    }
                    //if there havent had any instance yet --> insert
                    else
                    {
                        int res = personalInfoBll.Insert(new PersonalInfo(this.memberId, fullname, int.Parse(age), occupation));
                        if (res != 0)
                        {
                            MessageBox.Show("Insert succeeded");
                            updateButton.Text = "Update";
                            fullNameTextBox.Enabled = false;
                            ageTextBox.Enabled = false;
                            occupationTextBox.Enabled = false;
                        }
                    }
                }
                this.isUpdateButtonClicked = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonalInfoForm_Load(object sender, EventArgs e)
        {
            DataTable res = personalInfoBll.GetById(this.memberId);
            if (res.Rows.Count != 0)
            {
                memberIdTextBox.Text = res.Rows[0]["Id"].ToString();
                fullNameTextBox.Text = res.Rows[0]["Fullname"].ToString();
                ageTextBox.Text = res.Rows[0]["Age"].ToString();
                occupationTextBox.Text = res.Rows[0]["Occupation"].ToString();

                tmpPersonalInfo.id = this.memberId;
                tmpPersonalInfo.fullname = fullNameTextBox.Text;
                tmpPersonalInfo.age = int.Parse(ageTextBox.Text);
                tmpPersonalInfo.occupation = occupationTextBox.Text;
            }

            memberIdTextBox.Enabled = false;
            fullNameTextBox.Enabled = false;
            ageTextBox.Enabled = false;
            occupationTextBox.Enabled = false;
        }
    }
}
