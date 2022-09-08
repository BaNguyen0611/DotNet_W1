using System;
namespace Ex9 {
    class Program {
        static void Main(string[] args) {
            System.Console.Write("Nhập số nguyên có 3 chữ số : ");
            int a = int.Parse(Console.ReadLine());
            int b=a;
            int[] mang = new int[3];
            for(int i =0 ;i<3;i++){
                if(a%10!=0){
                    mang[i]=a%10;
                }
                else {
                    mang[i]=0;
                };
                a=(a-a%10)/10;
            }
            int temp=0,vitri = 0;
            for(int i =0 ;i <3 ; i++){
                if(temp <mang[i]){
                    temp = mang[i];
                    vitri=i;
                }
            }
            if(vitri==0){
                System.Console.WriteLine("\nChữ số lớn nhất của số {0} là {1} và nằm ở hàng đơn vị !",b,temp);
            }
            if(vitri==1){
                System.Console.WriteLine("\nChữ số lớn nhất của số {0} là {1} và nằm ở hàng chục !",b,temp);
            }
            if(vitri==2){
                System.Console.WriteLine("\nChữ số lớn nhất của số {0} là {1} và nằm ở hàng trăm !",b,temp);
            }

            for (int i = 0; i < 3; i++)
            {
                for(int j=i+1;j<3;j++){
                    if(mang[i]>mang[j]){
                        int temp1;
                        temp1 =mang[i];
                        mang[i]=mang[j];
                        mang[j]=temp1;
                    }
                }
            }
            System.Console.Write("Thứ tự tăng dần của các chữ số của số {0} la :",b);
            for(int i=0;i<3;i++){
                System.Console.Write(mang[i]+" ");
            }
        }
    }
}