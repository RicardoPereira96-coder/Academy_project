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
            // 
            // btWorkouts
            // 
            btWorkouts.Location = new Point(303, 119);
            btWorkouts.Name = "btWorkouts";
            btWorkouts.Size = new Size(139, 71);
            btWorkouts.TabIndex = 1;
            btWorkouts.Text = "Workouts Management";
            btWorkouts.UseVisualStyleBackColor = true;
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
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
