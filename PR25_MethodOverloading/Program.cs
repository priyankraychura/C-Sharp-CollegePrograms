using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR25_MethodOverloading
{
    internal class Program
    {
        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        static double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int myNum1 = PlusMethodInt(8, 5);
            double myNum2 = PlusMethodDouble(11.5, 22.32);

            Console.WriteLine("int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

            Console.ReadLine();
        }
    }
}
