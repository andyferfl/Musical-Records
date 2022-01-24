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
    public partial class RegisterEmployee : KryptonForm
    {
        private Menu parentForm;
        private Conection conection = new Conection();

        public RegisterEmployee(Menu parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            
            roleComboBox.DataSource = null;

            SqlCommand cmd = new SqlCommand("select distinct role from Role where role != 'Customer'", conection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Rows.Add();
            da.Fill(dt);

            roleComboBox.DataSource = dt;
           
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var sure = MessageBox.Show("Are you sure?", "personal information will be changed", MessageBoxButtons.YesNo);
            if (sure == DialogResult.No)
                return;

            try
            {
                string hashedPassword = User.CreateHashPassword(passwordTextBox.Text);
                SqlParameter name = new SqlParameter("@name", nameTextBox.Text);
                SqlParameter lastname = new SqlParameter("@last_name", lastNameTextBox.Text);
                SqlParameter phonenumber = new SqlParameter("@phone_number", phoneNumberTextBox.Text);
                SqlParameter address = new SqlParameter("@address", addressTextBox.Text);
                SqlParameter passportNumber = new SqlParameter("@passport_number", passportTextBox.Text);
                SqlParameter login = new SqlParameter("@login", usernameTextBox.Text);
                SqlParameter password = new SqlParameter("password", hashedPassword);
                SqlParameter role = new SqlParameter("@role", roleComboBox.GetItemText(roleComboBox.SelectedItem));
                //exec employee_registration @name, @last_name, @phone_number, @address, @passport_number, @login, @password, @role

                SqlCommand cmd = new SqlCommand("employee_registration", conection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(name);
                cmd.Parameters.Add(lastname);
                cmd.Parameters.Add(phonenumber);
                cmd.Parameters.Add(address);
                cmd.Parameters.Add(passportNumber);
                cmd.Parameters.Add(role);
                cmd.Parameters.Add(login);
                cmd.Parameters.Add(password);

                if (cmd.ExecuteNonQuery() <= 1)
                {
                    MessageBox.Show("Personal information could't be changed");
                }
           
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Succesfully changed information");
            this.Close();
        }

    }
}
