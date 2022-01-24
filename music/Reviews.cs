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
    public partial class Reviews : KryptonForm
    {
        private readonly Menu parentForm;
        private readonly Conection conection = new Conection();
        private readonly String recordId;
        public Reviews(Menu parent, String id = null)
        {
            InitializeComponent();
            parentForm = parent;
            recordId = id;
        }

        private void Reviews_Load(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(recordId))
                {
                
                    reviewsDataGrid.DataSource = null;
                    reviewsDataGrid.Columns.Clear();
                    reviewsDataGrid.Refresh();

                    string query = @"select o.order_id, rec.title, rec.genre, rec.interpreter,
	                                rec.year, rt.type, r.text_review
                                from Review r
                                join [Order] o on r.order_id = o.order_id
                                join OrderRecord orec on orec.order_id = o.order_id
                                join Record rec on rec.record_id = orec.record_id
                                join RecordType rt on rt.record_type_id = rec.record_type_id";

                    SqlCommand cmd = new SqlCommand(query, conection.con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    reviewsDataGrid.DataSource = dt;

                    backButton.Hide();
                }
                else
                {
                    reviewsDataGrid.DataSource = null;
                    reviewsDataGrid.Columns.Clear();
                    reviewsDataGrid.Refresh();

                    SqlParameter record = new SqlParameter("@record_id", recordId);

                    string query = @"select o.order_id, rec.title, rec.genre, rec.interpreter,
	                                    rec.year, rt.type, r.text_review
                                    from Review r
                                    join [Order] o on r.order_id = o.order_id
                                    join OrderRecord orec on orec.order_id = o.order_id
                                    join Record rec on rec.record_id = orec.record_id
                                    join RecordType rt on rt.record_type_id = rec.record_type_id
                                    where rec.record_id = @record_id";

                    SqlCommand cmd = new SqlCommand(query, conection.con);
                    cmd.Parameters.Add(record);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    reviewsDataGrid.DataSource = dt;
                    menu_button.Hide();
                }
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
            if (recordId == null && !parentForm.Visible)
            {
                parentForm.Show();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
