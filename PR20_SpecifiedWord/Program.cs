using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR20_SpecifiedWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            String str = Console.ReadLine();

            Console.Write("Enter a word: ");
            String word = Console.ReadLine();

            bool startsWith = str.StartsWith(word, StringComparison.OrdinalIgnoreCase);

            if(startsWith)
            {
                Console.WriteLine("Starts with the specified word");
            } else
            {
                Console.WriteLine("Doesn't start with specified word");
            }
            Console.ReadLine();
        }
    }
}
