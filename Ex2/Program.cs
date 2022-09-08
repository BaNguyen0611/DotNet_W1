using System;

namespace Ex_1 {
    class Program {
        
        static void Main(string[] args) {
            int i = Convert.ToInt32(Console.ReadLine());
            if (i < 0) {
                if (i % 2 == 0) {
                    Console.WriteLine($"{i} la so am va chan");
                }
                else {
                    Console.WriteLine($"{i} la so am va le");
                }
            }
            else {
                if (i % 2 == 0) {
                    Console.WriteLine($"{i} la so duong va chan");
                }
                else {
                    Console.WriteLine($"{i} la so duong va le");
                }
            }
        }
    }
}

