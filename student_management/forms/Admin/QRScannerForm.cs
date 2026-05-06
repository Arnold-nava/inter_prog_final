using AForge.Video;
using AForge.Video.DirectShow;
using crud;
using MySql.Data.MySqlClient;
using student_management.forms.Auth;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Windows.Compatibility;
using student_management.Helpers;

namespace student_management.forms.Admin
{
    public partial class QRScannerForm : Form
    {
        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice FinalFrame;

        private int currentAttendanceId = 0;
        private bool isProcessing = false;

        public QRScannerForm()
        {
            InitializeComponent();
        }

        private void QRScannerForm_Load(object sender, EventArgs e)
        {
            ResetUI();

            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            comboBox1.Items.Clear();

            foreach (FilterInfo Device in CaptureDevices)
                comboBox1.Items.Add(Device.Name);

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            else
                MessageBox.Show("No camera found.");

            timer1.Interval = 500;
            timer1.Stop();

            FinalFrame = new VideoCaptureDevice();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Select camera first.");
                return;
            }

            ResetUI();

            if (FinalFrame != null && FinalFrame.IsRunning)
            {
                isProcessing = false;
                timer1.Stop();
                timer1.Start();
                return;
            }

            FinalFrame = new VideoCaptureDevice(CaptureDevices[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += FinalFrame_NewFrame;
            FinalFrame.Start();

            isProcessing = false;
            timer1.Stop();
            timer1.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            this.Invoke(new MethodInvoker(delegate
            {
                picCamera.Image = bitmap;
            }));
        }

        private void StopCamera()
        {
            timer1.Stop();

            if (FinalFrame != null && FinalFrame.IsRunning)
            {
                FinalFrame.SignalToStop();
                FinalFrame.WaitForStop();
            }
        }

        private void ResetUI()
        {
            lblClassInfo.Text = "Class: -";
            lblSubject.Text = "Subject: -";
            lblStudentName.Text = "Waiting for scan...";
            lblStudentNo.Text = "Student No: -";
            lblTimeIn.Text = "Time In: -";
            lblTimeOut.Text = "Time Out: -";
            lblStatus.Text = "Status: Ready";

            btnTimeOut.Enabled = false;
            currentAttendanceId = 0;
            isProcessing = false;
        }

        private void ShowStudentInfo(string name, string studentNo, string timeIn, string timeOut, string status)
        {
            lblStudentName.Text = name;
            lblStudentNo.Text = "Student No: " + studentNo;
            lblTimeIn.Text = "Time In: " + timeIn;
            lblTimeOut.Text = "Time Out: " + timeOut;
            lblStatus.Text = "Status: " + status;
        }

        private void ShowClassInfo(int studentDbId)
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT c.class_name
                    FROM students s
                    INNER JOIN classes c ON s.class_id = c.id
                    WHERE s.id = @studentId";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@studentId", studentDbId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblClassInfo.Text = "Class: " + reader["class_name"].ToString();
                    lblSubject.Text = "Subject: Attendance";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Class info error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void SaveAttendance(string qrValue)
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                qrValue = qrValue.Trim();

                string studentQuery = @"
                    SELECT id, full_name, student_id
                    FROM students
                    WHERE student_id = @qr
                    AND status = 'active'";

                MySqlCommand studentCmd = new MySqlCommand(studentQuery, db.Connection);
                studentCmd.Parameters.AddWithValue("@qr", qrValue);

                MySqlDataReader studentReader = studentCmd.ExecuteReader();

                if (!studentReader.Read())
                {
                    studentReader.Close();
                    ShowStudentInfo("Not Found", "-", "-", "-", "Invalid QR");
                    return;
                }

                int studentDbId = Convert.ToInt32(studentReader["id"]);
                string studentName = studentReader["full_name"].ToString();
                string studentNo = studentReader["student_id"].ToString();

                studentReader.Close();

                ShowClassInfo(studentDbId);

                string checkQuery = @"
                    SELECT id, time_in, time_out
                    FROM attendance
                    WHERE student_id = @studentId
                    AND attendance_date = CURDATE()
                    ORDER BY id DESC
                    LIMIT 1";

                MySqlCommand checkCmd = new MySqlCommand(checkQuery, db.Connection);
                checkCmd.Parameters.AddWithValue("@studentId", studentDbId);

                MySqlDataReader checkReader = checkCmd.ExecuteReader();

                if (!checkReader.Read())
                {
                    checkReader.Close();

                    string insertQuery = @"
                        INSERT INTO attendance
                        (student_id, teacher_id, subject_id, class_id, attendance_date, time_in, status)
                        VALUES
                        (@studentId, 1, 1, 1, CURDATE(), CURTIME(), 'Present')";

                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, db.Connection);
                    insertCmd.Parameters.AddWithValue("@studentId", studentDbId);

                    insertCmd.ExecuteNonQuery();

                    currentAttendanceId = (int)insertCmd.LastInsertedId;
                    btnTimeOut.Enabled = true;

                    ShowStudentInfo(
                        studentName,
                        studentNo,
                        DateTime.Now.ToString("hh:mm tt"),
                        "-",
                        "Timed In"
                    );
                }
                else
                {
                    int attendanceId = Convert.ToInt32(checkReader["id"]);
                    string timeIn = checkReader["time_in"].ToString();
                    object timeOut = checkReader["time_out"];

                    checkReader.Close();

                    currentAttendanceId = attendanceId;

                    if (timeOut == DBNull.Value || timeOut.ToString() == "")
                    {
                        btnTimeOut.Enabled = true;
                        ShowStudentInfo(studentName, studentNo, timeIn, "-", "Already Timed In");
                    }
                    else
                    {
                        btnTimeOut.Enabled = false;
                        currentAttendanceId = 0;
                        ShowStudentInfo(studentName, studentNo, timeIn, timeOut.ToString(), "Completed Today");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Attendance Error: " + ex.Message);
            }
            finally
            {
                db.Close();
                isProcessing = false;
            }
        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            if (currentAttendanceId == 0)
            {
                MessageBox.Show("No active student selected. Scan student first.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string updateQuery = @"
                    UPDATE attendance
                    SET time_out = CURTIME()
                    WHERE id = @attendanceId
                    AND time_out IS NULL";

                MySqlCommand cmd = new MySqlCommand(updateQuery, db.Connection);
                cmd.Parameters.AddWithValue("@attendanceId", currentAttendanceId);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    lblTimeOut.Text = "Time Out: " + DateTime.Now.ToString("hh:mm tt");
                    lblStatus.Text = "Status: Timed Out";

                    btnTimeOut.Enabled = false;
                    currentAttendanceId = 0;
                    isProcessing = false;

                    MessageBox.Show("Time Out saved. Click Play for next student.");
                }
                else
                {
                    lblStatus.Text = "Status: Already Timed Out";
                    btnTimeOut.Enabled = false;
                    currentAttendanceId = 0;
                    isProcessing = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Time Out Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isProcessing) return;
            if (picCamera.Image == null) return;

            try
            {
                BarcodeReader reader = new BarcodeReader();

                Bitmap bitmap = new Bitmap(picCamera.Image);
                Result result = reader.Decode(bitmap);
                bitmap.Dispose();

                if (result != null)
                {
                    isProcessing = true;
                    timer1.Stop();

                    string qrValue = result.Text.Trim();

                    SaveAttendance(qrValue);

                    // Scanner stops here.
                    // Click Time Out, then click Play again for next student.
                }
            }
            catch
            {
                isProcessing = false;
                timer1.Start();
            }
        }

        private void QRScannerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        private void btnDaashboard_Click(object sender, EventArgs e)
        {
            TeacherDashBoard frm = new TeacherDashBoard();
            frm.Show();
            this.Hide();
        }

        private void btnScanner_Click(object sender, EventArgs e)
        {
            QRScannerForm frm = new QRScannerForm();
            frm.Show();
            this.Hide();
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            StudentManagementForm frm = new StudentManagementForm();
            frm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Session.Clear();
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void btnAttendanceRecords_Click_1(object sender, EventArgs e)
        {
            AttendanceHistoryForm frm = new AttendanceHistoryForm();
            frm.Show();
            this.Hide();
        }
    }
}