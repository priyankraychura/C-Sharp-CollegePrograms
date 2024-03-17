using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR03_MaxNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is the max number");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + " is the max number");
            }
            else
            {
                Console.WriteLine(num3 + " is the max number");
            }

            Console.ReadLine();
        }
    }
}
