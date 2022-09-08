using System;
namespace Ex8 {
    class Program {
        static void Main(string[] args) {
            System.Console.Write("Nhập giờ : ");
            int gio = int.Parse(Console.ReadLine());
            System.Console.Write("Nhập phút : ");
            int phut = int.Parse(Console.ReadLine());
            System.Console.Write("Nhập giây : ");
            int giay = int.Parse(Console.ReadLine());
            while( ( gio>24 || gio<0 ) && (phut <0 || phut >60) && (giay<0 ||giay>60)){
                System.Console.Write("Bạn nhập sai giờ , phút hoặc giây !! Hãy vui lòng nhập lại ");
                System.Console.Write("Nhập giờ : ");
                gio = int.Parse(Console.ReadLine());
                System.Console.Write("Nhập phút : ");
                phut = int.Parse(Console.ReadLine());
                System.Console.Write("Nhập giây : ");
                giay = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Bạn vừa nhập vào {0} giờ {1} phút {2} giây ~ ",gio,phut,giay);
        }
    }
}