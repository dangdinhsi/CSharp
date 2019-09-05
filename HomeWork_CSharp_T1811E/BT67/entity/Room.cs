using System;
using System.Collections.Generic;
using System.Text;

namespace BT67.entity
{
    class Room
    {
        private string name;
        private double price;
        private int tang;
        private int soNguoiMax;
        private string maPhong;

        public Room()
        {
        }

        public Room(string name, double price, int tang, int soNguoiMax, string maPhong)
        {
            this.name = name;
            this.price = price;
            this.tang = tang;
            this.soNguoiMax = soNguoiMax;
            this.maPhong = maPhong;
        }

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Tang { get => tang; set => tang = value; }
        public int SoNguoiMax { get => soNguoiMax; set => soNguoiMax = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }

        public void inputRoom()
        {
            Console.Write("Nhập tên phòng:");
            this.name = Console.ReadLine();
            Console.Write("Giá tiền:");
            this.price = double.Parse(Console.ReadLine());
            Console.Write("Phòng ở tầng:");
            this.tang = Int32.Parse(Console.ReadLine());
            Console.Write("Số khách hàng tối đa có thể chứa:");
            this.soNguoiMax = Int32.Parse(Console.ReadLine());
            Console.Write("Mã phòng:");
            this.maPhong = Console.ReadLine();
        }
        public void displayRoom()
        {
            
            Console.WriteLine("Tên:{0} ,Mã phòng:{1} ,Vị trí:tầng {2} ,Chứa tối đa {3} khách hàng ,Giá Tiền:{4}",this.name,this.maPhong,this.tang,this.soNguoiMax,this.price);
        }
    }
}
