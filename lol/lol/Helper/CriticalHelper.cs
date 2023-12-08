using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol.Helper
{
    public static class CriticalHelper
    {
        public static double Ranbom(int critical)
        {
            var ranbom = new Random();

            var result = ranbom.Next(0, critical);

            return result;
        }
    }
}
