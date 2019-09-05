using System;
using System.Collections.Generic;
using System.Text;

namespace room
{
    class Table
    {
        private string ten;
        private string mauSac;
        private int soNgaySD;

        public Table()
        {
        }

        public Table(string ten, string mauSac, int soNgaySD)
        {
            this.ten = ten;
            this.mauSac = mauSac;
            this.soNgaySD = soNgaySD;
        }

        public string Ten { get => ten; set => ten = value; }
        public string MauSac { get => mauSac; set => mauSac = value; }
        public int SoNgaySD { get => soNgaySD; set => soNgaySD = value; }
    }
}
