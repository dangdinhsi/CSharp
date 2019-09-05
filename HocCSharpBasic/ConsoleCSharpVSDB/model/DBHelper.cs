using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharpVSDB.model
{
    class DBHelper
    {
        private MySqlConnection connection;
        private string servername;
        private string database;
        private string uid;
        private string password;

        public DBHelper()
        {
            Initialize();   
        }

        public void Initialize()
        {
            servername = "localhost";
            database = "sidang0312";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + servername + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";CharSet=utf8;";
            connection = new MySqlConnection(connectionString);
        }
        public bool OpenConnect()
        {
            try
            {
                connection.Open();
                return true;

            }catch(Exception ex){
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool CloseConnect()
        {

            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Message);
                return false;
            }

        }
        public MySqlConnection ketnoi()
        {
            return this.connection;
        }
    }
}
