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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUname.Text=="Admin" && txtPassword.Text=="123")
            {
                MessageBox.Show("Wecome Admin \n Login is Done Successfullt");
                this.Hide();
                //this.Close();
                Dashboard ob = new Dashboard();
                ob.Show();
                

            }
            else
            {
                MessageBox.Show("Please check User and Password and try again");
                txtUname.Text = "";

                txtPassword.Text="";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
