using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonInCSharp
{
    //Bước 1: import thư viện Newtonsoft.Json từ nuget package!!
    class Program
    {
        static void Main(string[] args)
        {
            /*   Lưu vào C:\Users\Sidang\source\repos\HocCSharpBasic\JsonInCSharp\bin\Debug\netcoreapp2.1   
               
               List<Student> list = new List<Student>();
               Student student = new Student("si","d00474");
               Student student2 = new Student("ngoc", "n00123");
               list.Add(student);
               list.Add(student2);
               string jsonText = JsonConvert.SerializeObject(list);
               Console.WriteLine(jsonText);
               File.WriteAllText("studentlist.json", jsonText);
               Console.WriteLine("Success!!!");*/



            /* đọc ngược lại!!!! */
            string jsonText = String.Empty; 
             jsonText = File.ReadAllText(@"studentlist.json");
            List<Student> listStudent = JsonConvert.DeserializeObject<List<Student>>(jsonText);
            foreach(var student in listStudent)
            {
                Console.WriteLine(student.ToString());
            }

           

        }
    }
}
