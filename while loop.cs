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
            int a = 1;
            while(a<=10)
            {
                Console.WriteLine(a+"\t" +(11-a));
                a++;

                Console.ReadLine();
            }
        }
    }
}
