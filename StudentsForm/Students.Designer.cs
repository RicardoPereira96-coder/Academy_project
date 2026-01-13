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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
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
            // 
            // btDeleteStudent
            // 
            btDeleteStudent.Location = new Point(224, 147);
            btDeleteStudent.Name = "btDeleteStudent";
            btDeleteStudent.Size = new Size(112, 43);
            btDeleteStudent.TabIndex = 1;
            btDeleteStudent.Text = "Delete Student";
            btDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // btStudentUpdate
            // 
            btStudentUpdate.Location = new Point(12, 62);
            btStudentUpdate.Name = "btStudentUpdate";
            btStudentUpdate.Size = new Size(112, 43);
            btStudentUpdate.TabIndex = 2;
            btStudentUpdate.Text = "Update Student Info";
            btStudentUpdate.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(224, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(224, 91);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 23);
            textBox4.TabIndex = 10;
            // 
            // ListStudents
            // 
            ListStudents.FormattingEnabled = true;
            ListStudents.ItemHeight = 15;
            ListStudents.Location = new Point(12, 147);
            ListStudents.Name = "ListStudents";
            ListStudents.Size = new Size(206, 229);
            ListStudents.TabIndex = 11;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListStudents);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ListBox ListStudents;
    }
}