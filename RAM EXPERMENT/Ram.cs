using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAM_EXPERMENT
{
    public static class Ram
    {
        private static char?[] Context = new char?[512];
        public static char? Read(int x) {
            return Context[x];
        }
        public static void Write(int x, char? y)
        {
            Context[x] = y;
            Offset++;
        }
        public static string ReadAll()
        {
            string output = "";
            for (int x = 0; true; x++) { 
                if (Context[x] == null) {
                    break;
                }
                output += Context[x];
            }
            return output;
        }
        public static int Offset = 0;
    }
}
