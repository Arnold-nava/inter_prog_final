using crud;
using MySql.Data.MySqlClient;
using student_management.forms.Auth;
using student_management.Helpers;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace student_management.forms.Admin
{
    public partial class AttendanceHistoryForm : Form
    {
        public AttendanceHistoryForm()
        {
            InitializeComponent();
        }

        private void AttendanceHistoryForm_Load(object sender, EventArgs e)
        {
            LoadClasses();
            LoadAttendance();
        }

        private void LoadClasses()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT id, class_name FROM classes ORDER BY class_name ASC";
                MySqlDataAdapter da = new MySqlDataAdapter(query, db.Connection);

                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow row = dt.NewRow();
                row["id"] = 0;
                row["class_name"] = "All Classes";
                dt.Rows.InsertAt(row, 0);

                cmbClass.DataSource = dt;
                cmbClass.DisplayMember = "class_name";
                cmbClass.ValueMember = "id";
                cmbClass.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load class error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void LoadAttendance()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                int classId = 0;

                if (cmbClass.SelectedValue != null && int.TryParse(cmbClass.SelectedValue.ToString(), out int selectedId))
                {
                    classId = selectedId;
                }

                string query = @"
            SELECT 
                s.student_id AS 'Student No',
                s.full_name AS 'Full Name',
                c.class_name AS 'Class',
                a.attendance_date AS 'Date',
                a.time_in AS 'Time In',
                a.time_out AS 'Time Out',
                a.status AS 'Status'
            FROM attendance a
            INNER JOIN students s ON a.student_id = s.id
            INNER JOIN classes c ON a.class_id = c.id
            WHERE a.attendance_date = @date";

                if (txtSearch.Text.Trim() != "")
                {
                    query += @" AND (
                s.student_id LIKE @search
                OR s.full_name LIKE @search
                OR c.class_name LIKE @search
            )";
                }

                if (classId != 0)
                {
                    query += " AND c.id = @classId";
                }

                query += " ORDER BY a.attendance_date DESC, a.time_in DESC";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);

                if (txtSearch.Text.Trim() != "")
                    cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

                if (classId != 0)
                    cmd.Parameters.AddWithValue("@classId", classId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAttendance.DataSource = dt;

                dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvAttendance.ReadOnly = true;

                // remove ugly gray parts
                dgvAttendance.AllowUserToAddRows = false;
                dgvAttendance.RowHeadersVisible = false;
                dgvAttendance.BackgroundColor = System.Drawing.Color.White;
                dgvAttendance.BorderStyle = BorderStyle.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load attendance error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbClass.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;

            LoadAttendance();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAttendance();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClass.SelectedValue != null)
                LoadAttendance();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAttendance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Login frm = new Login();
            frm.Show();
            this.Hide();
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

        private void btnAttendanceRecords_Click(object sender, EventArgs e)
        {
            AttendanceHistoryForm frm = new AttendanceHistoryForm();
            frm.Show();
            this.Hide();
        }
    }
}