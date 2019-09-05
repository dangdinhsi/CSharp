using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class People
    {
        /*tao ra bo getter,setter*/
        public string Fullname { get; set; }
        public string Address { get; set; }

        public string Gender { get; set; }
        public int age { get; set; }

        public People(string fullname, string address, string gender, int age)
        {
            Fullname = fullname;
            Address = address;
            Gender = gender;
            this.age = age;
        }
    }
}
