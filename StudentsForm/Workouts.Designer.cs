namespace Forms
{
    partial class Workouts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListWorkouts = new ListBox();
            tbWorkoutDuration = new TextBox();
            tbWorkoutObjetive = new TextBox();
            tbWorkoutName = new TextBox();
            lbWokroutDuration = new Label();
            lbWorkoutObjective = new Label();
            lbWorkoutName = new Label();
            btUpdateWorkout = new Button();
            btDeleteWorkout = new Button();
            btAddWorkout = new Button();
            btBack = new Button();
            SuspendLayout();
            // 
            // ListWorkouts
            // 
            ListWorkouts.FormattingEnabled = true;
            ListWorkouts.ItemHeight = 15;
            ListWorkouts.Location = new Point(12, 155);
            ListWorkouts.Name = "ListWorkouts";
            ListWorkouts.Size = new Size(206, 229);
            ListWorkouts.TabIndex = 23;
            ListWorkouts.SelectedIndexChanged += ListWorkouts_SelectedIndexChanged;
            // 
            // tbWorkoutDuration
            // 
            tbWorkoutDuration.Location = new Point(242, 76);
            tbWorkoutDuration.Name = "tbWorkoutDuration";
            tbWorkoutDuration.Size = new Size(236, 23);
            tbWorkoutDuration.TabIndex = 21;
            // 
            // tbWorkoutObjetive
            // 
            tbWorkoutObjetive.Location = new Point(242, 49);
            tbWorkoutObjetive.Name = "tbWorkoutObjetive";
            tbWorkoutObjetive.Size = new Size(236, 23);
            tbWorkoutObjetive.TabIndex = 20;
            // 
            // tbWorkoutName
            // 
            tbWorkoutName.Location = new Point(242, 20);
            tbWorkoutName.Name = "tbWorkoutName";
            tbWorkoutName.Size = new Size(236, 23);
            tbWorkoutName.TabIndex = 19;
            // 
            // lbWokroutDuration
            // 
            lbWokroutDuration.AutoSize = true;
            lbWokroutDuration.Location = new Point(130, 79);
            lbWokroutDuration.Name = "lbWokroutDuration";
            lbWokroutDuration.Size = new Size(53, 15);
            lbWokroutDuration.TabIndex = 17;
            lbWokroutDuration.Text = "Duration";
            // 
            // lbWorkoutObjective
            // 
            lbWorkoutObjective.AutoSize = true;
            lbWorkoutObjective.Location = new Point(130, 52);
            lbWorkoutObjective.Name = "lbWorkoutObjective";
            lbWorkoutObjective.Size = new Size(106, 15);
            lbWorkoutObjective.TabIndex = 16;
            lbWorkoutObjective.Text = "Workout Objective";
            // 
            // lbWorkoutName
            // 
            lbWorkoutName.AutoSize = true;
            lbWorkoutName.Location = new Point(130, 23);
            lbWorkoutName.Name = "lbWorkoutName";
            lbWorkoutName.Size = new Size(39, 15);
            lbWorkoutName.TabIndex = 15;
            lbWorkoutName.Text = "Name";
            // 
            // btUpdateWorkout
            // 
            btUpdateWorkout.Location = new Point(12, 70);
            btUpdateWorkout.Name = "btUpdateWorkout";
            btUpdateWorkout.Size = new Size(112, 43);
            btUpdateWorkout.TabIndex = 14;
            btUpdateWorkout.Text = "Update Workout Info";
            btUpdateWorkout.UseVisualStyleBackColor = true;
            btUpdateWorkout.Click += btUpdateWorkout_Click;
            // 
            // btDeleteWorkout
            // 
            btDeleteWorkout.Location = new Point(224, 155);
            btDeleteWorkout.Name = "btDeleteWorkout";
            btDeleteWorkout.Size = new Size(112, 43);
            btDeleteWorkout.TabIndex = 13;
            btDeleteWorkout.Text = "Delete Workout";
            btDeleteWorkout.UseVisualStyleBackColor = true;
            btDeleteWorkout.Click += btDeleteWorkout_Click;
            // 
            // btAddWorkout
            // 
            btAddWorkout.Location = new Point(12, 20);
            btAddWorkout.Name = "btAddWorkout";
            btAddWorkout.Size = new Size(112, 43);
            btAddWorkout.TabIndex = 12;
            btAddWorkout.Text = "Add Wokrout";
            btAddWorkout.UseVisualStyleBackColor = true;
            btAddWorkout.Click += btAddWorkout_Click;
            // 
            // btBack
            // 
            btBack.Location = new Point(661, 399);
            btBack.Name = "btBack";
            btBack.Size = new Size(75, 23);
            btBack.TabIndex = 24;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // Workouts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btBack);
            Controls.Add(ListWorkouts);
            Controls.Add(tbWorkoutDuration);
            Controls.Add(tbWorkoutObjetive);
            Controls.Add(tbWorkoutName);
            Controls.Add(lbWokroutDuration);
            Controls.Add(lbWorkoutObjective);
            Controls.Add(lbWorkoutName);
            Controls.Add(btUpdateWorkout);
            Controls.Add(btDeleteWorkout);
            Controls.Add(btAddWorkout);
            Name = "Workouts";
            Text = "Workouts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListWorkouts;
        private TextBox tbWorkoutDuration;
        private TextBox tbWorkoutObjetive;
        private TextBox tbWorkoutName;
        private Label lbWokroutDuration;
        private Label lbWorkoutObjective;
        private Label lbWorkoutName;
        private Button btUpdateWorkout;
        private Button btDeleteWorkout;
        private Button btAddWorkout;
        private Button btBack;
    }
}