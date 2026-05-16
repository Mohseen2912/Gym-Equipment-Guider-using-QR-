namespace GymManagementSystem
{
    partial class Dashboard
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
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelMini = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnQRDecode = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.homePage1 = new GymManagementSystem.HomePage();
            this.report1 = new GymManagementSystem.Report();
            this.qrCreation1 = new GymManagementSystem.QRCreation();
            this.qrDecoding1 = new GymManagementSystem.QRDecoding();
            this.aboutUS1 = new GymManagementSystem.AboutUS();
            this.panelSide.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panelSide.Controls.Add(this.panelMini);
            this.panelSide.Controls.Add(this.btnLogout);
            this.panelSide.Controls.Add(this.btnAboutUs);
            this.panelSide.Controls.Add(this.btnReport);
            this.panelSide.Controls.Add(this.btnQRDecode);
            this.panelSide.Controls.Add(this.btnQR);
            this.panelSide.Controls.Add(this.btnDashboard);
            this.panelSide.Controls.Add(this.panelLogo);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(174, 617);
            this.panelSide.TabIndex = 1;
            // 
            // panelMini
            // 
            this.panelMini.BackColor = System.Drawing.Color.White;
            this.panelMini.Location = new System.Drawing.Point(0, 91);
            this.panelMini.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMini.Name = "panelMini";
            this.panelMini.Size = new System.Drawing.Size(8, 40);
            this.panelMini.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::GymManagementSystem.Properties.Resources.icons8_Logout_24px;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 291);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(174, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.Image = global::GymManagementSystem.Properties.Resources.icons8_about_16px;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(0, 251);
            this.btnAboutUs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(174, 40);
            this.btnAboutUs.TabIndex = 5;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::GymManagementSystem.Properties.Resources.icons8_report_file_24px;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 211);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(174, 40);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnQRDecode
            // 
            this.btnQRDecode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQRDecode.FlatAppearance.BorderSize = 0;
            this.btnQRDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRDecode.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnQRDecode.ForeColor = System.Drawing.Color.White;
            this.btnQRDecode.Image = global::GymManagementSystem.Properties.Resources.icons8_Paint_Bucket_With_QR_24px;
            this.btnQRDecode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQRDecode.Location = new System.Drawing.Point(0, 171);
            this.btnQRDecode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQRDecode.Name = "btnQRDecode";
            this.btnQRDecode.Size = new System.Drawing.Size(174, 40);
            this.btnQRDecode.TabIndex = 4;
            this.btnQRDecode.Text = "QR Decoding";
            this.btnQRDecode.UseVisualStyleBackColor = true;
            this.btnQRDecode.Click += new System.EventHandler(this.btnQRDecode_Click);
            // 
            // btnQR
            // 
            this.btnQR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQR.FlatAppearance.BorderSize = 0;
            this.btnQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQR.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnQR.ForeColor = System.Drawing.Color.White;
            this.btnQR.Image = global::GymManagementSystem.Properties.Resources.icons8_qr_code_24px;
            this.btnQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQR.Location = new System.Drawing.Point(0, 131);
            this.btnQR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(174, 40);
            this.btnQR.TabIndex = 3;
            this.btnQR.Text = "QR Creation";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::GymManagementSystem.Properties.Resources.icons8_dashboard_layout_24px;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 91);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(174, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(174, 91);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::GymManagementSystem.Properties.Resources.images;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(174, 91);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateGray;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(174, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(848, 56);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(473, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Muscle Power";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelData.Controls.Add(this.homePage1);
            this.panelData.Controls.Add(this.report1);
            this.panelData.Controls.Add(this.qrCreation1);
            this.panelData.Controls.Add(this.qrDecoding1);
            this.panelData.Controls.Add(this.aboutUS1);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(174, 56);
            this.panelData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(848, 561);
            this.panelData.TabIndex = 3;
            // 
            // homePage1
            // 
            this.homePage1.BackColor = System.Drawing.Color.White;
            this.homePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePage1.Location = new System.Drawing.Point(0, 0);
            this.homePage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(848, 561);
            this.homePage1.TabIndex = 4;
            // 
            // report1
            // 
            this.report1.BackColor = System.Drawing.Color.White;
            this.report1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report1.Location = new System.Drawing.Point(0, 0);
            this.report1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.report1.Name = "report1";
            this.report1.Size = new System.Drawing.Size(848, 561);
            this.report1.TabIndex = 3;
            // 
            // qrCreation1
            // 
            this.qrCreation1.BackColor = System.Drawing.Color.White;
            this.qrCreation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qrCreation1.Location = new System.Drawing.Point(0, 0);
            this.qrCreation1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qrCreation1.Name = "qrCreation1";
            this.qrCreation1.Size = new System.Drawing.Size(848, 561);
            this.qrCreation1.TabIndex = 2;
            // 
            // qrDecoding1
            // 
            this.qrDecoding1.BackColor = System.Drawing.Color.White;
            this.qrDecoding1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qrDecoding1.Location = new System.Drawing.Point(0, 0);
            this.qrDecoding1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qrDecoding1.Name = "qrDecoding1";
            this.qrDecoding1.Size = new System.Drawing.Size(848, 561);
            this.qrDecoding1.TabIndex = 1;
            // 
            // aboutUS1
            // 
            this.aboutUS1.BackColor = System.Drawing.Color.White;
            this.aboutUS1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutUS1.Location = new System.Drawing.Point(0, 0);
            this.aboutUS1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aboutUS1.Name = "aboutUS1";
            this.aboutUS1.Size = new System.Drawing.Size(848, 561);
            this.aboutUS1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 617);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelSide.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelMini;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnQRDecode;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label3;
        private QRCreation qrCreation1;
        private QRDecoding qrDecoding1;
        private AboutUS aboutUS1;
        private System.Windows.Forms.Button btnReport;
        private HomePage homePage1;
        private Report report1;

    }
}