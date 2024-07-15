
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.cs
{
    internal class Dimensional
    {
        static void Main()
        {
            int[,] matrix = new int[3, 3]; 
          
            matrix[0, 0] = 11;
            matrix[0, 1] = 12;
            matrix[0, 2] = 12;

            matrix[1, 0] = 13;
            matrix[1, 1] = 14;
            matrix[1, 2] = 14;

            matrix[2, 0] = 15;
            matrix[2, 1] = 16;
            matrix[2, 2] = 14;
           
            foreach (var m in matrix)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();
            
            for (int m= 0; m < 3; m++)



            {
                for (int n = 0; n < 3; n++)
                {
                    Console.Write(matrix[m,n] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
