using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet7_1
{
    public partial class MainForm : Form
    {
        PharmacyDb db;
        public MainForm()
        {
            InitializeComponent();
            dgvTable.AutoGenerateColumns = false;
            dgvProducts.AutoGenerateColumns = false;
            dgvTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ConnectionForm connection = new ConnectionForm("");
            if (connection.ShowDialog() != DialogResult.OK)
                Close();

            db = new PharmacyDb(connection.ConnectionString);
            dgvTable.DataSource = db.Suppliers.ToList();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            int n = db.Suppliers.Count();
            Supplier supplier = new Supplier()
            {
                Name = $"Supplier {n + 1}",
                PhoneNumber = $"123{n + 1}"
            };
            db.Suppliers.Add(supplier);
            dgvTable.DataSource = null;
            db.SaveChanges();
            dgvTable.DataSource = db.Suppliers.ToList();
        }

        private void dgvTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count == 0)
                return;
            
            dgvProducts.DataSource = null;

            Supplier supplier = dgvTable.SelectedRows[0].DataBoundItem as Supplier;
            if (supplier == null)
                return;

            dgvProducts.DataSource = supplier.Products.ToList();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count == 0)
                return;

            Supplier supplier = dgvTable.SelectedRows[0].DataBoundItem as Supplier;
            if (supplier == null)
                return;

            int n = db.Products.Count() + 1;
            Product product = new Product()
            {
                Name = $"Product {n}",
                Cost = 10 + n
            };
            dgvProducts.DataSource = null;
            supplier.Products.Add(product);
            db.Products.Add(product);
            db.SaveChanges();

            dgvProducts.DataSource = supplier.Products.ToList();
        }
    }
}
