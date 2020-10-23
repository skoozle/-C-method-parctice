using System;

namespace methodPractice
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello - What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName} - What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your favborite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"hi {userName} , nice to meet you! it says here your favorite color is {color} and your favorite animal is {animal}" +
                $"it also looks like your listen to a ton of {band} thats pretty wild");

            // exercise two


            var result = Add(6, 9);
            Console.WriteLine(result);

            var mult = Multiply(7, 6);
            Console.WriteLine(mult);

            var sub = Subtract(100, 31, 1);
            Console.WriteLine(sub);

            var addi = Addition(1, 1, 1, 1, 1);
            Console.WriteLine(addi);
        }

        static int Add(int x, int y)
        {
            return x + y;
        }


        static int Multiply(int a, int b)
        {
            return a * b;
        }


        static int Subtract(int n, int k, int z)
        {
            return n - k - z;
        }

        static int Addition(int a, int b, int c, int d, int e)
        {
            return a + b + c + d + e;
        }
         






    }
}
