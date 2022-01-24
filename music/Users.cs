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
    public partial class Users : KryptonForm
    {
        private readonly Menu parentForm;
        private readonly Conection conection = new Conection();
        public Users(Menu parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            try
            {
                fillDataGridAllUsers();               

                roleComboBox.DataSource = null;

                SqlCommand cmd = new SqlCommand("select * from Role", conection.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dt.Rows.Add();
                da.Fill(dt);

                roleComboBox.DataSource = dt;

                usersDataGrid.CellClick += usersDataGrid_Click;
            }
            catch (SqlException)
            {
                usersDataGrid.Hide();
            }

        }

        private void filter_Click(object sender, EventArgs e)
        {
            try
            {
                usersDataGrid.DataSource = null;
                usersDataGrid.Columns.Clear();
                usersDataGrid.Refresh();

                SqlParameter login = new SqlParameter("@login", (String.IsNullOrEmpty(loginTextBox.Text) ? (object)DBNull.Value : loginTextBox.Text));
                SqlParameter role = new SqlParameter("@role", (String.IsNullOrEmpty(roleComboBox.GetItemText(roleComboBox.SelectedItem)) ? (object)DBNull.Value : roleComboBox.GetItemText(roleComboBox.SelectedItem)));
                SqlParameter name = new SqlParameter("@name", (String.IsNullOrEmpty(nameTextBox.Text) ? (object)DBNull.Value : nameTextBox.Text));
                SqlParameter lastname = new SqlParameter("@last_name", (String.IsNullOrEmpty(lastnameTextBox.Text) ? (object)DBNull.Value : lastnameTextBox.Text));


                string query = @"select u.user_id, u.login, r.role, coalesce(c.customer_id, e.employee_id) as id,
	                                coalesce(c.name, e.name) as name, coalesce(c.last_name, e.last_name) as last_name,
	                                coalesce(c.phone_number, e.phone_number) as phone_number, e.address, e.passport_number
                                from [User] u
                                join Role r on u.role_id = r.role_id
                                left join Customer c on c.[user_id] = u.[user_id]
                                left join Employee e on e.[user_id] = u.[user_id]
                                where (@login is null or u.login = @login)
	                                and (@role is null or r.role = @role)
	                                and	(@name is null or c.name = @name or e.name = @name)
	                                and (@last_name is null or c.last_name = @last_name or e.last_name = @last_name)";

                SqlCommand cmd = new SqlCommand(query, conection.con);

                cmd.Parameters.Add(login);
                cmd.Parameters.Add(role);
                cmd.Parameters.Add(name);
                cmd.Parameters.Add(lastname);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                usersDataGrid.DataSource = dt;


                KryptonDataGridViewButtonColumn editButtonColumn = new KryptonDataGridViewButtonColumn();
                editButtonColumn.Name = "edit";
                editButtonColumn.Text = "edit";
                editButtonColumn.UseColumnTextForButtonValue = true;
                editButtonColumn.ButtonStyle = ButtonStyle.Custom1;
                editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                usersDataGrid.Columns.Insert(usersDataGrid.Columns.Count, editButtonColumn);


                KryptonDataGridViewButtonColumn deleteButtonColumn = new KryptonDataGridViewButtonColumn();
                deleteButtonColumn.Name = "delete";
                deleteButtonColumn.Text = "delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                deleteButtonColumn.ButtonStyle = ButtonStyle.Custom1;
                deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                usersDataGrid.Columns.Insert(usersDataGrid.Columns.Count, deleteButtonColumn);

                

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            try
            {
               fillDataGridAllUsers();
            }
            catch (SqlException)
            {
                usersDataGrid.Hide();
            }
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void on_form_closed(object sender, FormClosedEventArgs e)
        {
            if (!parentForm.Visible)
            {
                parentForm.Close();
            }
        }

        private void fillDataGridAllUsers()
        {

            usersDataGrid.DataSource = null;
            usersDataGrid.Columns.Clear();
            usersDataGrid.Refresh();

            string query = @"select u.user_id, u.login, r.role, coalesce(c.customer_id, e.employee_id) as id,
	                            coalesce(c.name, e.name) as name, coalesce(c.last_name, e.last_name) as last_name,
	                            coalesce(c.phone_number, e.phone_number) as phone_number, e.address, e.passport_number
                            from [User] u
                            join Role r on u.role_id = r.role_id
                            left join Customer c on c.[user_id] = u.[user_id]
                            left join Employee e on e.[user_id] = u.[user_id]";

            SqlCommand cmd = new SqlCommand(query, conection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            usersDataGrid.DataSource = dt;

            KryptonDataGridViewButtonColumn editButtonColumn = new KryptonDataGridViewButtonColumn();
            editButtonColumn.Name = "edit";
            editButtonColumn.Text = "edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.ButtonStyle = ButtonStyle.Custom1;
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            usersDataGrid.Columns.Insert(usersDataGrid.Columns.Count, editButtonColumn);

            
            KryptonDataGridViewButtonColumn deleteButtonColumn = new KryptonDataGridViewButtonColumn();
            deleteButtonColumn.Name = "delete";
            deleteButtonColumn.Text = "delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.ButtonStyle = ButtonStyle.Custom1;
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            usersDataGrid.Columns.Insert(usersDataGrid.Columns.Count, deleteButtonColumn);


        }


        private void usersDataGrid_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            SqlCommand cmd;

            if (e.ColumnIndex == usersDataGrid.Columns["edit"].Index)
            {
                String userid = usersDataGrid.Rows[e.RowIndex].Cells["user_id"].Value.ToString();
                String id = usersDataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString();
                EditUser edit = new EditUser(parentForm, userid, id);
                edit.ShowDialog();
                fillDataGridAllUsers();

            }
            else if (e.ColumnIndex == usersDataGrid.Columns["delete"].Index)
            {
                try
                {
                    var result = MessageBox.Show("Are you sure you want to delete this user?",
                            "User: "+ usersDataGrid.Rows[e.RowIndex].Cells["login"].Value.ToString()
                            , MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                        return;
                    
                    
                    SqlParameter login = new SqlParameter("@login", usersDataGrid.Rows[e.RowIndex].Cells["login"].Value);

                    String tmpCmd;
                    
                    if (usersDataGrid.Rows[e.RowIndex].Cells["role"].Value.ToString() == "Customer")
                    {
                        tmpCmd = @"delete from Customer where user_id = (select user_id from [User] where login = @login)
                                            delete from [User] where login = @login";
                    }
                    else
                    {
                        tmpCmd = @"delete from Employee where user_id = (select user_id from [User] where login = @login)
                                            delete from [User] where login = @login";
                    }

                    cmd = new SqlCommand(tmpCmd, conection.con);
                    cmd.Parameters.Add(login);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("User could not be deleted");
                    }
                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("User couldn't be deleted");
                }
                
            }
        }
    }
}
