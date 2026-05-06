using crud;
using MySql.Data.MySqlClient;
using student_management.forms.Auth;
using student_management.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_management.forms.Admin
{
    public partial class TeacherDashBoard : Form
    {
        public TeacherDashBoard()
        {
            InitializeComponent();
        }

        private void LoadStats()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string todayClassQuery = @"
            SELECT COUNT(*) 
            FROM teacher_subjects 
            WHERE teacher_id = @teacherId";

                MySqlCommand cmd1 = new MySqlCommand(todayClassQuery, db.Connection);
                cmd1.Parameters.AddWithValue("@teacherId", Session.teacherId);
                lblClass.Text = cmd1.ExecuteScalar().ToString();

                string studentsQuery = @"
            SELECT COUNT(DISTINCT s.id)
            FROM students s
            INNER JOIN teacher_subjects ts ON s.class_id = ts.class_id
            WHERE ts.teacher_id = @teacherId";

                MySqlCommand cmd2 = new MySqlCommand(studentsQuery, db.Connection);
                cmd2.Parameters.AddWithValue("@teacherId", Session.teacherId);
                lblStudents.Text = cmd2.ExecuteScalar().ToString();

                string attendanceQuery = @"
            SELECT COUNT(*)
            FROM attendance
            WHERE teacher_id = @teacherId
            AND attendance_date = CURDATE()";

                MySqlCommand cmd3 = new MySqlCommand(attendanceQuery, db.Connection);
                cmd3.Parameters.AddWithValue("@teacherId", Session.teacherId);
                lblAttendance.Text = cmd3.ExecuteScalar().ToString();
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

        // AI generated code for loading class cards based on teacher's subjects and classes
        private void LoadClassCards()
        {
            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"
            SELECT 
                ts.subject_id,
                ts.class_id,
                s.subject_name,
                c.class_name,
                c.grade_level,
                c.section,
                COUNT(st.id) AS student_count
            FROM teacher_subjects ts
            INNER JOIN subjects s ON ts.subject_id = s.id
            INNER JOIN classes c ON ts.class_id = c.id
            LEFT JOIN students st ON st.class_id = c.id
            WHERE ts.teacher_id = @teacherId
            GROUP BY 
                ts.subject_id,
                ts.class_id,
                s.subject_name,
                c.class_name,
                c.grade_level,
                c.section";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@teacherId", Session.teacherId);

                MySqlDataReader reader = cmd.ExecuteReader();

                flowClasses.Controls.Clear();

                while (reader.Read())
                {
                    int subjectId = Convert.ToInt32(reader["subject_id"]);
                    int classId = Convert.ToInt32(reader["class_id"]);

                    Panel card = new Panel();
                    card.Width = 180;
                    card.Height = 120;
                    card.BorderStyle = BorderStyle.FixedSingle;
                    card.Margin = new Padding(10);

                    Label lblClass = new Label();
                    lblClass.Text = reader["class_name"].ToString();
                    lblClass.Left = 10;
                    lblClass.Top = 10;
                    lblClass.AutoSize = true;
                    lblClass.Font = new Font("Arial", 10, FontStyle.Bold);

                    Label lblSubject = new Label();
                    lblSubject.Text = reader["subject_name"].ToString();
                    lblSubject.Left = 10;
                    lblSubject.Top = 35;
                    lblSubject.AutoSize = true;

                    Label lblStudents = new Label();
                    lblStudents.Text = "Students: " + reader["student_count"].ToString();
                    lblStudents.Left = 10;
                    lblStudents.Top = 60;
                    lblStudents.AutoSize = true;

                    Button btnStart = new Button();
                    btnStart.Text = "Start Attendance";
                    btnStart.Left = 10;
                    btnStart.Top = 85;
                    btnStart.Width = 150;
                    btnStart.Height = 28;

                    btnStart.Click += (s, e) =>
                    {
                        QRScannerForm frm = new QRScannerForm();
                        frm.Show();
                        this.Hide();
                    };

                    card.Controls.Add(lblClass);
                    card.Controls.Add(lblSubject);
                    card.Controls.Add(lblStudents);
                    card.Controls.Add(btnStart);

                    flowClasses.Controls.Add(card);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Class cards error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }

        private void TeacherDashBoard_Load(object sender, EventArgs e)
        {
            lblTeacherName.Text = "Welcome, " + Session.fullName + "!";

            LoadStats();
            LoadClassCards();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
