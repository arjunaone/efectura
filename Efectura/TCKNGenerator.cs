using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Efectura
{
    public class TCKNGenerator
    {
        public static string Random()
        {
            Random random = new Random();
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11;
            n1 = random.Next(1, 10);
            n2 = random.Next(10);
            n3 = random.Next(10);
            n4 = random.Next(10);
            n5 = random.Next(10);
            n6 = random.Next(10);
            n7 = random.Next(10);
            n8 = random.Next(10);
            n9 = random.Next(10);
            n10 = ((n1 + n3 + n5 + n7 + n9) * 7 - (n2 + n4 + n6 + n8)) % 10;
            n11 = (n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10) % 10;
            return n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString() + n5.ToString() + n6.ToString() + n7.ToString() + n8.ToString() + n9.ToString() + n10.ToString() + n11.ToString();
        }
    }
}
