using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR08_NumSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            String result = (num > 0) ? "Number is Positive" : (num < 0) ? "Number is Negative" : "Number is Zero";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
