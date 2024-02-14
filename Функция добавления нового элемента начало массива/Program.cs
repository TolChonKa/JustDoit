using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функции2
{
    internal class Program
    {
        static void firstMassiv(ref int[] array, int newEl)
        {
            int a = array.Length + 1;
            int [] myArray = new int[a];
            for (int i = 1; i <= array.Length; i++)
            {
                myArray[0] = newEl;
                myArray[i] = array[i-1];
            }
            array = myArray;
        }


        static void Main(string[] args)
        {
            int[] myarray = { 1, 2, 3};
            firstMassiv(ref myarray, 3);


        } 
    }
}
