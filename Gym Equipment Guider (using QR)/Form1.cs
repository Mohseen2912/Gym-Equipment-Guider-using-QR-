using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace GymManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void qrcodeGen()
        {
            try
            {
                QRCodeEncoder qrCode = new QRCodeEncoder();
                qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
                String str1, str2, str;
                str1 = txtCode.Text;
                str2 = textBox1.Text;
                str = "Name="+str1 +"\nAddress="+ str2;
                this.PictureBox1.Image = qrCode.Encode(str, System.Text.Encoding.UTF8);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                qrcodeGen();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
