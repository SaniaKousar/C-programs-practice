using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for.loop_example_1
{
    class Program
    {
        static void Main()
        {
           int t;
            Console.WriteLine("Enter table value ");
            t = Convert.ToInt32(Console.ReadLine());

            for (int a = 1; a <= 10; a++)
            {
                Console.WriteLine(t+" X " +a+" = "+(t * a));
            }
            Console.ReadLine();

        }
    }
}
