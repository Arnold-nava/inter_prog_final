using crud;
using MySql.Data.MySqlClient;
using student_management.forms.Auth;
using student_management.Helpers;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace student_management.forms.student
{
    public partial class AttendanceHistoryForm : Form
    {
        public AttendanceHistoryForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AttendanceHistoryForm_Load(object sender, EventArgs e)
        {
            cbStatus.Items.Clear();
            cbStatus.Items.Add("All");
            cbStatus.Items.Add("Present");
            cbStatus.Items.Add("Late");
            cbStatus.Items.Add("Absent");
            cbStatus.SelectedIndex = 0;

            SetupTable();
            LoadAttendance();
        }

        private void SetupTable()
        {
            dgvAttendance.ReadOnly = true;
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.BackgroundColor = Color.White;
        }

        private void LoadAttendance()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT 
                        a.attendance_date AS 'Date',
                        sub.subject_name AS 'Subject',
                        t.full_name AS 'Teacher',
                        a.time_in AS 'Time In',
                        a.time_out AS 'Time Out',
                        a.status AS 'Status'
                    FROM attendance a
                    INNER JOIN subjects sub ON a.subject_id = sub.id
                    INNER JOIN teachers t ON a.teacher_id = t.id
                    INNER JOIN students s ON a.student_id = s.id
                    WHERE s.user_id = @userId";

                if (txtSearch.Text.Trim() != "")
                {
                    query += " AND sub.subject_name LIKE @search";
                }

                if (cbStatus.SelectedIndex > 0)
                {
                    query += " AND a.status = @status";
                }

                query += " ORDER BY a.attendance_date DESC, a.time_in DESC";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@userId", Session.userId);

                if (txtSearch.Text.Trim() != "")
                    cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

                if (cbStatus.SelectedIndex > 0)
                    cmd.Parameters.AddWithValue("@status", cbStatus.Text);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAttendance.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Attendance Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on Attendance History.");
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
            Login frm = new Login();
            frm.Show();
            this.Close();
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {
            int radius = 25;

            GraphicsPath path = new GraphicsPath();

            path.AddLine(0, 0, panelSidebar.Width - radius, 0);
            path.AddArc(panelSidebar.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panelSidebar.Width - radius, panelSidebar.Height - radius, radius, radius, 0, 90);
            path.AddLine(0, panelSidebar.Height, 0, 0);

            path.CloseFigure();

            panelSidebar.Region = new Region(path);
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cbStatus.SelectedIndex = 0;
            LoadAttendance();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAttendance();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttendance();

        }
    }
}