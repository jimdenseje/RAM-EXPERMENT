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
        int y = 0;
        public String(string s) {
            this.x = Ram.Offset;
            this.y = s.Length + Ram.Offset;
            for (int c = this.x; c < this.y; c++) {
                Ram.Write(c, s[c - this.x]);
            }
            Ram.Write(this.y, null);

        }

        public void PrintString() {
            for (int c = this.x; c < this.y; c++)
            {
                Console.Write(Ram.Read(c));
            }
            Console.WriteLine();
        }
    }
}
