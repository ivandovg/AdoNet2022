using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Diagnostics;

namespace AdoNet9_1
{
    class Program9_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            //PrintMovieDetail();
            //PrintMovieDetailInclude();
            PrintMovieDetailExplicitLoad();
            sw.Stop();
            Console.WriteLine($"\nTotalSeconds: {sw.Elapsed.TotalSeconds}");

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
        private static void PrintMovieDetail()
        {
            // ленивая или отложеная загрузка - работает по умолчанию в EF
            using (MoviesDbEntities db = new MoviesDbEntities())
            {
                //db.Configuration.LazyLoadingEnabled = true;
                var movies = db.Movies.OrderBy(m => m.Title);
                foreach (var m in movies)
                {
                    Console.WriteLine($"{m.Title} - {m.Actor.FirstName} {m.Actor.LastName}");
                }
            }
        }
        private static void PrintMovieDetailInclude()
        {
            // безотложная загрузка
            using (MoviesDbEntities db = new MoviesDbEntities())
            {
                // отключить отложенную загрузку
                db.Configuration.LazyLoadingEnabled = false;

                var movies = db.Movies.Include("Actor").OrderBy(m => m.Title);
                foreach (var m in movies)
                {
                    Console.WriteLine($"{m.Title} - {m.Actor.FirstName} {m.Actor.LastName}");
                }
            }
        }
        private static void PrintMovieDetailExplicitLoad()
        {
            // явная загрузка
            //Entry()
            //Reference()
            //Collection()
            //Load()

            using (MoviesDbEntities db = new MoviesDbEntities())
            {
                // отключить отложенную загрузку
                db.Configuration.LazyLoadingEnabled = false;
                var movies = db.Movies.OrderBy(m => m.Title);
                
                foreach (var m in movies)
                {
                    // применяю явную загрузку связанного поля
                    db.Entry(m).Reference(a => a.Actor).Load();

                    Console.WriteLine($"{m.Title} - {m.Actor.FirstName} {m.Actor.LastName}");
                }
                Console.WriteLine();
                var moviesActors = db.Movies.OrderBy(a => a.Title);
                foreach (var m in moviesActors)
                {
                    // применяю явную загрузку связанного поля
                    db.Entry(m).Collection("Actors").Load();

                    Console.WriteLine($"{m.Title}");
                    foreach (var i in m.Actors)
                    {
                        Console.WriteLine($"\t{i.FirstName} {i.LastName}");
                    }
                }
            }
        }
    }
}
