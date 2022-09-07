using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet11_1
{
    class Contact
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string Detail { get; set; }
        public Author Author { get; set; }
    }
}
