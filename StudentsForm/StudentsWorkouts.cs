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
    public partial class StudentsWorkouts : Form
    {
        private List<StudentModel> allStudents = GlobalConfig.Connection.GetStudents_All();
        public StudentsWorkouts()
        {
            InitializeComponent();

            cbStudentName.DataSource = allStudents;
            cbStudentName.DisplayMember = "Name";
        }

        private void lbStudentWorkouts_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentModel selected = (StudentModel)cbStudentName.SelectedItem;

            if (selected != null)
            {
                List<TrainingModel> studentWorkouts = GlobalConfig.Connection.GetWorkoutsByStudent(selected.ID);

                lbStudentWorkouts.DataSource = null;
                lbStudentWorkouts.DataSource = studentWorkouts;
                lbStudentWorkouts.DisplayMember = "Name";
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
}
}
