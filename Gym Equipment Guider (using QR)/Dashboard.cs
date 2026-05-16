using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnDashboard.Height;
            panelMini.Top = btnDashboard.Top;
            homePage1.BringToFront();
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnQR.Height;
            panelMini.Top = btnQR.Top;
             qrCreation1.BringToFront();
        }

        private void btnQRDecode_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnQRDecode.Height;
            panelMini.Top = btnQRDecode.Top;
             qrDecoding1.BringToFront();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnAboutUs.Height;
            panelMini.Top = btnAboutUs.Top;
             aboutUS1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnLogout.Height;
            panelMini.Top = btnLogout.Top;
            MessageBox.Show("Logout!!!");
            this.Close();
            LoginForm ob = new LoginForm();
            ob.Show();
            // homePage1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnReport.Height;
            panelMini.Top = btnReport.Top;
            report1.BringToFront();
        }
    }
}
