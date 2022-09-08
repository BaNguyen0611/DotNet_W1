using System;
namespace Ex8 {
    class Program {
        static void Main(string[] args) {
            System.Console.Write("Nhap a : ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("Nhap b : ");
            int b = int.Parse(Console.ReadLine());;
            System.Console.Write("Nhap c : ");
            int c = int.Parse(Console.ReadLine());;
            int[] mang1 = { a,b,c};
            for (int i = 0; i < 3; i++)
            {
                for(int j=i+1;j<3;j++){
                    if(mang1[i]>mang1[j]){
                        int temp;
                        temp =mang1[i];
                        mang1[i]=mang1[j];
                        mang1[j]=temp;
                    }
                }
            }
            for(int i=0;i<3;i++){
                System.Console.Write(mang1[i]+" ");
            }
        }
    }
}
