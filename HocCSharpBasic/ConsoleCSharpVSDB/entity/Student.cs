using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharpVSDB.entity
{
    class Student
    {

        private int id;
        private string name;
        private string rollnumber;

        public Student()
        {
        }

        public Student(string name, string rollnumber)
        {
            this.name = name;
            this.rollnumber = rollnumber;
        }

        public Student(int id, string name, string rollnumber)
        {
            this.id = id;
            this.name = name;
            this.rollnumber = rollnumber;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Rollnumber { get => rollnumber; set => rollnumber = value; }

        public override string ToString()
        {
            return this.name + "-" + this.rollnumber;
        }


    }
}
