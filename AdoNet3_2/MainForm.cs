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

namespace AdoNet3_2
{
    public partial class MainForm : Form
    {
        private SqlDataAdapter adapter;
        private DataSet dbSet;
        public MainForm()
        {
            InitializeComponent();
            //string connectionStr = @"Data Source=DESKTOP-ALEU41I\SQLEXPRESS;Initial Catalog=BooksDb;Integrated Security=True";
            //string sql = "select * from Themes;" +
            //    "select * from Authors;" +
            //    "select * from Format";

            //adapter = new SqlDataAdapter(sql, connectionStr);
            ////var dt = adapter.TableMappings.Add("Table", "Themes");
            ////dt.ColumnMappings.Add()
            //adapter.TableMappings.Add("Table", "Themes");
            //adapter.TableMappings.Add("Table1", "Authors");
            //adapter.TableMappings.Add("Table2", "Format");

            //dbSet = new DataSet("BooksDb");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectionForm connection = new ConnectionForm();
            if (connection.ShowDialog() != DialogResult.OK)
                return;


            // string connectionStr = @"Data Source=DESKTOP-ALEU41I\SQLEXPRESS;Initial Catalog=BooksDb;Integrated Security=True";
            string sql = "select * from Themes;" +
                "select * from Authors;" +
                "select * from Format";

            adapter = new SqlDataAdapter(sql, connection.ConnectionString);
            //var dt = adapter.TableMappings.Add("Table", "Themes");
            //dt.ColumnMappings.Add()
            adapter.TableMappings.Add("Table", "Themes");
            adapter.TableMappings.Add("Table1", "Authors");
            adapter.TableMappings.Add("Table2", "Format");

            dbSet = new DataSet("BooksDb");

            adapter.Fill(dbSet);
            // v1
            //dgvThemes.DataSource = dbSet.Tables[0];
            //dgvAuthors.DataSource = dbSet.Tables[1];
            //dgvFormat.DataSource = dbSet.Tables[2];

            // v2
            //dgvThemes.DataSource = dbSet.Tables["Table"];
            //dgvAuthors.DataSource = dbSet.Tables["Table1"];
            //dgvFormat.DataSource = dbSet.Tables["Table2"];

            // v3
            dgvThemes.DataSource = dbSet.Tables["Themes"];
            dgvAuthors.DataSource = dbSet.Tables["Authors"];
            dgvFormat.DataSource = dbSet.Tables["Format"];
        }
    }
}
