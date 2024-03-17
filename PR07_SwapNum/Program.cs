using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR07_SwapNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a num 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a num 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swaping: num1= " + num1 + " and num2= " + num2);
            Console.ReadLine();
        }
    }
}
