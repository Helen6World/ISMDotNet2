using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double sum = 0;
            Console.Write("Введiть цiле число n (n>0): ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                sum += 1.0 / i;
            }
            Console.WriteLine($"Сума= {sum}");
        }
    }
}
