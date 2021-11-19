using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFormAppT110
{
    public static class Utilities
    {
        public static bool IsEmpty(string[] arr)
        {
            foreach (var ar in arr)
            {
                if (string.IsNullOrWhiteSpace(ar))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
