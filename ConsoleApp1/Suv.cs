using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Suv : Car, IMove
    {
        public Suv()
        {
            Fuel = Fuel.Diesel;
            Wheels = 4;
            Speed = 0;
            IsHybrid = false;
        }

        public void Accelerate()
        {
            Speed += 10;
            Console.WriteLine($"Suv accelerated successfully. Current speed {Speed}");
        }

        public void Brake()
        {
            Speed -= 10;
            if (Speed <= 0)
            {
                Speed = 0;
                Console.WriteLine("Suv stopped");
            }
            else 
            {
                Console.WriteLine($"Suv decelerated successfully. Current speed {Speed}");
            }
        }
    }
}
