using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet8_1
{
    public partial class MainForm : Form
    {
        ToysDb db;
        public MainForm()
        {
            InitializeComponent();
            dgvManufacturers.AutoGenerateColumns = false;
            dgvToys.AutoGenerateColumns = false;

            db = new ToysDb();
            db.Configuration.LazyLoadingEnabled = false;

            dgvManufacturers.DataSource = db.Manufacturers.ToList();
            //AddRecord(); // Manufacturers

            UpdateToysList();

            // fill combobox
            cmbManufacturer.DataSource = db.Manufacturers.ToList();
            cmbManufacturer.DisplayMember = "ShortName";
            cmbManufacturer.ValueMember = "Id";
            cmbManufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void UpdateToysList()
        {
            dgvToys.DataSource = null;

            dgvToys.DataSource = db.Toys.Include("Manufacturer").ToList();

            colToysManufacturer.DataSource = db.Manufacturers.ToList();
            colToysManufacturer.DataPropertyName = "ManufacturerId";
            colToysManufacturer.DisplayMember = "ShortName";
            colToysManufacturer.ValueMember = "Id";
        }
        private void AddRecord()
        {
            for (int i = 0; i < 5; i++)
            {
                Manufacturer m = new Manufacturer()
                {
                    ShortName = "Manufacturer " + i.ToString(),
                    Phone = $"123-{i + 10}"
                };
                db.Manufacturers.Add(m);
            }
            db.SaveChanges();
        }

        private void btnAddToys_Click(object sender, EventArgs e)
        {
            Manufacturer m = cmbManufacturer.SelectedItem as Manufacturer;
            if (m == null)
                return;

            Toy toy = new Toy()
            {
                Name = edToyName.Text,
                Cost = edToyCost.Value,
                Count = (int)edToyCount.Value,
                Manufacturer = m
            };
            db.Toys.Add(toy);
            db.SaveChanges();
            UpdateToysList();
        }
    }
}
