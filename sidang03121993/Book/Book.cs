using System;
using System.Collections.Generic;
using System.Text;

namespace QuanliBook
{
    class Book
    {
        private String bookName;

        private String bookAuthor;

        private String producer;

        private int yearPublishing;

        private float price;

        public Book()
        {
        }

        public Book(string bookName, string bookAuthor, string producer, int yearPublishing, float price)
        {
            this.BookName = bookName;
            this.BookAuthor = bookAuthor;
            this.Producer = producer;
            this.YearPublishing = yearPublishing;
            this.Price = price;
        }

        public string BookName { get => bookName; set => bookName = value; }
        public string BookAuthor { get => bookAuthor; set => bookAuthor = value; }
        public string Producer { get => producer; set => producer = value; }
        public int YearPublishing { get => yearPublishing; set => yearPublishing = value; }
        public float Price { get => price; set => price = value; }

        public virtual void input()
        {
            Console.WriteLine("Nhap thong tin cua sach");
            Console.Write("Ten sach:");
            string name = Console.ReadLine();
            Console.Write("Ten tac gia:");
            string author = Console.ReadLine();
            Console.Write("Nha san xuat:");
            string produc = Console.ReadLine();
            Console.Write("Nam phat hanh:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gia tien:");
            float tien = float.Parse(Console.ReadLine());
            bookName = name;
            bookAuthor = author;
            producer = produc;
            yearPublishing = year;
            price = tien;
        }
        public virtual void hienthi()
        {
            Console.WriteLine("Thong tin cua sach la:");
            Console.WriteLine("Ten sach: " +this.BookName);
            Console.WriteLine("Tac gia: " + this.BookAuthor);
            Console.WriteLine("Nha san xuat: " + this.Producer);
            Console.WriteLine("Nam phat hanh: " + this.YearPublishing);
            Console.WriteLine("Gia tien: " + this.Price);
        }
    }
}
