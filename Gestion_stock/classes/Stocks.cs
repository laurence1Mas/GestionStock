using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace Gestion_stock.classes
{
    class Stocks
    {
        string id;
        string produit_id;
        int quantite;
        string type_operation;
        decimal pu;
        DateTime date;

        SqlConnection con;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Produit_id
        {
            get
            {
                return produit_id;
            }

            set
            {
                produit_id = value;
            }
        }

        public int Quantite
        {
            get
            {
                return quantite;
            }

            set
            {
                quantite = value;
            }
        }

        public string Type_operation
        {
            get
            {
                return type_operation;
            }

            set
            {
                type_operation = value;
            }
        }

        public decimal Pu
        {
            get
            {
                return pu;
            }

            set
            {
                pu = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public  int ModifierStocks(Stocks stock)
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_transactstock @quantite, @prix,@CodeStock;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcode = new SqlParameter("@CodeStock", stock.id);
                SqlParameter prquant = new SqlParameter("@quantite", stock.quantite);
                SqlParameter prpu = new SqlParameter("@prix", stock.pu);
                cmd.Parameters.Add(prcode);
                cmd.Parameters.Add(prquant);
                cmd.Parameters.Add(prpu);
                value = cmd.ExecuteNonQuery();
                return value;
            }
            else
            {
                return value;
            }
        }
        public int supprimierStocks(Stocks stock)
        {
            int value = 0;
            string strquery = "exec delete_transactstock @codestock";
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeclient = new SqlParameter("@codestock", stock.id);
                cmd.Parameters.Add(prcodeclient);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }
        public List<Stocks> GetStocks()
        {
            List<Stocks> list = new List<Stocks>();
            con = new dataconnexion().DBConnect();
            string strquery = "exec GenerateJournal";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Stocks clsc = new Stocks();
                clsc.id = dr["TransactionID"].ToString();
                clsc.produit_id = dr["Produit"].ToString();
                clsc.quantite = Convert.ToInt32((dr["Quantite"]));
                clsc.pu = Convert.ToInt32(dr["PrixUnitaire"]);
                clsc.type_operation = Convert.ToString(dr["TypeOperation"]);
                clsc.date = Convert.ToDateTime(dr["DateOperation"]);
                list.Add(clsc);
            }
            return list;
        }
        public DataTable recherche_Infromation(string NomTable, string produit, string typeoperation, string recherche)
        {
            con = new dataconnexion().DBConnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            SqlCommand cmd = new SqlCommand("select * from " + NomTable + " WHERE " + produit + " LIKE '%" + recherche + "%' or " + typeoperation + " LIKE '%" + recherche + "%'", con);
            SqlDataAdapter dt = null;
            dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
    }
}
