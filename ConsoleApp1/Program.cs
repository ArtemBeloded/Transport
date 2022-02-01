using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Suv bmv = new Suv();

            Console.WriteLine(bmv.Wheels);

            bmv.Refuel(Fuel.Diesel);
            bmv.Accelerate();
            bmv.Brake();
            bmv.Brake();
        }
    }
}
