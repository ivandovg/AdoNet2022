using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoNet2_1
{
    class ProgramAdo2_1
    {
        static void Main(string[] args)
        {
            string connectionStr = System.Configuration.ConfigurationManager.ConnectionStrings["BooksConnection"].ConnectionString;
            
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                ReadFromDb(connection, "select * from Publisher");
                //AddTheme(connection);
                AddPublisher(connection);
                ReadFromDb(connection, "select * from Publisher");
            }
            Console.ReadKey();
        }

        static void AddPublisher(SqlConnection connection)
        {
            Console.Write("New Publisher\n\tName: ");
            string name = Console.ReadLine();
            Console.Write("\tAddress: ");
            string addres = Console.ReadLine();
            Console.Write("\tContacts: ");
            string contacts = Console.ReadLine();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "AddPublisher";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            // input parameters
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar, 200).Value = name;
            command.Parameters.Add("@addres", System.Data.SqlDbType.NVarChar, 400).Value = addres;
            command.Parameters.Add("@contacts", System.Data.SqlDbType.NVarChar, 200).Value = contacts;

            //output parameters
            SqlParameter publisherId = new SqlParameter("@publisherId", System.Data.SqlDbType.Int);
            publisherId.Direction = System.Data.ParameterDirection.Output;
            command.Parameters.Add(publisherId);

            int result = command.ExecuteNonQuery();
            if (result == 1)
            {
                //int id = (int)command.Parameters["@publisherId"].Value;
                if (int.TryParse(command.Parameters["@publisherId"].Value.ToString(), out int id))
                    Console.WriteLine($"Publisher inserted as Id = {id}");
                else
                    Console.WriteLine("ERROR Convert return parameter!!!");
            }
        }

        static void AddTheme(SqlConnection connection)
        {
            Console.Write("Enter theme name: ");
            string name = Console.ReadLine();

            // string sql = $"insert into Themes values ('{name}')";
            // insert into Themes values ('t3'; drop table Themes;'')
            // select * from Themes where ([Name] = '';select * from users;''+'%')


            string sql = "insert into Themes values (@name)";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;

            command.Parameters.AddWithValue("@name", name);
            // insert into Themes values ('t3; drop table Themes;')
            // select * from Themes where ([Name] = ';select * from users;'+'%')

            Console.WriteLine($"Record affected: {command.ExecuteNonQuery()}");
        }
        static void ReadFromDb(SqlConnection connection, string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            bool first = true;
            do
            {
                while (reader.Read())
                {
                    if (first)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader.GetName(i) + "\t");
                        }
                        first = false;
                        Console.WriteLine();
                    }
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader.GetValue(i) + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                first = true;
            } while (reader.NextResult());
            reader.Close();
        }

        //static int RunQuery(SqlConnection connection, string query)
        //{
        //    SqlCommand command = connection.CreateCommand();
        //    command.CommandText = query;
        //    return command.ExecuteNonQuery();
        //}
    }
}
