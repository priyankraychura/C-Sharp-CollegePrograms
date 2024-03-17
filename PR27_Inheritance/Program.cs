using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR27_Inheritance
{
    public class Vehical
    {
        protected string make;
        protected string model;

        public Vehical(string make, string model) 
        {
            this.make = make;
            this.model = model;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {make}, Model: {model}");
        }
    }

    public class Car: Vehical
    {
        private int year;

        public Car(String make, string model, int year): base(make, model)
        {
            this.year = year;
        }

        public void displayYear()
        {
            Console.WriteLine($"Year: {year}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Camry", 2020);
            myCar.DisplayInfo();
            myCar.displayYear();

            Console.ReadLine();
        }
    }
}
