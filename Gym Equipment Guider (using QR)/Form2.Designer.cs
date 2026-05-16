namespace GymManagementSystem
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.qrDecoding1 = new GymManagementSystem.QRDecoding();
            this.SuspendLayout();
            // 
            // qrDecoding1
            // 
            this.qrDecoding1.Location = new System.Drawing.Point(-10, 12);
            this.qrDecoding1.Name = "qrDecoding1";
            this.qrDecoding1.Size = new System.Drawing.Size(1276, 689);
            this.qrDecoding1.TabIndex = 0;
            this.qrDecoding1.Load += new System.EventHandler(this.qrDecoding1_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 803);
            this.Controls.Add(this.qrDecoding1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private QRDecoding qrDecoding1;





    }
}