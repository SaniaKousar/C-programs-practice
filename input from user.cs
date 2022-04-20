using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_from_user
{
    class Program
    {
        static void Main()
        {
            int a;
            int b;

            Console.WriteLine("Please enter value one");
            a = Convert.ToInt32(( Console.ReadLine()));

            Console.WriteLine("Please enter value two");
            b = Convert.ToInt32((Console.ReadLine()));

            int sum = a + b;
            Console.WriteLine("The Result is " + sum);

            Console.ReadLine();
        }
    }
}
