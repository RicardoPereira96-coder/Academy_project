using Forms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Forms
{
    public partial class Students : Form
    {
        private List<StudentModel> availableStudents = GlobalConfig.Connection.GetStudents_All();
        public Students()
        {
            InitializeComponent();
            WireUpLists();
            ClearForm();
        }
        private void WireUpLists()
        {
            ListStudents.DataSource = null;
            ListStudents.DataSource = availableStudents;
            ListStudents.DisplayMember = "FullName";
        }

        private void btAddStudent_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                StudentModel s = new StudentModel
                {
                    Name = tbName.Text,
                    PhoneNumber = tbPhoneNumber.Text,
                    EmailAddress = tbEmail.Text,
                    BirthDate = tbBirth.Text
                };

                GlobalConfig.Connection.CreateStudent(s);
                availableStudents.Add(s);
                WireUpLists();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Plese fill the necessary data");
            }
        }

        private void btStudentUpdate_Click(object sender, EventArgs e)
        {
            StudentModel selected = (StudentModel)ListStudents.SelectedItem;

            if (selected != null && ValidateForm())
            {
                selected.Name = tbName.Text;
                selected.PhoneNumber = tbPhoneNumber.Text;
                selected.EmailAddress = tbEmail.Text;
                selected.BirthDate = tbBirth.Text;


                GlobalConfig.Connection.UpdateStudent(selected);

                WireUpLists();
                MessageBox.Show("Student Info updated");
            }
        }

        private void btDeleteStudent_Click(object sender, EventArgs e)
        {
            StudentModel selected = (StudentModel)ListStudents.SelectedItem;

            if (selected != null)
            {
                var confirm = MessageBox.Show($"Are you sure to delete the student {selected.Name}?", "Confirm", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {

                    GlobalConfig.Connection.DeleteStudent(selected.ID);


                    availableStudents.Remove(selected);
                    WireUpLists();
                    ClearForm();
                }
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            foreach (char c in tbName.Text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("The Name field can only contain letters.", "Invalid Input");
                    return false;
                }
            }
            foreach (char c in tbPhoneNumber.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("The Phone Number must contain only numbers.", "Invalid Input");
                    return false;
                }
            }
            DateTime tempDate;
            bool isValidDate = DateTime.TryParse(tbBirth.Text, out tempDate);

            if (isValidDate == false)
            {
                MessageBox.Show("Please enter a valid Birth Date (e.g., 15-01-2000).", "Invalid Input");
                return false;
            }
            if (tbName.Text.Length == 0 || tbPhoneNumber.Text.Length == 0 || tbEmail.Text.Length == 0)
            {
                MessageBox.Show("Please fill in all required fields.", "Invalid Input");
                output = false;
            }

            return output;
        }
        private void ClearForm()
        {
            tbName.Text = "";
            tbPhoneNumber.Text = "";
            tbEmail.Text = "";
            tbBirth.Text = "";
        }

        private void ListStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentModel selected = (StudentModel)ListStudents.SelectedItem;

            if (selected != null)
            {
                tbName.Text = selected.Name;
                tbPhoneNumber.Text = selected.PhoneNumber;
                tbEmail.Text = selected.EmailAddress;
                tbBirth.Text = selected.BirthDate;
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
