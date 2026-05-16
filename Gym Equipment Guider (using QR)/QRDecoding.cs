using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace GymManagementSystem
{
    public partial class QRDecoding : UserControl
    {
        public QRDecoding()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                lblPath.Text = open.FileName;
            }  
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                QRCodeEncoder qrCode = new QRCodeEncoder();
                qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
                /*String str1, str2, str3, str;
                str1 = txtName.Text;
                str2 = txtDesc.Text;
                str3 = txtLink.Text;
                str = "Equiment Name=" + str1 + "\nDescription=" + str2 + "\nYouTube Link=" + str3;*/   
                //this.pictureBox1.Image = qrCode.Encode(str, System.Text.Encoding.UTF8);
                //using (OpenFileDialog ofd = new OpenFileDialog())
                //{
                    //ofd.Filter = "JPG(*.JPG)|*.jpg";
                  //  ofd.ValidateNames = true;
                  //  ofd.Multiselect = false;
                  //  if(ofd.ShowDialog()==DialogResult.OK)
                   // {
                        MessagingToolkit.QRCode.Codec.QRCodeDecoder decode=new QRCodeDecoder();
                        pictureBox1.Image = Image.FromFile(lblPath.Text);
                        txtData.Text = decode.decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
                    //}
                //}
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
