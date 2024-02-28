using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock.classes
{
    class dataconnexion
    {
        SqlConnection con;
        public SqlConnection DBConnect()
        {
            try
            {

                string filePath = (@"C:\Chemin\CHBD.txt");
                string connectionString = File.ReadAllText(filePath);
                con = new SqlConnection(connectionString);
                con.Open();
                return con;
                //string strConnectionString = "C:/chemin";
                ////string strConnectionString = "datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=stock_management;";

                //con = new SqlConnection(strConnectionString);
                //con.Open();
                //return con;
            }
            catch (SqlException )
            {
                return null ;
            }
        }
    }
}
