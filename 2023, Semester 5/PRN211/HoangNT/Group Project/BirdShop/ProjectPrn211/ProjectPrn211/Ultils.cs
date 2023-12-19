using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSAPP
{
    public class Ultils
    {
        public static bool IsEmptyString(string str)
        { return (str == null || str.Length == 0); }

        public static bool CheckLengthString(string str, int min, int max)
        { return (str.Length >= min && str.Length <= max); }
    }
}
