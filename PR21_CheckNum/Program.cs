using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR21_CheckNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            bool isTrue = (num1 < 100 && num2 > 200 || num1 > 200 && num2 <100);

            if(isTrue)
            {
                Console.WriteLine("Condition satisfied.");
            }
            else
            {
                Console.WriteLine("Don't satisfy condition.");
            }
            Console.ReadLine();
        }
    }
}
