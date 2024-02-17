using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рекурсия
{
    internal class Program
    { 
        //Вывод суммы всех элементов массива с помощью рекурсии:

       /* static void Massiv(ref int[] newmassiv, int i = 0, int result = 0)
        {
            if (i < newmassiv.Length)
            {
                result += newmassiv[i];
                Massiv(ref newmassiv, i + 1, result);
            }
            else { Console.WriteLine(result); }
        }
        

        static void Main(string[] args)
        {
            int[] massiv = { 1, 2, 3, 4, 5, 6 };
            Massiv(ref massiv);
            
        }*/

///////////////////////////////////////////////////////////////////////////////////////////////////

       // Вывод суммы цифр любого числа с помощью рекурсии
        static void sumVolue(int volue, int number = 0, int result = 0)
        {
            if (volue != 0)
            {
                number = volue % 10;
                result += number;
                sumVolue(volue / 10, number, result);
            }
            else { Console.WriteLine(result); }
        }


        static void Main(string[] args)
        {
            int Volue = 0;
            sumVolue(Volue);

        }


    }
}
