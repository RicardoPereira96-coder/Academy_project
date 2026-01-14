namespace StudentsForm
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btStudents = new Button();
            btWorkouts = new Button();
            lbHome = new Label();
            btWorkoutAssigns = new Button();
            btWorkoutsStudents = new Button();
            SuspendLayout();
            // 
            // btStudents
            // 
            btStudents.Location = new Point(158, 119);
            btStudents.Name = "btStudents";
            btStudents.Size = new Size(139, 71);
            btStudents.TabIndex = 0;
            btStudents.Text = "Students Management";
            btStudents.UseVisualStyleBackColor = true;
            btStudents.Click += btStudents_Click;
            // 
            // btWorkouts
            // 
            btWorkouts.Location = new Point(303, 119);
            btWorkouts.Name = "btWorkouts";
            btWorkouts.Size = new Size(139, 71);
            btWorkouts.TabIndex = 1;
            btWorkouts.Text = "Workouts Management";
            btWorkouts.UseVisualStyleBackColor = true;
            btWorkouts.Click += btWorkouts_Click;
            // 
            // lbHome
            // 
            lbHome.AutoSize = true;
            lbHome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHome.Location = new Point(193, 74);
            lbHome.Name = "lbHome";
            lbHome.Size = new Size(354, 30);
            lbHome.TabIndex = 2;
            lbHome.Text = "Welcome to the academy homepage";
            // 
            // btWorkoutAssigns
            // 
            btWorkoutAssigns.Location = new Point(448, 119);
            btWorkoutAssigns.Name = "btWorkoutAssigns";
            btWorkoutAssigns.Size = new Size(139, 71);
            btWorkoutAssigns.TabIndex = 3;
            btWorkoutAssigns.Text = "Workouts Assigns";
            btWorkoutAssigns.UseVisualStyleBackColor = true;
            btWorkoutAssigns.Click += btWorkoutAssigns_Click;
            // 
            // btWorkoutsStudents
            // 
            btWorkoutsStudents.Location = new Point(303, 196);
            btWorkoutsStudents.Name = "btWorkoutsStudents";
            btWorkoutsStudents.Size = new Size(139, 71);
            btWorkoutsStudents.TabIndex = 4;
            btWorkoutsStudents.Text = "Students Workouts";
            btWorkoutsStudents.UseVisualStyleBackColor = true;
            btWorkoutsStudents.Click += btWorkoutsStudents_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btWorkoutsStudents);
            Controls.Add(btWorkoutAssigns);
            Controls.Add(lbHome);
            Controls.Add(btWorkouts);
            Controls.Add(btStudents);
            Name = "HomeForm";
            Text = "StudentsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btStudents;
        private Button btWorkouts;
        private Label lbHome;
        private Button btWorkoutAssigns;
        private Button btWorkoutsStudents;
    }
}
