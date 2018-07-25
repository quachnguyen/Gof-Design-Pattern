using SimpleFactoryPatten.Animal;
using SimpleFactoryPatten.Model;
using System;

namespace SimpleFactoryPatten.Factory
{
    public abstract class ISimpleFactory
    {
        public abstract IAnimal Create();
    }

    public class SimpleFactory : ISimpleFactory
    {
        public override IAnimal Create()
        {
            IAnimal animal = null;
            Console.WriteLine("Enter your chooice(0 for Dog, 1 for Tiger)");
            string a = Console.ReadLine();
            int input;
            if (int.TryParse(a, out input))
            {
                Console.WriteLine("You have entered {0}", input);
                switch (input)
                {
                    case 1:
                        animal = new Dog();
                        break;
                    case 2:
                        animal = new Tiger();
                        break;
                    default:
                        Console.WriteLine("You must enter a number either 0 or 1");
                        break;
                }
            }
            return animal;
        }
    }
}
