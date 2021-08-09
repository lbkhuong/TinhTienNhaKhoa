using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienNhaKhoa.Check
{
    class NameCheck
    {
        public bool BlankCheck(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                return false;
            }

            return true;
        }

        public bool NumberCheck(TextBox textBox)
        {
            string str = textBox.Text.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                for (char j = '0'; j < '9'; j++)
                {
                    if (str[i] == j)
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }

        public bool SpecCharCheck(TextBox textBox)
        {
            return true;
        }
    }
}
