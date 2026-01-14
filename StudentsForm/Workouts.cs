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
    public partial class Workouts : Form
    {
        private List<TrainingModel> availableWorkouts = GlobalConfig.Connection.GetTraining_All();
        public Workouts()
        {
            InitializeComponent();
            WireUpLists();
            ClearForm();
        }
        private void WireUpLists()
        {
            ListWorkouts.DataSource = null;
            ListWorkouts.DataSource = availableWorkouts;
            ListWorkouts.DisplayMember = "Name";
        }
        private void btAddWorkout_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TrainingModel t = new TrainingModel
                {
                    Name = tbWorkoutName.Text,
                    Objective = tbWorkoutObjetive.Text,
                    Duration = tbWorkoutDuration.Text
                };

                GlobalConfig.Connection.CreateTraining(t);

                availableWorkouts.Add(t);
                WireUpLists();
                ClearForm();
                MessageBox.Show("Workout created successfully!");
            }
        }

        private void btUpdateWorkout_Click(object sender, EventArgs e)
        {
            TrainingModel selected = (TrainingModel)ListWorkouts.SelectedItem;

            if (selected != null && ValidateForm())
            {
                selected.Name = tbWorkoutName.Text;
                selected.Objective = tbWorkoutObjetive.Text;
                selected.Duration = tbWorkoutDuration.Text;

                GlobalConfig.Connection.UpdateTraining(selected);

                WireUpLists();
                MessageBox.Show("Workout info updated!");
            }
        }

        private void btDeleteWorkout_Click(object sender, EventArgs e)
        {
            TrainingModel selected = (TrainingModel)ListWorkouts.SelectedItem;

            if (selected != null)
            {
                var confirm = MessageBox.Show($"Delete '{selected.Name}'?", "Confirm", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    GlobalConfig.Connection.DeleteTraining(selected.ID);
                    availableWorkouts.Remove(selected);
                    WireUpLists();
                    ClearForm();
                }
            }
        }
        private bool ValidateForm()
        {
            return tbWorkoutName.Text.Length > 0 && tbWorkoutDuration.Text.Length > 0;
        }
        private void ListWorkouts_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrainingModel selected = (TrainingModel)ListWorkouts.SelectedItem;

            if (selected != null)
            {
                tbWorkoutName.Text = selected.Name;
                tbWorkoutObjetive.Text = selected.Objective;
                tbWorkoutDuration.Text = selected.Duration;
            }
        }
        private void ClearForm()
        {
            tbWorkoutName.Text = "";
            tbWorkoutObjetive.Text = "";
            tbWorkoutDuration.Text = "";
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
