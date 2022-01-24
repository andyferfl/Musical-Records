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
    public partial class Records : KryptonForm
    {
        private readonly Menu parentForm;
        private readonly Conection conection = new Conection();

        public Records(Menu parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (parentForm.currentUser.access != "Administrator")
            {
                addRecordButton.Hide();
            }


            try
            {
                recordsDataGrid.DataSource = null;

                SqlCommand cmd = new SqlCommand("find_record", conection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                recordsDataGrid.DataSource = dt;


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


                configureDataGrid();


                recordsDataGrid.CellClick += recordsDataGrid_Click;

            }
            catch (SqlException)
            {
                recordsDataGrid.Hide();
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            recordsDataGrid.DataSource = null;
            recordsDataGrid.Columns.Clear();
            recordsDataGrid.Refresh();

            try
            {
                recordsDataGrid.DataSource = null;

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

                recordsDataGrid.DataSource = dt;

                configureDataGrid();
            }
            catch (SqlException)
            {
                recordsDataGrid.Hide();
            }
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            recordsDataGrid.DataSource = null;
            recordsDataGrid.Columns.Clear();
            recordsDataGrid.Refresh();

            try
            {

                SqlCommand cmd = new SqlCommand("find_record", conection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                recordsDataGrid.DataSource = dt;

                configureDataGrid();
            }
            catch (SqlException)
            {
                recordsDataGrid.Hide();
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

        private void configureDataGrid()
        {
            KryptonDataGridViewButtonColumn reviewButtonColumn = new KryptonDataGridViewButtonColumn();
            reviewButtonColumn.Name = "reviews";
            reviewButtonColumn.Text = "reviews";
            reviewButtonColumn.UseColumnTextForButtonValue = true;
            reviewButtonColumn.ButtonStyle = ButtonStyle.Custom1;
            reviewButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            recordsDataGrid.Columns.Insert(recordsDataGrid.Columns.Count, reviewButtonColumn);

            if (parentForm.currentUser.access != "Customer")
            {
                KryptonDataGridViewButtonColumn editButtonColumn = new KryptonDataGridViewButtonColumn();
                editButtonColumn.Name = "edit";
                editButtonColumn.Text = "edit";
                editButtonColumn.UseColumnTextForButtonValue = true;
                editButtonColumn.ButtonStyle = ButtonStyle.Custom1;
                editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                recordsDataGrid.Columns.Insert(recordsDataGrid.Columns.Count, editButtonColumn);

                if (parentForm.currentUser.access == "Administrator")
                {
                    KryptonDataGridViewButtonColumn deleteButtonColumn = new KryptonDataGridViewButtonColumn();
                    deleteButtonColumn.Name = "delete";
                    deleteButtonColumn.Text = "delete";
                    deleteButtonColumn.UseColumnTextForButtonValue = true;
                    deleteButtonColumn.ButtonStyle = ButtonStyle.Custom1;
                    deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    recordsDataGrid.Columns.Insert(recordsDataGrid.Columns.Count, deleteButtonColumn);
                }
            }

            recordsDataGrid.Columns["record_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            recordsDataGrid.Columns["title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            recordsDataGrid.Columns["genre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            recordsDataGrid.Columns["interpreter"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            recordsDataGrid.Columns["price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            recordsDataGrid.Columns["year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            recordsDataGrid.Columns["cuantity_available"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            recordsDataGrid.Columns["type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }

        private void recordsDataGrid_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            SqlCommand cmd;
            if (e.ColumnIndex == recordsDataGrid.Columns["reviews"].Index)
            {
                String id = recordsDataGrid.Rows[e.RowIndex].Cells["record_id"].Value.ToString();
                Reviews edit = new Reviews(parentForm, id);
                edit.ShowDialog();

            }
            else if (parentForm.currentUser.access != "Customer" && e.ColumnIndex == recordsDataGrid.Columns["edit"].Index)
            {
                String id = recordsDataGrid.Rows[e.RowIndex].Cells["record_id"].Value.ToString();
                EditRecord edit = new EditRecord(parentForm, id);
                edit.ShowDialog();
                                
            }
            else if (parentForm.currentUser.access == "Administrator" && e.ColumnIndex == recordsDataGrid.Columns["delete"].Index)
            {
                try
                {
                    var result = MessageBox.Show("Are you sure you want to delete this record?",
                            "Record id: " + recordsDataGrid.Rows[e.RowIndex].Cells["record_id"].Value.ToString()
                            , MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        SqlParameter orderId = new SqlParameter("@record_id", recordsDataGrid.Rows[e.RowIndex].Cells["record_id"].Value);

                        String tmpCmd = @"delete from Record where record_id = @record_id";

                        cmd = new SqlCommand(tmpCmd, conection.con);
                        cmd.Parameters.Add(orderId);

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("Couldn't delete record");
                        }
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Couldn't delete record");
                }

            }

            try
            {
                recordsDataGrid.DataSource = null;
                recordsDataGrid.Columns.Clear();
                recordsDataGrid.Refresh();

                cmd = new SqlCommand("find_record", conection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                recordsDataGrid.DataSource = dt;

                configureDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            EditRecord form = new EditRecord(parentForm);
            form.ShowDialog();

            try
            {
                recordsDataGrid.DataSource = null;
                recordsDataGrid.Columns.Clear();
                recordsDataGrid.Refresh();

                SqlCommand cmd = new SqlCommand("find_record", conection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                recordsDataGrid.DataSource = dt;
                configureDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
