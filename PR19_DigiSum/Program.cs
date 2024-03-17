using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR19_DigiSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int reminder, sum = 0;

            while (num != 0)
            {
                reminder = num % 10;
                sum = sum + reminder;
                num = num / 10;
            }

            Console.WriteLine("Sum of the entered number's digit is: " + sum);
            Console.ReadLine();
        }
    }
}
