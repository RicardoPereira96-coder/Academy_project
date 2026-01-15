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
            ListWorkouts.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            ListWorkouts.FormattingEnabled = true;
            ListWorkouts.ItemHeight = 22;
            ListWorkouts.Location = new Point(119, 144);
            ListWorkouts.Name = "ListWorkouts";
            ListWorkouts.Size = new Size(523, 224);
            ListWorkouts.TabIndex = 23;
            ListWorkouts.SelectedIndexChanged += ListWorkouts_SelectedIndexChanged;
            // 
            // tbWorkoutDuration
            // 
            tbWorkoutDuration.Location = new Point(277, 94);
            tbWorkoutDuration.Name = "tbWorkoutDuration";
            tbWorkoutDuration.Size = new Size(236, 23);
            tbWorkoutDuration.TabIndex = 21;
            // 
            // tbWorkoutObjetive
            // 
            tbWorkoutObjetive.Location = new Point(277, 65);
            tbWorkoutObjetive.Name = "tbWorkoutObjetive";
            tbWorkoutObjetive.Size = new Size(236, 23);
            tbWorkoutObjetive.TabIndex = 20;
            // 
            // tbWorkoutName
            // 
            tbWorkoutName.Location = new Point(277, 37);
            tbWorkoutName.Name = "tbWorkoutName";
            tbWorkoutName.Size = new Size(236, 23);
            tbWorkoutName.TabIndex = 19;
            tbWorkoutName.TextChanged += tbWorkoutName_TextChanged;
            // 
            // lbWokroutDuration
            // 
            lbWokroutDuration.AutoSize = true;
            lbWokroutDuration.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbWokroutDuration.Location = new Point(196, 92);
            lbWokroutDuration.Name = "lbWokroutDuration";
            lbWokroutDuration.Size = new Size(75, 22);
            lbWokroutDuration.TabIndex = 17;
            lbWokroutDuration.Text = "Duration";
            // 
            // lbWorkoutObjective
            // 
            lbWorkoutObjective.AutoSize = true;
            lbWorkoutObjective.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbWorkoutObjective.Location = new Point(119, 66);
            lbWorkoutObjective.Name = "lbWorkoutObjective";
            lbWorkoutObjective.Size = new Size(152, 22);
            lbWorkoutObjective.TabIndex = 16;
            lbWorkoutObjective.Text = "Workout Objective";
            // 
            // lbWorkoutName
            // 
            lbWorkoutName.AutoSize = true;
            lbWorkoutName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbWorkoutName.Location = new Point(218, 38);
            lbWorkoutName.Name = "lbWorkoutName";
            lbWorkoutName.Size = new Size(53, 22);
            lbWorkoutName.TabIndex = 15;
            lbWorkoutName.Text = "Name";
            // 
            // btUpdateWorkout
            // 
            btUpdateWorkout.BackColor = Color.Yellow;
            btUpdateWorkout.FlatStyle = FlatStyle.Flat;
            btUpdateWorkout.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btUpdateWorkout.Location = new Point(519, 81);
            btUpdateWorkout.Name = "btUpdateWorkout";
            btUpdateWorkout.Size = new Size(123, 57);
            btUpdateWorkout.TabIndex = 14;
            btUpdateWorkout.Text = "Update Workout Info";
            btUpdateWorkout.UseVisualStyleBackColor = false;
            btUpdateWorkout.Click += btUpdateWorkout_Click;
            // 
            // btDeleteWorkout
            // 
            btDeleteWorkout.BackColor = Color.Red;
            btDeleteWorkout.FlatStyle = FlatStyle.Flat;
            btDeleteWorkout.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btDeleteWorkout.Location = new Point(648, 144);
            btDeleteWorkout.Name = "btDeleteWorkout";
            btDeleteWorkout.Size = new Size(119, 55);
            btDeleteWorkout.TabIndex = 13;
            btDeleteWorkout.Text = "Delete Workout";
            btDeleteWorkout.UseVisualStyleBackColor = false;
            btDeleteWorkout.Click += btDeleteWorkout_Click;
            // 
            // btAddWorkout
            // 
            btAddWorkout.BackColor = Color.FromArgb(0, 192, 0);
            btAddWorkout.FlatStyle = FlatStyle.Flat;
            btAddWorkout.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btAddWorkout.Location = new Point(519, 23);
            btAddWorkout.Name = "btAddWorkout";
            btAddWorkout.Size = new Size(123, 52);
            btAddWorkout.TabIndex = 12;
            btAddWorkout.Text = "Add Wokrout";
            btAddWorkout.UseVisualStyleBackColor = false;
            btAddWorkout.Click += btAddWorkout_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.FromArgb(224, 224, 224);
            btBack.FlatStyle = FlatStyle.Flat;
            btBack.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btBack.Location = new Point(671, 382);
            btBack.Name = "btBack";
            btBack.Size = new Size(96, 39);
            btBack.TabIndex = 24;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // Workouts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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