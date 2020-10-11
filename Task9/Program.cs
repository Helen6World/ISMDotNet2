using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, copyI;
            double sum = 0, faktorial = 1;
            Console.Write("Введiть цiле число n (n>0): ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                faktorial = 1;
                copyI = i;
                while (copyI != 0) {
                    faktorial *= copyI;
                    copyI--;
                }
                sum += faktorial;
            }
            Console.WriteLine($"Сума= {sum}");
            Console.ReadKey();
        }
    }
}
