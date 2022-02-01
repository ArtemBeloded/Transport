using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CompactCar : Car, IMove
    {
        public CompactCar()
        {
            Fuel = Fuel.Gasoline;
            Wheels = 4;
            Speed = 0;
            IsHybrid = true;
        }

        public void Accelerate()
        {
            Speed += 20;
            Console.WriteLine($"Compact car accelerated successfully. Current speed {Speed}");
        }

        public void Brake()
        {
            Speed -= 20;
            if (Speed <= 0)
            {
                Speed = 0;
                Console.WriteLine("Compact car stopped");
            }
            else
            {
                Console.WriteLine($"Compact car decelerated successfully. Current speed {Speed}");
            }
        }
    }
}
