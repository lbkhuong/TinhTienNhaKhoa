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

        public bool NumAndSpecCharCheck(TextBox textBox)
        {
            string str = textBox.Text.ToString();

            char[] arrChar = new char[256];
            AddAsciiCode(arrChar);

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j <= 127; j++)
                {
                    if (str[i] == arrChar[j])
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }

        private void AddAsciiCode(char[] arrChar)
        {
            for (int i = 0; i <= 127; i++)
            {
                arrChar[i] = (char)i;

                if (i == 10 || i == 32)
                {
                    arrChar[i] = (char)64;
                }

                for (int n = 65; n <= 90; n++)
                {
                    if (i == n)
                    {
                        arrChar[i] = (char)64;
                        continue;
                    }
                }

                for (int n = 97; n <= 122; n++)
                {
                    if (i == n)
                    {
                        arrChar[i] = (char)64;
                        continue;
                    }
                }
            }
        }
    }
}
