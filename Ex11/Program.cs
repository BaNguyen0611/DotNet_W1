using System;
namespace Ex8 {
    class Program {
        static void Main(string[] args) {
            System.Console.Write("Nhâp Năm bạn muốn kiểm tra :");
            int nam= int.Parse(Console.ReadLine());
            System.Console.Write("Nhập vào tháng : ");
            int thang = int.Parse(Console.ReadLine());
            if(thang ==1 ||thang==3||thang==5||thang==7||thang==8||thang==10||thang==12){
                System.Console.WriteLine("Thang {0} nam {1} có 31 ngày !",thang,nam);
            }
            if(thang ==4 ||thang==6||thang==9||thang==11){
                System.Console.WriteLine("Tháng {0} năm {1} vó 30 ngày !",thang,nam);
            }
            if(nam%4==0){
                if(thang ==2){
                    System.Console.WriteLine("Thang {0} nam {1} có 29 ngay !",thang,nam);
                }
            }else{
                if(thang ==2){
                    System.Console.WriteLine("Thang {0} nam {1} có 28 ngay !",thang,nam);
                }
            }
        }
    }
}