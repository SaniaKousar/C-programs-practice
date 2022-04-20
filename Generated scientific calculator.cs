using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generated_Scientific_Calculater
{
    class Program
    {
        static void Main()
        {
            int a, b;
            char ch;

            Console.WriteLine("Enter 1st value");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd value");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Add\n");
            Console.WriteLine("2. Subtract\n");
            Console.WriteLine("3. Multiply\n");
            Console.WriteLine("4. Divide\n");

        again:
            Console.WriteLine("Enter your choice(1-4)");
            ch =Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case '1':
                case 'A':
                case 'a':
                    Console.WriteLine(a +"+" +b +"=" + (a + b));
                    break;

                case '2':
                case 'S':
                case 's':
                    Console.WriteLine(a +"-" +b +"=" + (a - b));
                    break;

                case '3':
                case 'M':
                case 'm':
                    Console.WriteLine(a +"X" +b +"=" + (a * b));
                    break;

                case '4':
                case 'D':
                case 'd':
                    Console.WriteLine(a +"/" +b +"=" + (a / b));
                    break;
                default:
                    Console.WriteLine("Wrong Choice\n");
                    goto again;

            }
            Console.ReadLine();

        }
    }
}
