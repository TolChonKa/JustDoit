using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функция_добавления_эелемента_под_опр_индексом_в_массиве
{
    internal class Program
    {
        static void firstMassiv(ref int[] array, int newEl, int index)
        {
            int a = array.Length + 1;
            int[] myArray = new int[a];
            myArray[index] = newEl;
            for (int i = 0 ; i < index; i++)
            {
                myArray[i] = array[i];       
            }
            for (int k = index; k < array.Length; k++)
            {
               myArray[k + 1] = array[k];
            }
            array = myArray;
        }

        
        static void Main(string[] args)
        {
            int[] myarray = { 1, 2, 3, 4};
            firstMassiv(ref myarray, 623, 2);


        }
    }
    
}
