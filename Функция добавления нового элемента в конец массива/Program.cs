using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace функция_добавления_нового_элемента_в_конец_массива
{
    internal class Program
    {
        static void lastMassiv(ref int[] array, int newEl)
        {
            int a = array.Length + 1;
            int[] newArray = new int[a];
            for (int i = array.Length - 1; i >= 0 ; i--) 
            {
                newArray[array.Length] = newEl;
                newArray[i] = array[i];
            }
            array = newArray;
        }


        static void Main(string[] args)
        {
            int[] myarray = { 1, 2, 3 };
            lastMassiv(ref myarray, 3);


        }
    }
}
