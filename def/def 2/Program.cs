using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace def_2
{
    internal class Program
    {
        static int Array(int[] myarray, int volue)
        {
            for (int i = 0; i < myarray.Length; i++) 
            { 
                if (myarray[i] == volue)
                {
                    return i;
                    
                }

            } 
            return -1;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите количество переменных в массиве: ");
            int a = int.Parse(Console.ReadLine());
            int[] myarray = new int[a];
            for (int i = 0; i < myarray.Length; i++) 
            {
                Console.Write($"\nВведите число под индексом {i}: ");
                myarray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nКакое значение вы хотите найти: ");
            int volue = int.Parse(Console.ReadLine());
            Console.Write("\nНайденный индекс: ");
            int k = Array(myarray, volue);
            Console.Write(k);
            Console.ReadLine();
        }
    }
}
