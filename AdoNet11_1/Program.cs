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

            //Test1Read(connection);
            //Test2Read(connection);
            //Test3Insert(connection);
            //Test4Delete(connection);
            //Test5Delete(connection);
            //Test6ReadJoin(connection);
            Test7StoredProcedure(connection);


            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }

        private static void Test1Read(IDbConnection connection)
        {
            connection.ConnectionString = connectionStr;
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
        private static void Test2Read(IDbConnection connection)
        {
            connection.ConnectionString = connectionStr;
            using (connection)
            {
                connection.Open();
                // run query
                string sql = "select * from Authors";
                var result = connection.Query<Author>(sql);
                foreach (var a in result)
                {
                    Console.WriteLine(a.Id.ToString() + ") " + a.ToString());
                }
            }
        }
        private static void Test3Insert(IDbConnection connection)
        {
            connection.ConnectionString = connectionStr;
            using (connection)
            {
                connection.Open();
                // run query
                string sql = "insert into Authors([Firstname],[Lastname],[Birthdate],[Country]) " +
                    "values(@Firstname, @Lastname, @Birthdate, @Country)";

                List<Author> authors = new List<Author>();
                for (int i = 0; i < 5; i++)
                {
                    Author author = new Author()
                    {
                        Firstname = $"D{i + 100}",
                        Lastname = $"F{i + 1000}",
                        Birthdate = new DateTime(1930, i + 3, i + 1),
                        Country = $"W{i + 50}"
                    };
                    authors.Add(author);
                }

                var rows = connection.Execute(sql, authors);
                Console.WriteLine("Affected rows: " + rows.ToString());
            }

            Console.WriteLine("\nAll Authors");
            Test2Read(connection);
        }
        private static void Test4Delete(IDbConnection connection)
        {
            Console.WriteLine("\nAll Authors");
            Test2Read(connection);

            connection.ConnectionString = connectionStr;
            using (connection)
            {
                connection.Open();
                // run query
                string sql = "delete from Authors where [Id] = @Id";

                Console.Write("Enter id: ");
                int id = int.Parse(Console.ReadLine());

                var rows = connection.Execute(sql, new { Id = id});
                Console.WriteLine("Affected rows: " + rows.ToString());
            }

            Console.WriteLine("\nAll Authors");
            Test2Read(connection);

        }

        private static void Test5Delete(IDbConnection connection)
        {
            Console.WriteLine("\nAll Authors");
            Test2Read(connection);

            connection.ConnectionString = connectionStr;
            using (connection)
            {
                connection.Open();
                // run query
                string sql = "delete from Authors where [Id] in @ids";

                List<int> ids = new List<int>();
                do
                {
                    Console.Write("Enter id or 0 for exit: ");
                    int id = int.Parse(Console.ReadLine());
                    if (id == 0)
                        break;
                    ids.Add(id);
                } while (true);

                var rows = connection.Execute(sql, new { ids });
                Console.WriteLine("Affected rows: " + rows.ToString());
            }

            Console.WriteLine("\nAll Authors");
            Test2Read(connection);

        }
        private static void Test6ReadJoin(IDbConnection connection)
        {
            connection.ConnectionString = connectionStr;
            using (connection)
            {
                connection.Open();
                // run query
                string sql = "select * from Contacts as C inner join Authors as A on A.Id = C.AuthorId order by C.AuthorId";
                var result = connection.Query<Contact, Author, Contact>(sql, (c, a) => {
                        c.Author = a;
                        return c;
                    }/*, splitOn: "Id"*/);

                Console.WriteLine("\nAll Contacts");
                foreach (var c in result)
                {
                    Console.WriteLine($"{c.Author.Firstname} {c.Author.Lastname} >> {c.ContactName } = {c.Detail}");
                }
            }
        }

        private static void Test7StoredProcedure(IDbConnection connection)
        {
            connection.ConnectionString = connectionStr;
            using (connection)
            {
                connection.Open();
                Console.WriteLine("Add Publisher");

                string sql = "AddPublisher";

                var p = new DynamicParameters();
                Console.Write("Name: ");
                p.Add("@name", Console.ReadLine(), DbType.String, ParameterDirection.Input, 200);
                
                Console.Write("Address: ");
                string s = Console.ReadLine();
                p.Add("@addres", s, DbType.String, ParameterDirection.Input, 400);

                Console.Write("Contacts: ");
                s = Console.ReadLine();
                p.Add("@contacts", s, DbType.String, ParameterDirection.Input, 200);

                p.Add("@publisherId", DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@return", DbType.Int32, direction: ParameterDirection.ReturnValue);

                var result = connection.Execute(sql, p, commandType: CommandType.StoredProcedure);

                Console.WriteLine($"Return result: {result}, Return: {p.Get<int>("@return")}, Publisher Id: {p.Get<int>("@publisherId")}");

                // run query
                sql = "select * from [Publisher]";
                var pubResult = connection.Query(sql);
                foreach (var t in pubResult)
                {
                    Console.WriteLine(t);
                }
            }
        }
    }
}
