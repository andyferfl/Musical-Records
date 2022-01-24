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

namespace music
{
    public partial class CustomerMenu : Menu
    {
        public CustomerMenu(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void customer_menu_Load(object sender, EventArgs e)
        {

        }

        private void records_cmenu_Click(object sender, EventArgs e)
        {
            Records form = new Records(this);
            form.Show();
            this.Hide();
        }

        private void myOrdersButton_cmenu_Click(object sender, EventArgs e)
        {
            Orders form = new Orders(this);
            form.Show();
            this.Hide();
        }

        private void order_cmenu_Click(object sender, EventArgs e)
        {
            MakeOrder form = new MakeOrder(this);
            form.Show();
            this.Hide();
        }

        private void profile_cmenu_Click(object sender, EventArgs e)
        {
            EditUser form = new EditUser(this);
            form.Show();
        }
    }
}
