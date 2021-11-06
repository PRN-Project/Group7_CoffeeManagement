using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.Utils
{
    public static class DisplayTextExtension
    {
        public static string ToDisplayText (this decimal number)
        {
            return String.Format(CultureInfo.InvariantCulture, "{0:0,0}", number);
        }

        public static string ToDisplayText(this double number)
        {
            return String.Format(CultureInfo.InvariantCulture, "{0:0,0}", number);
        }
    }
}
