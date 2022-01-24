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
    public partial class Ranking : KryptonForm
    {
        private readonly Menu parentForm;
        private readonly Conection conection = new Conection();
        public Ranking(Menu parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            try
            {
                rankingDataGrid.DataSource = null;
                rankingDataGrid.Columns.Clear();
                rankingDataGrid.Refresh();

                string query = @"select * from finished_orders_employees order by finished_orders desc";

                SqlCommand cmd = new SqlCommand(query, conection.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                rankingDataGrid.DataSource = dt;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void employeesRanking_Click(object sender, EventArgs e)
        {
            try
            {
                rankingDataGrid.DataSource = null;
                rankingDataGrid.Columns.Clear();
                rankingDataGrid.Refresh();

                string query = @"select * from finished_orders_employees order by finished_orders desc";

                SqlCommand cmd = new SqlCommand(query, conection.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                rankingDataGrid.DataSource = dt;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customersRanking_Click(object sender, EventArgs e)
        {
            try
            {
                rankingDataGrid.DataSource = null;
                rankingDataGrid.Columns.Clear();
                rankingDataGrid.Refresh();

                string query = @"select * from finished_orders_customers order by finished_orders desc";

                SqlCommand cmd = new SqlCommand(query, conection.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                rankingDataGrid.DataSource = dt;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void recordsRanking_Click(object sender, EventArgs e)
        {
            try
            {
                rankingDataGrid.DataSource = null;
                rankingDataGrid.Columns.Clear();
                rankingDataGrid.Refresh();

                string query = @"select * from last_month_selled_records order by selled desc";

                SqlCommand cmd = new SqlCommand(query, conection.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                rankingDataGrid.DataSource = dt;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
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
                
        
    }
}
