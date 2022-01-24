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
    public partial class Review : KryptonForm
    {
        public static String ReviewText { get; set; }
        public Review()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ReviewText = reviewTextBox.Text;
            this.Close();
        }

        private void cancelButon_Click(object sender, EventArgs e)
        {
            reviewTextBox = null;
            this.Close();
        }
    }
}
