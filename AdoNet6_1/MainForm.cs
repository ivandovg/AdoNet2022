using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace AdoNet6_1
{
    public partial class MainForm : Form
    {
        private MoviesDbEntities MoviesDb;
        public MainForm()
        {
            InitializeComponent();
            MoviesDb = new MoviesDbEntities();
            dgvActors.AutoGenerateColumns = false;
            dgvActors.ReadOnly = true;
            dgvActors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvActors.DataSource = MoviesDb.Actors.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvActors.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show("Delete selected record(s)?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            for (int i = 0; i < dgvActors.SelectedRows.Count; i++)
            {
                Actor actor = dgvActors.SelectedRows[i].DataBoundItem as Actor;
                if (actor == null)
                    continue;

                MoviesDb.Actors.Remove(actor);
            }
            UpdateTableActors();
        }
        private void UpdateTableActors()
        {
            dgvActors.DataSource = null;
            MoviesDb.SaveChanges();
            dgvActors.DataSource = MoviesDb.Actors.ToList();
        }

        private void dgvActors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvActors.SelectedRows.Count == 0)
                return;

            Actor actor = dgvActors.SelectedRows[0].DataBoundItem as Actor;
            if (actor == null)
                return;

            edFirstname.Text = actor.FirstName;
            edLastname.Text = actor.LastName;
            edBirth.Value = actor.Birth;
            edCountry.Text = actor.Country;
            edOscar.Value = (actor.Oscar.HasValue) ? actor.Oscar.Value : 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edFirstname.Text)
                || string.IsNullOrEmpty(edLastname.Text))
                return;

            if (dgvActors.SelectedRows.Count == 0)
                return;

            Actor actor = dgvActors.SelectedRows[0].DataBoundItem as Actor;
            if (actor == null)
                return;

            actor.FirstName = edFirstname.Text;
            actor.LastName = edLastname.Text;
            actor.Birth = edBirth.Value;
            actor.Country = edCountry.Text;
            actor.Oscar = (int)edOscar.Value;

            UpdateTableActors();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edFirstname.Text)
                || string.IsNullOrEmpty(edLastname.Text))
                return;

            Actor actor = new Actor()
            {
                FirstName = edFirstname.Text,
                LastName = edLastname.Text,
                Birth = edBirth.Value,
                Country = edCountry.Text,
                Oscar = (int)edOscar.Value
            };

            MoviesDb.Actors.Add(actor);
            UpdateTableActors();
        }
    }
}
