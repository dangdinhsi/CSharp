using System;
using System.Collections.Generic;
using System.Text;

namespace BT67.entity
{
    class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string MaKS { get; set; }
        public List<Room> roomList = new List<Room>();

        public Hotel()
        {
        }

        public Hotel(string name, string address, string type, string maKS, List<Room> roomList)
        {
            Name = name;
            Address = address;
            Type = type;
            MaKS = maKS;
            this.roomList = roomList;
        }

        public void inputHotel()
        {
            Console.Write("Tên khách sạn:");
            Name = Console.ReadLine();
            Console.Write("Địa chỉ khách sạn:");
            Address = Console.ReadLine();
            Console.Write("Loại Khách sạn:");
            Type = Console.ReadLine();
            Console.Write("Mã Khách sạn:");
            MaKS = Console.ReadLine();
            Console.Write("Nhập số phòng cần thêm:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Thông tin phòng thứ " + (i + 1));
                Room room = new Room();
                room.inputRoom();
                roomList.Add(room);
            }

        }
        public void displayHotel()
        {
            Console.WriteLine("Mã Khách Sạn:{0},Tên:{1}, Địa chỉ:{2}, Loại khách sạn:{3}",MaKS,Name,Address,Type);
            Console.WriteLine("Danh sách phòng của khách sạn:");
            for(int i = 0; i < roomList.Count; i++)
            {
                Console.Write("Phòng {0}:", (i+1));
                roomList[i].displayRoom();
            }
        }
    }
}
