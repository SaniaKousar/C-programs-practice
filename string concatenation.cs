using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_concatination
{
    class Program
    {
        static void Main()
        {
            string FirstName;
            string LastName;

            Console.WriteLine("Please enter FirstName ");
            FirstName = Console.ReadLine();

            Console.WriteLine("Please enter LastName ");
            LastName = Console.ReadLine();

            Console.WriteLine("My name is " + FirstName + LastName);//string concatenation

            Console.ReadLine();


        }
    }
}
