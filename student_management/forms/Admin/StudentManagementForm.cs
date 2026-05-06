using crud;
using MySql.Data.MySqlClient;
using student_management.forms.Auth;
using student_management.Helpers;
using System;
using System.Data;
using System.Windows.Forms;

namespace student_management.forms.Admin
{
    public partial class StudentManagementForm : Form
    {
        int selectedStudentId = 0;

        public StudentManagementForm()
        {
            InitializeComponent();
        }

        private void StudentManagementForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("active");
            cmbStatus.Items.Add("inactive");
            cmbStatus.SelectedIndex = 0;

            LoadClasses();
            LoadStudents();
        }

        private void LoadClasses()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT id, class_name FROM classes";
                MySqlDataAdapter da = new MySqlDataAdapter(query, db.Connection);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbClass.DataSource = dt;
                cmbClass.DisplayMember = "class_name";
                cmbClass.ValueMember = "id";
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

        private void LoadStudents()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    SELECT 
                        s.id,
                        s.student_id AS 'Student No',
                        s.full_name AS 'Full Name',
                        s.email AS 'Email',
                        c.class_name AS 'Class',
                        s.status AS 'Status'
                    FROM students s
                    INNER JOIN classes c ON s.class_id = c.id
                    ORDER BY s.id DESC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, db.Connection);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvStudents.DataSource = dt;
                dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvStudents.ReadOnly = true;

                dgvStudents.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load students error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void ClearFields()
        {
            selectedStudentId = 0;
            txtStudentId.Clear();
            txtFullName.Clear();
            txtEmail.Clear();

            if (cmbClass.Items.Count > 0)
                cmbClass.SelectedIndex = 0;

            cmbStatus.SelectedIndex = 0;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

            selectedStudentId = Convert.ToInt32(row.Cells["id"].Value);
            txtStudentId.Text = row.Cells["Student No"].Value.ToString();
            txtFullName.Text = row.Cells["Full Name"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            cmbClass.Text = row.Cells["Class"].Value.ToString();
            cmbStatus.Text = row.Cells["Status"].Value.ToString();
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
            MessageBox.Show("You are already on Student Management.");
        }

        private void btnAttendanceRecords_Click(object sender, EventArgs e)
        {
            AttendanceHistoryForm frm = new AttendanceHistoryForm();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            {
                DBConnect db = new DBConnect();

                try
                {
                    db.Open();

                    string query = @"
            SELECT 
                s.id,
                s.student_id AS 'Student No',
                s.full_name AS 'Full Name',
                s.email AS 'Email',
                c.class_name AS 'Class',
                s.status AS 'Status'
            FROM students s
            INNER JOIN classes c ON s.class_id = c.id
            WHERE 
                s.student_id LIKE @search
                OR s.full_name LIKE @search
                OR s.email LIKE @search
                OR c.class_name LIKE @search
            ORDER BY s.id DESC";

                    MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                    cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvStudents.DataSource = dt;

                    if (dgvStudents.Columns.Contains("id"))
                        dgvStudents.Columns["id"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search error: " + ex.Message);
                }
                finally
                {
                    db.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtStudentId.Text == "" || txtFullName.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    INSERT INTO students
                    (user_id, student_id, full_name, class_id, email, status)
                    VALUES
                    (NULL, @studentId, @fullName, @classId, @email, @status)";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@studentId", txtStudentId.Text.Trim());
                cmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());
                cmd.Parameters.AddWithValue("@classId", cmbClass.SelectedValue);
                cmd.Parameters.AddWithValue("@qrCode", txtStudentId.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student added successfully.");

                ClearFields();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Select a student first.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
                    UPDATE students
                    SET student_id = @studentId,
                        full_name = @fullName,
                        class_id = @classId,
                        email = @email,
                        status = @status
                    WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@studentId", txtStudentId.Text.Trim());
                cmd.Parameters.AddWithValue("@fullName", txtFullName.Text.Trim());
                cmd.Parameters.AddWithValue("@classId", cmbClass.SelectedValue);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@id", selectedStudentId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student updated successfully.");

                ClearFields();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Select a student first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Delete this student?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (result != DialogResult.Yes) return;

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "DELETE FROM students WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@id", selectedStudentId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student deleted successfully.");

                ClearFields();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnScanner_Click_1(object sender, EventArgs e)
        {
            QRScannerForm frm = new QRScannerForm();
            frm.Show();
            this.Hide();
        }

        private void btnStudentManagement_Click_1(object sender, EventArgs e)
        {
            StudentManagementForm frm = new StudentManagementForm();
            frm.Show();
            this.Hide();
        }

        private void btnAttendanceRecords_Click_1(object sender, EventArgs e)
        {
            AttendanceHistoryForm frm = new AttendanceHistoryForm();
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
    }
}