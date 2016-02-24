using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonehageSamples
{
    public static class CheckerBoard
    {

        public static string CreateChecker()
        {
            var sb = new StringBuilder();
            const string white = "White";
            const string black = "Black";

            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    sb.Append("-");
                    if (r % 2 == 0)
                    {
                        sb.Append(c % 2 == 0 ? white : black);
                    }
                    else
                    {
                        sb.Append(c % 2 != 0 ? white : black);
                    }
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

    }
}