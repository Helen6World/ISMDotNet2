using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Введiть цiле число в дiапазонi вiд 1 до 7: ");
            number = int.Parse(Console.ReadLine());
            switch (number) {
                case 1:
                    Console.WriteLine("Введене число вiдповiдає понедiлку");
                    break;
                case 2:
                    Console.WriteLine("Введене число вiдповiдає вiвторку");
                    break;
                case 3:
                    Console.WriteLine("Введене число вiдповiдає середi");
                    break;
                case 4:
                    Console.WriteLine("Введене число вiдповiдає четвергу");
                    break;
                case 5:
                    Console.WriteLine("Введене число вiдповiдає п'ятницi");
                    break;
                case 6:
                    Console.WriteLine("Введене число вiдповiдає суботi");
                    break;
                case 7:
                    Console.WriteLine("Введене число вiдповiдає недiлi");
                    break;
                default:
                    Console.WriteLine("Введене число не вiдповiдає умовi задачi");
                    break;
            }
            Console.ReadKey();
        }
    }
}
