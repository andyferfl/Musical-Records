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
    public partial class EditOrder : KryptonForm
    {
        private readonly Menu parentForm;
        private readonly Conection conection = new Conection();
        private int id;
        public EditOrder(int orderId, Menu parent)
        {
            InitializeComponent();
            id = orderId;
            parentForm = parent;
        }

        private void EditOrder_Load(object sender, EventArgs e)
        {
            try
            {
                SqlParameter order_id = new SqlParameter("@order_id", id);

                SqlCommand cmd = new SqlCommand("view_order", conection.con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(order_id);

                String status;
                String payed;
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    idLabel.Text = "id: " + reader["order_id"].ToString();
                    datetimeLabel.Text = "datetime: " + reader["datetime"].ToString();
                    loginLabel.Text = "login: " + reader["login"].ToString();
                    totalPriceLabel.Text = "price: " + reader["total_price"].ToString();
                    recordsLabel.Text = "records: " + reader["records"].ToString();
                    payed = reader["is_payed"].ToString();
                    status = reader["status"].ToString();

                    if (payed == "True")
                    {
                        is_payed.Checked = true;
                        is_payed.Enabled = false;
                    }
                        

                    if (parentForm.currentUser.access == "Customer")
                    {
                        statusComboBox.Text = status;
                        statusComboBox.Enabled = false;

                        is_payed.Enabled = false;
                    }
                    else
                    {
                        statusComboBox.SelectedItem = status;
                    }
                }

                reader.Close();

                if (parentForm.currentUser.access != "Customer")
                {
                    statusComboBox.DataSource = null;

                    cmd = new SqlCommand("select * from Status", conection.con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    statusComboBox.DataSource = dt;
                }
                else
                {
                    saveButton.Hide();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("are you sure?", "cancel order", MessageBoxButtons.YesNo);
            if (answer == DialogResult.No)
                return;

            try
            {
                if (is_payed.Checked == false)
                {
                    String query = @"update [Order] set
	                             status_id = @status_id
                            where order_id = @order_id";

                    SqlParameter status = new SqlParameter("@status_id", "1");
                    SqlParameter order = new SqlParameter("@order_id", id);

                    SqlCommand cmd = new SqlCommand(query, conection.con);
                    cmd.Parameters.Add(status);
                    cmd.Parameters.Add(order);

                    cmd.ExecuteNonQuery();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cannot cancel a payed order");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (statusComboBox.SelectedValue.ToString() == "Finished" && is_payed.Checked == false)
                {
                    MessageBox.Show("Cannot finish an unpaid order");
                    return;
                }

                String query = @"update [Order] set
	                             status_id = (select status_id from Status where status = @status )
                            where order_id = @order_id
                            update [Order] set
	                             is_payed = @is_payed
                            where order_id = @order_id";
                
                SqlParameter status = new SqlParameter("@status", statusComboBox.SelectedValue.ToString());
                SqlParameter order = new SqlParameter("@order_id", id);
                SqlParameter payed = new SqlParameter("@is_payed", is_payed.Checked.ToString());

                SqlCommand cmd = new SqlCommand(query, conection.con);
                cmd.Parameters.Add(status);
                cmd.Parameters.Add(order);
                cmd.Parameters.Add(payed);
                cmd.ExecuteNonQuery();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
