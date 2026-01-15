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
            btBack = new Button();
            SuspendLayout();
            // 
            // btAddStudent
            // 
            btAddStudent.BackColor = Color.FromArgb(0, 192, 0);
            btAddStudent.FlatStyle = FlatStyle.Flat;
            btAddStudent.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btAddStudent.Location = new Point(500, 29);
            btAddStudent.Name = "btAddStudent";
            btAddStudent.Size = new Size(112, 43);
            btAddStudent.TabIndex = 0;
            btAddStudent.Text = "Add Student";
            btAddStudent.UseVisualStyleBackColor = false;
            btAddStudent.Click += btAddStudent_Click;
            // 
            // btDeleteStudent
            // 
            btDeleteStudent.BackColor = Color.Red;
            btDeleteStudent.FlatStyle = FlatStyle.Flat;
            btDeleteStudent.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btDeleteStudent.Location = new Point(618, 156);
            btDeleteStudent.Name = "btDeleteStudent";
            btDeleteStudent.Size = new Size(114, 47);
            btDeleteStudent.TabIndex = 1;
            btDeleteStudent.Text = "Delete Student";
            btDeleteStudent.UseVisualStyleBackColor = false;
            btDeleteStudent.Click += btDeleteStudent_Click;
            // 
            // btStudentUpdate
            // 
            btStudentUpdate.BackColor = Color.Yellow;
            btStudentUpdate.FlatStyle = FlatStyle.Flat;
            btStudentUpdate.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btStudentUpdate.Location = new Point(500, 78);
            btStudentUpdate.Name = "btStudentUpdate";
            btStudentUpdate.Size = new Size(112, 43);
            btStudentUpdate.TabIndex = 2;
            btStudentUpdate.Text = "Update Student Info";
            btStudentUpdate.UseVisualStyleBackColor = false;
            btStudentUpdate.Click += btStudentUpdate_Click;
            // 
            // lbStudentName
            // 
            lbStudentName.AutoSize = true;
            lbStudentName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbStudentName.Location = new Point(188, 21);
            lbStudentName.Name = "lbStudentName";
            lbStudentName.Size = new Size(53, 22);
            lbStudentName.TabIndex = 3;
            lbStudentName.Text = "Name";
            // 
            // lbStudentPhoneNumber
            // 
            lbStudentPhoneNumber.AutoSize = true;
            lbStudentPhoneNumber.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbStudentPhoneNumber.Location = new Point(121, 50);
            lbStudentPhoneNumber.Name = "lbStudentPhoneNumber";
            lbStudentPhoneNumber.Size = new Size(120, 22);
            lbStudentPhoneNumber.TabIndex = 4;
            lbStudentPhoneNumber.Text = "Phone Number";
            // 
            // lbStudentEmail
            // 
            lbStudentEmail.AutoSize = true;
            lbStudentEmail.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbStudentEmail.Location = new Point(190, 77);
            lbStudentEmail.Name = "lbStudentEmail";
            lbStudentEmail.Size = new Size(51, 22);
            lbStudentEmail.TabIndex = 5;
            lbStudentEmail.Text = "Email";
            // 
            // lbStudentBirthDate
            // 
            lbStudentBirthDate.AutoSize = true;
            lbStudentBirthDate.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbStudentBirthDate.Location = new Point(155, 105);
            lbStudentBirthDate.Name = "lbStudentBirthDate";
            lbStudentBirthDate.Size = new Size(86, 22);
            lbStudentBirthDate.TabIndex = 6;
            lbStudentBirthDate.Text = "Birth Date";
            // 
            // tbName
            // 
            tbName.Location = new Point(247, 20);
            tbName.Name = "tbName";
            tbName.Size = new Size(236, 23);
            tbName.TabIndex = 7;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(247, 49);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(236, 23);
            tbPhoneNumber.TabIndex = 8;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(247, 76);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(236, 23);
            tbEmail.TabIndex = 9;
            // 
            // tbBirth
            // 
            tbBirth.Location = new Point(247, 104);
            tbBirth.Name = "tbBirth";
            tbBirth.Size = new Size(236, 23);
            tbBirth.TabIndex = 10;
            // 
            // ListStudents
            // 
            ListStudents.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            ListStudents.FormattingEnabled = true;
            ListStudents.ItemHeight = 22;
            ListStudents.Location = new Point(121, 156);
            ListStudents.Name = "ListStudents";
            ListStudents.Size = new Size(491, 246);
            ListStudents.TabIndex = 11;
            ListStudents.SelectedIndexChanged += ListStudents_SelectedIndexChanged;
            // 
            // btBack
            // 
            btBack.BackColor = Color.FromArgb(224, 224, 224);
            btBack.FlatStyle = FlatStyle.Flat;
            btBack.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btBack.Location = new Point(669, 384);
            btBack.Name = "btBack";
            btBack.Size = new Size(93, 41);
            btBack.TabIndex = 12;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = false;
            btBack.Click += btBack_Click;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btBack);
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
        private Button btBack;
    }
}