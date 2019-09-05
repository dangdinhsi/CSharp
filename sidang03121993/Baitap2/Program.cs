using System;

namespace Baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao ten cua ban:");
            string name = Console.ReadLine();
            Console.Write("Ma SV:");
            string mssv = Console.ReadLine();
            Console.Write("Dia Chi:");
           string diachi= Console.ReadLine();
            Console.Write("Tuoi:");
            int tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ten:" + name + ",MSSV:" + mssv + ",Tuoi:" + tuoi + ",Dia chi:" + diachi);
        }
    }
}
