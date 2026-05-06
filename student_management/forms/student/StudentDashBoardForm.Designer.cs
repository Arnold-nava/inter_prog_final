namespace student_management.forms.student
{
    partial class StudentDashBoardForm
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
            panelSidebar = new Panel();
            label1 = new Label();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnProfile = new FontAwesome.Sharp.IconButton();
            btnAttendance = new FontAwesome.Sharp.IconButton();
            btnMyQR = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            lblWelcome = new Label();
            panelTodayStatus = new Panel();
            iconStatus = new FontAwesome.Sharp.IconPictureBox();
            lblTimeOut = new Label();
            lblTimeIn = new Label();
            lblStatus = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            lblTotalPresent = new Label();
            lblTotalAbsent = new Label();
            lblTotalLate = new Label();
            dgvSchedule = new DataGridView();
            label3 = new Label();
            panelSidebar.SuspendLayout();
            panelTodayStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatus).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(192, 255, 192);
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnProfile);
            panelSidebar.Controls.Add(btnAttendance);
            panelSidebar.Controls.Add(btnMyQR);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.ForeColor = Color.Black;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 450);
            panelSidebar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 37);
            label1.TabIndex = 1;
            label1.Text = "STUDENT";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 192, 192);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.Red;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnLogout.IconColor = Color.Red;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(12, 396);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(0, 2, 0, 0);
            btnLogout.Size = new Size(165, 42);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleRight;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(192, 255, 192);
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnProfile.ForeColor = Color.Black;
            btnProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            btnProfile.IconColor = Color.Black;
            btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(12, 241);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(165, 50);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profile";
            btnProfile.TextAlign = ContentAlignment.MiddleRight;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.FromArgb(192, 255, 192);
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAttendance.ForeColor = Color.Black;
            btnAttendance.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            btnAttendance.IconColor = Color.Black;
            btnAttendance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(12, 183);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(165, 52);
            btnAttendance.TabIndex = 0;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleRight;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnMyQR
            // 
            btnMyQR.BackColor = Color.FromArgb(192, 255, 192);
            btnMyQR.FlatAppearance.BorderSize = 0;
            btnMyQR.FlatStyle = FlatStyle.Flat;
            btnMyQR.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMyQR.ForeColor = Color.Black;
            btnMyQR.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            btnMyQR.IconColor = Color.Black;
            btnMyQR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMyQR.ImageAlign = ContentAlignment.MiddleLeft;
            btnMyQR.Location = new Point(12, 126);
            btnMyQR.Name = "btnMyQR";
            btnMyQR.Size = new Size(165, 51);
            btnMyQR.TabIndex = 0;
            btnMyQR.Text = "QR code";
            btnMyQR.TextAlign = ContentAlignment.MiddleRight;
            btnMyQR.UseVisualStyleBackColor = false;
            btnMyQR.Click += btnMyQR_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(128, 255, 128);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.Green;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            btnDashboard.IconColor = Color.Green;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(12, 69);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(165, 51);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleRight;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(22, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(138, 21);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Guest!";
            // 
            // panelTodayStatus
            // 
            panelTodayStatus.Controls.Add(iconStatus);
            panelTodayStatus.Controls.Add(lblTimeOut);
            panelTodayStatus.Controls.Add(lblTimeIn);
            panelTodayStatus.Controls.Add(lblStatus);
            panelTodayStatus.Controls.Add(label2);
            panelTodayStatus.Location = new Point(17, 43);
            panelTodayStatus.Name = "panelTodayStatus";
            panelTodayStatus.Size = new Size(320, 134);
            panelTodayStatus.TabIndex = 1;
            // 
            // iconStatus
            // 
            iconStatus.BackColor = SystemColors.Control;
            iconStatus.ForeColor = SystemColors.ControlText;
            iconStatus.IconChar = FontAwesome.Sharp.IconChar.None;
            iconStatus.IconColor = SystemColors.ControlText;
            iconStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconStatus.IconSize = 80;
            iconStatus.Location = new Point(203, 26);
            iconStatus.Name = "iconStatus";
            iconStatus.Size = new Size(80, 80);
            iconStatus.TabIndex = 14;
            iconStatus.TabStop = false;
            // 
            // lblTimeOut
            // 
            lblTimeOut.AutoSize = true;
            lblTimeOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeOut.Location = new Point(14, 86);
            lblTimeOut.Name = "lblTimeOut";
            lblTimeOut.Size = new Size(86, 21);
            lblTimeOut.TabIndex = 0;
            lblTimeOut.Text = "Time out :";
            // 
            // lblTimeIn
            // 
            lblTimeIn.AutoSize = true;
            lblTimeIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeIn.Location = new Point(14, 65);
            lblTimeIn.Name = "lblTimeIn";
            lblTimeIn.Size = new Size(75, 21);
            lblTimeIn.TabIndex = 0;
            lblTimeIn.Text = "Time In :";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(14, 35);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(94, 30);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Pending";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 14);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 0;
            label2.Text = "Today's Status";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dgvSchedule);
            panel1.Controls.Add(panelTodayStatus);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 450);
            panel1.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTotalPresent);
            panel3.Controls.Add(lblTotalAbsent);
            panel3.Controls.Add(lblTotalLate);
            panel3.Location = new Point(17, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(320, 75);
            panel3.TabIndex = 3;
            // 
            // lblTotalPresent
            // 
            lblTotalPresent.AutoSize = true;
            lblTotalPresent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPresent.Location = new Point(3, 6);
            lblTotalPresent.Name = "lblTotalPresent";
            lblTotalPresent.Size = new Size(117, 21);
            lblTotalPresent.TabIndex = 0;
            lblTotalPresent.Text = "TotalPresent : ";
            // 
            // lblTotalAbsent
            // 
            lblTotalAbsent.AutoSize = true;
            lblTotalAbsent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAbsent.Location = new Point(3, 27);
            lblTotalAbsent.Name = "lblTotalAbsent";
            lblTotalAbsent.Size = new Size(113, 21);
            lblTotalAbsent.TabIndex = 0;
            lblTotalAbsent.Text = "TotalAbsent : ";
            // 
            // lblTotalLate
            // 
            lblTotalLate.AutoSize = true;
            lblTotalLate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalLate.Location = new Point(3, 48);
            lblTotalLate.Name = "lblTotalLate";
            lblTotalLate.Size = new Size(92, 21);
            lblTotalLate.TabIndex = 0;
            lblTotalLate.Text = "TotalLate : ";
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(17, 292);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.Size = new Size(654, 146);
            dgvSchedule.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 268);
            label3.Name = "label3";
            label3.Size = new Size(192, 21);
            label3.TabIndex = 0;
            label3.Text = "Today's Class Schedule";
            // 
            // StudentDashBoardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(panel1);
            Controls.Add(panelSidebar);
            Name = "StudentDashBoardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentDashBoardForm";
            Load += StudentDashBoardForm_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelTodayStatus.ResumeLayout(false);
            panelTodayStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconStatus).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnAttendance;
        private FontAwesome.Sharp.IconButton btnMyQR;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private Label lblWelcome;
        private Panel panelTodayStatus;
        private Label lblTimeOut;
        private Label lblTimeIn;
        private Label lblStatus;
        private Label label2;
        private Panel panel1;
        private Label lblTotalPresent;
        private Label lblTotalAbsent;
        private Panel panel3;
        private Label lblTotalLate;
        private DataGridView dgvSchedule;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconStatus;
    }
}