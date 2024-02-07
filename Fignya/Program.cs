using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fignya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int q = int.Parse(a);
            string b = Console.ReadLine();
            int w = int.Parse(b);
            string c = Console.ReadLine();
            int e = int.Parse(c);
            int result = q + w + e;
            Console.WriteLine(result);
            int multi = q * w * e;
            Console.WriteLine(multi);
            Console.ReadLine();



        }
    }
}
