namespace Đề_1_720_2212404_PhamKhanhLinh
{
    partial class frmMonHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.nudSoTC = new System.Windows.Forms.NumericUpDown();
            this.cbbDT = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chương trình ĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tín chỉ";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(136, 24);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(201, 20);
            this.txtMaMH.TabIndex = 4;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(136, 53);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(201, 20);
            this.txtTenMH.TabIndex = 5;
            // 
            // nudSoTC
            // 
            this.nudSoTC.Location = new System.Drawing.Point(137, 118);
            this.nudSoTC.Name = "nudSoTC";
            this.nudSoTC.Size = new System.Drawing.Size(200, 20);
            this.nudSoTC.TabIndex = 6;
            // 
            // cbbDT
            // 
            this.cbbDT.FormattingEnabled = true;
            this.cbbDT.Location = new System.Drawing.Point(136, 83);
            this.cbbDT.Name = "cbbDT";
            this.cbbDT.Size = new System.Drawing.Size(201, 21);
            this.cbbDT.TabIndex = 7;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(161, 171);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 228);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbbDT);
            this.Controls.Add(this.nudSoTC);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMonHoc";
            this.Text = "Môn Học";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.NumericUpDown nudSoTC;
        private System.Windows.Forms.ComboBox cbbDT;
        private System.Windows.Forms.Button btnLuu;
    }
}

