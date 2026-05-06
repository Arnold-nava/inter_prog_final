namespace student_management.forms.Admin
{
    partial class StudentManagementForm
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
            panel2 = new Panel();
            cmbStatus = new ComboBox();
            cmbClass = new ComboBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            txtStudentId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dgvStudents = new DataGridView();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
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
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 498);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 446);
            button1.Name = "button1";
            button1.Size = new Size(107, 36);
            button1.TabIndex = 1;
            button1.Text = "LogOut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
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
            btnAttendanceRecords.Click += btnAttendanceRecords_Click_1;
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
            btnStudentManagement.Click += btnStudentManagement_Click_1;
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
            btnScanner.Click += btnScanner_Click_1;
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
            label1.Location = new Point(191, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 2;
            label1.Text = "Student Management";
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbStatus);
            panel2.Controls.Add(cmbClass);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtFullName);
            panel2.Controls.Add(txtStudentId);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(187, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(604, 231);
            panel2.TabIndex = 3;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "active\t", "inactive" });
            cmbStatus.Location = new Point(449, 92);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(142, 29);
            cmbStatus.TabIndex = 5;
            // 
            // cmbClass
            // 
            cmbClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(449, 41);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(142, 29);
            cmbClass.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(390, 187);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 27);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(286, 187);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 27);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(182, 187);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 27);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(78, 187);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 27);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(139, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(142, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(139, 92);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(142, 27);
            txtFullName.TabIndex = 3;
            // 
            // txtStudentId
            // 
            txtStudentId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStudentId.Location = new Point(138, 41);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(142, 27);
            txtStudentId.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(78, 142);
            label5.Name = "label5";
            label5.Size = new Size(50, 17);
            label5.TabIndex = 2;
            label5.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 97);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 2;
            label4.Text = "Full Name :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(345, 92);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 2;
            label7.Text = "Status :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(345, 47);
            label6.Name = "label6";
            label6.Size = new Size(47, 17);
            label6.TabIndex = 2;
            label6.Text = "Class :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 47);
            label3.Name = "label3";
            label3.Size = new Size(118, 17);
            label3.TabIndex = 2;
            label3.Text = "Student Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 15);
            label2.Name = "label2";
            label2.Size = new Size(166, 21);
            label2.TabIndex = 2;
            label2.Text = "Student Information";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvStudents);
            panel3.Controls.Add(txtSearch);
            panel3.Location = new Point(188, 302);
            panel3.Name = "panel3";
            panel3.Size = new Size(603, 178);
            panel3.TabIndex = 4;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(11, 51);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(586, 113);
            dgvStudents.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(389, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(201, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // StudentManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "StudentManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentManagementForm";
            Load += StudentManagementForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private FontAwesome.Sharp.IconButton btnAttendanceRecords;
        private FontAwesome.Sharp.IconButton btnStudentManagement;
        private FontAwesome.Sharp.IconButton btnScanner;
        private FontAwesome.Sharp.IconButton btnDaashboard;
        private Label label1;
        private Panel panel2;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private TextBox txtStudentId;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private ComboBox cmbStatus;
        private ComboBox cmbClass;
        private Panel panel3;
        private DataGridView dgvStudents;
        private TextBox txtSearch;
    }
}