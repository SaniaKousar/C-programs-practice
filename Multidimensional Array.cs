using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Array.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x = { { 9, 2, 8 }, { 3, 6, 7 } };
            for(int r=0;r<2;r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.WriteLine(x[r, c]);
                }
            }
            Console.ReadLine();
        }
        
    }
}
