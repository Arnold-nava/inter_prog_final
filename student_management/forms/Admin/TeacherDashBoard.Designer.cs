namespace student_management.forms.Admin
{
    partial class TeacherDashBoard
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
            panel1 = new Panel();
            button1 = new Button();
            btnAttendanceRecords = new FontAwesome.Sharp.IconButton();
            btnStudentManagement = new FontAwesome.Sharp.IconButton();
            btnScanner = new FontAwesome.Sharp.IconButton();
            btnDaashboard = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            pnlTodayClasses = new Panel();
            lblClass = new Label();
            lblTodayClassesTitle = new Label();
            panel3 = new Panel();
            lblStudents = new Label();
            label4 = new Label();
            panel4 = new Panel();
            lblAttendance = new Label();
            label3 = new Label();
            lblTeacherName = new Label();
            flowClasses = new FlowLayoutPanel();
            label2 = new Label();
            panel1.SuspendLayout();
            pnlTodayClasses.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAttendanceRecords);
            panel1.Controls.Add(btnStudentManagement);
            panel1.Controls.Add(btnScanner);
            panel1.Controls.Add(btnDaashboard);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 466);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 418);
            button1.Name = "button1";
            button1.Size = new Size(107, 36);
            button1.TabIndex = 1;
            button1.Text = "LogOut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAttendanceRecords
            // 
            btnAttendanceRecords.FlatAppearance.BorderSize = 0;
            btnAttendanceRecords.FlatStyle = FlatStyle.Flat;
            btnAttendanceRecords.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttendanceRecords.IconChar = FontAwesome.Sharp.IconChar.HouseCircleCheck;
            btnAttendanceRecords.IconColor = Color.Black;
            btnAttendanceRecords.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAttendanceRecords.IconSize = 32;
            btnAttendanceRecords.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendanceRecords.Location = new Point(12, 165);
            btnAttendanceRecords.Name = "btnAttendanceRecords";
            btnAttendanceRecords.Size = new Size(160, 44);
            btnAttendanceRecords.TabIndex = 0;
            btnAttendanceRecords.Text = "attendance record";
            btnAttendanceRecords.TextAlign = ContentAlignment.MiddleRight;
            btnAttendanceRecords.UseVisualStyleBackColor = true;
            btnAttendanceRecords.Click += btnAttendanceRecords_Click;
            // 
            // btnStudentManagement
            // 
            btnStudentManagement.FlatAppearance.BorderSize = 0;
            btnStudentManagement.FlatStyle = FlatStyle.Flat;
            btnStudentManagement.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentManagement.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnStudentManagement.IconColor = Color.Black;
            btnStudentManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStudentManagement.IconSize = 32;
            btnStudentManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudentManagement.Location = new Point(12, 115);
            btnStudentManagement.Name = "btnStudentManagement";
            btnStudentManagement.Size = new Size(160, 44);
            btnStudentManagement.TabIndex = 0;
            btnStudentManagement.Text = "Manage Students";
            btnStudentManagement.TextAlign = ContentAlignment.MiddleRight;
            btnStudentManagement.UseVisualStyleBackColor = true;
            btnStudentManagement.Click += btnStudentManagement_Click;
            // 
            // btnScanner
            // 
            btnScanner.FlatAppearance.BorderSize = 0;
            btnScanner.FlatStyle = FlatStyle.Flat;
            btnScanner.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScanner.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            btnScanner.IconColor = Color.Black;
            btnScanner.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnScanner.IconSize = 32;
            btnScanner.ImageAlign = ContentAlignment.MiddleLeft;
            btnScanner.Location = new Point(12, 65);
            btnScanner.Name = "btnScanner";
            btnScanner.Size = new Size(107, 44);
            btnScanner.TabIndex = 0;
            btnScanner.Text = "Scanner";
            btnScanner.TextAlign = ContentAlignment.MiddleRight;
            btnScanner.UseVisualStyleBackColor = true;
            btnScanner.Click += btnScanner_Click;
            // 
            // btnDaashboard
            // 
            btnDaashboard.FlatAppearance.BorderSize = 0;
            btnDaashboard.FlatStyle = FlatStyle.Flat;
            btnDaashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDaashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            btnDaashboard.IconColor = Color.Black;
            btnDaashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDaashboard.IconSize = 32;
            btnDaashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDaashboard.Location = new Point(12, 15);
            btnDaashboard.Name = "btnDaashboard";
            btnDaashboard.Size = new Size(120, 44);
            btnDaashboard.TabIndex = 0;
            btnDaashboard.Text = "Dashboard";
            btnDaashboard.TextAlign = ContentAlignment.MiddleRight;
            btnDaashboard.UseVisualStyleBackColor = true;
            btnDaashboard.Click += btnDaashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            // 
            // pnlTodayClasses
            // 
            pnlTodayClasses.Controls.Add(lblClass);
            pnlTodayClasses.Controls.Add(lblTodayClassesTitle);
            pnlTodayClasses.Location = new Point(205, 83);
            pnlTodayClasses.Name = "pnlTodayClasses";
            pnlTodayClasses.Size = new Size(162, 142);
            pnlTodayClasses.TabIndex = 2;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClass.Location = new Point(45, 19);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(74, 86);
            lblClass.TabIndex = 0;
            lblClass.Text = "0";
            // 
            // lblTodayClassesTitle
            // 
            lblTodayClassesTitle.AutoSize = true;
            lblTodayClassesTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayClassesTitle.Location = new Point(19, 105);
            lblTodayClassesTitle.Name = "lblTodayClassesTitle";
            lblTodayClassesTitle.Size = new Size(126, 25);
            lblTodayClassesTitle.TabIndex = 1;
            lblTodayClassesTitle.Text = "Today's Class";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblStudents);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(411, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(162, 142);
            panel3.TabIndex = 2;
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudents.Location = new Point(42, 19);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(74, 86);
            lblStudents.TabIndex = 0;
            lblStudents.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 105);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 1;
            label4.Text = "Students";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblAttendance);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(607, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(162, 142);
            panel4.TabIndex = 2;
            // 
            // lblAttendance
            // 
            lblAttendance.AutoSize = true;
            lblAttendance.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAttendance.Location = new Point(44, 19);
            lblAttendance.Name = "lblAttendance";
            lblAttendance.Size = new Size(74, 86);
            lblAttendance.TabIndex = 2;
            lblAttendance.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 111);
            label3.Name = "label3";
            label3.Size = new Size(128, 17);
            label3.TabIndex = 3;
            label3.Text = "Today's Attendance";
            // 
            // lblTeacherName
            // 
            lblTeacherName.AutoSize = true;
            lblTeacherName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeacherName.Location = new Point(182, 34);
            lblTeacherName.Name = "lblTeacherName";
            lblTeacherName.Size = new Size(160, 25);
            lblTeacherName.TabIndex = 1;
            lblTeacherName.Text = "Welcome, Guest!";
            // 
            // flowClasses
            // 
            flowClasses.Location = new Point(202, 294);
            flowClasses.Name = "flowClasses";
            flowClasses.Size = new Size(576, 139);
            flowClasses.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(182, 254);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 1;
            label2.Text = " Today's Classes";
            // 
            // TeacherDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(flowClasses);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pnlTodayClasses);
            Controls.Add(lblTeacherName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "TeacherDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherDashBoard";
            Load += TeacherDashBoard_Load;
            panel1.ResumeLayout(false);
            pnlTodayClasses.ResumeLayout(false);
            pnlTodayClasses.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnDaashboard;
        private Button button1;
        private FontAwesome.Sharp.IconButton btnAttendanceRecords;
        private FontAwesome.Sharp.IconButton btnStudentManagement;
        private FontAwesome.Sharp.IconButton btnScanner;
        private Label label1;
        private Panel pnlTodayClasses;
        private Panel panel3;
        private Panel panel4;
        private Label lblClass;
        private Label lblTodayClassesTitle;
        private Label lblStudents;
        private Label label4;
        private Label lblAttendance;
        private Label label3;
        private Label lblTeacherName;
        private FlowLayoutPanel flowClasses;
        private Label label2;
    }
}