using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR04_EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine(num + " is even no.");
            else
                Console.WriteLine(num + " is odd no.");

            Console.ReadLine();
        }
    }
}
