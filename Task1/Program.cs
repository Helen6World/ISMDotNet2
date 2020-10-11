using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            float sideA, sideB, perimeter, square;
            Console.Write("Введiть довжину сторони a прямокутника: ");
            sideA = float.Parse(Console.ReadLine());
            Console.Write("Введiть довжину сторони b прямокутника: ");
            sideB = float.Parse(Console.ReadLine());
            perimeter = 2 * (sideA + sideB);
            Console.WriteLine($"Периметр= {perimeter}");
            square = sideA * sideB;
            Console.WriteLine($"Площа= {square}");
            Console.ReadKey();
        }
    }
}
