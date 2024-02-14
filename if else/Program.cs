using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for(int i = 0; i < 10; i++)
            {        
                for (int l = 0; l <= i; l++)
                {
                    Console.Write("#");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();


            for (int r = 0; r < 10; r++)
            {
                for (int k = 10; k > r; k--)
                {
                    Console.Write("#");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();


            for (int b = 0; b < 10; b++)
            {
                for (int j = 9; b <= j; j--)
                {
                    Console.Write(" ");

                }
               
                for (int z = 0; b >= z; z++)
                {
                    Console.Write("#");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();


            for (int b = 0; b < 10; b++)
            {
                
                for (int j = 0; b > j; j++)
                {
                    Console.Write(" ");

                }
                
                for (int z = 10; b < z; z--)
                {
                    Console.Write("#");

                }
                Console.WriteLine();
            }
            Console.ReadLine();



        }
    }
}
