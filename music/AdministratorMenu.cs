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
    public partial class AdministratorMenu : Menu
    {
        public AdministratorMenu(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void AdministratorMenu_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Users form = new Users(this);
            form.Show();
            this.Hide();
        }

        private void orders_amenu_Click(object sender, EventArgs e)
        {
            Orders form = new Orders(this);
            form.Show();
            this.Hide();
        }

        private void records_cmenu_Click(object sender, EventArgs e)
        {
            Records form = new Records(this);
            form.Show();
            this.Hide();
        }

        private void rankingButton_Click(object sender, EventArgs e)
        {
            Ranking form = new Ranking(this);
            form.Show();
            this.Hide();
        }

        private void profile_cmenu_Click(object sender, EventArgs e)
        {
            Reviews form = new Reviews(this);
            form.Show();
            this.Hide();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            RegisterEmployee form = new RegisterEmployee(this);
            form.ShowDialog();
        }

        private void addOptionsButton_Click(object sender, EventArgs e)
        {
            AddOptions form = new AddOptions(this);
            form.ShowDialog();
        }
    }
}
