using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double x1, x2, dyskriminant;
            Console.Write("Введiть а: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введiть b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введiть c: ");
            c = int.Parse(Console.ReadLine());
            dyskriminant = Math.Pow(b, 2) - 4 * a * c;
            if (dyskriminant < 0)
            {
                Console.WriteLine("Розв'язкiв немає");
            }
            else {
                x1 = (-b + Math.Sqrt(dyskriminant)) / 2 * a;
                Console.WriteLine($"x1= {x1}");
                if (dyskriminant > 0) {
                    x2 = (-b - Math.Sqrt(dyskriminant)) / 2 * a;
                    Console.WriteLine($"x2= {x2}");
                }

            }
            Console.ReadKey();
        }
    }
}
