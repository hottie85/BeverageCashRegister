using System;

namespace BerverageCashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Person daniel = new Person("Daniel", "Heiß");
            Console.WriteLine(daniel.fullName());
        }
    }
}
