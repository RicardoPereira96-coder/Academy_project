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
                //GlobalConfig.Connection.CreateStudent(s);

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

                // Chama a spStudents_Update no SQL
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
                    // Remove do SQL (spStudents_Delete)
                    GlobalConfig.Connection.DeleteStudent(selected.ID);

                    // Remove da lista em memória e atualiza UI
                    availableStudents.Remove(selected);
                    WireUpLists();
                    ClearForm();
                }
            }
        }
        private bool ValidateForm()
        {
            if (tbName.Text.Length == 0) return false;
            if (tbEmail.Text.Length == 0) return false;
            return true;
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
    }
}
