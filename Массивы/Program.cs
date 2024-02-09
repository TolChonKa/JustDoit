using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите колличество переменных в массиве: ");
            int a = int.Parse(Console.ReadLine());
            int[] Array = new int[a];
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write($"Введите число под инексом {i}: ");
                Array[i] = int.Parse(Console.ReadLine()); 
            }
            
            Console.WriteLine("Вывод массива:");
            for (int i = Array.Length - 1; i < Array.Length;i--) 
            {
                Console.WriteLine(Array[i]);
            }
            Console.Read();
        }
    }
}
