using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonehageSamples
{
    public static class Fibonatcci
    {
        public static int GetValue(int n)
        {
            var result = 1;
            var n1 = 1;
            var n2 = 0;
            for (int i = 0; i < n; i++)
            {
                result = n1 + n2;
                n2 = n1;
                n1 = result;
            }
            return result;
        }
    }
}
