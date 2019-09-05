using System;
using System.Collections.Generic;
using System.Text;

namespace BT565.entity
{
    class Hotel
    {
        private string nameKS;
        private string addressKS;
        private List<Room> danhsachRoom;

        public Hotel()
        {
        }

        public Hotel(string nameKS, string addressKS, List<Room> danhsachRoom)
        {
            this.nameKS = nameKS;
            this.addressKS = addressKS;
            this.danhsachRoom = danhsachRoom;
        }

        public void inputKS()
        {
            Console.Write("Nhập tên KS:");
            this.nameKS = Console.ReadLine();
            Console.Write("Nhập địa chỉ KS:");
            this.addressKS = Console.ReadLine();
            Console.WriteLine("Nhập danh sách phòng");
            Console.Write("Số lượng phòng là:");
            int n = int.Parse(Console.ReadLine());
            List<Room> list = new List<Room>();
            for(int i = 0; i < n; i++)
            {
                Room room = new Room();
                Console.WriteLine("Thông tin phòng thứ " + (i + 1));
                room.inputRoom();
                list.Add(room);
            }
            this.danhsachRoom = list;
        }

        public void displayKS()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("Thông tin khách sạn là:");
            Console.WriteLine("Tên:" + this.nameKS);
            Console.WriteLine("Địa chỉ:" + this.addressKS);
           foreach(var st in this.danhsachRoom)
            {
                Console.WriteLine(st.ToString());
            }
            Console.WriteLine("*********************************************");

        }
    }
}
