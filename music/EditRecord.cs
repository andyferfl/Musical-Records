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
    public partial class EditRecord : KryptonForm
    {
        private Menu parentForm;
        private Conection conection = new Conection();
        private String record_id;
        public EditRecord(Menu parent, String recordId = null)
        {
            InitializeComponent();
            parentForm = parent;

            if (recordId != null)
            {
                record_id = recordId;
            }
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            SqlCommand cmd;

            if (String.IsNullOrEmpty(record_id))
            {
                typeComboBox.DataSource = null;

                cmd = new SqlCommand("select type from RecordType", conection.con);
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
                return;
            }
            


            SqlParameter id = new SqlParameter("@record_id", record_id);

            String query = @"get_record_data";

            cmd = new SqlCommand(query, conection.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(id);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                titleTextBox.Text = reader["title"].ToString();
                priceTextBox.Text = reader["price"].ToString();
                yearTextBox.Text = reader["year"].ToString();
                cuantityTextBox.Text = reader["cuantity_available"].ToString();
                interpreterTextBox.Text = reader["interpreter"].ToString();
                genreComboBox.Text = reader["genre"].ToString();
                typeComboBox.Text = reader["type"].ToString();
            }

            reader.Close();

            if (parentForm.currentUser.access == "Seller")
            {
                titleTextBox.Enabled = false;
                priceTextBox.Enabled = false;
                yearTextBox.Enabled = false;
                interpreterTextBox.Enabled = false;
                genreComboBox.Enabled = false;
                typeComboBox.Enabled = false;
            }
            else if (parentForm.currentUser.access == "Administrator")
            {
                typeComboBox.DataSource = null;

                cmd = new SqlCommand("select type from RecordType", conection.con);
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
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var sure = MessageBox.Show("Are you sure?", "record information will be changed", MessageBoxButtons.YesNo);
            if (sure == DialogResult.No)
                return;

            try
            {
                if (parentForm.currentUser.access == "Seller")
                {
                    SqlParameter recordId = new SqlParameter("@record_id", record_id);
                    SqlParameter cuantity = new SqlParameter("@cuantity_available", cuantityTextBox.Text);

                    String query = @"update Record set
	                                     cuantity_available = @cuantity_available
                                    where record_id = @record_id";

                    SqlCommand cmd = new SqlCommand(query, conection.con);
                    cmd.Parameters.Add(recordId);
                    cmd.Parameters.Add(cuantity);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Record information could't be changed");
                    }
                }
                else if (parentForm.currentUser.access == "Administrator" && record_id != null)
                {
                    SqlParameter recordId = new SqlParameter("@record_id", record_id);
                    SqlParameter title = new SqlParameter("@title", titleTextBox.Text);
                    SqlParameter genre = new SqlParameter("@genre", genreComboBox.Text);//genreComboBox.GetItemText(genreComboBox.SelectedItem));
                    SqlParameter interpreter = new SqlParameter("@interpreter", interpreterTextBox.Text);
                    SqlParameter year = new SqlParameter("@year", yearTextBox.Text);
                    SqlParameter price = new SqlParameter("@price", priceTextBox.Text);
                    SqlParameter type = new SqlParameter("@type", typeComboBox.GetItemText(typeComboBox.SelectedItem));
                    SqlParameter cuantity = new SqlParameter("@cuantity_available", cuantityTextBox.Text);

                    String query = @"update Record set
	                                     title = @title,
	                                     genre = @genre,
	                                     interpreter = @interpreter,
	                                     year = @year,
	                                     price = @price,
	                                     record_type_id = (select record_type_id from RecordType where type = @type),
	                                     cuantity_available = @cuantity_available
                                    where record_id = @record_id";

                    SqlCommand cmd = new SqlCommand(query, conection.con);
                    cmd.Parameters.Add(recordId);
                    cmd.Parameters.Add(title);
                    cmd.Parameters.Add(genre);
                    cmd.Parameters.Add(interpreter);
                    cmd.Parameters.Add(year);
                    cmd.Parameters.Add(price);
                    cmd.Parameters.Add(type);
                    cmd.Parameters.Add(cuantity);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Record information could't be changed");
                    }
                }
                else if(parentForm.currentUser.access == "Administrator" && record_id == null)
                {
                    SqlParameter title = new SqlParameter("@title", titleTextBox.Text);
                    SqlParameter genre = new SqlParameter("@genre", genreComboBox.GetItemText(genreComboBox.SelectedItem));
                    SqlParameter interpreter = new SqlParameter("@interpreter", interpreterTextBox.Text);
                    SqlParameter year = new SqlParameter("@year", yearTextBox.Text);
                    SqlParameter price = new SqlParameter("@price", priceTextBox.Text);
                    SqlParameter type = new SqlParameter("@type", typeComboBox.GetItemText(typeComboBox.SelectedItem));
                    SqlParameter cuantity = new SqlParameter("@cuantity_available", cuantityTextBox.Text);

                    String query = @"insert into Record(title, genre, interpreter, [year], price, record_type_id, cuantity_available)
                                     values (@title, @genre, @interpreter, @year, @price, (select record_type_id from RecordType where type = @type), @cuantity_available)";

                    SqlCommand cmd = new SqlCommand(query, conection.con);
                    cmd.Parameters.Add(title);
                    cmd.Parameters.Add(genre);
                    cmd.Parameters.Add(interpreter);
                    cmd.Parameters.Add(year);
                    cmd.Parameters.Add(price);
                    cmd.Parameters.Add(type);
                    cmd.Parameters.Add(cuantity);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Record information could't be added");
                    }

                }

                MessageBox.Show("Succesfully changed information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
