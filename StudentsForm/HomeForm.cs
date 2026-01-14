using Forms;

namespace StudentsForm
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btStudents_Click(object sender, EventArgs e)
        {

            Students studentForm = new Students();
            studentForm.Show();
        }

        private void btWorkouts_Click(object sender, EventArgs e)
        {

            Workouts workoutForm = new Workouts();
            workoutForm.Show();
        }

        private void btWorkoutAssigns_Click(object sender, EventArgs e)
        {

            WorkoutsAssigns workoutAssignForm = new WorkoutsAssigns();
            workoutAssignForm.Show();
        }

        private void btWorkoutsStudents_Click(object sender, EventArgs e)
        {
            StudentsWorkouts workoutStudentForm = new StudentsWorkouts();
            workoutStudentForm.Show();
        }
    }
}
