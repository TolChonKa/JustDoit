using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функции_по_удалению_элемента_из_массива
{
    internal class Program
    {
         static void firstMassiv(ref int[] array, int delEl)
        {
            int a = array.Length - 1;
            int[] myArray = new int[a];
            for (int i = 0; i < delEl; i++)
            {
                myArray[i] = array[i];
                if(i == delEl)
                {
                    continue;
                }
            }
            for (int k = delEl; k < array.Length - 1; k++)
            {
                myArray[k] = array[k+1];
            }
            array = myArray;
        }
        

       
        static void firstelement(ref int[] array)
        {
            firstMassiv(ref array, 0);
            
        }

        static void secondelement(ref int[] array)
        {
           firstMassiv(ref array, array.Length - 1);

        }

        static void Main(string[] args)
        {
            int[] myarray = { 1, 2, 3 };
            secondelement(ref myarray);


        }
    }
}
