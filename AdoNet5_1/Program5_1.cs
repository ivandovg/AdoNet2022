using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet5_1
{
    class Program5_1
    {
        static List<User> users = new List<User>();
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();
            //list.AddRange(new string[] { "Ukraine", "USA", "Brazilia", "Italy", "Spain" });
            //PrintCollection("unordered list", list);
            //Console.WriteLine();

            //var o = from c in list
            //        //orderby c
            //        where c.StartsWith("U")
            //        select c;

            //PrintCollection("ordered list", o);

            users.AddRange(new User[] {
                new User(){Id = 4, FirstName="F4", LastName="L4", Birthdate=DateTime.Now},
                new User(){Id = 2, FirstName="F2", LastName="L2", Birthdate=DateTime.Now},
                new User(){Id = 3, FirstName="F3", LastName="L3", Birthdate=DateTime.Now},
                new User(){Id = 1, FirstName="F1", LastName="L1", Birthdate=DateTime.Now},
                new User(){Id = 5, FirstName="F5", LastName="L5", Birthdate=DateTime.Now}
            });

            //var namesOnly = (from u in users
            //                orderby u.FirstName
            //                select new { u.FirstName, u.LastName }).Select(t=>t.FirstName);
            //var namesOnly = users.OrderBy(a => a.FirstName).Select(b => new { b.FirstName, b.LastName });
            //Console.WriteLine("\nOnly names");
            //foreach (var item in namesOnly)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //}


            //var n = from u in users
            //        orderby u.FirstName
            //        select $"{u.FirstName} {u.LastName}";
            //var n = users.OrderBy(u => u.FirstName).Select(u => $"{u.FirstName} {u.LastName}");

            //Console.WriteLine("\nOnly names");
            //foreach (var item in n)
            //{
            //    Console.WriteLine(item);
            //}

            var namesOnly = users.OrderBy(a => a.FirstName).Select(b => new { Name = b.FirstName, Surname = b.LastName });
            Console.WriteLine("\nOnly names");
            foreach (var item in namesOnly)
            {
                Console.WriteLine($"{item.Name} {item.Surname}");
            }

            Console.ReadKey();
        }

        private static void PrintCollection(string message, IEnumerable<object> collection)
        {
            Console.WriteLine(message);
            foreach (string s in collection)
            {
                Console.WriteLine(s);
            }
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
