using SimpleFactoryPatten.Animal;
using SimpleFactoryPatten.Factory;
using System;

namespace SimpleFactoryPatten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a simple factory pattern demo");
            IAnimal animal = null;
            ISimpleFactory simpleFactory = new SimpleFactory();
            animal = simpleFactory.Create();
            animal.Speak();
            animal.Action();
            Console.Read();
        }
    }
}
