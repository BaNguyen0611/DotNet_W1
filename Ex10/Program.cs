using System;
namespace Ex8 {
    class Program {
        static void Main(string[] args) {
            System.Console.Write("Nhập số : ");
            int a= int.Parse(Console.ReadLine());
            while(a<2 || a>8){
                System.Console.WriteLine("Bạn nhập sai : ");
                System.Console.Write("Nhập lại số : ");
                a= int.Parse(Console.ReadLine());
            }
            switch (a)
            {
                case 2 :{
                    System.Console.WriteLine("Bạn vừa nhập thứ hai ");
                    break;
                }
                case 3 :{
                    System.Console.WriteLine("Bạn vừa nhập thứ ba");
                    break;
                }
                case 4 :{
                    System.Console.WriteLine("Bạn vừa nhập thứ tư ");
                    break;
                }
                case 5 :{
                    System.Console.WriteLine("Bạn vừa nhập thứ năm ");
                    break;
                }
                case 6 :{
                    System.Console.WriteLine("Bạn vừa nhập thứ sáu ");
                    break;
                }
                case 7 :{
                    System.Console.WriteLine("Bạn vừa nhập thứ bảy ");
                    break;
                }
                case 8 :{
                    System.Console.WriteLine("Bạn vừa nhập chủ nhật ");
                    break;
                }
                // default:
            }
            
        }
    }
}