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

namespace AdoNet7_1
{
    public partial class ConnectionForm : Form
    {
        private SqlConnectionStringBuilder builder;

        public string ConnectionString => builder.ConnectionString;
        public ConnectionForm(string str)
        {
            if (string.IsNullOrEmpty(str))
                builder = new SqlConnectionStringBuilder(@"Data Source=DESKTOP-ALEU41I\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True");
            else
            {
                builder = new SqlConnectionStringBuilder(str);
            }
            
            InitializeComponent();

            edAddress.Text = builder.DataSource;
            edDatabase.Text = builder.InitialCatalog;
            edLogin.Text = builder.UserID;
            edPassword.Text = builder.Password;
            if (builder.IntegratedSecurity)
                rbWindows.Checked = true;
            else
                rbSQL.Checked = true;
        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            grUserPassword.Enabled = rbSQL.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            builder.DataSource = edAddress.Text;
            builder.InitialCatalog = edDatabase.Text;
            builder.IntegratedSecurity = rbWindows.Checked;
            if (rbSQL.Checked)
            {
                builder.UserID = edLogin.Text;
                builder.Password = edPassword.Text;
            }
            else
            {
                builder.UserID = string.Empty;
                builder.Password = string.Empty;
            }
        }
    }
}
