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

namespace Forms
{
    /// <summary>
    /// Form designed to display the specific workouts assigned to a selected student.
    /// </summary>
    public partial class StudentsWorkouts : Form
    {
        // Load the full list of students from the data source on initialization
        private List<StudentModel> allStudents = GlobalConfig.Connection.GetStudents_All();
        public StudentsWorkouts()
        {
            InitializeComponent();
            // Bind the student list to the ComboBox for selection
            cbStudentName.DataSource = allStudents;
            cbStudentName.DisplayMember = "Name";
        }

        private void lbStudentWorkouts_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentModel selected = (StudentModel)cbStudentName.SelectedItem;

            if (selected != null)
            {
                // Retrieve only the workouts belonging to the selected student ID
                List<TrainingModel> studentWorkouts = GlobalConfig.Connection.GetWorkoutsByStudent(selected.ID);

                // Refresh the ListBox display
                lbStudentWorkouts.DataSource = null;
                lbStudentWorkouts.DataSource = studentWorkouts;
                lbStudentWorkouts.DisplayMember = "Name";
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbStudentName_Click(object sender, EventArgs e)
        {

        }
    }
}
