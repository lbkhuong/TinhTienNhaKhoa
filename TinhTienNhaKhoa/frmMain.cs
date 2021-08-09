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

            if (!nameCheck.TextBoxBlankCheck(txtName))
            {
                epvNameCheck.SetError(txtName, "Tên không được bỏ trống!");
                return false;
            }
            /*else
            {
                epvNameCheck.Clear();
                return true;
            }*/
            epvNameCheck.SetError(txtName, "");//t sửa này được ko
            return true;
        }
    }
}
