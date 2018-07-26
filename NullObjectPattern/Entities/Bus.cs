using NullObjectPattern.Vehicle;
using System;

namespace NullObjectPattern.Entities
{
    public class Bus : IVehicle
    {
        public static int count = 0;
        public Bus()
        {
            count++;
        }

        public void Travel()
        {
            Console.WriteLine("Travel by bus!!!");
        }
    }
}
