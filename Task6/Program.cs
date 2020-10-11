using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double multipl = 1;
            Console.Write("Введiть цiле число a (a<b): ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введiть цiле число b (a<b): ");
            b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++) {
                multipl *= i;
            }
            Console.WriteLine($"Добуток= {multipl}");
            Console.ReadKey();
        }
    }
}
