using System;
namespace Ex8 {
    class Program {
        static void Main(string[] args) {
            System.Console.Write("Nhâp ngay : ");
                int ngay =int.Parse(Console.ReadLine());
                System.Console.Write("Nhập tháng : ");
                int thang =int.Parse(Console.ReadLine());
                System.Console.Write("Nhập năm : ");
                int nam = int.Parse(Console.ReadLine());
            while( (nam>3000 || nam <1000) || ( thang<0 || thang >12) || (ngay>31 || ngay<0) ){
                System.Console.WriteLine("Bạn vừa nhập sai định dạng ngày tháng năm !! Hay nhập lại");
                System.Console.Write("Nhâp ngày : ");
                ngay =int.Parse(Console.ReadLine());
                System.Console.Write("Nhập tháng : ");
                thang =int.Parse(Console.ReadLine());
                System.Console.Write("Nhập năm : ");
                nam = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Bạn vừa nhập ngày {0} thang {1} nam {2} có định dạng hợp lệ ",ngay,thang,nam); 

        }
    }
}