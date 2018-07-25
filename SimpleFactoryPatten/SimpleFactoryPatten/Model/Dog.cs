using SimpleFactoryPatten.Animal;
using System;

namespace SimpleFactoryPatten.Model
{
    class Dog : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Dogs prefer barking...");
        }

        public void Speak()
        {
            Console.WriteLine("Dog says: Bow-Wow.");
        }
    }
}
