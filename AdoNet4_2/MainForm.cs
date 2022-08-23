using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdoNet4_2
{
    public partial class MainForm : Form
    {
        SqlConnection connection = null;
        SqlConnectionStringBuilder builderString;
        public MainForm()
        {
            //Data Source=DESKTOP-ALEU41I\SQLEXPRESS;Initial Catalog=BooksDb;Integrated Security=True
            builderString = new SqlConnectionStringBuilder(@"Data Source=DESKTOP-ALEU41I\SQLEXPRESS;Initial Catalog=BooksDb;Integrated Security=True");
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text.Equals("Connect"))
            {
                builderString.AsynchronousProcessing = cbAsyncEnabled.Checked;
                connection = new SqlConnection(builderString.ConnectionString);
                connection.Open();
                cbAsyncEnabled.Enabled = false;
                btnConnect.Text = "Disconnect";
                string sql = "SELECT table_name FROM INFORMATION_SCHEMA.TABLES where (table_name <> 'sysdiagrams')";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                cmbTables.Items.Clear();
                while (reader.Read())
                {
                    cmbTables.Items.Add(reader[0]);
                }
                reader.Close();
                btnAsyncQuery.Enabled = true;
                btnSyncQuery.Enabled = true;
            }
            else
            {
                connection.Close();
                connection = null;
                cbAsyncEnabled.Enabled = true;
                btnAsyncQuery.Enabled = false;
                btnSyncQuery.Enabled = false;
                btnConnect.Text = "Connect";
            }
        }

        private void btnSyncQuery_Click(object sender, EventArgs e)
        {
            // sync method
            string sql = "waitfor delay '00:00:05'; select * from " + cmbTables.SelectedItem.ToString();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            bool first = true;
            DataTable table = new DataTable(cmbTables.SelectedText);

            while (reader.Read())
            {
                if (first)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        DataColumn column = new DataColumn(reader.GetName(i));
                        table.Columns.Add(column);
                    }
                    first = false;
                }

                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }
                table.Rows.Add(row);
            }
            reader.Close();
                dgvContent.DataSource = table;
                btnAsyncQuery.Enabled = true;
        }

        private void btnAsyncQuery_Click(object sender, EventArgs e)
        {
            btnAsyncQuery.Enabled = false;
            string sql = "waitfor delay '00:00:05'; select * from " + cmbTables.SelectedItem.ToString();
            SqlCommand command = new SqlCommand(sql, connection);
            //SqlDataReader reader = command.ExecuteReader();
            AsyncCallback callback = new AsyncCallback(GetData);
            command.BeginExecuteReader(callback, command);
        }

        private void GetData(IAsyncResult result)
        {
            SqlCommand command = result.AsyncState as SqlCommand;
            if (command == null)
                return;

            SqlDataReader reader = command.EndExecuteReader(result);

            bool first = true;
            DataTable table = new DataTable(cmbTables.SelectedText);

            while (reader.Read())
            {
                if (first)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        DataColumn column = new DataColumn(reader.GetName(i));
                        table.Columns.Add(column);
                    }
                    first = false;
                }

                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }
                table.Rows.Add(row);
            }
            reader.Close();

            Action a = () =>
            {
                dgvContent.DataSource = table;
                btnAsyncQuery.Enabled = true;
            };
            if (this.InvokeRequired)
            {
                this.Invoke(a);
            }
            else
            {
                a();
            }
        }
    }
}
