using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функция_добавления_элемента_в_опр_индекс_в_массив
{
    internal class Program
    {
        static void firstMassiv(ref int[] array, int newEl)
        {
            int[] myArray = new int[newEl];
            for (int i = 0; i < array.Length && i < myArray.Length; i++)
            {
                myArray[i] = array[i];
            }
            array = myArray;
        }


        static void Main(string[] args)
        {
            int[] myarray = { 1, 2, 3 };
            firstMassiv(ref myarray, 2);


        }
    }
}
