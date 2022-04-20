using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if.else_example_1
{
    class Program
    {
        static void Main()
        {
            int a;
            Console.WriteLine("Enter a value");
            a = Convert.ToInt32((Console.ReadLine()));
            if (a == 10)
            {
                Console.WriteLine("Value entered is 10");
            }
            if (a < 10)
            {
                Console.WriteLine("Value entered is less than 10");
            }

            if(a > 10)
            {
                Console.WriteLine("Value entered is greater than 10");
            }
            Console.ReadLine();
        }
    }
}
