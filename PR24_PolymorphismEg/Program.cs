using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR24_PolymorphismEg
{
    internal class Program
    {
        void totalSum(int a, int b)
        {
            Console.WriteLine("The sum of number is: " + (a + b));
        }

        void totalSum(double a, double b)
        {
            Console.WriteLine("The sum of number is: " + (a + b));
        }
        static void Main(string[] args)
        {
            Program sum1 = new Program();
            sum1.totalSum(5, 7);
            sum1.totalSum(55.69, 56.6);

            Console.ReadLine();
        }
    }
}
