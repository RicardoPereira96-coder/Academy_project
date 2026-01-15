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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            btStudents = new Button();
            btWorkouts = new Button();
            lbHome = new Label();
            btWorkoutAssigns = new Button();
            btWorkoutsStudents = new Button();
            SuspendLayout();
            // 
            // btStudents
            // 
            btStudents.BackColor = Color.SkyBlue;
            btStudents.BackgroundImageLayout = ImageLayout.Center;
            btStudents.FlatStyle = FlatStyle.Flat;
            btStudents.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btStudents.ForeColor = SystemColors.ActiveCaptionText;
            btStudents.Location = new Point(158, 119);
            btStudents.Name = "btStudents";
            btStudents.Size = new Size(139, 71);
            btStudents.TabIndex = 0;
            btStudents.Text = "Students Management";
            btStudents.UseVisualStyleBackColor = false;
            btStudents.Click += btStudents_Click;
            // 
            // btWorkouts
            // 
            btWorkouts.BackColor = Color.SkyBlue;
            btWorkouts.BackgroundImageLayout = ImageLayout.Center;
            btWorkouts.FlatStyle = FlatStyle.Flat;
            btWorkouts.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btWorkouts.Location = new Point(303, 119);
            btWorkouts.Name = "btWorkouts";
            btWorkouts.Size = new Size(139, 71);
            btWorkouts.TabIndex = 1;
            btWorkouts.Text = "Workouts Management";
            btWorkouts.UseVisualStyleBackColor = false;
            btWorkouts.Click += btWorkouts_Click;
            // 
            // lbHome
            // 
            lbHome.AutoSize = true;
            lbHome.BackColor = Color.Transparent;
            lbHome.BorderStyle = BorderStyle.Fixed3D;
            lbHome.Font = new Font("Sylfaen", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHome.ForeColor = Color.Crimson;
            lbHome.Location = new Point(158, 18);
            lbHome.Name = "lbHome";
            lbHome.Size = new Size(453, 37);
            lbHome.TabIndex = 2;
            lbHome.Text = "Welcome to the academy homepage";
            // 
            // btWorkoutAssigns
            // 
            btWorkoutAssigns.BackColor = Color.SkyBlue;
            btWorkoutAssigns.BackgroundImageLayout = ImageLayout.Center;
            btWorkoutAssigns.FlatStyle = FlatStyle.Flat;
            btWorkoutAssigns.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btWorkoutAssigns.Location = new Point(448, 119);
            btWorkoutAssigns.Name = "btWorkoutAssigns";
            btWorkoutAssigns.Size = new Size(139, 71);
            btWorkoutAssigns.TabIndex = 3;
            btWorkoutAssigns.Text = "Workouts Assigns";
            btWorkoutAssigns.UseVisualStyleBackColor = false;
            btWorkoutAssigns.Click += btWorkoutAssigns_Click;
            // 
            // btWorkoutsStudents
            // 
            btWorkoutsStudents.BackColor = Color.SkyBlue;
            btWorkoutsStudents.BackgroundImageLayout = ImageLayout.Center;
            btWorkoutsStudents.FlatStyle = FlatStyle.Flat;
            btWorkoutsStudents.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btWorkoutsStudents.Location = new Point(303, 196);
            btWorkoutsStudents.Name = "btWorkoutsStudents";
            btWorkoutsStudents.Size = new Size(139, 71);
            btWorkoutsStudents.TabIndex = 4;
            btWorkoutsStudents.Text = "Students Workouts";
            btWorkoutsStudents.UseVisualStyleBackColor = false;
            btWorkoutsStudents.Click += btWorkoutsStudents_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
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
