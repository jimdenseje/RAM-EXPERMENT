using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAM_EXPERMENT
{
    public class String
    {
        int x = 0;
        public String(string s) {
            x = Ram.Offset;
            int y = s.Length + Ram.Offset;
            for (int c = x; c < y; c++) {
                Ram.Write(c, s[c - x]);
            }
            Ram.Write(y, null);

        }

        public void PrintString() {
            for (int c = x; true; c++)
            {
                char? buffer = Ram.Read(c);
                if (buffer == null)
                {
                    break;
                }
                Console.Write(buffer);
            }
            Console.WriteLine();
        }
    }
}
