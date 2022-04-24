using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 7;
            float weight = 200.7F;
            double totalweight = count * weight;
            Console.WriteLine("Total weight calculated is " + totalweight);
            Console.ReadLine();

        }
    }
}
