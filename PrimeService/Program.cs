using System;

namespace Prime.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var service = new PrimeService();
            service.IsPrime(1);
        }
    }
}
