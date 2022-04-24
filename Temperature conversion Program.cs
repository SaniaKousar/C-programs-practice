using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @Temperature Conversion Program.cs
{
    class Program
    {
        static void Main()
        {
            int fah;
            Console.WriteLine("Enter tempreture in Fahrenheit ");
            fah = Convert.ToInt32(Console.ReadLine());
            int cel = (fah - 32) * 5 / 2;
            Console.WriteLine("Equivalent tempreture in Celcius is " + cel);

                    Console.ReadLine( );

        }
    }
}
