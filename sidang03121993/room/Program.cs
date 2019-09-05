using System;

namespace room
{
    class Program
    {
        static void Main(string[] args)
        {
            nhapvahienthi();
        }
        static void nhapvahienthi()
        {
            Console.Write("nhap ten:");
            string ten = Console.ReadLine();
            Console.Write("nhap mau sac:");
            string mausac = Console.ReadLine();
            Console.Write("nhap so ngay su dung:");
            int date = Convert.ToInt32(Console.ReadLine());
            Table table = new Table();
            table.Ten = ten;
            table.MauSac = mausac;
            table.SoNgaySD = date;
            Console.WriteLine("Ten:" + table.Ten+",Mausac:"+table.MauSac+",Ngay su dung: "+table.SoNgaySD);
           
        }
        
    }
}
