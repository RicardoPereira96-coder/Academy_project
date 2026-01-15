using Forms;

namespace StudentsForm
{
    public partial class HomeForm : Form
    {
        /// <summary>
        /// The main dashboard of the application. 
        /// It provides navigation buttons to access all other modules.
        /// </summary>
        public HomeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens the Student Management form.
        /// </summary>
        private void btStudents_Click(object sender, EventArgs e)
        {

            Students studentForm = new Students();
            studentForm.Show();
        }

        /// <summary>
        /// Opens the Workout/Training Plan Management form.
        /// </summary>
        private void btWorkouts_Click(object sender, EventArgs e)
        {

            Workouts workoutForm = new Workouts();
            workoutForm.Show();
        }

        /// <summary>
        /// Opens the form to assign workouts to specific students.
        /// </summary>
        private void btWorkoutAssigns_Click(object sender, EventArgs e)
        {

            WorkoutsAssigns workoutAssignForm = new WorkoutsAssigns();
            workoutAssignForm.Show();
        }

        /// <summary>
        /// Opens the viewer form to check which workouts are assigned to which student.
        /// </summary>
        private void btWorkoutsStudents_Click(object sender, EventArgs e)
        {
            StudentsWorkouts workoutStudentForm = new StudentsWorkouts();
            workoutStudentForm.Show();
        }
    }
}
