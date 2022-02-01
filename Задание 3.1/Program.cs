using System;

namespace Задание_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //f = ctg x + 1
            double a, b, h, f;
            Console.WriteLine("Введите значение a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение h");
            h = Convert.ToDouble(Console.ReadLine());

            for (double x = a; x <= b; x += h)
            {
                f = Math.Tan(x) + 1;
                Console.WriteLine(x + "/t" + f);
            }
        
        }
    }
}
