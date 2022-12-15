using System.Runtime.InteropServices;

namespace Dashboard
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromKnownColor(KnownColor.LightGray);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromKnownColor(KnownColor.LightGray);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            pnlNav.Left = btnAnalytics.Left;
            btnAnalytics.BackColor = Color.FromKnownColor(KnownColor.LightGray);
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalender.Height;
            pnlNav.Top = btnCalender.Top;
            pnlNav.Left = btnCalender.Left;
            btnCalender.BackColor = Color.FromKnownColor(KnownColor.LightGray);
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            pnlNav.Left = btnContactUs.Left;
            btnContactUs.BackColor = Color.FromKnownColor(KnownColor.LightGray);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromKnownColor(KnownColor.LightGray);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}