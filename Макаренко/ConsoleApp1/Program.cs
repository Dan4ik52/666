using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Введите нечетное число k (1 <= k <= 180): ");
            int k = int.Parse(Console.ReadLine());
            if(k<=0 || k>180 || k % 2==0)
                {
                Console.Write("Ошибка!Прочитайте еще раз условие.");
            }

            int numberIndex = (k + 1) / 2;
            int number =10 + numberIndex -1 ;
            int digitIndex = (k + 1) % 2;
            int digit = number /10;
            Console.WriteLine($"k-я цифра: {digit}");
            */


            Console.Write("Введите координаты поля p1 (например, e2): ");
            string p1 = Console.ReadLine();
            Console.Write("Введите координаты поля p2 (например, e4): ");
            string p2 = Console.ReadLine();

   
            int x1 = p1[0] - 'a';
            int y1 = p1[1] - '1'; 
            int x2 = p2[0] - 'a';
            int y2 = p2[1] - '1';

            Console.WriteLine("Фигуры, которые могут атаковать:");

            // Пешка (белая)
            if (y1 == y2 - 1 && (x1 == x2 - 1 || x1 == x2 + 1))
                Console.WriteLine("Пешка");

            // Ладья
            if (x1 == x2 || y1 == y2)
                Console.WriteLine("Ладья");

            // Слон
            if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
                Console.WriteLine("Слон");

            // Конь
            if ((Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2) ||
                (Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1))
                Console.WriteLine("Конь");

            // Ферзь
            if (x1 == x2 || y1 == y2 || Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
                Console.WriteLine("Ферзь");

            // Король
            if (Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1)
                Console.WriteLine("Король");

            Console.ReadKey();
        }
    }
}
