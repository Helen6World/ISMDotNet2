using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, a, b;
            double y;
            Console.Write("Введіть значення x: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Введіть значення a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Введіть значення b: ");
            b = float.Parse(Console.ReadLine());
            y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a-b), 2) + Math.Pow(10, -2) * (x - b);
            Console.WriteLine($"y= {y}");
            Console.ReadKey();
        }
    }
}
