using System;
using System.Windows.Forms;
using crud;
using MySql.Data.MySqlClient;
using student_management.forms.Admin;
using student_management.forms.student;
using student_management.Helpers;

namespace student_management.forms.Auth
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (user == "" || pass == "")
            {
                MessageBox.Show("Please enter both username and password.", "Error");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "SELECT * FROM users WHERE username=@username AND password=@password";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", pass);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int userId = Convert.ToInt32(reader["id"]);
                    string role = reader["role"].ToString();

                    Session.userId = userId;
                    Session.username = reader["username"].ToString();
                    Session.role = role;

                    reader.Close();

                    if (role == "teacher")
                    {
                        LoadTeacherSession(db, userId);

                        MessageBox.Show("Login successful!");

                        TeacherDashBoard frm = new TeacherDashBoard();
                        frm.Show();
                        this.Hide();
                    }
                    else if (role == "student")
                    {
                        LoadStudentSession(db, userId);

                        MessageBox.Show("Login successful!");

                        StudentDashBoardForm frm = new StudentDashBoardForm();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Invalid username or password.", "Login Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error");
            }
            finally
            {
                db.Close();
            }
        }

        private void LoadTeacherSession(DBConnect db, int userId)
        {
            string query = "SELECT id, teacher_id, full_name FROM teachers WHERE user_id=@userId";

            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@userId", userId);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Session.teacherId = Convert.ToInt32(reader["id"]);
                Session.teacherNumber = reader["teacher_id"].ToString();
                Session.fullName = reader["full_name"].ToString();
            }

            reader.Close();
        }

        private void LoadStudentSession(DBConnect db, int userId)
        {
            string query = @"
                SELECT 
                    s.id,
                    s.student_id,
                    s.full_name,
                    s.class_id,
                    c.class_name,
                    c.grade_level,
                    c.section
                FROM students s
                INNER JOIN classes c ON s.class_id = c.id
                WHERE s.user_id=@userId";

            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("@userId", userId);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Session.studentId = Convert.ToInt32(reader["id"]);
                Session.studentNumber = reader["student_id"].ToString();
                Session.fullName = reader["full_name"].ToString();

                Session.classId = Convert.ToInt32(reader["class_id"]);
                Session.className = reader["class_name"].ToString();
                Session.gradeLevel = reader["grade_level"].ToString();
                Session.section = reader["section"].ToString();
            }

            reader.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register frm = new Register();
            frm.Show();
            this.Hide();
        }
    }
}