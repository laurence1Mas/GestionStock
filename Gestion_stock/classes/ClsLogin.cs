using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock.classes
{
    class ClsLogin
    {
        string username;
        string password;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        SqlConnection con;
        public int resetlogin(ClsLogin clslogin)
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_login @username, @password;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prusername = new SqlParameter("@username", clslogin.username);
                SqlParameter prpassword = new SqlParameter("@password", clslogin.password);
                cmd.Parameters.Add(prusername);
                cmd.Parameters.Add(prpassword);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }
    }
}
