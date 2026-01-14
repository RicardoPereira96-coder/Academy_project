namespace Forms
{
    partial class StudentsWorkouts
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
            cbStudentName = new ComboBox();
            lbStudentName = new Label();
            lbStudentWorkouts = new ListBox();
            SuspendLayout();
            // 
            // cbStudentName
            // 
            cbStudentName.FormattingEnabled = true;
            cbStudentName.Location = new Point(345, 75);
            cbStudentName.Name = "cbStudentName";
            cbStudentName.Size = new Size(121, 23);
            cbStudentName.TabIndex = 27;
            // 
            // lbStudentName
            // 
            lbStudentName.AutoSize = true;
            lbStudentName.Location = new Point(233, 75);
            lbStudentName.Name = "lbStudentName";
            lbStudentName.Size = new Size(83, 15);
            lbStudentName.TabIndex = 26;
            lbStudentName.Text = "Student Name";
            // 
            // lbStudentWorkouts
            // 
            lbStudentWorkouts.FormattingEnabled = true;
            lbStudentWorkouts.ItemHeight = 15;
            lbStudentWorkouts.Location = new Point(233, 140);
            lbStudentWorkouts.Name = "lbStudentWorkouts";
            lbStudentWorkouts.Size = new Size(233, 229);
            lbStudentWorkouts.TabIndex = 28;
            // 
            // StudentsWorkouts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbStudentWorkouts);
            Controls.Add(cbStudentName);
            Controls.Add(lbStudentName);
            Name = "StudentsWorkouts";
            Text = "StudentsWorkouts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbStudentName;
        private Label lbStudentName;
        private ListBox lbStudentWorkouts;
    }
}