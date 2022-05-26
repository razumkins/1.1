using System;

namespace дз_рпм
{
    class Program
    {
        static void Main(string[] args)
        {
            drob d1 = new drob(2, 3);
            drob d2 = new drob(2, 3, 4);
            drob d3 = new drob(-2);
            Console.WriteLine(d1.ToDouble());
            Console.WriteLine((d1 * d2).ToDouble());
            Console.WriteLine((d1 * d3).Znak);
            Console.ReadKey();
        }
    }
}