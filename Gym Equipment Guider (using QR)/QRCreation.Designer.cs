namespace GymManagementSystem
{
    partial class QRCreation
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSaveQR = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNewEntry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label1.Location = new System.Drawing.Point(222, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equiment Name :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(414, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(377, 28);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Creation of QR Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtDesc.Location = new System.Drawing.Point(414, 154);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(377, 137);
            this.txtDesc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label2.Location = new System.Drawing.Point(180, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Equiment Description :";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtLink.Location = new System.Drawing.Point(414, 329);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(377, 28);
            this.txtLink.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(325, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Link :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 585);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 273);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.lblID.Location = new System.Drawing.Point(257, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 21);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // btnSaveQR
            // 
            this.btnSaveQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.btnSaveQR.FlatAppearance.BorderSize = 0;
            this.btnSaveQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveQR.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnSaveQR.ForeColor = System.Drawing.Color.White;
            this.btnSaveQR.Image = global::GymManagementSystem.Properties.Resources.icons8_save_16px;
            this.btnSaveQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveQR.Location = new System.Drawing.Point(948, 405);
            this.btnSaveQR.Name = "btnSaveQR";
            this.btnSaveQR.Size = new System.Drawing.Size(219, 47);
            this.btnSaveQR.TabIndex = 18;
            this.btnSaveQR.Text = "Save QR";
            this.btnSaveQR.UseVisualStyleBackColor = false;
            this.btnSaveQR.Click += new System.EventHandler(this.btnSaveQR_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::GymManagementSystem.Properties.Resources.icons8_refresh_24px;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(1015, 504);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(184, 47);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(901, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Image = global::GymManagementSystem.Properties.Resources.icons8_create_24px;
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.Location = new System.Drawing.Point(507, 405);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(219, 47);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate QR";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::GymManagementSystem.Properties.Resources.icons8_Delete_16px;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(776, 504);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(184, 47);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::GymManagementSystem.Properties.Resources.icons8_Female_User_Update_24px;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(542, 504);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 47);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::GymManagementSystem.Properties.Resources.icons8_add_16px;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(302, 504);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 47);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.btnNewEntry.FlatAppearance.BorderSize = 0;
            this.btnNewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEntry.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnNewEntry.ForeColor = System.Drawing.Color.White;
            this.btnNewEntry.Image = global::GymManagementSystem.Properties.Resources.icons8_empty_holding_hand_32px;
            this.btnNewEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewEntry.Location = new System.Drawing.Point(74, 504);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(184, 47);
            this.btnNewEntry.TabIndex = 8;
            this.btnNewEntry.Text = "New Entry";
            this.btnNewEntry.UseVisualStyleBackColor = false;
            this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
            // 
            // QRCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSaveQR);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNewEntry);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "QRCreation";
            this.Size = new System.Drawing.Size(1286, 861);
            this.Load += new System.EventHandler(this.QRCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewEntry;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSaveQR;
    }
}
