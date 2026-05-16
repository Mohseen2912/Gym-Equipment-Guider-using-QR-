using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using MessagingToolkit.QRCode.Codec;

namespace GymManagementSystem
{
    public partial class QRCreation : UserControl
    {
        public QRCreation()
        {
            InitializeComponent();
        }
        public void ClearData()
        {
            lblID.Text = "";
            txtName.Text = "";
            txtDesc.Text = "";
            txtLink.Text = "";
            pictureBox1.Image = null;
        }
        private void qrcodeGen()
        {
            try
            {
                QRCodeEncoder qrCode = new QRCodeEncoder();
                qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
                String str1, str2, str3,str;
                str1 = txtName.Text;
                str2 = txtDesc.Text;
                str3 = txtLink.Text;
               // str = "Equiment Name=" + str1 + "\nDescription=" + str2+"\nYouTube Link="+str3;
                str =  str3;
                this.pictureBox1.Image = qrCode.Encode(str, System.Text.Encoding.UTF8);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LoadData()
        {
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from tbl_Equiment ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                dataGridView1.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    string msg1 = "Please insert Equiment Name";
                    string msg2 = "Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtName.Focus();
                    return;
                }
                if (txtDesc.Text == "")
                {
                    string msg1 = "Please Insert Decription";
                    string msg2 = "Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtDesc.Focus();
                    return;
                }
                if (txtLink.Text == "")
                {
                    string msg1 = "Please Insert Link";
                    string msg2 = "Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtLink.Focus();
                    return;
                }
                if (pictureBox1.Image == null)
                {
                    string msg1 = "Please Click on Genrate Button";
                    string msg2 = "Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                   // txtDesc.Focus();
                    return;
                }


                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "insert into tbl_Equiment values(@name,@details,@link)";
                 SqlCommand cmd = new SqlCommand(sql, con);
                 cmd.Parameters.AddWithValue("@name", txtName.Text);
                 cmd.Parameters.AddWithValue("@details", txtDesc.Text);
                 cmd.Parameters.AddWithValue("@link", txtLink.Text);
                 
                 if (con.State != ConnectionState.Open)
                 {
                     con.Open();
                 }
                 int x = cmd.ExecuteNonQuery();

              

                con.Close();
                MessageBox.Show(x.ToString() + "Record Inserted");
                ClearData();
                LoadData();
                dataGridView1.Update();
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void QRCreation_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
             
                if (txtName.Text == "")
                {
                    string msg1 = "Please insert Equiment Name";
                    string msg2 = "Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtName.Focus();
                    return;
                }
                if (txtDesc.Text == "")
                {
                    string msg1 = "Please Insert Decription";
                    string msg2 = "Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtDesc.Focus();
                    return;
                }
                if (txtLink.Text == "")
                {
                    string msg1 = "Please Insert Link";
                    string msg2 = "Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtLink.Focus();
                    return;
                }
              
            qrcodeGen();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtLink.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            try
            {
                QRCodeEncoder qrCode = new QRCodeEncoder();
                qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
                String str1, str2, str3, str;
                str1 = txtName.Text;
                str2 = txtDesc.Text;
                str3 = txtLink.Text;
                str = "Equiment Name=" + str1 + "\nDescription=" + str2 + "\nYouTube Link=" + str3;
                this.pictureBox1.Image = qrCode.Encode(str, System.Text.Encoding.UTF8);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    string msg1 = "Please insert Equiment Name";
                    string msg2 = "Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtName.Focus();
                    return;
                }
                if (txtDesc.Text == "")
                {
                    string msg1 = "Please Insert Decription";
                    string msg2 = "Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtDesc.Focus();
                    return;
                }
                if (txtLink.Text == "")
                {
                    string msg1 = "Please Insert Link";
                    string msg2 = "Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtLink.Focus();
                    return;
                }
            

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "update tbl_Equiment set name=@name,details=@details,link=@link where eid='"+lblID.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@details", txtDesc.Text);
                cmd.Parameters.AddWithValue("@link", txtLink.Text);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();



                con.Close();
                MessageBox.Show(x.ToString() + "Record Updated");
                ClearData();
                LoadData();
                dataGridView1.Update();
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblID.Text == "")
                {
                    string msg1 = "Please select Data in Table";
                    string msg2 = "Product";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    //txtName.Focus();
                    return;
                }
               


                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "delete from tbl_Equiment where eid='" + lblID.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();



                con.Close();
                MessageBox.Show(x.ToString() + "Record deleted");
                ClearData();
                LoadData();
                dataGridView1.Update();
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        Image img;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*if (pictureBox1.Image == null)
            {
                btnSaveQR.Visible = false;
            }
            else
            {
                btnSaveQR.Visible = true;
            }*/
        }

        private void btnSaveQR_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "JPG(*.JPG)|*.jpg";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                     
                    pictureBox1.Image.Save(sf.FileName);
                }
            }
            catch (Exception ex)
            { 
            }
        }
    }
}
