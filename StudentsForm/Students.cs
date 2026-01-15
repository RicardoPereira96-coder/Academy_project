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
    /// <summary>
    /// Form for managing student records, including creation, updates, and deletion.
    /// </summary>
    public partial class Students : Form
    {
        // Local list to hold students loaded from the data source
        private List<StudentModel> availableStudents = GlobalConfig.Connection.GetStudents_All();
        public Students()
        {
            InitializeComponent();
            WireUpLists();
            ClearForm();
        }
        /// <summary>
        /// Refreshes the ListBox data binding to show the current list of students.
        /// </summary>
        private void WireUpLists()
        {
            ListStudents.DataSource = null;
            ListStudents.DataSource = availableStudents;
            ListStudents.DisplayMember = "FullName";
        }

        /// <summary>
        /// Logic is after all the validations adds..
        /// </summary>
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
                // Save to data storage (file or Database) and update local list
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
        /// <summary>
        /// Validation for the data.
        /// </summary>
        /// <returns>True if all fields are valid.</returns>
        private bool ValidateForm()
        {
            // Ensure name only contains letters and spaces
            bool output = true;
            foreach (char c in tbName.Text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("The Name field can only contain letters.", "Invalid Input");
                    return false;
                }
            }
            // Ensure phone number contains only digits
            foreach (char c in tbPhoneNumber.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("The Phone Number must contain only numbers.", "Invalid Input");
                    return false;
                }
            }
            // Validate date format
            DateTime tempDate;
            bool isValidDate = DateTime.TryParse(tbBirth.Text, out tempDate);

            if (isValidDate == false)
            {
                MessageBox.Show("Please enter a valid Birth Date (e.g., 15-01-2000).", "Invalid Input");
                return false;
            }
            // Check for empty required fields
            if (tbName.Text.Length == 0 || tbPhoneNumber.Text.Length == 0 || tbEmail.Text.Length == 0)
            {
                MessageBox.Show("Please fill in all required fields.", "Invalid Input");
                output = false;
            }

            return output;
        }
        /// <summary>
        /// Resets all input fields to empty strings.
        /// </summary>
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
