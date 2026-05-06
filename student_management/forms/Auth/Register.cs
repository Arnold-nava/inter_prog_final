using crud;
using MySql.Data.MySqlClient;
using student_management.forms.student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using student_management.Helpers;
using student_management.forms.Admin;


namespace student_management.forms.Auth
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNumber.Text.Trim();
            string username = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (studentNo == "" || username == "" || password == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string checkStudent = @"
            SELECT id FROM students 
            WHERE student_id = @student_id AND user_id IS NULL";

                MySqlCommand cmd1 = new MySqlCommand(checkStudent, db.Connection);
                cmd1.Parameters.AddWithValue("@student_id", studentNo);

                object result = cmd1.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Student not found or already registered.");
                    return;
                }

                int studentDbId = Convert.ToInt32(result);


                string checkUser = "SELECT id FROM users WHERE username=@username";
                MySqlCommand cmd2 = new MySqlCommand(checkUser, db.Connection);
                cmd2.Parameters.AddWithValue("@username", username);

                object userExists = cmd2.ExecuteScalar();

                if (userExists != null)
                {
                    MessageBox.Show("Username already taken.");
                    return;
                }

                string insertUser = @"
            INSERT INTO users (username, password, role)
            VALUES (@username, @password, 'student')";

                MySqlCommand cmd3 = new MySqlCommand(insertUser, db.Connection);
                cmd3.Parameters.AddWithValue("@username", username);
                cmd3.Parameters.AddWithValue("@password", password);

                cmd3.ExecuteNonQuery();

                int userId = (int)cmd3.LastInsertedId;

                string update = @"
            UPDATE students 
            SET user_id = @user_id 
            WHERE id = @student_id";

                MySqlCommand cmd4 = new MySqlCommand(update, db.Connection);
                cmd4.Parameters.AddWithValue("@user_id", userId);
                cmd4.Parameters.AddWithValue("@student_id", studentDbId);

                cmd4.ExecuteNonQuery();

                string studentInfoQuery = @"
            SELECT 
                s.full_name,
                s.class_id,
                c.class_name,
                c.grade_level,
                c.section
            FROM students s
            INNER JOIN classes c ON s.class_id = c.id
            WHERE s.id = @id";

                MySqlCommand infoCmd = new MySqlCommand(studentInfoQuery, db.Connection);
                infoCmd.Parameters.AddWithValue("@id", studentDbId);

                MySqlDataReader reader = infoCmd.ExecuteReader();

                if (reader.Read())
                {
                    Session.userId = userId;
                    Session.username = username;
                    Session.role = "student";

                    Session.studentId = studentDbId;
                    Session.studentNumber = studentNo;
                    Session.fullName = reader["full_name"].ToString();

                    Session.classId = Convert.ToInt32(reader["class_id"]);
                    Session.className = reader["class_name"].ToString();
                    Session.gradeLevel = reader["grade_level"].ToString();
                    Session.section = reader["section"].ToString();
                }

                reader.Close();

                MessageBox.Show("Registration successful!");

                StudentDashBoardForm frm = new StudentDashBoardForm();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
