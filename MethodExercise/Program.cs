using System;

namespace MethodExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            //exercise one

            Console.WriteLine("What is your name ?");
            var name = Console.ReadLine();

            Console.WriteLine($"Hi {name}. What is your favorite color ?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awsome color. What is your favorite animal ?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();

        }
    }
}

