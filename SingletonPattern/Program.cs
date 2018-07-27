using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton demo");
            Console.WriteLine("create instance 1");
            var instance1 = SingletonPatternEx.Instance;
            Console.WriteLine("create instance 2");
            var instance2 = SingletonPatternEx.Instance;

            if (instance1 == instance2)
                Console.WriteLine("Only one object is instance");
            else
                Console.WriteLine("Different instance exist");
            Console.ReadLine();
        }
    }
}
