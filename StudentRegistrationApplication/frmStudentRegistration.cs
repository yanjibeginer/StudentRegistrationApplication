using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void StudentRegistrationApplication_click(object sender, EventArgs e)
        {
            cmbday.Items.Add("-Day-");
            cmbmonth.Items.Add("-Month-");
            cmbyear.Items.Add("-Year-");



            for (int day = 1; day <= 31; day++)
            {
                cmbday.Items.Add(day);
            }


            for (int month = 1; month <= 12; month++)
            {
                cmbmonth.Items.Add(month);
            }


            int currentYear = DateTime.Now.Year;
            for (int year = 1900; year <= currentYear; year++)
            {
                cmbyear.Items.Add(year);
            }


            cmbday.SelectedIndex = 0;
            cmbmonth.SelectedIndex = 0;
            cmbyear.SelectedIndex = 0;
        }
        

        private void Register_Click(object sender, EventArgs e)
            
        {

            if (string.IsNullOrWhiteSpace(lnamebox.Text))
            {
                MessageBox.Show("Please enter the last name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lnamebox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(fnamebox.Text))
            {
                MessageBox.Show("Please enter the first name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fnamebox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(mnamebox.Text))
            {
                MessageBox.Show("Please enter the middle name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mnamebox.Focus();
                return;
            }

            if (!rbmale.Checked && !rbfemale.Checked)
            {
                MessageBox.Show("Please select a gender.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbday.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a day.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbmonth.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a month.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbyear.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a year.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string day = cmbday.SelectedItem.ToString();
            string month = cmbmonth.SelectedItem.ToString();
            string year = cmbyear.SelectedItem.ToString();

            string gender = "";
            if (rbmale.Checked)
            {
                gender = "Male";
            }
            else if (rbfemale.Checked)
            {
                gender = "Female";
            }

            string fullName = fnamebox.Text + " " + mnamebox.Text + " " + lnamebox.Text;


            string dateOfBirth = day + "/" + month + "/" + year;


            string message = "Student name: " + fullName + "\n"
                           + "Gender: " + gender + "\n"
                           + "Date of birth: " + dateOfBirth;

            MessageBox.Show(message);
        }
    }
}




