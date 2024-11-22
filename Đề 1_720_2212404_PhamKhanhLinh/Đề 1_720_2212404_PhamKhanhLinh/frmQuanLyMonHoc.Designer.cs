namespace Đề_1_720_2212404_PhamKhanhLinh
{
    partial class frmQuanLyMonHoc
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
            this.grbCTDT = new System.Windows.Forms.GroupBox();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rdTatCa = new System.Windows.Forms.RadioButton();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.txtSoTC = new System.Windows.Forms.TextBox();
            this.rdSoTC = new System.Windows.Forms.RadioButton();
            this.rdMaTenMH = new System.Windows.Forms.RadioButton();
            this.grbDSMH = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvDanhSachMH = new System.Windows.Forms.ListView();
            this.txtMaMH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTenMH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbCTDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudSoTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbCTDT.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.grbDSMH.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCTDT
            // 
            this.grbCTDT.Controls.Add(this.rd3);
            this.grbCTDT.Controls.Add(this.rd2);
            this.grbCTDT.Controls.Add(this.rd1);
            this.grbCTDT.Controls.Add(this.rdTatCa);
            this.grbCTDT.Location = new System.Drawing.Point(43, 13);
            this.grbCTDT.Name = "grbCTDT";
            this.grbCTDT.Size = new System.Drawing.Size(436, 55);
            this.grbCTDT.TabIndex = 0;
            this.grbCTDT.TabStop = false;
            this.grbCTDT.Text = "Chọn chương trình đào tạo";
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(293, 20);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(49, 17);
            this.rd3.TabIndex = 3;
            this.rd3.TabStop = true;
            this.rd3.Text = "2020";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(202, 20);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(49, 17);
            this.rd2.TabIndex = 2;
            this.rd2.TabStop = true;
            this.rd2.Text = "2017";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(111, 19);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(49, 17);
            this.rd1.TabIndex = 1;
            this.rd1.TabStop = true;
            this.rd1.Text = "2015";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // rdTatCa
            // 
            this.rdTatCa.AutoSize = true;
            this.rdTatCa.Location = new System.Drawing.Point(20, 20);
            this.rdTatCa.Name = "rdTatCa";
            this.rdTatCa.Size = new System.Drawing.Size(56, 17);
            this.rdTatCa.TabIndex = 0;
            this.rdTatCa.TabStop = true;
            this.rdTatCa.Text = "Tất cả";
            this.rdTatCa.UseVisualStyleBackColor = true;
            this.rdTatCa.CheckedChanged += new System.EventHandler(this.rdTatCa_CheckedChanged);
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.txtSoTC);
            this.grbTimKiem.Controls.Add(this.rdSoTC);
            this.grbTimKiem.Controls.Add(this.rdMaTenMH);
            this.grbTimKiem.Location = new System.Drawing.Point(43, 88);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(436, 55);
            this.grbTimKiem.TabIndex = 1;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // txtSoTC
            // 
            this.txtSoTC.Location = new System.Drawing.Point(216, 20);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.Size = new System.Drawing.Size(194, 20);
            this.txtSoTC.TabIndex = 2;
            // 
            // rdSoTC
            // 
            this.rdSoTC.AutoSize = true;
            this.rdSoTC.Location = new System.Drawing.Point(124, 20);
            this.rdSoTC.Name = "rdSoTC";
            this.rdSoTC.Size = new System.Drawing.Size(81, 17);
            this.rdSoTC.TabIndex = 1;
            this.rdSoTC.TabStop = true;
            this.rdSoTC.Text = "Theo số TC";
            this.rdSoTC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdSoTC.UseVisualStyleBackColor = true;
            // 
            // rdMaTenMH
            // 
            this.rdMaTenMH.AutoSize = true;
            this.rdMaTenMH.Checked = true;
            this.rdMaTenMH.Location = new System.Drawing.Point(11, 20);
            this.rdMaTenMH.Name = "rdMaTenMH";
            this.rdMaTenMH.Size = new System.Drawing.Size(107, 17);
            this.rdMaTenMH.TabIndex = 0;
            this.rdMaTenMH.TabStop = true;
            this.rdMaTenMH.Text = "Theo mã/tên MH";
            this.rdMaTenMH.UseVisualStyleBackColor = true;
            // 
            // grbDSMH
            // 
            this.grbDSMH.Controls.Add(this.lvDanhSachMH);
            this.grbDSMH.Controls.Add(this.btnAdd);
            this.grbDSMH.Location = new System.Drawing.Point(21, 174);
            this.grbDSMH.Name = "grbDSMH";
            this.grbDSMH.Size = new System.Drawing.Size(478, 170);
            this.grbDSMH.TabIndex = 2;
            this.grbDSMH.TabStop = false;
            this.grbDSMH.Text = "Danh sách môn học";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(449, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 22);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvDanhSachMH
            // 
            this.lvDanhSachMH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.txtMaMH,
            this.txtTenMH,
            this.cbbCTDT,
            this.nudSoTC});
            this.lvDanhSachMH.FullRowSelect = true;
            this.lvDanhSachMH.HideSelection = false;
            this.lvDanhSachMH.Location = new System.Drawing.Point(0, 38);
            this.lvDanhSachMH.MultiSelect = false;
            this.lvDanhSachMH.Name = "lvDanhSachMH";
            this.lvDanhSachMH.Size = new System.Drawing.Size(472, 119);
            this.lvDanhSachMH.TabIndex = 1;
            this.lvDanhSachMH.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachMH.View = System.Windows.Forms.View.Details;
            this.lvDanhSachMH.SelectedIndexChanged += new System.EventHandler(this.lvDanhSachMH_SelectedIndexChanged);
            // 
            // txtMaMH
            // 
            this.txtMaMH.Text = "Mã môn học";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Text = "Tên môn học";
            // 
            // cbbCTDT
            // 
            this.cbbCTDT.Text = "Chương trình đào tạo";
            // 
            // nudSoTC
            // 
            this.nudSoTC.Text = "Số tín chỉ";
            // 
            // frmQuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 343);
            this.Controls.Add(this.grbDSMH);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.grbCTDT);
            this.Name = "frmQuanLyMonHoc";
            this.Text = "Quản lý môn học";
            this.grbCTDT.ResumeLayout(false);
            this.grbCTDT.PerformLayout();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.grbDSMH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCTDT;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.GroupBox grbDSMH;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rdTatCa;
        private System.Windows.Forms.TextBox txtSoTC;
        private System.Windows.Forms.RadioButton rdSoTC;
        private System.Windows.Forms.RadioButton rdMaTenMH;
        private System.Windows.Forms.ListView lvDanhSachMH;
        private System.Windows.Forms.ColumnHeader txtMaMH;
        private System.Windows.Forms.ColumnHeader txtTenMH;
        private System.Windows.Forms.ColumnHeader cbbCTDT;
        private System.Windows.Forms.ColumnHeader nudSoTC;
    }
}