using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bus : Vehicle, IMove
    {
        public Bus()
        {
            Fuel = Fuel.Gasoline;
            Wheels = 10;
            Speed = 0;
        }

        public void Accelerate()
        {
            Speed += 3;
            Console.WriteLine($"Bus accelerated successfully. Current speed {Speed}");
        }

        public void Brake()
        {
            Speed -= 3;
            if (Speed <= 0)
            {
                Speed = 0;
                Console.WriteLine("Bus stopped");
            }
            else
            {
                Console.WriteLine($"Bus decelerated successfully. Current speed {Speed}");
            }
        }
    }
}
