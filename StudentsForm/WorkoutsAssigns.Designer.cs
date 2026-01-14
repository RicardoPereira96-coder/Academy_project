namespace Forms
{
    partial class WorkoutsAssigns
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
            lbStudentName = new Label();
            lbWorkoutName = new Label();
            cbWorkoutName = new ComboBox();
            cbStudentName = new ComboBox();
            btAddWorkoutToStudent = new Button();
            btRemoveWorkoutToStudent = new Button();
            SuspendLayout();
            // 
            // lbStudentName
            // 
            lbStudentName.AutoSize = true;
            lbStudentName.Location = new Point(229, 152);
            lbStudentName.Name = "lbStudentName";
            lbStudentName.Size = new Size(83, 15);
            lbStudentName.TabIndex = 23;
            lbStudentName.Text = "Student Name";
            // 
            // lbWorkoutName
            // 
            lbWorkoutName.AutoSize = true;
            lbWorkoutName.Location = new Point(229, 123);
            lbWorkoutName.Name = "lbWorkoutName";
            lbWorkoutName.Size = new Size(88, 15);
            lbWorkoutName.TabIndex = 22;
            lbWorkoutName.Text = "Workout Name";
            // 
            // cbWorkoutName
            // 
            cbWorkoutName.FormattingEnabled = true;
            cbWorkoutName.Location = new Point(341, 120);
            cbWorkoutName.Name = "cbWorkoutName";
            cbWorkoutName.Size = new Size(121, 23);
            cbWorkoutName.TabIndex = 24;
            // 
            // cbStudentName
            // 
            cbStudentName.FormattingEnabled = true;
            cbStudentName.Location = new Point(341, 152);
            cbStudentName.Name = "cbStudentName";
            cbStudentName.Size = new Size(121, 23);
            cbStudentName.TabIndex = 25;
            // 
            // btAddWorkoutToStudent
            // 
            btAddWorkoutToStudent.Location = new Point(229, 205);
            btAddWorkoutToStudent.Name = "btAddWorkoutToStudent";
            btAddWorkoutToStudent.Size = new Size(135, 44);
            btAddWorkoutToStudent.TabIndex = 26;
            btAddWorkoutToStudent.Text = "Add Workout to Student";
            btAddWorkoutToStudent.UseVisualStyleBackColor = true;
            // 
            // btRemoveWorkoutToStudent
            // 
            btRemoveWorkoutToStudent.Location = new Point(370, 205);
            btRemoveWorkoutToStudent.Name = "btRemoveWorkoutToStudent";
            btRemoveWorkoutToStudent.Size = new Size(135, 44);
            btRemoveWorkoutToStudent.TabIndex = 27;
            btRemoveWorkoutToStudent.Text = "Remove Workout to Student";
            btRemoveWorkoutToStudent.UseVisualStyleBackColor = true;
            // 
            // WorkoutsAssigns
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btRemoveWorkoutToStudent);
            Controls.Add(btAddWorkoutToStudent);
            Controls.Add(cbStudentName);
            Controls.Add(cbWorkoutName);
            Controls.Add(lbStudentName);
            Controls.Add(lbWorkoutName);
            Name = "WorkoutsAssigns";
            Text = "WorkoutsAssigns";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbStudentName;
        private Label lbWorkoutName;
        private ComboBox cbWorkoutName;
        private ComboBox cbStudentName;
        private Button btAddWorkoutToStudent;
        private Button btRemoveWorkoutToStudent;
    }
}