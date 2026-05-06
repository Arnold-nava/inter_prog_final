using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using crud;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using student_management.Helpers;
using System.Drawing.Drawing2D;

namespace student_management.forms.student
{

    public partial class StudentDashBoardForm : Form
    {
        public StudentDashBoardForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RoundControl(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();
            control.Region = new Region(path);
        }

        private void StudentDashBoardForm_Load(object sender, EventArgs e)
        {
            SetupScheduleTable();
            LoadDashboard();
            RoundControl(panelSidebar, 25);

            RoundControl(btnDashboard, 15);
            RoundControl(btnMyQR, 15);
            RoundControl(btnAttendance, 15);
            RoundControl(btnProfile, 15);
            RoundControl(btnLogout, 15);


            LoadDashboard();
        }

        private void SetupScheduleTable()
        {
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.ReadOnly = true;
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.RowHeadersVisible = false;
            dgvSchedule.BackgroundColor = Color.White;
        }

        private void LoadDashboard()
        {
            LoadStudentInfo();
            LoadTodayAttendance();
            LoadAttendanceStats();
            LoadTodaySchedule();
        }

        private void ApplyStatusUI(string status)
        {
            if (status == "Present")
            {
                lblStatus.Text = "Present";
                lblStatus.ForeColor = Color.Green;

                iconStatus.IconChar = IconChar.CircleCheck;
                iconStatus.IconColor = Color.Green;

                panelTodayStatus.BackColor = Color.FromArgb(220, 255, 220);
            }
            else if (status == "Absent")
            {
                lblStatus.Text = "Absent";
                lblStatus.ForeColor = Color.Red;

                iconStatus.IconChar = IconChar.CircleXmark;
                iconStatus.IconColor = Color.Red;

                panelTodayStatus.BackColor = Color.FromArgb(255, 220, 220);
            }
            else if (status == "Late")
            {
                lblStatus.Text = "Late";
                lblStatus.ForeColor = Color.OrangeRed;

                iconStatus.IconChar = IconChar.Clock;
                iconStatus.IconColor = Color.OrangeRed;

                panelTodayStatus.BackColor = Color.FromArgb(255, 240, 210);
            }
            else
            {
                lblStatus.Text = "Pending";
                lblStatus.ForeColor = Color.Gray;

                iconStatus.IconChar = IconChar.HourglassHalf;
                iconStatus.IconColor = Color.Gray;

                panelTodayStatus.BackColor = Color.White;
            }
        }

        private void LoadStudentInfo()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT full_name FROM students WHERE user_id=@userId";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@userId", Session.userId);

                object result = cmd.ExecuteScalar();

                if (result != null)
                    lblWelcome.Text = "Welcome, " + result.ToString() + "!";
                else
                    lblWelcome.Text = "Welcome, Student!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student info error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void LoadTodayAttendance()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT a.status, a.time_in, a.time_out
                    FROM students s
                    LEFT JOIN attendance a
                        ON a.student_id = s.id
                        AND a.attendance_date = CURDATE()
                    WHERE s.user_id = @userId";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@userId", Session.userId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["status"] == DBNull.Value)
                    {
                        ApplyStatusUI("Pending");

                        lblTimeIn.Text = "Time In: -";
                        lblTimeOut.Text = "Time Out: -";
                    }
                    else
                    {
                        string status = reader["status"].ToString();

                        ApplyStatusUI(status);

                        lblTimeIn.Text = "Time In: " + reader["time_in"].ToString();

                        if (reader["time_out"] == DBNull.Value ||
                            reader["time_out"].ToString() == "")
                        {
                            lblTimeOut.Text = "Time Out: -";
                        }
                        else
                        {
                            lblTimeOut.Text = "Time Out: " +
                                              reader["time_out"].ToString();
                        }
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Attendance error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void LoadAttendanceStats()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT
                        IFNULL(SUM(CASE WHEN a.status='Present' THEN 1 ELSE 0 END),0) AS present_count,
                        IFNULL(SUM(CASE WHEN a.status='Absent' THEN 1 ELSE 0 END),0) AS absent_count,
                        IFNULL(SUM(CASE WHEN a.status='Late' THEN 1 ELSE 0 END),0) AS late_count
                    FROM students s
                    LEFT JOIN attendance a ON a.student_id = s.id
                    WHERE s.user_id = @userId";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@userId", Session.userId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblTotalPresent.Text =
                        "TotalPresent: " + reader["present_count"].ToString();

                    lblTotalAbsent.Text =
                        "TotalAbsent: " + reader["absent_count"].ToString();

                    lblTotalLate.Text =
                        "TotalLate: " + reader["late_count"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stats error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void LoadTodaySchedule()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string today = DateTime.Now.DayOfWeek.ToString();

                string query = @"
                    SELECT
                        sub.subject_name AS 'Subject',
                        t.full_name AS 'Teacher',
                        TIME_FORMAT(ts.start_time, '%h:%i %p') AS 'Start',
                        TIME_FORMAT(ts.end_time, '%h:%i %p') AS 'End'
                    FROM students s
                    INNER JOIN teacher_subjects ts
                        ON s.class_id = ts.class_id
                    INNER JOIN subjects sub
                        ON ts.subject_id = sub.id
                    INNER JOIN teachers t
                        ON ts.teacher_id = t.id
                    WHERE s.user_id = @userId
                    AND ts.day_of_week = @today
                    ORDER BY ts.start_time ASC";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@userId", Session.userId);
                cmd.Parameters.AddWithValue("@today", today);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvSchedule.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Schedule error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnMyQR_Click(object sender, EventArgs e)
        {
            QRCodeForm frm = new QRCodeForm();
            frm.Show();
            this.Close();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceHistoryForm frm = new AttendanceHistoryForm();
            frm.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm frm = new ProfileForm();
            frm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();

            new student_management.forms.Auth.Login().Show();

            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}