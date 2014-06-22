using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture05
{
    class S01
    {
        public static void ConnectedRead()
        {
            var connection = new SqlCeConnection(@"Data Source=|DataDirectory|\Database.sdf;");
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "Select * from Employee";
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.Write("{0,-15}", reader[i]);
                Console.WriteLine();
            }
            connection.Close();
        }

        public static void ConnectedUpdate()
        {
            var connection = new SqlCeConnection(@"Data Source=|DataDirectory|\Database.sdf;");
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "delete from employee where Id=5";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "update employee set FirstName=@FirstName where Id=1";
            cmd.Parameters.AddWithValue("@FirstName", "ДЖИМ");
            cmd.ExecuteNonQuery();

            cmd.CommandText = "insert into employee values(100,'ПИТЕР','АБРАМС','100000','1')";
            cmd.ExecuteNonQuery();

            connection.Close();
            ConnectedRead();
        }

        public static void MainX()
        {
            Eraser.Erase();
            ConnectedRead();
            Console.WriteLine("-------------------");
            ConnectedUpdate();
        }
    }
}
