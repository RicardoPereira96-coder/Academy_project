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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lbWokroutDuration = new Label();
            lbWorkoutObjective = new Label();
            lbWorkoutName = new Label();
            btUpdateWorkout = new Button();
            btDeleteWorkout = new Button();
            btAddWorkout = new Button();
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
            // 
            // textBox3
            // 
            textBox3.Location = new Point(242, 76);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 23);
            textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(242, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 23);
            textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(242, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 19;
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
            // 
            // btDeleteWorkout
            // 
            btDeleteWorkout.Location = new Point(224, 155);
            btDeleteWorkout.Name = "btDeleteWorkout";
            btDeleteWorkout.Size = new Size(112, 43);
            btDeleteWorkout.TabIndex = 13;
            btDeleteWorkout.Text = "Delete Workout";
            btDeleteWorkout.UseVisualStyleBackColor = true;
            // 
            // btAddWorkout
            // 
            btAddWorkout.Location = new Point(12, 20);
            btAddWorkout.Name = "btAddWorkout";
            btAddWorkout.Size = new Size(112, 43);
            btAddWorkout.TabIndex = 12;
            btAddWorkout.Text = "Add Wokrout";
            btAddWorkout.UseVisualStyleBackColor = true;
            // 
            // Workouts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListWorkouts);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lbWokroutDuration;
        private Label lbWorkoutObjective;
        private Label lbWorkoutName;
        private Button btUpdateWorkout;
        private Button btDeleteWorkout;
        private Button btAddWorkout;
    }
}