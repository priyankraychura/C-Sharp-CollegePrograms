using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR09_MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to get table of: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + num * i);
            }

            Console.ReadLine();
        }
    }
}
