using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;

namespace AdoNet4_1
{
    public partial class MainForm : Form
    {
        DbProviderFactory factory = null;
        DbConnection connection = null;

        string providerStr = string.Empty;
        string connectionStr = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGetFactory_Click(object sender, EventArgs e)
        {
            DataTable table = DbProviderFactories.GetFactoryClasses();
            dgvContent.DataSource = table;

            cmbProvider.DataSource = table;
            cmbProvider.DisplayMember = "InvariantName";
            cmbProvider.ValueMember = "InvariantName";
        }

        private void cmbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExecute.Enabled = false;

            providerStr = cmbProvider.SelectedValue.ToString();
            if (string.IsNullOrEmpty(providerStr))
                return;

            // Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Data\db1.mdf;Integrated Security=True;Connect Timeout=30
            // Data Source=DESKTOP-ALEU41I\SQLEXPRESS;Initial Catalog=BooksDb;Integrated Security=True
            // Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Data\db1.mdb
            // Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Data\db1.accdb
            connectionStr = string.Empty;
            foreach (ConnectionStringSettings item in ConfigurationManager.ConnectionStrings)
            {
                if (item.ProviderName.Equals(providerStr))
                {
                    connectionStr = item.ConnectionString;
                    break;
                }
            }

            if (string.IsNullOrEmpty(connectionStr))
                return;

            factory = DbProviderFactories.GetFactory(providerStr);
            connection = factory.CreateConnection();
            connection.ConnectionString = connectionStr;
            btnExecute.Enabled = true;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (connection == null)
                return;

            connection.ConnectionString = connectionStr;

            using (connection)
            {
                connection.Open();
                DbCommand command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = edSQL.Text;

                DbDataAdapter adapter = factory.CreateDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvContent.DataSource = table;
            }
        }
    }
}
