namespace GymManagementSystem
{
    partial class Report
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
            this.lblcnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEID = new System.Windows.Forms.Label();
            this.dataGridViewAddProduct = new System.Windows.Forms.DataGridView();
            this.cbSearchData = new System.Windows.Forms.ComboBox();
            this.lblMobno = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcnt
            // 
            this.lblcnt.AutoSize = true;
            this.lblcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcnt.ForeColor = System.Drawing.Color.Black;
            this.lblcnt.Location = new System.Drawing.Point(248, 655);
            this.lblcnt.Name = "lblcnt";
            this.lblcnt.Size = new System.Drawing.Size(20, 24);
            this.lblcnt.TabIndex = 215;
            this.lblcnt.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(121, 655);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 214;
            this.label1.Text = "Total Count : ";
            // 
            // lblEID
            // 
            this.lblEID.AutoSize = true;
            this.lblEID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEID.ForeColor = System.Drawing.Color.Black;
            this.lblEID.Location = new System.Drawing.Point(997, 286);
            this.lblEID.Name = "lblEID";
            this.lblEID.Size = new System.Drawing.Size(27, 24);
            this.lblEID.TabIndex = 213;
            this.lblEID.Text = "ID";
            this.lblEID.Visible = false;
            // 
            // dataGridViewAddProduct
            // 
            this.dataGridViewAddProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddProduct.Location = new System.Drawing.Point(89, 362);
            this.dataGridViewAddProduct.Name = "dataGridViewAddProduct";
            this.dataGridViewAddProduct.RowTemplate.Height = 24;
            this.dataGridViewAddProduct.Size = new System.Drawing.Size(1131, 260);
            this.dataGridViewAddProduct.TabIndex = 210;
            this.dataGridViewAddProduct.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAddProduct_RowHeaderMouseDoubleClick);
            // 
            // cbSearchData
            // 
            this.cbSearchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbSearchData.FormattingEnabled = true;
            this.cbSearchData.Items.AddRange(new object[] {
            "Bill No.",
            "Customer Name",
            "Mobile No.",
            "Date Vise"});
            this.cbSearchData.Location = new System.Drawing.Point(500, 173);
            this.cbSearchData.Name = "cbSearchData";
            this.cbSearchData.Size = new System.Drawing.Size(345, 30);
            this.cbSearchData.TabIndex = 208;
            // 
            // lblMobno
            // 
            this.lblMobno.AutoSize = true;
            this.lblMobno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobno.ForeColor = System.Drawing.Color.Black;
            this.lblMobno.Location = new System.Drawing.Point(364, 176);
            this.lblMobno.Name = "lblMobno";
            this.lblMobno.Size = new System.Drawing.Size(110, 24);
            this.lblMobno.TabIndex = 206;
            this.lblMobno.Text = "Select Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 37);
            this.label7.TabIndex = 201;
            this.label7.Text = "Equipment Details";
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.btnPrintAll.FlatAppearance.BorderSize = 0;
            this.btnPrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnPrintAll.ForeColor = System.Drawing.Color.White;
            this.btnPrintAll.Image = global::GymManagementSystem.Properties.Resources.icons8_exam_24px;
            this.btnPrintAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintAll.Location = new System.Drawing.Point(1036, 639);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(184, 55);
            this.btnPrintAll.TabIndex = 219;
            this.btnPrintAll.Text = "Print All";
            this.btnPrintAll.UseVisualStyleBackColor = false;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::GymManagementSystem.Properties.Resources.icons8_refresh_24px;
            this.btnRefresh.Location = new System.Drawing.Point(874, 172);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(49, 33);
            this.btnRefresh.TabIndex = 218;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::GymManagementSystem.Properties.Resources.icons8_print_16px;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(830, 639);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(184, 55);
            this.btnPrint.TabIndex = 212;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Image = global::GymManagementSystem.Properties.Resources.icons8_data_recovery_16px;
            this.btnShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAll.Location = new System.Drawing.Point(724, 235);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(184, 55);
            this.btnShowAll.TabIndex = 211;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::GymManagementSystem.Properties.Resources.icons8_search_24px;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(445, 235);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(184, 55);
            this.btnSearch.TabIndex = 209;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblcnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEID);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dataGridViewAddProduct);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchData);
            this.Controls.Add(this.lblMobno);
            this.Controls.Add(this.label7);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(1309, 774);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEID;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dataGridViewAddProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearchData;
        private System.Windows.Forms.Label lblMobno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPrintAll;
    }
}
