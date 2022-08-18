using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoNet3_1
{
    class Program3_1
    {
        static void Main(string[] args)
        {
            ConsoleColor old = Console.ForegroundColor;
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-ALEU41I\SQLEXPRESS;Initial Catalog=BooksDb;Integrated Security=True");
            using (connection)
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string sql = "insert into Category([Name]) values (@name)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar);
                    command.Transaction = transaction;

                    command.Parameters["@name"].Value = "Fantasy1";
                    command.ExecuteNonQuery();

                    command.Parameters["@name"].Value = "Detective1";
                    command.ExecuteNonQuery();

                    command.Parameters["@name"].Value = "Medicine1";
                    command.ExecuteNonQuery();

                    //throw new Exception("test transaction");

                    transaction.Commit();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("All inserted");
                    Console.ForegroundColor = old;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("ERR: ");
                    Console.ForegroundColor = old;
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
