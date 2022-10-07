using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace lineComparison
{
    internal class lineUC1
    {
        public static int UC1(int x1, int y1, int x2, int y2)
        {
            int length = (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Lenght of Line is :" + length);
            return length;
        }
    }
}