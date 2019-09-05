using BT67.entity;
using System;
using System.Collections.Generic;

namespace BT67
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();
            List<Hotel> hotelList = new List<Hotel>();
            List<Order> orderList = new List<Order>();
            int choose;
            do
            {
                ShowMenu();
                choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        input(hotelList);
                        break;
                    case 2:
                        display(hotelList);
                        break;
                    case 3:
                        InputOrder(orderList,customerList,hotelList);
                        break;
                    case 4:

                        break;

                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Console.WriteLine("Exit program");
                        break;
                    default:
                        Console.WriteLine("Input failed");
                        break;
                }

            } while (choose != 7);
        }

        static void InputOrder(List<Order> orderList,List<Customer> customerList, List<Hotel> hotelList)
        {
            Order order = new Order();
            order.inputOrder(customerList,hotelList);
            orderList.Add(order);
        }
        static void display(List<Hotel> hotelList)
        {
            for(int i = 0; i < hotelList.Count; i++)
            {
                hotelList[i].displayHotel();
            }
        }
        static void input(List<Hotel> hotelList)
        {
            Console.Write("Nhập số khách sạn cần thêm:");
            int n = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Hotel hotel = new Hotel();
                hotel.inputHotel();
                hotelList.Add(hotel);
            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("1.Nhập thông tin khách sạn");
            Console.WriteLine("2.Hiển thị thông tin khách sạn");
            Console.WriteLine("3.Đặt phòng nghỉ");
            Console.WriteLine("5.Thống kê doanh thu khách sạn");
            Console.WriteLine("6.Tìm kiếm thông tin khách hàng");
            Console.Write("Nhập lựa chọn:");
        }
    }
}
