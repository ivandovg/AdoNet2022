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

namespace AdoNet2_2
{
    public partial class MainForm : Form
    {
        const string connectionString = @"Data Source=DESKTOP-ALEU41I\SQLEXPRESS;Initial Catalog=BooksDb;Integrated Security=True";

        private SqlDataAdapter adapterAuthors;
        private DataTable authors;

        public MainForm()
        {
            InitializeComponent();
            adapterAuthors = new SqlDataAdapter("select * from Authors", connectionString);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapterAuthors);
            adapterAuthors.UpdateCommand = builder.GetUpdateCommand();
            adapterAuthors.DeleteCommand = builder.GetDeleteCommand();
            adapterAuthors.InsertCommand = builder.GetInsertCommand();

            authors = new DataTable("Authors");
            adapterAuthors.Fill(authors);
            dgvAuthors.AutoGenerateColumns = false;
            dgvAuthors.MultiSelect = false;
            dgvAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuthors.DataSource = authors;
            //dgvAuthors.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //int row=dgvAuthors.SelectedRows
            adapterAuthors.Update(authors);
            authors.Clear();
            dgvAuthors.DataSource = null;
            adapterAuthors.Fill(authors);
            dgvAuthors.DataSource = authors;
        }

        private void dgvAuthors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAuthors.SelectedRows.Count == 0)
                return;

            edFirstname.Text = dgvAuthors.SelectedRows[0].Cells[1].Value.ToString();
            edLastname.Text = dgvAuthors.SelectedRows[0].Cells[2].Value.ToString();
            edBirthdate.Text = dgvAuthors.SelectedRows[0].Cells[3].Value.ToString();
            edCountry.Text = dgvAuthors.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
