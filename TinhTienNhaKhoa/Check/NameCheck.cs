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
        public bool TextBoxBlankCheck(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                return false;
            }

            return true;
        }

        public bool TextBoxHaveNumberCheck(TextBox textBox)
        {
            string s = textBox.Text.ToString();

            for (int i = 0; i <= s.Length; i++)
            {
                for (char C = 'A'; C <= 'Z'; C++)
                {
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        if (s[i] != c || s[i] != C)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
