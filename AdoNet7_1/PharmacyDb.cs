using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace AdoNet7_1
{
    public class PharmacyDb: DbContext
    {
        public PharmacyDb(): base("DbConnection") { }
        public PharmacyDb(string connectionString): base(connectionString) { }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
    }

    public class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public double Cost { get; set; }

        [Required]
        public int SupplierId { get; set; }
    }
}
