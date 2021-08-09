
namespace TinhTienNhaKhoa
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDVSD = new System.Windows.Forms.Label();
            this.lblTTNK = new System.Windows.Forms.Label();
            this.lblCaoVoi = new System.Windows.Forms.Label();
            this.lblTramRang = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.ckbTienTramRang = new System.Windows.Forms.CheckBox();
            this.ckbTienCaoVoi = new System.Windows.Forms.CheckBox();
            this.lblNhoRang = new System.Windows.Forms.Label();
            this.lblDonGiaNhoRang = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.nudSoRangNho = new System.Windows.Forms.NumericUpDown();
            this.epvNameCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoRangNho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvNameCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoTen.Location = new System.Drawing.Point(86, 67);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(72, 20);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ Tên:";
            // 
            // lblDVSD
            // 
            this.lblDVSD.AutoSize = true;
            this.lblDVSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDVSD.Location = new System.Drawing.Point(86, 110);
            this.lblDVSD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDVSD.Name = "lblDVSD";
            this.lblDVSD.Size = new System.Drawing.Size(147, 20);
            this.lblDVSD.TabIndex = 1;
            this.lblDVSD.Text = "Dịch Vụ Sử Dụng";
            // 
            // lblTTNK
            // 
            this.lblTTNK.AutoSize = true;
            this.lblTTNK.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTTNK.Location = new System.Drawing.Point(193, 20);
            this.lblTTNK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTTNK.Name = "lblTTNK";
            this.lblTTNK.Size = new System.Drawing.Size(222, 24);
            this.lblTTNK.TabIndex = 2;
            this.lblTTNK.Text = "TÍNH TIỀN NHA KHOA";
            // 
            // lblCaoVoi
            // 
            this.lblCaoVoi.AutoSize = true;
            this.lblCaoVoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCaoVoi.Location = new System.Drawing.Point(86, 183);
            this.lblCaoVoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaoVoi.Name = "lblCaoVoi";
            this.lblCaoVoi.Size = new System.Drawing.Size(73, 20);
            this.lblCaoVoi.TabIndex = 3;
            this.lblCaoVoi.Text = "Cạo Vôi :";
            // 
            // lblTramRang
            // 
            this.lblTramRang.AutoSize = true;
            this.lblTramRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTramRang.Location = new System.Drawing.Point(86, 146);
            this.lblTramRang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTramRang.Name = "lblTramRang";
            this.lblTramRang.Size = new System.Drawing.Size(96, 20);
            this.lblTramRang.TabIndex = 4;
            this.lblTramRang.Text = "Trám Răng :";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTen.Location = new System.Drawing.Point(194, 63);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(293, 26);
            this.txtHoTen.TabIndex = 5;
            this.txtHoTen.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoTen_Validating);
            // 
            // ckbTienTramRang
            // 
            this.ckbTienTramRang.AutoSize = true;
            this.ckbTienTramRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTienTramRang.Location = new System.Drawing.Point(194, 145);
            this.ckbTienTramRang.Margin = new System.Windows.Forms.Padding(2);
            this.ckbTienTramRang.Name = "ckbTienTramRang";
            this.ckbTienTramRang.Size = new System.Drawing.Size(112, 21);
            this.ckbTienTramRang.TabIndex = 6;
            this.ckbTienTramRang.Text = "200.000 VND";
            this.ckbTienTramRang.UseVisualStyleBackColor = true;
            // 
            // ckbTienCaoVoi
            // 
            this.ckbTienCaoVoi.AutoSize = true;
            this.ckbTienCaoVoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbTienCaoVoi.Location = new System.Drawing.Point(194, 182);
            this.ckbTienCaoVoi.Margin = new System.Windows.Forms.Padding(2);
            this.ckbTienCaoVoi.Name = "ckbTienCaoVoi";
            this.ckbTienCaoVoi.Size = new System.Drawing.Size(112, 21);
            this.ckbTienCaoVoi.TabIndex = 7;
            this.ckbTienCaoVoi.Text = "300.000 VND";
            this.ckbTienCaoVoi.UseVisualStyleBackColor = true;
            // 
            // lblNhoRang
            // 
            this.lblNhoRang.AutoSize = true;
            this.lblNhoRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhoRang.Location = new System.Drawing.Point(86, 222);
            this.lblNhoRang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhoRang.Name = "lblNhoRang";
            this.lblNhoRang.Size = new System.Drawing.Size(89, 20);
            this.lblNhoRang.TabIndex = 8;
            this.lblNhoRang.Text = "Nhổ Răng :";
            // 
            // lblDonGiaNhoRang
            // 
            this.lblDonGiaNhoRang.AutoSize = true;
            this.lblDonGiaNhoRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDonGiaNhoRang.Location = new System.Drawing.Point(248, 224);
            this.lblDonGiaNhoRang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonGiaNhoRang.Name = "lblDonGiaNhoRang";
            this.lblDonGiaNhoRang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDonGiaNhoRang.Size = new System.Drawing.Size(198, 18);
            this.lblDonGiaNhoRang.TabIndex = 9;
            this.lblDonGiaNhoRang.Text = "(đơn giá 100.000 VND / răng)";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTongTien.Location = new System.Drawing.Point(86, 267);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(93, 20);
            this.lblTongTien.TabIndex = 11;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(194, 262);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(293, 26);
            this.txtTongTien.TabIndex = 12;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTinhTien.Location = new System.Drawing.Point(248, 307);
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(2);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(100, 35);
            this.btnTinhTien.TabIndex = 13;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.Tinh_Tien);
            // 
            // nudSoRangNho
            // 
            this.nudSoRangNho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudSoRangNho.Location = new System.Drawing.Point(194, 222);
            this.nudSoRangNho.Margin = new System.Windows.Forms.Padding(2);
            this.nudSoRangNho.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSoRangNho.Name = "nudSoRangNho";
            this.nudSoRangNho.Size = new System.Drawing.Size(50, 24);
            this.nudSoRangNho.TabIndex = 14;
            // 
            // epvNameCheck
            // 
            this.epvNameCheck.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "VND";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSoRangNho);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblDonGiaNhoRang);
            this.Controls.Add(this.lblNhoRang);
            this.Controls.Add(this.ckbTienCaoVoi);
            this.Controls.Add(this.ckbTienTramRang);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblTramRang);
            this.Controls.Add(this.lblCaoVoi);
            this.Controls.Add(this.lblTTNK);
            this.Controls.Add(this.lblDVSD);
            this.Controls.Add(this.lblHoTen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Tính Tiền Nha Khoa";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoRangNho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvNameCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDVSD;
        private System.Windows.Forms.Label lblTTNK;
        private System.Windows.Forms.Label lblCaoVoi;
        private System.Windows.Forms.Label lblTramRang;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.CheckBox ckbTienTramRang;
        private System.Windows.Forms.CheckBox ckbTienCaoVoi;
        private System.Windows.Forms.Label lblNhoRang;
        private System.Windows.Forms.Label lblDonGiaNhoRang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.NumericUpDown nudSoRangNho;
        private System.Windows.Forms.ErrorProvider epvNameCheck;
        private System.Windows.Forms.Label label1;
    }
}

