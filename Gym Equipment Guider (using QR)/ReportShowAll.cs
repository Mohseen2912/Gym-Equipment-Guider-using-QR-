using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GymManagementSystem
{
    public partial class ReportShowAll : Form
    {
        public ReportShowAll()
        {
            InitializeComponent();
        }

        private void ReportShowAll_Load(object sender, EventArgs e)
        {
            try
            {
                crystalReportViewer1.Visible = true;
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select * from tbl_Equiment", con);
                // SqlCommand cmd = new SqlCommand("select * from Sale where ID='15'", con);
                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                dr.Fill(dt);
                CrystalReport1 cr = new CrystalReport1();
                cr.Database.Tables["tbl_Equiment"].SetDataSource(dt);
                this.crystalReportViewer1.ReportSource = cr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
