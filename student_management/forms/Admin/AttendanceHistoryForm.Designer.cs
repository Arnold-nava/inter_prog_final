namespace student_management.forms.Admin
{
    partial class AttendanceHistoryForm
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
            panel2 = new Panel();
            dtpDate = new DateTimePicker();
            cmbClass = new ComboBox();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvAttendance = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
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
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 466);
            panel1.TabIndex = 2;
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
            // panel2
            // 
            panel2.Controls.Add(dtpDate);
            panel2.Controls.Add(cmbClass);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(186, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 79);
            panel2.TabIndex = 3;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDate.Location = new Point(348, 28);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(152, 29);
            dtpDate.TabIndex = 8;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // cmbClass
            // 
            cmbClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(190, 28);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(152, 29);
            cmbClass.TabIndex = 7;
            cmbClass.SelectedIndexChanged += cmbClass_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DodgerBlue;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(552, 27);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 30);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(15, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(169, 29);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(348, 8);
            label4.Name = "label4";
            label4.Size = new Size(37, 17);
            label4.TabIndex = 4;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(190, 8);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 4;
            label3.Text = "Class";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 8);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 4;
            label2.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 4;
            label1.Text = "Attendance Record";
            // 
            // dgvAttendance
            // 
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(187, 147);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.Size = new Size(662, 311);
            dgvAttendance.TabIndex = 5;
            // 
            // AttendanceHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 465);
            Controls.Add(dgvAttendance);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AttendanceHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AttendanceHistoryForm";
            Load += AttendanceHistoryForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
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
        private Panel panel2;
        private Button btnRefresh;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtSearch;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpDate;
        private ComboBox cmbClass;
        private DataGridView dgvAttendance;
    }
}