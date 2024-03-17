using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR18_SwapChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "This is a string";
            Console.WriteLine("Original String: " + str);

            char[] charString = str.ToCharArray();

            char temp = charString[0];
            charString[0] = charString[charString.Length - 1];
            charString[charString.Length - 1] = temp;

            Console.WriteLine(charString);
            Console.ReadLine();
        }
    }
}
