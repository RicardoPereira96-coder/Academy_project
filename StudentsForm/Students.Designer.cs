namespace Forms
{
    partial class Students
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
            btAddStudent = new Button();
            btDeleteStudent = new Button();
            btStudentUpdate = new Button();
            lbStudentName = new Label();
            lbStudentPhoneNumber = new Label();
            lbStudentEmail = new Label();
            lbStudentBirthDate = new Label();
            tbName = new TextBox();
            tbPhoneNumber = new TextBox();
            tbEmail = new TextBox();
            tbBirth = new TextBox();
            ListStudents = new ListBox();
            SuspendLayout();
            // 
            // btAddStudent
            // 
            btAddStudent.Location = new Point(12, 12);
            btAddStudent.Name = "btAddStudent";
            btAddStudent.Size = new Size(112, 43);
            btAddStudent.TabIndex = 0;
            btAddStudent.Text = "Add Student";
            btAddStudent.UseVisualStyleBackColor = true;
            btAddStudent.Click += btAddStudent_Click;
            // 
            // btDeleteStudent
            // 
            btDeleteStudent.Location = new Point(224, 147);
            btDeleteStudent.Name = "btDeleteStudent";
            btDeleteStudent.Size = new Size(112, 43);
            btDeleteStudent.TabIndex = 1;
            btDeleteStudent.Text = "Delete Student";
            btDeleteStudent.UseVisualStyleBackColor = true;
            btDeleteStudent.Click += btDeleteStudent_Click;
            // 
            // btStudentUpdate
            // 
            btStudentUpdate.Location = new Point(12, 62);
            btStudentUpdate.Name = "btStudentUpdate";
            btStudentUpdate.Size = new Size(112, 43);
            btStudentUpdate.TabIndex = 2;
            btStudentUpdate.Text = "Update Student Info";
            btStudentUpdate.UseVisualStyleBackColor = true;
            btStudentUpdate.Click += btStudentUpdate_Click;
            // 
            // lbStudentName
            // 
            lbStudentName.AutoSize = true;
            lbStudentName.Location = new Point(130, 15);
            lbStudentName.Name = "lbStudentName";
            lbStudentName.Size = new Size(39, 15);
            lbStudentName.TabIndex = 3;
            lbStudentName.Text = "Name";
            // 
            // lbStudentPhoneNumber
            // 
            lbStudentPhoneNumber.AutoSize = true;
            lbStudentPhoneNumber.Location = new Point(130, 44);
            lbStudentPhoneNumber.Name = "lbStudentPhoneNumber";
            lbStudentPhoneNumber.Size = new Size(88, 15);
            lbStudentPhoneNumber.TabIndex = 4;
            lbStudentPhoneNumber.Text = "Phone Number";
            // 
            // lbStudentEmail
            // 
            lbStudentEmail.AutoSize = true;
            lbStudentEmail.Location = new Point(130, 71);
            lbStudentEmail.Name = "lbStudentEmail";
            lbStudentEmail.Size = new Size(36, 15);
            lbStudentEmail.TabIndex = 5;
            lbStudentEmail.Text = "Email";
            // 
            // lbStudentBirthDate
            // 
            lbStudentBirthDate.AutoSize = true;
            lbStudentBirthDate.Location = new Point(130, 99);
            lbStudentBirthDate.Name = "lbStudentBirthDate";
            lbStudentBirthDate.Size = new Size(59, 15);
            lbStudentBirthDate.TabIndex = 6;
            lbStudentBirthDate.Text = "Birth Date";
            // 
            // tbName
            // 
            tbName.Location = new Point(224, 15);
            tbName.Name = "tbName";
            tbName.Size = new Size(236, 23);
            tbName.TabIndex = 7;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(224, 41);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(236, 23);
            tbPhoneNumber.TabIndex = 8;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(224, 67);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(236, 23);
            tbEmail.TabIndex = 9;
            // 
            // tbBirth
            // 
            tbBirth.Location = new Point(224, 91);
            tbBirth.Name = "tbBirth";
            tbBirth.Size = new Size(236, 23);
            tbBirth.TabIndex = 10;
            // 
            // ListStudents
            // 
            ListStudents.FormattingEnabled = true;
            ListStudents.ItemHeight = 15;
            ListStudents.Location = new Point(12, 147);
            ListStudents.Name = "ListStudents";
            ListStudents.Size = new Size(206, 229);
            ListStudents.TabIndex = 11;
            ListStudents.SelectedIndexChanged += ListStudents_SelectedIndexChanged;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListStudents);
            Controls.Add(tbBirth);
            Controls.Add(tbEmail);
            Controls.Add(tbPhoneNumber);
            Controls.Add(tbName);
            Controls.Add(lbStudentBirthDate);
            Controls.Add(lbStudentEmail);
            Controls.Add(lbStudentPhoneNumber);
            Controls.Add(lbStudentName);
            Controls.Add(btStudentUpdate);
            Controls.Add(btDeleteStudent);
            Controls.Add(btAddStudent);
            Name = "Students";
            Text = "Students";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAddStudent;
        private Button btDeleteStudent;
        private Button btStudentUpdate;
        private Label lbStudentName;
        private Label lbStudentPhoneNumber;
        private Label lbStudentEmail;
        private Label lbStudentBirthDate;
        private TextBox tbName;
        private TextBox tbPhoneNumber;
        private TextBox tbEmail;
        private TextBox tbBirth;
        private ListBox ListStudents;
    }
}