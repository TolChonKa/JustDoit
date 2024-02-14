using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace функции
{
    internal class Program
    {
        static void Resize(ref int[] array2, int newsize)
        {
            int[] newarray = new int[newsize];
            for (int i = 0; i < array2.Length && i < newarray.Length; i++)
            {
                newarray[i] = array2[i];
            }
            array2 = newarray;
        }

        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3 };
            Resize(ref array, 2);

        }
    
    }
}
