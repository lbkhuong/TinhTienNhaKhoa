using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinhTienNhaKhoa.Check;

namespace TinhTienNhaKhoa
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            NameValidating(sender);
        }

        private bool NameValidating(object sender)
        {
            TextBox txtName = (TextBox)sender;

            Check.NameCheck nameCheck = new Check.NameCheck();

            if (!nameCheck.BlankCheck(txtName))
            {
                epvNameCheck.SetError(txtName, "Họ tên không được để trống!");
                btnTinhTien.Enabled = false;
                return false;
            }

            if (!nameCheck.NumAndSpecCharCheck(txtName))
            {
                epvNameCheck.SetError(txtName, "Họ tên không được có số hay ký tự đặc biệt!");
                btnTinhTien.Enabled = false;
                return false;
            }

            btnTinhTien.Enabled = true;

            epvNameCheck.Clear();

            return true;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            float tongTien = 0;

            if (ckbTienTramRang.Checked == true)
            {
                tongTien += 200000;
            }

            if (ckbTienCaoVoi.Checked == true)
            {
                tongTien += 300000;
            }

            byte soRang = (byte)nudSoRangNho.Value;

            tongTien = tongTien + soRang * 100000;

            if (tongTien == 0)
            {
                MessageBox.Show("Bạn chưa nhập bất kỳ mục dịch vụ nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtTongTien.Text = tongTien.ToString();
        }

        private void txtHoTen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ckbTienTramRang.Focus();
            }
        }
    }
}
