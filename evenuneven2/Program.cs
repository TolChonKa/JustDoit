using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenuneven2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int count3 = 0;
            int count2 = 0;
            Console.WriteLine("Введите какое число вы хотите проверить на четность и нечетность:");
            int number = int.Parse(Console.ReadLine());
            while (count < number)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверно!");
                    Console.ReadLine();
                    continue;
                }
                count++;
                if (count % 2 == 0)
                {
                    count3++;
                }
                else
                {
                    count2++;
                }
            }
            Console.WriteLine(count3 + " Четных чисел");
            Console.WriteLine(count2 + " Нечетных чисел");
            Console.ReadLine();



        }
    }
}
