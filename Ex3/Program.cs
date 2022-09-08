using System;

namespace Ex_3 {
    class Program {
        static void Main(string[] args) {
            int n, x, y;
            n = x = y = 2;
            if (n % 2 == 0)
            {
                if (x > 3) 
                    x = 0; 
            }
            else 
                y = 0;
            Console.WriteLine("x :" + x);
            Console.WriteLine("y :" + y);
        }
    }
}