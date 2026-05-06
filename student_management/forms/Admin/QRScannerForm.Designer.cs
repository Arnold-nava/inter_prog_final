namespace student_management.forms.Admin
{
    partial class QRScannerForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            button1 = new Button();
            btnAttendanceRecords = new FontAwesome.Sharp.IconButton();
            btnStudentManagement = new FontAwesome.Sharp.IconButton();
            btnScanner = new FontAwesome.Sharp.IconButton();
            btnDaashboard = new FontAwesome.Sharp.IconButton();
            btnPlay = new Button();
            btnTimeOut = new Button();
            picCamera = new PictureBox();
            panel2 = new Panel();
            lblStatus = new Label();
            lblSubject = new Label();
            lblClassInfo = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblStudentName = new Label();
            lblStudentNo = new Label();
            panel3 = new Panel();
            lblTimeOut = new Label();
            lblTimeIn = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCamera).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Size = new Size(176, 561);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 516);
            button1.Name = "button1";
            button1.Size = new Size(107, 26);
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
            btnStudentManagement.Location = new Point(16, 118);
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
            // btnPlay
            // 
            btnPlay.BackColor = SystemColors.Control;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(321, 496);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(182, 44);
            btnPlay.TabIndex = 9;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnTimeOut
            // 
            btnTimeOut.BackColor = Color.Firebrick;
            btnTimeOut.FlatStyle = FlatStyle.Flat;
            btnTimeOut.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimeOut.Location = new Point(524, 496);
            btnTimeOut.Name = "btnTimeOut";
            btnTimeOut.Size = new Size(172, 44);
            btnTimeOut.TabIndex = 10;
            btnTimeOut.Text = "Time Out";
            btnTimeOut.UseVisualStyleBackColor = false;
            btnTimeOut.Click += btnTimeOut_Click;
            // 
            // picCamera
            // 
            picCamera.BackColor = Color.Black;
            picCamera.Location = new Point(320, 116);
            picCamera.Name = "picCamera";
            picCamera.Size = new Size(376, 292);
            picCamera.TabIndex = 8;
            picCamera.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(lblSubject);
            panel2.Controls.Add(lblClassInfo);
            panel2.Location = new Point(321, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 67);
            panel2.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(17, 45);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 17);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "label1";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(17, 25);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(45, 17);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "label1";
            // 
            // lblClassInfo
            // 
            lblClassInfo.AutoSize = true;
            lblClassInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassInfo.Location = new Point(17, 4);
            lblClassInfo.Name = "lblClassInfo";
            lblClassInfo.Size = new Size(57, 21);
            lblClassInfo.TabIndex = 0;
            lblClassInfo.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 14);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Camera";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(559, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 23);
            comboBox1.TabIndex = 12;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(17, 12);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(57, 21);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "label1";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentNo.Location = new Point(17, 33);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(45, 17);
            lblStudentNo.TabIndex = 0;
            lblStudentNo.Text = "label1";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTimeOut);
            panel3.Controls.Add(lblTimeIn);
            panel3.Controls.Add(lblStudentNo);
            panel3.Controls.Add(lblStudentName);
            panel3.Location = new Point(320, 414);
            panel3.Name = "panel3";
            panel3.Size = new Size(375, 67);
            panel3.TabIndex = 6;
            // 
            // lblTimeOut
            // 
            lblTimeOut.AutoSize = true;
            lblTimeOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeOut.Location = new Point(239, 33);
            lblTimeOut.Name = "lblTimeOut";
            lblTimeOut.Size = new Size(45, 17);
            lblTimeOut.TabIndex = 0;
            lblTimeOut.Text = "label1";
            // 
            // lblTimeIn
            // 
            lblTimeIn.AutoSize = true;
            lblTimeIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeIn.Location = new Point(239, 16);
            lblTimeIn.Name = "lblTimeIn";
            lblTimeIn.Size = new Size(45, 17);
            lblTimeIn.TabIndex = 0;
            lblTimeIn.Text = "label1";
            // 
            // QRScannerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(comboBox1);
            Controls.Add(btnPlay);
            Controls.Add(btnTimeOut);
            Controls.Add(picCamera);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "QRScannerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QRScannerForm";
            Load += QRScannerForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCamera).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Button btnPlay;
        private Button btnTimeOut;
        private PictureBox picCamera;
        private Panel panel2;
        private Label lblStatus;
        private Label lblSubject;
        private Label lblClassInfo;
        private Label label1;
        private ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private Label lblStudentName;
        private Label lblStudentNo;
        private Panel panel3;
        private Label lblTimeIn;
        private Label lblTimeOut;
    }
}