using System;
using System.Collections.Generic;
using System.Text;

namespace JsonInCSharp
{
    class Student
    {
        private string fullname;
        private string address;

        public Student(string fullname, string address)
        {
            this.fullname = fullname;
            this.address = address;
        }
        public override string ToString()
        {
            return "Tên:"+this.fullname + ",Địa chỉ:" + this.address;
        }


        public string Fullname { get => fullname; set => fullname = value; }
        public string Address { get => address; set => address = value; }
    }
}
