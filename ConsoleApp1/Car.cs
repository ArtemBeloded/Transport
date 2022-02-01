using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Car : Vehicle
    {
        protected bool IsHybrid { get; set; }

        public override void Refuel(Fuel fuel)
        {
            if (IsHybrid && fuel == Fuel.Electricity)
            {
                Console.WriteLine("Successfully charged");
            }
            else if (fuel == this.Fuel)
            {
                Console.WriteLine("Successfully refueled");
            }
            else 
            {
                throw new Exception("Wrong fuel type");
            }
        }
    }
}
