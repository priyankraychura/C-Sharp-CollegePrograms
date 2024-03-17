using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR17_TempConv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter celius tempreture: ");
            float celius = float.Parse(Console.ReadLine());

            float fahrenherit = (celius * 9 / 5) + 32;
            float kelvin = (float)(celius + 273.15);

            Console.WriteLine("Celius to Fahrenherit: " + fahrenherit);
            Console.WriteLine("Celius to Kelvin: " + kelvin);
            Console.ReadLine();
        }
    }
}
