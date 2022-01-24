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
    public partial class Orders : KryptonForm
    {
        private readonly Menu parentForm;
        private readonly Conection conection = new Conection();
        public Orders(Menu parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            try
            {
                if (parentForm.currentUser.access != "Customer")
                {
                    fillDataGridAllOrders();
                }
                else
                {
                    fillDataGridCurrentUserOrders();
                    loginTextBox.Hide();
                    loginLabel.Hide();
                }

                configureFilledDataGrid();

                typeComboBox.DataSource = null;

                SqlCommand cmd = new SqlCommand("select * from RecordType", conection.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dt.Rows.Add();
                da.Fill(dt);

                typeComboBox.DataSource = dt;

                genreComboBox.DataSource = null;

                cmd = new SqlCommand("select distinct genre from Record", conection.con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dt.Rows.Add();
                da.Fill(dt);

                genreComboBox.DataSource = dt;

                statusComboBox.DataSource = null;

                cmd = new SqlCommand("select * from [Status]", conection.con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dt.Rows.Add();
                da.Fill(dt);

                statusComboBox.DataSource = dt;

                isPayedComboBox.DataSource = null;

                cmd = new SqlCommand("select distinct is_payed from [Order]", conection.con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dt.Rows.Add();
                da.Fill(dt);

                isPayedComboBox.DataSource = dt;

                dateTimePicker.Format = DateTimePickerFormat.Custom;
                dateTimePicker.CustomFormat = "yyyy-MM-dd";


                ordersDataGrid.CellClick += ordersDataGrid_Click;
            }
            catch (SqlException)
            {
                ordersDataGrid.Hide();
            }

        }

        private void filter_Click(object sender, EventArgs e)
        {
            try
            {
                ordersDataGrid.DataSource = null;
                ordersDataGrid.Columns.Clear();
                ordersDataGrid.Refresh();

                SqlParameter title = new SqlParameter("@title", (String.IsNullOrEmpty(titleTextBox.Text) ? (object)DBNull.Value : titleTextBox.Text));
                SqlParameter genre = new SqlParameter("@genre", (String.IsNullOrEmpty(genreComboBox.GetItemText(genreComboBox.SelectedItem)) ? (object)DBNull.Value : genreComboBox.GetItemText(genreComboBox.SelectedItem)));
                SqlParameter interpreter = new SqlParameter("@interpreter", (String.IsNullOrEmpty(interpreterTextBox.Text) ? (object)DBNull.Value : interpreterTextBox.Text));
                SqlParameter year = new SqlParameter("@year", (String.IsNullOrEmpty(yearTextBox.Text) ? (object)DBNull.Value : yearTextBox.Text));
                year.SqlDbType = SqlDbType.Int;
                SqlParameter price = new SqlParameter("@price", (object)DBNull.Value);
                SqlParameter record_type = new SqlParameter("@record_type", (String.IsNullOrEmpty(typeComboBox.GetItemText(typeComboBox.SelectedItem)) ? (object)DBNull.Value : typeComboBox.GetItemText(typeComboBox.SelectedItem)));
                SqlParameter cuantity_available = new SqlParameter("@cuantity_available", (object)DBNull.Value);

                SqlParameter login;
                if (parentForm.currentUser.access != "Customer")
                {
                   login = new SqlParameter("@login", (String.IsNullOrEmpty(loginTextBox.Text) ? (object)DBNull.Value : loginTextBox.Text));
                }
                else
                {
                    login = new SqlParameter("@login", parentForm.currentUser.username);
                }
                
                SqlParameter status = new SqlParameter("@status", (String.IsNullOrEmpty(statusComboBox.GetItemText(statusComboBox.SelectedItem)) ? (object)DBNull.Value : statusComboBox.GetItemText(statusComboBox.SelectedItem)));
                SqlParameter is_payed = new SqlParameter("@is_payed", (String.IsNullOrEmpty(isPayedComboBox.GetItemText(isPayedComboBox.SelectedItem)) ? (object)DBNull.Value : isPayedComboBox.GetItemText(isPayedComboBox.SelectedItem)));
                is_payed.SqlDbType = SqlDbType.Bit;
                SqlParameter record_id = new SqlParameter("@record_id", (String.IsNullOrEmpty(recordIdTextBox.Text) ? (object)DBNull.Value : recordIdTextBox.Text));
                record_id.SqlDbType = SqlDbType.Int;
                
                SqlParameter date = new SqlParameter("@date", SqlDbType.Date);
                if (enableDateTimePicker.Checked)
                {
                    DateTime tmpDate = DateTime.Parse(dateTimePicker.Text);
                    date.Value = (object)tmpDate;
                }
                else
                {
                    date.Value = (object)DBNull.Value;
                }

                string query = @"select distinct
                                o.order_id,	o.datetime,
                                u.login, o.total_price,
                                o.is_payed,	s.status,
                                stuff((select
	                                '; (' + cast(r.record_id as nvarchar) + ') ' + r.title + ' (' + rt.type + ')'
	                                from OrderRecord orec, Record r, RecordType rt
	                                where o.order_id = orec.order_id and orec.record_id = r.record_id 
		                                and r.record_type_id = rt.record_type_id for xml path('')),1,1,'') as records
                                from [Order] o
                                join [Status] s on o.status_id = s.status_id
                                join [User] u on u.user_id = o.user_id
                                join OrderRecord ordrec on ordrec.order_id = o.order_id
                                join Record rec on rec.record_id = ordrec.record_id
                                join RecordType rect on rec.record_type_id = rect.record_type_id
                                where (@login is null or u.login = @login) and (@price is null or o.total_price = @price)
	                                and (@is_payed is null or o.is_payed = @is_payed) and (@status is null or s.status = @status)
	                                and (@record_id is null or rec.record_id = @record_id) and (@title is null or rec.title = @title)
	                                and (@interpreter is null or rec.interpreter = @interpreter) and (@genre is null or rec.genre = @genre) 
	                                and (@year is null or rec.year = @year)
	                                and (@cuantity_available is null or rec.cuantity_available = @cuantity_available)
	                                and (@record_type is null or rect.type = @record_type) and (@date is null or cast(o.datetime as date) = @date)";

                SqlCommand cmd = new SqlCommand(query, conection.con);

                cmd.Parameters.Add(title);
                cmd.Parameters.Add(genre);
                cmd.Parameters.Add(interpreter);
                cmd.Parameters.Add(year);
                cmd.Parameters.Add(price);
                cmd.Parameters.Add(record_type);
                cmd.Parameters.Add(cuantity_available);
                cmd.Parameters.Add(login);
                cmd.Parameters.Add(status);
                cmd.Parameters.Add(is_payed);
                cmd.Parameters.Add(record_id);
                cmd.Parameters.Add(date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ordersDataGrid.DataSource = dt;

                configureFilledDataGrid();

                enableDateTimePicker.Checked = false;
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
                if (parentForm.currentUser.access != "Customer")
                {
                    fillDataGridAllOrders();
                }
                else
                {
                    fillDataGridCurrentUserOrders();
                    loginTextBox.Hide();
                    loginLabel.Hide();
                }

                configureFilledDataGrid();

                enableDateTimePicker.Checked = false;
            }
            catch (SqlException)
            {
                ordersDataGrid.Hide();
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

        private void fillDataGridAllOrders()
        {
            if (parentForm.currentUser.access == "Customer")
            {
                MessageBox.Show("Error while loading data, please try to log in again");
                return;
            }

            ordersDataGrid.DataSource = null;
            ordersDataGrid.Columns.Clear();
            ordersDataGrid.Refresh();

            string query = @"select distinct
                                o.order_id,	o.datetime,
                                u.login, o.total_price,
                                o.is_payed,	s.status,
                                stuff((select
	                                '; (' + cast(r.record_id as nvarchar) + ') ' + r.title + ' (' + rt.type + ')'
	                                from OrderRecord orec, Record r, RecordType rt
	                                where o.order_id = orec.order_id and orec.record_id = r.record_id 
		                                and r.record_type_id = rt.record_type_id for xml path('')),1,1,'') as records
                                from [Order] o
                                join [Status] s on o.status_id = s.status_id
                                join [User] u on u.user_id = o.user_id
                                join OrderRecord ordrec on ordrec.order_id = o.order_id
                                join Record rec on rec.record_id = ordrec.record_id
                                join RecordType rect on rec.record_type_id = rect.record_type_id";

            SqlCommand cmd = new SqlCommand(query, conection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ordersDataGrid.DataSource = dt;
        }

        private void fillDataGridCurrentUserOrders()
        {
            ordersDataGrid.DataSource = null;
            ordersDataGrid.Columns.Clear();
            ordersDataGrid.Refresh();

            SqlParameter login = new SqlParameter("@login", parentForm.currentUser.username);
            

            string query = @"select distinct
                                o.order_id,	o.datetime,
                                u.login, o.total_price,
                                o.is_payed,	s.status,
                                stuff((select
	                                '; (' + cast(r.record_id as nvarchar) + ') ' + r.title + ' (' + rt.type + ')'
	                                from OrderRecord orec, Record r, RecordType rt
	                                where o.order_id = orec.order_id and orec.record_id = r.record_id 
		                                and r.record_type_id = rt.record_type_id for xml path('')),1,1,'') as records
                                from [Order] o
                                join [Status] s on o.status_id = s.status_id
                                join [User] u on u.user_id = o.user_id
                                join OrderRecord ordrec on ordrec.order_id = o.order_id
                                join Record rec on rec.record_id = ordrec.record_id
                                join RecordType rect on rec.record_type_id = rect.record_type_id
                                where (@login is null or u.login = @login)";

            SqlCommand cmd = new SqlCommand(query, conection.con);

            cmd.Parameters.Add(login);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ordersDataGrid.DataSource = dt;
        }

        private void configureFilledDataGrid()
        {
            ordersDataGrid.Columns["order_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ordersDataGrid.Columns["datetime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ordersDataGrid.Columns["login"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ordersDataGrid.Columns["total_price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ordersDataGrid.Columns["is_payed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ordersDataGrid.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ordersDataGrid.Columns["records"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            KryptonDataGridViewButtonColumn editButtonColumn = new KryptonDataGridViewButtonColumn();
            editButtonColumn.Name = "edit";
            editButtonColumn.Text = "edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.ButtonStyle = ButtonStyle.Custom1;
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ordersDataGrid.Columns.Insert(ordersDataGrid.Columns.Count, editButtonColumn);

            if (parentForm.currentUser.access == "Administrator")
            {
                KryptonDataGridViewButtonColumn deleteButtonColumn = new KryptonDataGridViewButtonColumn();
                deleteButtonColumn.Name = "delete";
                deleteButtonColumn.Text = "delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                deleteButtonColumn.ButtonStyle = ButtonStyle.Custom1;
                deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                ordersDataGrid.Columns.Insert(ordersDataGrid.Columns.Count, deleteButtonColumn);
            }
            else
            {
                KryptonDataGridViewButtonColumn reviewButtonColumn = new KryptonDataGridViewButtonColumn();
                reviewButtonColumn.Name = "review";
                reviewButtonColumn.Text = "review";
                reviewButtonColumn.UseColumnTextForButtonValue = true;
                reviewButtonColumn.ButtonStyle = ButtonStyle.Custom1;
                reviewButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                ordersDataGrid.Columns.Insert(ordersDataGrid.Columns.Count, reviewButtonColumn);
            }


        }

        private void ordersDataGrid_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            SqlCommand cmd;

            if (e.ColumnIndex == ordersDataGrid.Columns["edit"].Index)
            {
                int id = Int32.Parse(ordersDataGrid.Rows[e.RowIndex].Cells["order_id"].Value.ToString());
                EditOrder edit = new EditOrder(id, parentForm);
                edit.ShowDialog();

                if (parentForm.currentUser.access != "Customer")
                {
                    fillDataGridAllOrders();
                }
                else
                {
                    fillDataGridCurrentUserOrders();
                    loginTextBox.Hide();
                    loginLabel.Hide();
                }

                configureFilledDataGrid();

            }
            else if (parentForm.currentUser.access != "Administrator" && e.ColumnIndex == ordersDataGrid.Columns["review"].Index)
            {
                try
                {
                    Review review = new Review();
                    review.ShowDialog();
                    String text = Review.ReviewText;

                    if (String.IsNullOrEmpty(text))
                        return;
                    
                    SqlParameter orderId = new SqlParameter("@order_id", ordersDataGrid.Rows[e.RowIndex].Cells["order_id"].Value);
                    SqlParameter reviewText = new SqlParameter("@review", text);

                    String tmpCmd = @"insert into Review (order_id, text_review)
                        values (@order_id, @review)";

                    cmd = new SqlCommand(tmpCmd, conection.con);
                    cmd.Parameters.Add(orderId);
                    cmd.Parameters.Add(reviewText);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Error while adding review \n (You cannot add more than one review per order)");
                    }
                    else
                    {
                        MessageBox.Show("Review succesfully added");
                    }
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error while adding review");
                }
            }
            else if (parentForm.currentUser.access == "Administrator" && e.ColumnIndex == ordersDataGrid.Columns["delete"].Index)
            {
                try
                {
                    var result = MessageBox.Show("Are you sure you want to delete this order?",
                            "Order id: "+ ordersDataGrid.Rows[e.RowIndex].Cells["order_id"].Value.ToString()
                            , MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        SqlParameter orderId = new SqlParameter("@order_id", ordersDataGrid.Rows[e.RowIndex].Cells["order_id"].Value);

                        String tmpCmd = @"declare @flag as bit
                            set @flag = (select is_payed from [Order] where order_id = @order_id)
                            delete from OrderRecord where order_id = @order_id and @flag = 0
                            delete from [Order] where order_id = @order_id and @flag = 0";

                        cmd = new SqlCommand(tmpCmd, conection.con);
                        cmd.Parameters.Add(orderId);

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("Cannot delete payed order");
                        }
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Cannot delete payed order");
                }
                
            }
        }
    }
}
