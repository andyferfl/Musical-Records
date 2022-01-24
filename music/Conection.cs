using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace music
{
    class Conection
    {
        private System.Data.SqlClient.SqlConnectionStringBuilder conStr;
        public SqlConnection con { get; private set;}

        public Conection()
        {
            conStr = new System.Data.SqlClient.SqlConnectionStringBuilder();
            conStr.DataSource = @"DESKTOP-SC3U1PM";
            conStr.InitialCatalog = "music";
            conStr.IntegratedSecurity = true;

            con = new SqlConnection(conStr.ToString());
            con.Open();
        }
    }
}
