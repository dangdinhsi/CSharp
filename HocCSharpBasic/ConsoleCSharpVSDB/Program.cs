using ConsoleCSharpVSDB.entity;
using ConsoleCSharpVSDB.model;
using System;
using System.Collections.Generic;

namespace ConsoleCSharpVSDB
{
    class Program
    {
        private static StudentModel model = new StudentModel();
        static void Main(string[] args)
        {
            GenerateMenu();
        }
        static void getListStudent()
        {
            List<Student> list = model.listStudent();
            if (list.Count != 0)
            {
                Console.WriteLine("Student list from Database:");
                Console.WriteLine("{0, -20} {1, -20} {2, -20}","ID" ,"NAME", "ROLLNUMBER");
                foreach (var st in list)
                {
                    Console.WriteLine("{0, -20} {1, -20} {2, -20}", st.Id, st.Name, st.Rollnumber);
                }
            }
            else
            {
                Console.WriteLine("Danh sách trống hoặc chưa được kết nối đến database!!!!");
            }
        }
        static void AddStudent()
        {
            Boolean check = true;
            string namest = null;
            string rollst = null;
            while (check)
            {
                Console.Write("Nhập name:");
               string _name = Console.ReadLine();
                if (_name.Length==0)
                {
                    Console.WriteLine("Name không thể bỏ trống!!!!");
                }else
                {
                    namest = _name;
                    break;
                }
            }
            while (check)
            {
                Console.Write("Nhập rollnumber:");
                string _roll = Console.ReadLine();
                if (_roll.Length == 0)
                {
                    Console.WriteLine("Rollnumber không thể bỏ trống!!!!");
                }
                else
                {
                    rollst = _roll;
                    break;
                }
            }

            Student student = new Student(namest,rollst);
            model.addStudent(student);
                Console.WriteLine("Thêm thành công sinh viên vào database!!!");
        }
        static void DeleteStudent()
        {
            //xoa sinh vien
        }

        static void UpdateStudent()
        {
            // sua sinh vien
        }

        static void FindStudentByName()
        {
            //tim kiem theo ten
        }
        static void GenerateMenu()
        {
            while (true)
            {
                Console.WriteLine("----------Quản lý sinh viên---------");
                Console.WriteLine("1. Thêm mới sinh viên.");
                Console.WriteLine("2. Hiển thị danh sách.");
                Console.WriteLine("3. Tìm kiếm theo tên.");
                Console.WriteLine("4. Thoát.");
                Console.WriteLine("------------------------------------");
                Console.Write("Nhập lựa chọn của bạn: ");
                var choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //lua chon 1
                        AddStudent();
                        break;
                    case 2:
                        getListStudent();
                        //lua chon 2
                        break;
                    case 3:
                        FindStudentByName();
                       //lua chon 3
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}
