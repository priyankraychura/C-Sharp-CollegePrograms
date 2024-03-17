using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR12_Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a nummber: ");
            int num = int.Parse(Console.ReadLine());

            int r, temp = num;
            double sum = 0;

            while (num > 0)
            {
                r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }

            Console.ReadLine();
        }
    }
}
