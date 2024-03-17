using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR14_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int reverse = 0;
            int reminder;

            while (temp != 0)
            {
                reminder = temp % 10;
                reverse = reverse * 10 + reminder;
                temp = temp / 10;
            }

            if (num == reverse)
            {
                Console.WriteLine("Palidrome number.");
            }
            else
            {
                Console.WriteLine("Not palidrome number.");
            }

            Console.ReadLine();
        }
    }
}
