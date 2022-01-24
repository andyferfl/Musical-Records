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
    public partial class InsertCuantity : KryptonForm
    {
        public static int SelectedCuantity { get; set; } = -1;
        private DataGridViewRow row;
        public InsertCuantity(DataGridViewRow info)
        {
            InitializeComponent();
            row = info;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SelectedCuantity = Int32.Parse(cuantityNumericUpDown.Value.ToString());
            this.Close();
        }

        private void cancelButon_Click(object sender, EventArgs e)
        {
            SelectedCuantity = -1;
            this.Close();
        }

        private void InsertCuantity_Load(object sender, EventArgs e)
        {
            priceLabel.Text = row.Cells[5].Value.ToString();
            titleLabel.Text = row.Cells[2].Value.ToString();
            genreLabel.Text = row.Cells[3].Value.ToString();
            interpreterLabel.Text = row.Cells[4].Value.ToString();
        }
    }
}
