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
    public partial class Login : KryptonForm
    {
        public bool UserSuccessfullyAuthenticated { get; private set; } = false;

        public User LoginUser { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sign_in_login_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Insert username and password");
                return;
            }

            try
            {
                SqlCommand cmd;
                Conection conection = new Conection();

                SqlParameter loginPar = new SqlParameter
                {
                    ParameterName = "@username",
                    SqlDbType = SqlDbType.VarChar,
                    Value = username
                };
                    
                cmd = new SqlCommand("select * from [User] u join [Role] r on u.role_id = r.role_id where login=@username", conection.con);
                cmd.Parameters.Add(loginPar);

                string foundUsername = "";
                string foundPassword = "";
                string foundRole = "";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        foundUsername = reader["login"].ToString();
                        foundPassword = reader["password"].ToString();
                        foundRole = reader["role"].ToString();
                    }
                }

                if (username == foundUsername && User.ValidatePassword(password, foundPassword))
                {
                    UserSuccessfullyAuthenticated = true;
                    User foundUser = new User();
                    foundUser.username = foundUsername;
                    foundUser.access = foundRole;

                    LoginUser = foundUser;
                }
                else 
                {
                    MessageBox.Show("Incorrect username or password");
                }
                
            }
            catch (Exception)
            {
                UserSuccessfullyAuthenticated = false;
                MessageBox.Show("Authentication error");
            }

            if (UserSuccessfullyAuthenticated)
                Close();
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            RegisterCustomer form = new RegisterCustomer(this);
            form.Show();
            this.Hide();
        }
    }
}
