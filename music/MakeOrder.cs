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
    public partial class MakeOrder : KryptonForm
    {
        private readonly Menu parentForm;
        private readonly Conection conection = new Conection();
        private readonly DataTable recordsTable = new DataTable();

        public MakeOrder(Menu parent)
        {
            InitializeComponent();
            parentForm = parent;

            recordsTable.Columns.Add("record_id", typeof(int));
            recordsTable.Columns.Add("cuantity", typeof(int));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                orderRecordsDataGrid.DataSource = null;

                SqlCommand cmd = new SqlCommand("find_record", conection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                orderRecordsDataGrid.DataSource = dt;


                typeComboBox.DataSource = null;

                cmd = new SqlCommand("select * from RecordType", conection.con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
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

                orderRecordsDataGrid.Columns["record_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                orderRecordsDataGrid.Columns["title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                orderRecordsDataGrid.Columns["genre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                orderRecordsDataGrid.Columns["interpreter"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                orderRecordsDataGrid.Columns["price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                orderRecordsDataGrid.Columns["year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                orderRecordsDataGrid.Columns["cuantity_available"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                orderRecordsDataGrid.Columns["type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            }
            catch (SqlException)
            {
                orderRecordsDataGrid.Hide();
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            try
            {
                orderRecordsDataGrid.DataSource = null;

                SqlParameter title = new SqlParameter("@title", (String.IsNullOrEmpty(titleTextBox.Text) ? null : titleTextBox.Text));
                SqlParameter genre = new SqlParameter("@genre", (String.IsNullOrEmpty(genreComboBox.GetItemText(genreComboBox.SelectedItem)) ? null : genreComboBox.GetItemText(genreComboBox.SelectedItem)));
                SqlParameter interpreter = new SqlParameter("@interpreter", (String.IsNullOrEmpty(interpreterTextBox.Text) ? null : interpreterTextBox.Text));
                SqlParameter year = new SqlParameter("@year", (String.IsNullOrEmpty(yearTextBox.Text) ? null : yearTextBox.Text));
                year.SqlDbType = SqlDbType.Int;
                SqlParameter price = new SqlParameter("@price", null);
                SqlParameter record_type = new SqlParameter("@record_type", (String.IsNullOrEmpty(typeComboBox.GetItemText(typeComboBox.SelectedItem)) ? null : typeComboBox.GetItemText(typeComboBox.SelectedItem)));
                SqlParameter cuantity_available = new SqlParameter("@cuantity_available", null);

                SqlCommand cmd = new SqlCommand("find_record", conection.con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(title);
                cmd.Parameters.Add(genre);
                cmd.Parameters.Add(interpreter);
                cmd.Parameters.Add(year);
                cmd.Parameters.Add(price);
                cmd.Parameters.Add(record_type);
                cmd.Parameters.Add(cuantity_available);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
                DataTable dt = new DataTable();
                da.Fill(dt);

                orderRecordsDataGrid.DataSource = dt;

                for (int i = 0; i < orderRecordsDataGrid.Rows.Count; ++i)
                {
                    for (int j = 0; j < recordsTable.Rows.Count; ++j)
                    {
                        var row = recordsTable.Rows[j];
                        var id = row.ItemArray[0];
                        if (orderRecordsDataGrid.Rows[i].Cells[1].Value.ToString() == id.ToString())
                        {
                            orderRecordsDataGrid.Rows[i].Cells[0].Value = true;
                        }
                    }
                }
            }
            catch (SqlException)
            {
                orderRecordsDataGrid.Hide();
            }
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            try
            {
                orderRecordsDataGrid.DataSource = null;

                SqlCommand cmd = new SqlCommand("find_record", conection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                orderRecordsDataGrid.DataSource = dt;

                for (int i = 0; i < orderRecordsDataGrid.Rows.Count; ++i)
                {
                    for (int j = 0; j < recordsTable.Rows.Count; ++j)
                    {
                        var row = recordsTable.Rows[j];
                        var id = row.ItemArray[0];
                        if (orderRecordsDataGrid.Rows[i].Cells[1].Value.ToString() == id.ToString())
                        {
                            orderRecordsDataGrid.Rows[i].Cells[0].Value = true;
                        }
                    }
                }
                    
            }
            catch (SqlException)
            {
                orderRecordsDataGrid.Hide();
            }
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void recordsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            try
            {
                if (e.ColumnIndex == orderRecordsDataGrid.Columns["addToOrder"].Index && orderRecordsDataGrid.Rows[e.RowIndex].Cells["addToOrder"].Value == null || !(bool)orderRecordsDataGrid.Rows[e.RowIndex].Cells["addToOrder"].Value)
                {
                    InsertCuantity cuantityForm = new InsertCuantity(orderRecordsDataGrid.Rows[e.RowIndex]);
                    cuantityForm.ShowDialog();

                    int cuantity = InsertCuantity.SelectedCuantity;

                    if (Int32.Parse(orderRecordsDataGrid.Rows[e.RowIndex].Cells["cuantity_available"].Value.ToString()) - cuantity < 0)
                    {
                        MessageBox.Show("this record is not available right now");
                        return;
                    }

                    if (cuantity <= 0)
                        return;

                    DataRow dr = recordsTable.NewRow();
                    dr["record_id"] = orderRecordsDataGrid.Rows[e.RowIndex].Cells["record_id"].Value.ToString();

                    dr["cuantity"] = cuantity;

                    recordsTable.Rows.Add(dr);

                    SqlParameter param = new SqlParameter("@records", SqlDbType.Structured)
                    {
                        TypeName = "dbo.records_list",
                        Value = recordsTable
                    };

                    String query = @"select sum(rec.price* r.cuantity) from Record rec
	                            join @records r on rec.record_id = r.record_id";

                    SqlCommand cmd = new SqlCommand(query, conection.con);

                    cmd.Parameters.Add(param);

                    String price = cmd.ExecuteScalar().ToString();
                    priceLabel.Text = ("Total price: " + price);

                    orderRecordsDataGrid.Rows[e.RowIndex].Cells["addToOrder"].Value = true;
                }
                else if (e.ColumnIndex == orderRecordsDataGrid.Columns["addToOrder"].Index && (bool)orderRecordsDataGrid.Rows[e.RowIndex].Cells["addToOrder"].Value)
                {
                    for (int i = 0; i < recordsTable.Rows.Count; ++i)
                    {
                        var row = recordsTable.Rows[i];
                        var id = row.ItemArray[0];
                        if (id.ToString() == orderRecordsDataGrid.Rows[e.RowIndex].Cells["record_id"].Value.ToString())
                        {
                            recordsTable.Rows[i].Delete();
                            break;
                        }
                    }

                    SqlParameter param = new SqlParameter("@records", SqlDbType.Structured)
                    {
                        TypeName = "dbo.records_list",
                        Value = recordsTable
                    };

                    String query = @"select sum(rec.price* r.cuantity) from Record rec
	                            join @records r on rec.record_id = r.record_id";

                    SqlCommand cmd = new SqlCommand(query, conection.con);

                    cmd.Parameters.Add(param);

                    String price = cmd.ExecuteScalar().ToString();
                    priceLabel.Text = ("Total price: " + price);
                    orderRecordsDataGrid.Rows[e.RowIndex].Cells["addToOrder"].Value = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void on_form_closed(object sender, FormClosedEventArgs e)
        {
            if (!parentForm.Visible)
            {
                parentForm.Close();
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter login = new SqlParameter("@login", parentForm.currentUser.username);
                SqlParameter records = new SqlParameter("@records", SqlDbType.Structured)
                {
                    TypeName = "dbo.records_list",
                    Value = recordsTable
                };

                SqlCommand cmd = new SqlCommand("add_order", conection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(login);
                cmd.Parameters.Add(records);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Order successfully placed");
                recordsTable.Clear();
                for (int i = 0; i < orderRecordsDataGrid.Rows.Count; ++i)
                {
                    orderRecordsDataGrid.Rows[i].Cells[0].Value = false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Order couldn't be placed");
            }
        }
    }
}
