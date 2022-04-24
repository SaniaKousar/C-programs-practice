using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liobrary Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a value ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square root of " + a + " is " +Math.Sqrt(a));
            Console.ReadLine();
        }
    }
}
