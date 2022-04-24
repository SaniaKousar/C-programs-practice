using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_vs_Double_vs_Decimal.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 38.99F;
            double d = 48.77D;
            decimal d1 = 89.89M;
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine("float"+f +"\ndouble" +d +"\ndecimal" +d1);
            Console.ReadLine();

        }
    }
}
