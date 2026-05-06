using crud;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using student_management.Helpers;
using student_management.forms.Auth;

namespace student_management.forms.student
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        // 🔥 LOAD PROFILE DATA
        private void LoadProfile()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT 
                        s.full_name,
                        s.student_id,
                        s.email,
                        s.status,
                        c.class_name
                    FROM students s
                    JOIN classes c ON s.class_id = c.id
                    WHERE s.id = @student_id";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@student_id", Session.studentId);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblName.Text = reader["full_name"].ToString();
                    lblStudentNo.Text = reader["student_id"].ToString();
                    lblEmail.Text = reader["email"].ToString();
                    lblClass.Text = reader["class_name"].ToString();
                    lblStatus.Text = reader["status"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        // 🏠 DASHBOARD
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            StudentDashBoardForm frm = new StudentDashBoardForm();
            frm.Show();
            this.Close();
        }

        // 📷 MY QR
        private void btnMyQR_Click(object sender, EventArgs e)
        {
            new QRCodeForm().Show();
            this.Close();
        }

        // 📊 ATTENDANCE
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            new AttendanceHistoryForm().Show();
            this.Close();
        }

        // 👤 PROFILE (CURRENT PAGE)
        private void btnProfile_Click(object sender, EventArgs e)
        {
            // do nothing (already here)
        }

        // 🚪 LOGOUT
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            new student_management.forms.Auth.Login().Show();
            this.Close();
        }

        // 🔙 BACK BUTTON (optional)
        private void btnBack_Click(object sender, EventArgs e)
        {
            new StudentDashBoardForm().Show();
            this.Close();
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Login frm = new Login();
            frm.Show();
            this.Close();
        }

        private void btnMyQR_Click_1(object sender, EventArgs e)
        {
            QRCodeForm frm = new QRCodeForm();
            frm.Show();
            this.Close();
        }

        private void btnAttendance_Click_1(object sender, EventArgs e)
        {
            AttendanceHistoryForm frm = new AttendanceHistoryForm();
            frm.Show();
            this.Close();
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            ProfileForm frm = new ProfileForm();
            frm.Show();
            this.Close();
        }
    }
}