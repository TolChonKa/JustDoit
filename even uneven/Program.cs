using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_uneven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string mark = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
            switch (mark)
            {
                case "+":
                    {
                    Console.WriteLine(a + b);
                    break;
                    }
                    case "-":
                    Console.WriteLine(a - b);
                    break;

                case "*":
                    Console.WriteLine(a * b);
                    break;
                default:
                    Console.Write(a / b);
                    break;
            }
            Console.ReadLine();
            

        }
    }
}
