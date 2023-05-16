// See https://aka.ms/new-console-template for more information
using System;

namespace SystemTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");

            string yourName = Console.ReadLine ();

            Console.WriteLine("Hello: " + yourName);
        }
    }
}