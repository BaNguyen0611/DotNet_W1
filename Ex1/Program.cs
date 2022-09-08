using System;
namespace Ex8 {
    class Program {
        static void Main(string[] args) {
            System.Console.Write("Nhap ki tu :");
            char a= (char)Console.Read();
            if((a>='a' && a<='z') || (a>='A' && a<='Z') ){
                System.Console.WriteLine("Ban vua nhap 1 ki tu ");
            }
            else{
                System.Console.WriteLine("Ban vua ko nhap ki tu ");
            }
        }
    }
}