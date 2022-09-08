using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdoNet12_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PharmacyEntities db;
        public MainWindow()
        {
            db = new PharmacyEntities();
            InitializeComponent();
            dgvSuppliers.ItemsSource = db.Suppliers.ToList();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //db.SaveChanges();
            throw new NotImplementedException();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Supplier supplier = new Supplier()
            {
                Name = edName.Text,
                PhoneNumber = edPhoneNumber.Text
            };
            db.Suppliers.Add(supplier);
            dgvSuppliers.ItemsSource = null;

            db.SaveChanges();
            dgvSuppliers.ItemsSource = db.Suppliers.ToList();
        }
    }
}
