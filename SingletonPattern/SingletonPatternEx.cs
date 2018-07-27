using System;

namespace SingletonPattern
{
    public sealed class SingletonPatternEx
    {
        private static readonly SingletonPatternEx instance = new SingletonPatternEx();
        private static int totalInstance = 0;
        private SingletonPatternEx()
        {
            Console.WriteLine("Instance object via private constructor");
            totalInstance++;
            Console.WriteLine($"Number of instance {totalInstance}");
        }

        public static SingletonPatternEx Instance
        {
            get{
                Console.WriteLine("exist and we will reuse it!");
                return instance;
            }
        }
    }
}
