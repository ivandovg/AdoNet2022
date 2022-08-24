using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace AdoNet5_2
{
    [Table(Name ="Authors")]
    public class Author
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column(Name = "Firstname", DbType = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(DbType = "nvarchar(50)")]
        public string Lastname { get; set; }

        [Column(DbType = "date")]
        public DateTime Birthdate { get; set; }

        [Column(DbType = "nvarchar(50)")]
        public string Country { get; set; }

        public override string ToString()
        {
            return $"({Id}) {Name} {Lastname}, {Birthdate.ToShortDateString()}";
        }
    }
}
