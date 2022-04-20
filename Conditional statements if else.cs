using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if.else_example_2
{
    class Program
    {
        static void Main()
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Enter values for a, b and c ");
            a = Convert.ToInt32((Console.ReadLine()));
            b = Convert.ToInt32((Console.ReadLine()));
            c = Convert.ToInt32((Console.ReadLine()));
            if (a == b)
                if (b == c)
                    Console.WriteLine("a, b and c are equal ");
                else
                    Console.WriteLine("b and c are not equal");
            else
                Console.WriteLine("a and b are not equal ");

            Console.ReadLine();

        }
    }
}
