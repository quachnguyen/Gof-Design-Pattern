using NullObjectPattern.Entities;
using NullObjectPattern.Vehicle;
using System;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Pattern demo with NullObjet Pattern");
            int total = 0;
            string input = String.Empty;
            while (input != "exit")
            {
                Console.WriteLine("Enter your chooice(a for Bus, b for Train and exit to close)");
                input = Console.ReadLine();
                IVehicle vehicel = null;
                switch (input)
                {
                    case "a":
                        Console.WriteLine("You have chooice Bus");
                        vehicel = new Bus();
                        break;
                    case "b":
                        Console.WriteLine("You havae chooice Train");
                        vehicel = new Train();
                        break;
                    case "exit":
                        Console.WriteLine("closing application");
                        vehicel = NullVehicle.Instance;
                        break;
                    default:
                        vehicel = NullVehicle.Instance;
                        if (input == "exit")
                        {
                            Console.WriteLine("Press any key to exit!!");
                        }
                        break;
                }
                total = Bus.count + Train.count + NullVehicle.count;
                Console.WriteLine($"Total object has created: {total}");
            }
            Console.ReadLine();
        }
    }
}
