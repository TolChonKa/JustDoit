using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace def
{
    internal class Program
    {
       static void Print(string a, uint b)
        {
            for (int i = 0; i < b; i++) 
            {
                Console.Write(a);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            string simbol = Console.ReadLine();          
            Console.Write("Введите сколько раз: ");
            uint Volue = uint.Parse(Console.ReadLine());
            Console.Write("Вывод: ");
            Print(simbol, Volue);
            Console.Read();
            Console.Read();
        }
    }
}
