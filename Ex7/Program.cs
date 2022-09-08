using System;

namespace Ex_7 {
    class Program {
        static void Main(string[] args) {
            int a, b, c;
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            c = Convert.ToInt16(Console.ReadLine());
            if (a + b <= c || a + c <= b ||  b + c <= a){
                Console.WriteLine("3 canh tren khong phai la tam giac");
            }
            else{
                Console.Write("Day la tam giac: ");
                if((a == b) && (b == c)){
                Console.WriteLine("Deu");
                }
                else {
                    if(a * a + b * b == c * c || a * c + c * c == b * b || b * b + c * c == a * c) {
                        Console.WriteLine("Vuong");
                    }
                    if (a == b || a == c || b == c)
                        Console.WriteLine("Can");
                    else
                        Console.WriteLine("Thuong");
                }
            }
        }
    }
}