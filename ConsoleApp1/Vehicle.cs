using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Vehicle
    {
        public Fuel Fuel { get; protected set; }

        public int Wheels { get; protected set; }

        public int Speed { get; protected set; }

        public virtual void Refuel(Fuel fuel) 
        {
            if (fuel != this.Fuel)
            {
                throw new Exception("Wrong fuel type");
            }
            else
            {
                Console.WriteLine("Successfully refueled");
            }
        }
    }
}
