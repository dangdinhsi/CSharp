using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ThaoTacVoiFile
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1
            /* Lưu chuỗi content vào file test.txt;
              string content = "Hello World!!!";
              System.IO.File.AppendAllText("test.txt", content); */

            /* Đọc từ file test.txt 
            string content = System.IO.File.ReadAllText("test.txt");
            Console.WriteLine(content);
            */


            // 2  
            /* Ghi dữ liệu 1 class vào file txt
             List<Student> list = new List<Student>();
              for(int i = 0; i < 10; i++)
               {
                   list.Add(new Student("fullname"+i,"address "+i));
               }
               for(int i=0;i<list.Count;i++)
               {
                   System.IO.File.AppendAllText("student.txt", list[i].ToString()+"\n");
               }
               Console.WriteLine("Success!!!");
              */


            // 3
            /* Đọc dữ liêu từ file đổ vào class
         string[] lines = System.IO.File.ReadAllLines("student.txt");
            foreach(string line in lines)
            {
                if (line ==null || line == "")
                {
                    continue;
                }
                string[] elements = line.Split(new char[] { ',' });
                if (elements.Length == 2)
                {
                    Student std = new Student(elements[0], elements[1]);
                         list.Add(std);
                }
            }
            foreach (Student std in list)
            {
                   Console.WriteLine(std.ToString());

            }
         */

            /* Ghi dữ liêu ra dưới dạng 1 mảng...
           
            List<Student> list = new List<Student>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(new Student("Name "+i,"Address "+i));
            }

            using (Stream stream = File.Open("studentlist.dat", FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, list);
            }
            Console.WriteLine("save success!!");
             */

            /* Đọc dữ liệu từ 1 mảng:

            List<Student> list = new List<Student>();
            using (Stream stream = File.Open("studentlist.dat", FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                list = (List<Student>) binaryFormatter.Deserialize(stream);
            }

            if(list != null) {
                foreach(Student std in list) {
                    Console.WriteLine(std.ToString());
                }
            }
                */
        }
    }
}
