using System;
using System.Collections.Generic;
using System.Text;

namespace BT67.entity
{
    class Order
    {
        public int ngayDat { get; set; }
        public int ngayTra { get; set; }
        public string CMTND { get; set; }
        public string MaKhachSan { get; set; }
        public string MaPhong { get; set; }
        public Order()
        {
        }

        public void inputOrder(List<Customer> customerList,List<Hotel> hotelList)
        {
            Console.Write("Nhập CMTND:");
            CMTND = Console.ReadLine();
            bool checkCMTND = false;
            for(int i = 0; i < customerList.Count; i++)
            {
                if (customerList[i].Cmtnd.Equals(CMTND))
                {
                    checkCMTND = true;
                    break;
                }
            }
            if (!checkCMTND)
            {
                Console.WriteLine("Do số CMTND này chưa tồn tại nên cần nhập thông tin khách hàng");
                Customer customer = new Customer();
                customer.Cmtnd = CMTND;
                customer.inputCustomerWithoutCMTND();
                customerList.Add(customer);
            }
            displayHotelMenu(hotelList);
            Hotel hotel = null;
            while (true)
            {
                MaKhachSan = Console.ReadLine();
                checkCMTND = false;
                for(int i = 0; i < hotelList.Count; i++)
                {
                    if (hotelList[i].MaKS.Equals(MaKhachSan))
                    {
                        checkCMTND = true;
                        hotel = hotelList[i];
                        break;
                    }
                }
                if (checkCMTND)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhập lại mã khách sạn!!!");
                }
            }

            displayRoomMenu(hotel);
            while (true)
            {
                MaPhong = Console.ReadLine();
                checkCMTND = false;
                for(int i = 0; i < hotel.roomList.Count; i++)
                {
                    if (hotel.roomList[i].MaPhong.Equals(MaPhong))
                    {
                        checkCMTND = true;
                        break;
                    }
                }
                if (checkCMTND)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Mã phòng không tồn tại,nhập lại mã phòng:");
                }
            }
            Console.Write("Nhập ngày đặt phòng:");
            ngayDat = Int32.Parse(Console.ReadLine());
            Console.Write("Nhập ngày trả phòng:");
            ngayTra = Int32.Parse(Console.ReadLine());
        }

        public void displayHotelMenu(List<Hotel> hotelList)
        {
            for(int i = 0; i < hotelList.Count; i++)
            {
                Console.WriteLine("{0}. {1} - {2}",i+1,hotelList[i].Name,hotelList[i].MaKS);
            }
            Console.Write("Nhập mã khách sạn cần chọn:");
        }
        public void displayRoomMenu(Hotel hotel)
        {
            for(int i = 0; i < hotel.roomList.Count; i++)
            {
                Console.WriteLine("{0}. {1} - {2}", i + 1, hotel.roomList[i].Name, hotel.roomList[i].MaPhong);
            }
            Console.Write("Nhập mã phòng:");
        }
    }
}
