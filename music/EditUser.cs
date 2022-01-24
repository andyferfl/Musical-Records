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
    public partial class EditUser : KryptonForm
    {
        private Menu parentForm;
        private Conection conection = new Conection();
        private int user_id;
        private int data_id;
        private bool isCustomer = true;
        public EditUser(Menu parent, String userId = null, String dataId = null)
        {
            InitializeComponent();
            parentForm = parent;

            if (userId != null && dataId != null)
            {
                user_id = Int32.Parse(userId);
                data_id = Int32.Parse(userId);
            }
            else
            {
                getCurrentUserInfo();
            }
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            SqlParameter id = new SqlParameter("@user_id", user_id.ToString());

            String query = @"select u.user_id, u.login, r.role, coalesce(c.customer_id, e.employee_id) as id,
	                                coalesce(c.name, e.name) as name, coalesce(c.last_name, e.last_name) as last_name,
	                                coalesce(c.phone_number, e.phone_number) as phone_number, e.address, e.passport_number
                                from [User] u
                                join Role r on u.role_id = r.role_id
                                left join Customer c on c.[user_id] = u.[user_id]
                                left join Employee e on e.[user_id] = u.[user_id]
                                where (u.user_id = @user_id)";

            SqlCommand cmd = new SqlCommand(query, conection.con);
            cmd.Parameters.Add(id);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                nameTextBox.Text = reader["name"].ToString();
                lastNameTextBox.Text = reader["last_name"].ToString();
                phoneNumberTextBox.Text = reader["phone_number"].ToString();
                addressTextBox.Text = reader["address"].ToString();
                passportTextBox.Text = reader["passport_number"].ToString();
                usernameTextBox.Text = reader["login"].ToString();

                if (reader["login"].ToString() != parentForm.currentUser.username)
                {
                    newPasswordLabel.Hide();
                    newPasswordTextBox.Hide();
                }

            }

            reader.Close();

            if (parentForm.currentUser.access == "Customer")
            {
                addressLabel.Hide();
                addressTextBox.Hide();
                passportLabel.Hide();
                passportTextBox.Hide();
                roleLabel.Hide();
                roleComboBox.Hide();
            }
            else if (parentForm.currentUser.access == "Seller")
            {
                nameTextBox.Enabled = false;
                lastNameTextBox.Enabled = false;
                phoneNumberTextBox.Enabled = false;
                addressTextBox.Enabled = false;
                passportTextBox.Enabled = false;
                roleLabel.Hide();
                roleComboBox.Hide();
            }
            else
            {
                roleComboBox.DataSource = null;

                cmd = new SqlCommand("select distinct role from Role where role != 'Customer'", conection.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dt.Rows.Add();
                da.Fill(dt);

                roleComboBox.DataSource = dt;
            }

            if (String.IsNullOrEmpty(addressTextBox.Text) && String.IsNullOrEmpty(passportTextBox.Text))
            {
                addressLabel.Hide();
                addressTextBox.Hide();
                passportLabel.Hide();
                passportTextBox.Hide();
                roleLabel.Hide();
                roleComboBox.Hide();
                isCustomer = false;
            }

            usernameTextBox.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var sure = MessageBox.Show("Are you sure?", "personal information will be changed", MessageBoxButtons.YesNo);
            if (sure == DialogResult.No)
                return;

            try
            {
                if (newPasswordTextBox.Enabled && !String.IsNullOrEmpty(newPasswordTextBox.Text))
                {
                    string hashedNewPassword = User.CreateHashPassword(newPasswordTextBox.Text);
                    SqlParameter user = new SqlParameter("@user_id", user_id);
                    SqlParameter newPassword = new SqlParameter("@newPassword", hashedNewPassword);

                    String query = @"update [User] set [password] = @newPassword where user_id = @user_id";
                    SqlCommand cmd = new SqlCommand(query, conection.con);
                    cmd.Parameters.Add(user);
                    cmd.Parameters.Add(newPassword);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Password could't be changed");
                    }
                }

                if (parentForm.currentUser.access == "Seller")
                {
                    return;
                }
                if (parentForm.currentUser.access == "Customer")
                {
                    SqlParameter customerId = new SqlParameter("@customer_id", data_id);
                    SqlParameter name = new SqlParameter("@name", nameTextBox.Text);
                    SqlParameter lastname = new SqlParameter("@last_name", lastNameTextBox.Text);
                    SqlParameter phonenumber = new SqlParameter("@phone_number", phoneNumberTextBox.Text);

                    String query = @"update Customer set
	                                    name = @name
                                    where customer_id = @customer_id and @name is not null
                                    update Customer set
	                                    last_name = @last_name
                                    where customer_id = @customer_id and @last_name is not null
                                    update Customer set
	                                    phone_number = @phone_number
                                    where customer_id = @customer_id and @phone_number is not null";

                    SqlCommand cmd = new SqlCommand(query, conection.con);
                    cmd.Parameters.Add(customerId);
                    cmd.Parameters.Add(name);
                    cmd.Parameters.Add(lastname);
                    cmd.Parameters.Add(phonenumber);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Personal information could't be changed");
                    }
                }
                else
                {
                    if (isCustomer)
                    {
                        SqlParameter customerId = new SqlParameter("@customer_id", data_id);
                        SqlParameter name = new SqlParameter("@name", nameTextBox.Text);
                        SqlParameter lastname = new SqlParameter("@last_name", lastNameTextBox.Text);
                        SqlParameter phonenumber = new SqlParameter("@phone_number", phoneNumberTextBox.Text);

                        String query = @"update Customer set
	                                    name = @name
                                    where customer_id = @customer_id and @name is not null
                                    update Customer set
	                                    last_name = @last_name
                                    where customer_id = @customer_id and @last_name is not null
                                    update Customer set
	                                    phone_number = @phone_number
                                    where customer_id = @customer_id and @phone_number is not null";

                        SqlCommand cmd = new SqlCommand(query, conection.con);
                        cmd.Parameters.Add(customerId);
                        cmd.Parameters.Add(name);
                        cmd.Parameters.Add(lastname);
                        cmd.Parameters.Add(phonenumber);

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("Personal information could't be changed");
                        }
                    }
                    else
                    {
                        SqlParameter employeeId = new SqlParameter("@customer_id", data_id);
                        SqlParameter name = new SqlParameter("@name", nameTextBox.Text);
                        SqlParameter lastname = new SqlParameter("@last_name", lastNameTextBox.Text);
                        SqlParameter phonenumber = new SqlParameter("@phone_number", phoneNumberTextBox.Text);
                        SqlParameter address = new SqlParameter("@address", addressTextBox.Text);
                        SqlParameter passportNumber = new SqlParameter("@passportNumber", passportTextBox.Text);
                        SqlParameter role = new SqlParameter("@role", roleComboBox.GetItemText(roleComboBox.SelectedItem));

                        String query = @"update Employee set
	                                        name = @name
                                        where employee_id = @employee_id and @name is not null

                                        update Employee set
	                                        last_name = @last_name
                                        where employee_id = @employee_id and @last_name is not null

                                        update Employee set
	                                        phone_number = @phone_number
                                        where employee_id = @employee_id and @phone_number is not null

                                        update Employee set
	                                        address = @address
                                        where employee_id = @employee_id and @address is not null

                                        update Employee set
	                                        passport_number = @passport_number
                                        where employee_id = @employee_id and @passport_number is not null

                                        update [User] set role_id =
	                                        (select r.role_id from [Role] r where r.[role] = @newRole)
                                        where employee_id = @employee_id";

                        SqlCommand cmd = new SqlCommand(query, conection.con);
                        cmd.Parameters.Add(employeeId);
                        cmd.Parameters.Add(name);
                        cmd.Parameters.Add(lastname);
                        cmd.Parameters.Add(phonenumber);
                        cmd.Parameters.Add(address);
                        cmd.Parameters.Add(passportNumber);
                        cmd.Parameters.Add(role);

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("Personal information could't be changed");
                        }
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Succesfully changed information");
            this.Close();
        }

        private void getCurrentUserInfo()
        {
            try
            {
                SqlParameter login = new SqlParameter("@login", parentForm.currentUser.username);

                String query = @"select u.user_id, u.login, r.role, coalesce(c.customer_id, e.employee_id) as id,
	                                coalesce(c.name, e.name) as name, coalesce(c.last_name, e.last_name) as last_name,
	                                coalesce(c.phone_number, e.phone_number) as phone_number, e.address, e.passport_number
                                from [User] u
                                join Role r on u.role_id = r.role_id
                                left join Customer c on c.[user_id] = u.[user_id]
                                left join Employee e on e.[user_id] = u.[user_id]
                                where (@login is null or u.login = @login)";

                SqlCommand cmd = new SqlCommand(query, conection.con);
                cmd.Parameters.Add(login);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dt.Rows.Add();
                da.Fill(dt);

                DataRow row = dt.Rows[1];
                user_id = Int32.Parse(row["user_id"].ToString());
                data_id = Int32.Parse(row["id"].ToString());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
