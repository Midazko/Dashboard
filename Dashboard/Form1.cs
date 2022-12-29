using System.Runtime.InteropServices;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        // A method to make the form moveable by hoding down left mousebutton, Its importent the code is implemented in the Main Form
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }


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
            btnDashboard.BackColor = Color.FromKnownColor(KnownColor.DimGray);

            lblTitle.Text = "InfoBoard";
            this.PnlFormLoader2.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader2.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
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

            lblTitle.Text = "InfoBoard";
            this.PnlFormLoader2.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader2.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            pnlNav.Left = btnAnalytics.Left;
            btnAnalytics.BackColor = Color.FromKnownColor(KnownColor.LightGray);

            lblTitle.Text = "Music";
            this.PnlFormLoader2.Controls.Clear();
            frmAnalytics FrmDashboard_Vrb = new frmAnalytics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader2.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalender.Height;
            pnlNav.Top = btnCalender.Top;
            pnlNav.Left = btnCalender.Left;
            btnCalender.BackColor = Color.FromKnownColor(KnownColor.LightGray);

            lblTitle.Text = "Calender";
            this.PnlFormLoader2.Controls.Clear();
            frmCalender FrmDashboard_Vrb = new frmCalender() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader2.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            pnlNav.Left = btnContactUs.Left;
            btnContactUs.BackColor = Color.FromKnownColor(KnownColor.LightGray);

            lblTitle.Text = "Contact Us";
            this.PnlFormLoader2.Controls.Clear();
            frmContactUs FrmDashboard_Vrb = new frmContactUs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader2.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnGame_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = btnGame.Height;
            pnlNav.Top = btnGame.Top;
            pnlNav.Left = btnGame.Left;
            btnGame.BackColor = Color.FromKnownColor(KnownColor.DimGray);

            lblTitle.Text = "Game";
            this.PnlFormLoader2.Controls.Clear();
            frmGame FrmDashboard_Vrb = new frmGame() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader2.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnJesper_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = btnJesper.Height;
            pnlNav.Top = btnJesper.Top;
            pnlNav.Left = btnJesper.Left;
            btnJesper.BackColor = Color.FromKnownColor(KnownColor.DimGray);

            lblTitle.Text = "Jesper";
            this.PnlFormLoader2.Controls.Clear();
            frmJesper FrmDashboard_Vrb = new frmJesper() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader2.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromKnownColor(KnownColor.LightGray);

            lblTitle.Text = "Settings";
            this.PnlFormLoader2.Controls.Clear();
            frmSettings FrmDashboard_Vrb = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader2.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
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

        private void btnGame_Leave(object sender, EventArgs e)
        {
            btnGame.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }

        private void btnJesper_Leave(object sender, EventArgs e)
        {
            btnJesper.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromKnownColor(KnownColor.DimGray);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlFormLoader2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}