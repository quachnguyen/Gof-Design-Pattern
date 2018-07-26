using NullObjectPattern.Vehicle;
using System;

namespace NullObjectPattern.Entities
{
    public class NullVehicle : IVehicle
    {
        private static readonly NullVehicle instance = new NullVehicle();
        public static int count = 0;
        public static NullVehicle Instance
        {
            get { return instance; }
        }
        public void Travel()
        {
            throw new NotImplementedException();
        }
    }
}
