using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR06_ArithmeticOps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num = int.Parse(Console.ReadLine());

            double square = num *  num;

            Console.WriteLine("Square of number entered is: " + square);

            double cube = Math.Pow(num, 3);
            Console.WriteLine("Cube of number entered is: " + cube);
            Console.ReadLine();
        }
    }
}
