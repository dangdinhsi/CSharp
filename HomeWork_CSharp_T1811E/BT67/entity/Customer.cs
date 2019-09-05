using System;
using System.Collections.Generic;
using System.Text;

namespace BT67.entity
{
    class Customer
    {
        private string cmtnd;
        private string fullname;
        private int age;
        private string gender;
        private string address;

        public Customer()
        {
        }

        public string Cmtnd { get => cmtnd; set => cmtnd = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }

        public void inputCustomer()
        {
            Console.Write("Nhap CMTND:");
            this.cmtnd = Console.ReadLine();
            Console.Write("Nhap ten:");
            this.cmtnd = Console.ReadLine();
            Console.Write("Nhap tuoi:");
            this.age = int.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh:");
            this.gender = Console.ReadLine();
            Console.Write("Nhap dia chi:");
            this.address = Console.ReadLine();
        }

        public void inputCustomerWithoutCMTND()
        {
            Console.Write("Nhap ten:");
            this.cmtnd = Console.ReadLine();
            Console.Write("Nhap tuoi:");
            this.age = int.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh:");
            this.gender = Console.ReadLine();
            Console.Write("Nhap dia chi:");
            this.address = Console.ReadLine();
        }
        public void displayCustomer()
        {
            Console.WriteLine("Thong tin khach hang la:");
            Console.WriteLine("Full name:{0}, CMTND:{1}, Age:{2}, Gender:{3}, Address: {4}.",this.fullname,this.cmtnd,this.age,this.gender,this.address);
        }
    }
}
