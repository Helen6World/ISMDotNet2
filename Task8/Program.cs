using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, result = 1;
            int n;
            Console.Write("Введiть дробове число a (a^n): ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введiть цiле число n (a^n): ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                result *= a;
            }
            Console.WriteLine($"a^n= {result}");
            Console.ReadKey();
        }
    }
}

