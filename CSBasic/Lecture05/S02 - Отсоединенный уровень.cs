using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture05
{
    class S02
    {
        public static void DisconnectedRead()
        {
            var connection = new SqlCeConnection(@"Data Source=|DataDirectory|\Database.sdf;");
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "Select * from Employee";
            var adapter = new SqlCeDataAdapter(cmd);
            var set = new DataSet();
            adapter.Fill(set, "Employee");
            connection.Close();

            var table = set.Tables[0];
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                    Console.Write("{0,-15}", table.Rows[i][j]);
                Console.WriteLine();
            }
        }

        public static void DisconnectedUpdate()
        {
            var connection = new SqlCeConnection(@"Data Source=|DataDirectory|\Database.sdf;");
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "Select * from Employee";
            var adapter = new SqlCeDataAdapter(cmd);
            var set = new DataSet();
            adapter.Fill(set, "Employee");
            new SqlCeCommandBuilder(adapter);
            connection.Close();

            var table = set.Tables[0];

            foreach (DataRow row in table.Rows)
                if ((int)row["Id"] == 5)
                {
                    row.Delete();
                    break;
                }

            table.Rows[0]["FirstName"] = "ДЖИМ";

            var newRow = table.NewRow();
            newRow["Id"] = 100;
            newRow["FirstName"] = "ПИТЕР";
            newRow["LastName"] = "АБРАМС";
            newRow["Salary"] = 100000;
            table.Rows.Add(newRow);

            connection.Open();
            adapter.Update(set.Tables[0]);
            connection.Close();

            DisconnectedRead();
        }
        public static void MainX()
        {
            Eraser.Erase();
            DisconnectedRead();
            Console.WriteLine("-------------------");
            DisconnectedUpdate();
        }
    }
}
