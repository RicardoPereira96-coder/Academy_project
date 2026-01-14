using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms.Models;

namespace Forms
{
    public partial class WorkoutsAssigns : Form
    {
        private List<StudentModel> availableStudents = GlobalConfig.Connection.GetStudents_All();
        private List<TrainingModel> availableWorkouts = GlobalConfig.Connection.GetTraining_All();
        public WorkoutsAssigns()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            cbStudentName.DataSource = availableStudents;
            cbStudentName.DisplayMember = "Name";


            cbWorkoutName.DataSource = availableWorkouts;
            cbWorkoutName.DisplayMember = "Name";
        }
        private void btAddWorkoutToStudent_Click(object sender, EventArgs e)
        {
            StudentModel s = (StudentModel)cbStudentName.SelectedItem;
            TrainingModel t = (TrainingModel)cbWorkoutName.SelectedItem;

            if (s != null && t != null)
            {
                DateTime startDate = DateTime.Now;
                DateTime endDate = DateTime.Now.AddMonths(3);

                GlobalConfig.Connection.AssignTraining(s.ID, t.ID, startDate, endDate);

                MessageBox.Show($"Workout '{t.Name}' was successfully assigned to {s.Name}.");
            }
            else
            {
                MessageBox.Show("Please select both a student and a workout.");
            }
        }

        private void btRemoveWorkoutToStudent_Click(object sender, EventArgs e)
        {
            StudentModel s = (StudentModel)cbStudentName.SelectedItem;
            TrainingModel t = (TrainingModel)cbWorkoutName.SelectedItem;

            if (s != null && t != null)
            {
                var confirm = MessageBox.Show("Are you sure you want to remove this workout assignment?", "Confirm", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    GlobalConfig.Connection.RemoveTraining(s.ID, t.ID);
                    MessageBox.Show("Assignment removed.");
                }
            }
        }

        private void cbWorkoutName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
