using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstnumber = double.Parse(Console.ReadLine());
            string mark = Console.ReadLine();
            double secondnumber = double.Parse(Console.ReadLine());
            if (mark == "+")
            {
                Console.WriteLine(firstnumber + secondnumber);
            }
            if (mark == "-")
            {
                Console.WriteLine(firstnumber - secondnumber);
            }
            if (mark == "*")
            {
                Console.WriteLine(firstnumber * secondnumber);
            }
            else
            {
                Console.WriteLine(firstnumber / secondnumber);
            }    
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
