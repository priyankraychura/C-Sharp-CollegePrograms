using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR10_RevNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;
            int reminder;

            while (num != 0)
            {
                reminder = num % 10;
                reverse = reverse * 10 + reminder;
                num = num / 10;
            }

            Console.Write("Reverse of the entered number is: " + reverse);
            Console.ReadLine();
        }
    }
}
