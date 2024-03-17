using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR29_RefEg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Addition = 0;
            int Multiplication = 0;
            int Substration = 0;
            int Division = 0;

            Math(200, 100, ref Addition, ref Multiplication, ref Substration, ref Division);

            Console.WriteLine($"Addition: {Addition}");
            Console.WriteLine($"Multiplication: {Multiplication}");
            Console.WriteLine($"Substration: {Substration}");
            Console.WriteLine($"Division: {Division}");

            Console.ReadLine();
        }

        public static void Math(int number1, int number2, ref int Addition, ref int Multiplication, ref int Substration, ref int Division)
        {
            Addition = number1 + number2;
            Multiplication = number1 * number2;
            Substration = number1 - number2;
            Division = number1 / number2;
        }
    }
}
