using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace AdoNet11_1
{
    class Program
    {
        private const string connectionStr = @"Data Source=DESKTOP-ALEU41I\SQLEXPRESS;Initial Catalog=BooksDb;Integrated Security=True";
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            
            //TestRead1(connection);
            TestRead2(connection);

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }

        private static void TestRead1(IDbConnection connection)
        {
            using (connection)
            {
                connection.Open();
                // run query
                string sql = "select * from Authors";
                var result = connection.Query(sql);
                foreach (var a in result)
                {
                    Console.WriteLine($"{a.Firstname} {a.Lastname}, {a.Birthdate}");
                }
            }
        }
        private static void TestRead2(IDbConnection connection)
        {
            using (connection)
            {
                connection.Open();
                // run query
                string sql = "select * from Authors";
                var result = connection.Query<Author>(sql);
                foreach (var a in result)
                {
                    Console.WriteLine(a.ToString());
                }
            }
        }
    }
}
