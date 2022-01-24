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
    public partial class RegisterCustomer : KryptonForm
    {
        Login parentForm;
        public RegisterCustomer(Login parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void RegisterCustomer_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Conection conection = new Conection();
            string hashedPassword = User.CreateHashPassword(passwordTextBox.Text);

            try
            {
                SqlParameter name = new SqlParameter("@name", nameTextBox.Text);
                SqlParameter last_name = new SqlParameter("@last_name", lastNameTextBox.Text);
                SqlParameter username = new SqlParameter("@phone_number", phoneNumberTextBox.Text);
                SqlParameter password = new SqlParameter("@login", usernameTextBox.Text);
                SqlParameter phone_number = new SqlParameter("@password", hashedPassword);

                SqlCommand cmd = new SqlCommand("customer_registration", conection.con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(name);
                cmd.Parameters.Add(last_name);
                cmd.Parameters.Add(username);
                cmd.Parameters.Add(password);
                cmd.Parameters.Add(phone_number);

                if (cmd.ExecuteNonQuery() <= 1)
                {
                    MessageBox.Show("Registration Failed: Username or phone number already registered");
                    return;
                }
                else
                {
                    MessageBox.Show("Registration Successfull");
                }
                parentForm.Show();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);//("Registration Failed: Choose another username and make sure your phone number is right");
            }

        }
    }
}
