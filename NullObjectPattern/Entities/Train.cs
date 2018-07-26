using NullObjectPattern.Vehicle;
using System;

namespace NullObjectPattern.Entities
{
    public class Train : IVehicle
    {
        public static int count = 0;
        public Train()
        {
            count++;
        }

        public void Travel()
        {
            Console.WriteLine("Travel by Train!!!");
        }
    }
}
