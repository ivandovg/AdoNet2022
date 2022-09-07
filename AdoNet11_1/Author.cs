using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet11_1
{
    class Author
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} ({Country}), {Birthdate.ToShortDateString()}";
        }
    }
}
