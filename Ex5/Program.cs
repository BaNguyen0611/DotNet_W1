using System;
namespace Ex_5{
    class Program{
        static void Main(string[] args) {
            int a, b, c, e, d, f;
            float x, y;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            f = Convert.ToInt32(Console.ReadLine());
            x = c/(a + b);
            y = (f - (d * x))/e;
            Console.WriteLine($"x: {x}");
            Console.WriteLine($"y: {y}");

        }
    }
}