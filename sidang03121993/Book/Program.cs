using System;
using System.Collections.Generic;
namespace QuanliBook
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Book book = new Book();
            book.input();
            book.hienthi();*/
            AptechBook aptechBook = new AptechBook();
            aptechBook.input();
            aptechBook.hienthi();
        }
        
    }
}
