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
            int a = 15;
            while(a<1 || a>10)
            {
                Console.WriteLine("Enter a value (1_10)");
                a =Convert.ToInt32(Console.ReadLine());
            }
            
                Console.WriteLine("Value enterd is between 1 -10");
                Console.ReadLine();
       
            }
        }
    }
