using System;
namespace Ex8 {
    class Program {
        static void Main(string[] args) {
            System.Console.WriteLine("1.Hình tròn\n2.Hình Vuông\n3.Tam giác\n4.Hình chữ nhât\n");
            System.Console.Write("Vui lòng chọn hình muốn tính diện tích và chu vi : ");
            int luachon = int.Parse(Console.ReadLine());
            switch(luachon){
                case 1: {
                    System.Console.WriteLine("Bạn đã chọn hình tròn");
                    System.Console.Write("Nhập bán kính của hình tròn : ");
                    int banKinh = int.Parse(Console.ReadLine());
                    double dienTichHinhTron = Math.PI*banKinh*banKinh;
                    double chuViHinhtron = Math.PI*2*banKinh;
                    System.Console.WriteLine("Chu vi hình tròn bán kính {0} là : {1}",banKinh,chuViHinhtron);
                    System.Console.WriteLine("Diện tích hình tròn bán kính {0} là : {1}",banKinh,dienTichHinhTron);
                    break;
                }
                case 2:{
                    System.Console.WriteLine("Bạn đã chọn hình vuông !");
                    System.Console.Write("Nhập cạnh hình vuông : ");
                    float canhHV = float.Parse(Console.ReadLine());
                    float chuViHinhVuong = canhHV*4;
                    float dienTichHinhVuong = canhHV*canhHV;
                    System.Console.WriteLine("Chu vi của hình vuông : {1}",chuViHinhVuong);
                    System.Console.WriteLine("Diện tích cuả hình vuông : {0}",dienTichHinhVuong);
                    break;
                }
                case 3:{
                    System.Console.WriteLine("Bạn đã chọn hình tam giác ~");
                    System.Console.Write("Nhập độ dài cạnh thứ nhất : ");
                    float canhmot= float.Parse(Console.ReadLine());
                    System.Console.Write("Nhập độ dài cạnh thứ hai : ");
                    float canhhai= float.Parse(Console.ReadLine());
                    System.Console.Write("Nhập độ dài cạnh thứ ba : ");
                    float canhba= float.Parse(Console.ReadLine());
                    float chuvitamgiac = canhba+canhhai+canhmot;
                    float nuaChuVi = chuvitamgiac/2;
                    double temptamgiac =(double)nuaChuVi *(nuaChuVi-canhba)*(nuaChuVi-canhhai)*(nuaChuVi-canhmot);
                    double dientichtamgiac = (double)Math.Sqrt(temptamgiac);
                    System.Console.WriteLine("Chu vi hình tam giác là : {0}",chuvitamgiac);
                    System.Console.WriteLine("Diện tích hình tam giác là : {1}",dientichtamgiac);
                    break;
                }
                case 4:{
                    System.Console.WriteLine("Bạn đã chọn hình chữ nhật ~ ");
                    System.Console.Write("Nhập chiều dài hình chữ nhật : ");
                    float chieuDai= float.Parse(Console.ReadLine());
                    System.Console.Write("Nhập chiều rộng hình chữ nhật : ");
                    float chieuRong= float.Parse(Console.ReadLine());
                    float chuvi= (chieuDai+chieuRong)*2;
                    float dienTich = chieuDai*chieuRong;
                    System.Console.WriteLine("Chu vi hình chữ nhật là : {0}",chuvi);
                    System.Console.WriteLine("Diện tích hình chữ nhật là : {0}",dienTich);
                    break;
                }
            }
        }
    }
}