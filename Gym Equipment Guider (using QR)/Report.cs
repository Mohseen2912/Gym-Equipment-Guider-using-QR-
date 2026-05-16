using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GymManagementSystem
{
    public partial class Report : UserControl
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                cbSearchData.Items.Clear();
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                //DataTable donater = new DataTable();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_Equiment ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbSearchData.Items.Add(dr["name"].ToString());
                    //custid = dr["ID"].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cbSearchData.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSearchData.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSearchData.Text == "")
                {
                    string msg1 = "Please select Item";
                    string msg2 = "Item Master";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    cbSearchData.Focus();
                    return;
                }

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Equiment where name='" + cbSearchData.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewAddProduct.DataSource = dt;
                con.Close();
                dataGridViewAddProduct.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                con.Open();
                string sql = "select count(*) from tbl_Equiment where name='" + cbSearchData.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int cnt = (int)cmd.ExecuteScalar();
                lblcnt.Text = cnt.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewAddProduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblEID.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells["eid"].Value.ToString();
            btnPrint.Enabled = true;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Equiment", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewAddProduct.DataSource = dt;
                con.Close();
                dataGridViewAddProduct.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                con.Open();
                string sql = "select count(*) from tbl_Equiment";
                SqlCommand cmd = new SqlCommand(sql, con);
                int cnt = (int)cmd.ExecuteScalar();
                lblcnt.Text = cnt.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static int eid;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lblEID.Text == "")
            {
                string msg1 = "Please select Data";
                string msg2 = "Item Master";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                //cbSearchData.Focus();
                btnPrint.Enabled = false;
                return;
            }
            else
            {
                eid = Convert.ToInt32(lblEID.Text);
                ReportWindow ob = new ReportWindow();
                ob.Show();
            }
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            ReportShowAll obj = new ReportShowAll();
            obj.Show();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
