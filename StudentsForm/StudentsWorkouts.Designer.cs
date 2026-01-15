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
            btBack = new Button();
            lbWorkouts = new Label();
            SuspendLayout();
            // 
            // cbStudentName
            // 
            cbStudentName.BackColor = SystemColors.ScrollBar;
            cbStudentName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudentName.FlatStyle = FlatStyle.Flat;
            cbStudentName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            cbStudentName.FormattingEnabled = true;
            cbStudentName.Location = new Point(364, 75);
            cbStudentName.Name = "cbStudentName";
            cbStudentName.Size = new Size(121, 30);
            cbStudentName.TabIndex = 27;
            cbStudentName.SelectedIndexChanged += lbStudentWorkouts_SelectedIndexChanged;
            // 
            // lbStudentName
            // 
            lbStudentName.AutoSize = true;
            lbStudentName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbStudentName.Location = new Point(244, 78);
            lbStudentName.Name = "lbStudentName";
            lbStudentName.Size = new Size(114, 22);
            lbStudentName.TabIndex = 26;
            lbStudentName.Text = "Student Name";
            lbStudentName.Click += lbStudentName_Click;
            // 
            // lbStudentWorkouts
            // 
            lbStudentWorkouts.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbStudentWorkouts.FormattingEnabled = true;
            lbStudentWorkouts.ItemHeight = 22;
            lbStudentWorkouts.Location = new Point(244, 171);
            lbStudentWorkouts.Name = "lbStudentWorkouts";
            lbStudentWorkouts.Size = new Size(233, 224);
            lbStudentWorkouts.TabIndex = 28;
            lbStudentWorkouts.SelectedIndexChanged += lbStudentWorkouts_SelectedIndexChanged;
            // 
            // btBack
            // 
            btBack.FlatStyle = FlatStyle.Flat;
            btBack.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btBack.Location = new Point(683, 394);
            btBack.Name = "btBack";
            btBack.Size = new Size(75, 32);
            btBack.TabIndex = 29;
            btBack.Text = "Back";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // lbWorkouts
            // 
            lbWorkouts.AutoSize = true;
            lbWorkouts.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lbWorkouts.Location = new Point(244, 146);
            lbWorkouts.Name = "lbWorkouts";
            lbWorkouts.Size = new Size(82, 22);
            lbWorkouts.TabIndex = 30;
            lbWorkouts.Text = "Workouts";
            // 
            // StudentsWorkouts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lbWorkouts);
            Controls.Add(btBack);
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
        private Button btBack;
        private Label lbWorkouts;
    }
}