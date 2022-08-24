using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace AdoNet5_2
{
    class Program5_2
    {
        static void Main(string[] args)
        {
            string connectionStr = @"Data Source=DESKTOP-ALEU41I\SQLEXPRESS;Initial Catalog=BooksDb;Integrated Security=True";
            DataContext db = new DataContext(connectionStr);
            Table<Author> authors = db.GetTable<Author>();
            Console.WriteLine("All Authors");
            foreach (var a in authors)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\nFiltered records:");
            //var orderedDate = from a in db.GetTable<Author>()
            //                  where a.Name.StartsWith("T")
            //                  orderby a.Birthdate descending
            //                  select a;
            var orderedDate = db.GetTable<Author>().Where(a => a.Name.StartsWith("T")).OrderByDescending(a => a.Birthdate);
            foreach (var a in orderedDate)
            {
                Console.WriteLine(a);
            }

            //// insert record
            //Author author = CreateNewAuthor();
            //if (author != null)
            //{
            //    authors.InsertOnSubmit(author);
            //    db.SubmitChanges();
            //}
            //Console.WriteLine("\nAfter insert: ");

            //// update record
            //Console.Write("Enter Id: ");
            //int id = int.Parse(Console.ReadLine());
            //Author author = db.GetTable<Author>().Where(a => a.Id == id).FirstOrDefault();
            //if (author != null)
            //{
            //    Console.Write("New name: ");
            //    author.Name = Console.ReadLine();
            //    Console.Write("New lastname: ");
            //    author.Lastname = Console.ReadLine();
            //    db.SubmitChanges();
            //}

            // delete record
            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());
            Author author = db.GetTable<Author>().Where(a => a.Id == id).FirstOrDefault();
            if (author != null)
            {
                db.GetTable<Author>().DeleteOnSubmit(author);
                db.SubmitChanges();
            }

            Console.WriteLine("\nAfter changes: ");
            foreach (Author a in db.GetTable<Author>())
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }

        static Author CreateNewAuthor()
        {
            Author author = new Author();
            Console.WriteLine("Enter new data:");
            try
            {
                Console.Write("Name: ");
                author.Name = Console.ReadLine();
                Console.Write("Lastname: ");
                author.Lastname = Console.ReadLine();
                Console.Write("Birthdate: ");
                author.Birthdate = DateTime.Parse(Console.ReadLine());
                Console.Write("Country: ");
                author.Country = Console.ReadLine();
            }
            catch
            {
                return null;
            }
            return author;
        }
    }
}
