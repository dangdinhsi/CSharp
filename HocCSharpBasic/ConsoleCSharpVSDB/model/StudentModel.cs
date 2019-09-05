using ConsoleCSharpVSDB.entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharpVSDB.model
{
    class StudentModel
    {
        private DBHelper dBHelper = new DBHelper();
       public Student addStudent(Student student)
        {
            string query = "INSERT INTO students (name, rollNumber) VALUES ('" + student.Name + "', '" + student.Rollnumber + "')";
            if (dBHelper.OpenConnect() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, dBHelper.ketnoi());
                    cmd.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error " + ex.Message);
                }
                finally
                {
                    dBHelper.CloseConnect();
                }
            }
            return student;
        }

        public List<Student> listStudent()
        {
            List<Student> list = new List<Student>();
            String sql = "select * from students";
            if (dBHelper.OpenConnect())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql,dBHelper.ketnoi());
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt16("id");
                        String ten = reader.GetString("name");
                        String roll = reader.GetString("rollnumber");
                        Student student = new Student(id, ten, roll);
                        list.Add(student);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    dBHelper.CloseConnect();
                }
            }
            return list;
        }
    }
}
