using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16_Bill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float discount, finalTotal;

            Console.WriteLine("Enter the bill total amount: ");
            int billTotal = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of items: ");
            int items = int.Parse(Console.ReadLine());

            if (billTotal >= 500 && items > 10)
            {
                discount = 0.15f;
            }
            else if (billTotal < 500 && items > 10)
            {
                discount = 0.09f;
            }
            else
            {
                discount = 0;
            }

            finalTotal = billTotal - (billTotal * discount);

            Console.WriteLine("The final bill amount is: " + finalTotal);
            Console.ReadLine();
        }
    }
}
