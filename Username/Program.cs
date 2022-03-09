using System;

namespace Username
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Username: ");
            string Name = Console.ReadLine();
            if (Name.Length < 3)
                Console.WriteLine("\nInvalid User Entry");
            else
                Console.WriteLine("\nHello " + Name + ", How are you?");
        }
    }
}
