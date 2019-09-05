using System;
using System.Collections.Generic;
using System.Text;

namespace BT565.entity
{
    class Room
    {
        private string tenPhong;
        private string tang;
        private double giaTien;
        private int soNguoiMax;

        public Room()
        {
        }

        public Room(string tenPhong, string tang, double giaTien, int soNguoiMax)
        {
            this.tenPhong = tenPhong;
            this.tang = tang;
            this.giaTien = giaTien;
            this.soNguoiMax = soNguoiMax;
        }
        public override string ToString()
        {
            return "Thông tin phòng là:\n"+this.tenPhong + "-" + this.tang + "-" + this.giaTien + "-" + this.soNguoiMax;
        }
        public void inputRoom()
        {
            Console.WriteLine("Nhập thông tin Room");
            Console.Write("Nhập tên:");
             this.tenPhong= Console.ReadLine();
            Console.Write("Tầng:");
            this.tang = Console.ReadLine();
            Console.Write("Giá tiền:");
            this.giaTien = double.Parse(Console.ReadLine());
            Console.Write("Số người tối đa:");
            this.soNguoiMax = int.Parse(Console.ReadLine());
        }
      public void displayRoom()
        {
            Console.WriteLine("Thông tin room là: "+ToString());
        }
    }

}
