using System;
namespace Ex_4 {
    class Program {
        public static void f1(int x) {
            if (x < 0) {
                Console.WriteLine("x khong thoa man dieu kien !");
            }
            else {
                Console.WriteLine($" Gia tri cua ham f(x) la : {3 * x + Math.Sqrt(x)}");
            }
        }
        public static void f2(int x) {
            if (x > 0) {
                Console.WriteLine("x khong thoa man dieu kien !");
            }
            else {
                Console.WriteLine($" Gia tri cua ham f(x) la : {Math.Pow(2.7183, x) + 4}");
            }
        }
        public static void f3(int x) {
            if (x >= -1 && x >= 1) {
                Console.WriteLine("x khong thoa man dieu kien !");
            }
            else {
                Console.WriteLine($" Gia tri cua ham f(x) la : {3 * x + 5}");
            }
        }
        public static void f4(int x) {
            if (x > -1) {
                Console.WriteLine("x khong thoa man dieu kien !");
            }
            else {
                Console.WriteLine($" Gia tri cua ham f(x) la : {Math.Pow(x, 2) + 2 * x - 1}");
            }
        }
        static void Main(string[] args){
            int x1, x2, x3, x4;
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            x3 = Convert.ToInt32(Console.ReadLine());
            x4 = Convert.ToInt32(Console.ReadLine());
            f1(x1);
            f2(x2);
            f3(x3);
            f4(x4);
        }
    }
}
