using System;
using System.Collections;
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
            cmbProg.Items.Add("-Select Program-");



            ArrayList months = new ArrayList();
            {
                months.Add("January");
                months.Add("February");
                months.Add("March");
                months.Add("April");
                months.Add("May");
                months.Add("June");
                months.Add("July");
                months.Add("August");
                months.Add("September");
                months.Add("October");
                months.Add("November");
                months.Add("December");

            }

                for (int day = 1; day <= 31; day++)
                {
                    cmbday.Items.Add(day);
                }


                foreach (string m in months)
                {
                    cmbmonth.Items.Add(m);
                }


                int currentYear = DateTime.Now.Year;
                for (int year = 1900; year <= currentYear; year++)
                {
                    cmbyear.Items.Add(year);
                }
                ArrayList programs = new ArrayList();
                programs.Add("Bachelor of Science in Computer Science");
                programs.Add("Bachelor of Science in Information Technology");
                programs.Add("Bachelor of Science in Tourism Management");
                programs.Add("Bachelor of Science in Computer Engineering");
                foreach (string p in programs)
                {
                    cmbProg.Items.Add(p);
                }
                cmbday.SelectedIndex = 0;
                cmbmonth.SelectedIndex = 0;
                cmbyear.SelectedIndex = 0;
                cmbProg.SelectedIndex = 0;

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
            if(cmbProg.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a program.",
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
            string message =
                "Student name: " + fullName + "\n"
                    +"Gender: " + gender + "\n"
                       +"Date of birth: " + dateOfBirth+ "\n"
                            +"Program: " + cmbProg.SelectedItem.ToString();

            MessageBox.Show(message);
        }

        
        

        }
    }
    





