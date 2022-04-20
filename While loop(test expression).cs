using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while loop
{
    class Program
    {
        static void Main()
        {
            int a = 15;
            while(a<1 || a>10)
            {
                Console.WriteLine("Enter a value (1-10)");
                a =Convert.ToInt32(Console.ReadLine());
            }
            
                Console.WriteLine("Value enterd is between 1 -10");
                Console.ReadLine();
       
            }
        }
    }
