using System;
using System.Collections.Generic;
using System.Text;

namespace ThaoTacVoiFile
{
    [Serializable]   //phải có dòng này
    class Student
    {
        private string name;
        
        private string address;

        public Student(string name, string address)
        {
            this.name = name;
            
            this.address = address;
        }
        public override string ToString()
        {
            return this.name + ", " + this.address;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
    }
}
