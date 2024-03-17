using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR11_PrimeNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check number is prime or not: ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine(num + " is Prime");
            }
            else
            {
                Console.WriteLine(num + " is not Prime");
            }
            Console.ReadLine();
        }
    }
}
