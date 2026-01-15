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
            btBack = new Button();
            SuspendLayout();
            // 
            // lbStudentName
            // 
            lbStudentName.AutoSize = true;
            lbStudentName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbStudentName.Location = new Point(228, 154);
            lbStudentName.Name = "lbStudentName";
            lbStudentName.Size = new Size(114, 22);
            lbStudentName.TabIndex = 23;
            lbStudentName.Text = "Student Name";
            // 
            // lbWorkoutName
            // 
            lbWorkoutName.AutoSize = true;
            lbWorkoutName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbWorkoutName.Location = new Point(219, 120);
            lbWorkoutName.Name = "lbWorkoutName";
            lbWorkoutName.Size = new Size(123, 22);
            lbWorkoutName.TabIndex = 22;
            lbWorkoutName.Text = "Workout Name";
            // 
            // cbWorkoutName
            // 
            cbWorkoutName.BackColor = Color.Silver;
            cbWorkoutName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWorkoutName.FlatStyle = FlatStyle.Flat;
            cbWorkoutName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            cbWorkoutName.FormattingEnabled = true;
            cbWorkoutName.Location = new Point(348, 117);
            cbWorkoutName.Name = "cbWorkoutName";
            cbWorkoutName.Size = new Size(164, 30);
            cbWorkoutName.TabIndex = 24;
            cbWorkoutName.SelectedIndexChanged += cbWorkoutName_SelectedIndexChanged;
            // 
            // cbStudentName
            // 
            cbStudentName.BackColor = Color.Silver;
            cbStudentName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudentName.FlatStyle = FlatStyle.Flat;
            cbStudentName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            cbStudentName.FormattingEnabled = true;
            cbStudentName.Location = new Point(348, 154);
            cbStudentName.Name = "cbStudentName";
            cbStudentName.Size = new Size(164, 30);
            cbStudentName.TabIndex = 25;
            cbStudentName.SelectedIndexChanged += cbStudentName_SelectedIndexChanged;
            // 
            // btAddWorkoutToStudent
            // 
            btAddWorkoutToStudent.BackColor = Color.FromArgb(128, 255, 128);
            btAddWorkoutToStudent.FlatStyle = FlatStyle.Flat;
            btAddWorkoutToStudent.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btAddWorkoutToStudent.Location = new Point(203, 205);
            btAddWorkoutToStudent.Name = "btAddWorkoutToStudent";
            btAddWorkoutToStudent.Size = new Size(161, 63);
            btAddWorkoutToStudent.TabIndex = 26;
            btAddWorkoutToStudent.Text = "Add Workout to Student";
            btAddWorkoutToStudent.UseVisualStyleBackColor = false;
            btAddWorkoutToStudent.Click += btAddWorkoutToStudent_Click;
            // 
            // btRemoveWorkoutToStudent
            // 
            btRemoveWorkoutToStudent.BackColor = Color.Yellow;
            btRemoveWorkoutToStudent.FlatStyle = FlatStyle.Flat;
            btRemoveWorkoutToStudent.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btRemoveWorkoutToStudent.Location = new Point(388, 205);
            btRemoveWorkoutToStudent.Name = "btRemoveWorkoutToStudent";
            btRemoveWorkoutToStudent.Size = new Size(161, 63);
            btRemoveWorkoutToStudent.TabIndex = 27;
            btRemoveWorkoutToStudent.Text = "Remove Workout to Student";
            btRemoveWorkoutToStudent.UseVisualStyleBackColor = false;
            btRemoveWorkoutToStudent.Click += btRemoveWorkoutToStudent_Click;
            // 
            // btBack
            // 
            btBack.BackColor = Color.FromArgb(224, 224, 224);
            btBack.FlatStyle = FlatStyle.Flat;
            btBack.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btBack.Location = new Point(670, 376);
            btBack.Name = "btBack";
            btBack.Size = new Size(75, 48);
            btBack.TabIndex = 28;
            btBack.Text = "back";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // WorkoutsAssigns
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btBack);
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
        private Button btBack;
    }
}