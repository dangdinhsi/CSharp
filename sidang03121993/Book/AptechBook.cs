using System;
using System.Collections.Generic;
using System.Text;

namespace QuanliBook
{
    class AptechBook:Book
    {
        private string language;
        private int semester;

        public AptechBook()
        {
        }

        public AptechBook(string bookName, string bookAuthor, string producer, int yearPublishing, float price):base(bookName, bookAuthor, producer, yearPublishing, price)
        {
            this.Language = language;
            this.Semester = semester;
        }

        public string Language { get => language; set => language = value; }
        public int Semester { get => semester; set => semester = value; }

        public override void input()
        {
            base.input();
            Console.Write("Nhap ngon ngu:");
            string ngongu =Console.ReadLine();
            Console.Write("Nhap hoc ki:");
            int hocki = int.Parse(Console.ReadLine());
            language = ngongu;
            semester = hocki;
        }
        public override void hienthi()
        {
            base.hienthi();
            Console.WriteLine("Ngon ngu la: " + this.Language);
            Console.WriteLine("Hoc ki: " + this.Semester);
        }
    }
}
