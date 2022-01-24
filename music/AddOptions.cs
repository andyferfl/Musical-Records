using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace music
{
    public partial class AddOptions : KryptonForm
    {
        private Menu parentForm;
        private Conection conection = new Conection();

        public AddOptions(Menu parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void roleButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(roleTextBox.Text))
            {
                MessageBox.Show("insert the role you want to add first");
                return;
            }

            var sure = MessageBox.Show("Are you sure?", "you will add a new role", MessageBoxButtons.YesNo);
            if (sure == DialogResult.No)
                return;

            try
            {
                SqlParameter role = new SqlParameter("@role", roleTextBox.Text);

                SqlCommand cmd = new SqlCommand("insert into [Role] ([role]) values (@role)", conection.con);
                cmd.Parameters.Add(role);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Role could't be added");
                }

                MessageBox.Show("Role successfully added");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(statusTextBox.Text))
            {
                MessageBox.Show("insert the status you want to add first");
                return;
            }

            var sure = MessageBox.Show("Are you sure?", "you will add a new status", MessageBoxButtons.YesNo);
            if (sure == DialogResult.No)
                return;

            try
            {
                SqlParameter status = new SqlParameter("@status", statusTextBox.Text);

                SqlCommand cmd = new SqlCommand("insert into Status(status) values (@status)", conection.con);
                cmd.Parameters.Add(status);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Status could't be added");
                }

                MessageBox.Show("Status successfully added");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void typeButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(typeTextBox.Text))
            {
                MessageBox.Show("insert the type you want to add first");
                return;
            }

            var sure = MessageBox.Show("Are you sure?", "you will add a new type", MessageBoxButtons.YesNo);
            if (sure == DialogResult.No)
                return;

            try
            {
                SqlParameter type = new SqlParameter("@type", typeTextBox.Text);

                SqlCommand cmd = new SqlCommand("insert into RecordType(type) values (@type)", conection.con);
                cmd.Parameters.Add(type);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Type could't be added");
                }


                MessageBox.Show("Type successfully added");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void AddOptions_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!parentForm.Visible)
            {
                parentForm.Close();
            }
        }
    }
}
