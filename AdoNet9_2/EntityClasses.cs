using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace AdoNet9_2
{
    public class Paticipant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Country { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }

        public virtual ICollection<Result> Results { get; set; }
    }

    public class Competition
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }

        public virtual ICollection<Result> Results { get; set; }
    }

    public class Result
    {
        public int Id { get; set; }
        public int Place { get; set; }
        //[Required]
        public virtual Competition Competition { get; set; }
        //[Required]
        public virtual Paticipant Paticipant { get; set; }
    }

    public class CompetitionsDb : DbContext
    {
        public CompetitionsDb() : base("DbConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PaticipantMap());
            modelBuilder.Configurations.Add(new CompetitionMap());
            modelBuilder.Configurations.Add(new ResultMap());

            modelBuilder.Entity<Result>()
                .HasRequired(p => p.Competition)
                .WithRequiredDependent()
                .Map(m => m.MapKey("CompetitionId"));

            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<Paticipant> Paticipants { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}
