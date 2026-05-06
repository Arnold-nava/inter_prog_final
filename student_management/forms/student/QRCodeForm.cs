using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using student_management.Helpers;
using student_management.forms.Auth;

namespace student_management.forms.student
{
    public partial class QRCodeForm : Form
    {
        public QRCodeForm()
        {
            InitializeComponent();
        }

        // 🔵 ROUND METHOD
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

        // 🔥 LOAD
        private void QRCodeForm_Load(object sender, EventArgs e)
        {
            // 🎨 ROUND UI
            RoundControl(panelSidebar, 25);

            RoundControl(btnDashboard, 15);
            RoundControl(btnMyQR, 15);
            RoundControl(btnAttendance, 15);
            RoundControl(btnProfile, 15);
            RoundControl(btnLogout, 15);

            RoundControl(panelQR, 20);

            // 👤 INFO
            lblName.Text = Session.fullName;
            lblStudentNo.Text = Session.studentNumber;

            // 📷 QR GENERATION
            QRCodeGenerator qrGen = new QRCodeGenerator();
            QRCodeData qrData = qrGen.CreateQrCode(Session.studentNumber, QRCodeGenerator.ECCLevel.Q);
            QRCode qr = new QRCode(qrData);

            picQR.Image = qr.GetGraphic(8);
            picQR.SizeMode = PictureBoxSizeMode.StretchImage;
            picQR.BackColor = Color.White;
        }

        // 🏠 DASHBOARD
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new StudentDashBoardForm().Show();
            this.Close();
        }

        // 📷 MY QR (CURRENT PAGE)
        private void btnMyQR_Click(object sender, EventArgs e)
        {
            // already on this page
        }

        // 📊 ATTENDANCE
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            new AttendanceHistoryForm().Show();
            this.Close();
        }

        // 👤 PROFILE
        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm frm = new ProfileForm();
            frm.Show();
            this.Close();
        }

        // 🚪 LOGOUT
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Login frm = new Login();
            frm.Show();
            this.Close();
        }

        // 🔄 FIX ROUND ON RESIZE (IMPORTANT)
        private void QRCodeForm_Resize(object sender, EventArgs e)
        {
            RoundControl(panelSidebar, 25);
            RoundControl(panelQR, 20);
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}