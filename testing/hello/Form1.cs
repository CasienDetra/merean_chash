using System;

using System.Drawing;
using System.Windows.Forms;

namespace Hello
{
    public class MainForm : Form
    {
        private Panel sidebar;
        private Button btnHome;
        private Button btnSettings;

        public MainForm()
        {
            this.Text = "WinForms Sidebar Example";
            this.Size = new Size(800, 500);

            // Sidebar panel
            sidebar = new Panel();
            sidebar.Dock = DockStyle.Left;
            sidebar.Width = 200;
            sidebar.BackColor = Color.LightSlateGray;
            this.Controls.Add(sidebar);

            // Home button
            btnHome = new Button();
            btnHome.Text = "Home";
            btnHome.Dock = DockStyle.Top;
            btnHome.Height = 50;
            btnHome.Click += BtnHome_Click;
            sidebar.Controls.Add(btnHome);

            // Settings button
            btnSettings = new Button();
            btnSettings.Text = "Settings";
            btnSettings.Dock = DockStyle.Top;
            btnSettings.Height = 50;
            btnSettings.Click += BtnSettings_Click;
            sidebar.Controls.Add(btnSettings);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home clicked!");
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings clicked!");
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

