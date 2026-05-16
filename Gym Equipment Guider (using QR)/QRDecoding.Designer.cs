namespace GymManagementSystem
{
    partial class QRDecoding
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Decoding QR Code";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblPath.Location = new System.Drawing.Point(434, 373);
            this.lblPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(41, 19);
            this.lblPath.TabIndex = 23;
            this.lblPath.Text = "Path";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtData.Location = new System.Drawing.Point(242, 463);
            this.txtData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(447, 128);
            this.txtData.TabIndex = 24;
            // 
            // btnDecode
            // 
            this.btnDecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.btnDecode.FlatAppearance.BorderSize = 0;
            this.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecode.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnDecode.ForeColor = System.Drawing.Color.White;
            this.btnDecode.Image = global::GymManagementSystem.Properties.Resources.icons8_Paint_Bucket_With_QR_24px1;
            this.btnDecode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecode.Location = new System.Drawing.Point(380, 404);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(164, 38);
            this.btnDecode.TabIndex = 25;
            this.btnDecode.Text = "Decode QR";
            this.btnDecode.UseVisualStyleBackColor = false;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Image = global::GymManagementSystem.Properties.Resources.icons8_image_16px;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(380, 322);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(164, 38);
            this.btnBrowse.TabIndex = 20;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(341, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // QRDecoding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QRDecoding";
            this.Size = new System.Drawing.Size(957, 663);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnDecode;
    }
}
