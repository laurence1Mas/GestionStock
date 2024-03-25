using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Gestion_stock.classes
{
    class Ventes
    {
        string id;
        string client_id;
        int quantite;
        string produit_id;
        decimal PVunitaires;
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

        public string Client_id
        {
            get
            {
                return client_id;
            }

            set
            {
                client_id = value;
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

        public decimal PVunitaires1
        {
            get
            {
                return PVunitaires;
            }

            set
            {
                PVunitaires = value;
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

        public int Ajoutervente(Ventes vente)
        {
            try
            {

                int value = 0;
                int values = 0;
                con = new dataconnexion().DBConnect();
                if (con != null)
                {
                    string strquery = "exec insert_vente @client,@quantite,@produit,@prixu;; ";
                    string querytwo = "exec Gestion_stock @produit, @quantite, @types, @prixu;;";
                    SqlCommand cmd = new SqlCommand(strquery, con);
                    SqlCommand execut = new SqlCommand(querytwo, con);
                    SqlParameter pridclient = new SqlParameter("@client", vente.Client_id);
                    SqlParameter prquantite = new SqlParameter("@quantite", vente.Quantite);
                    SqlParameter pridproduit = new SqlParameter("@produit", vente.Produit_id);
                    SqlParameter prPV = new SqlParameter("@prixu", vente.PVunitaires1);
                    SqlParameter type = new SqlParameter("@types", "SORTIE");
                    SqlParameter prquantites = new SqlParameter("@quantite", vente.Quantite);
                    SqlParameter pridproduits = new SqlParameter("@produit", vente.Produit_id);
                    SqlParameter prPVs = new SqlParameter("@prixu", vente.PVunitaires1);
                    cmd.Parameters.Add(pridclient);
                    cmd.Parameters.Add(prquantite);
                    cmd.Parameters.Add(pridproduit);
                    cmd.Parameters.Add(prPV);
                    execut.Parameters.Add(pridproduits);
                    execut.Parameters.Add(prquantites);
                    execut.Parameters.Add(type);
                    execut.Parameters.Add(prPVs);

                    value = cmd.ExecuteNonQuery();
                    values = execut.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int modifierventes(Ventes vente)
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_vente @CodeVente,@client,@Quantite,@Produit_id,@PVunitaire";
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcode = new SqlParameter("@CodeVente", vente.id);
                SqlParameter prclient = new SqlParameter("@client", vente.client_id);
                SqlParameter prproduit = new SqlParameter("@Produit_id", vente.produit_id);
                SqlParameter prPV = new SqlParameter("@PVunitaire", vente.PVunitaires);
                SqlParameter prquantite = new SqlParameter("@Quantite", vente.quantite);
                cmd.Parameters.Add(prcode);
                cmd.Parameters.Add(prclient);
                cmd.Parameters.Add(prproduit);
                cmd.Parameters.Add(prPV);
                cmd.Parameters.Add(prquantite);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }
        public int supprimervente(Ventes vente)
        {
            int value = 0;
            string strquery = "exec delete_vente @codevente";
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeclient = new SqlParameter("@codevente", vente.id);
                cmd.Parameters.Add(prcodeclient);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }
        public List<Ventes> getVentes()
        {
            List<Ventes> list = new List<Ventes>();
            con = new dataconnexion().DBConnect();
            string strquery = "exec afficher_vente";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Ventes clsc = new Ventes();
                clsc.id =dr["id"].ToString();
                clsc.client_id = dr["client"].ToString();
                clsc.produit_id = dr["produit"].ToString();
                clsc.quantite = Convert.ToInt32(dr["quantite"]);
                clsc.PVunitaires = Convert.ToDecimal(dr["PVUnitaires"]);
                clsc.date = Convert.ToDateTime(dr["dateVente"]);
                list.Add(clsc);
            }
            return list;
        }

        public DataTable recherche_Infromation(string NomTable, string client, string produit, string datevente, string recherche)
        {
            con = new dataconnexion().DBConnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            SqlCommand cmd = new SqlCommand("select * from " + NomTable + " WHERE " + client + " LIKE '%" + recherche + "%' or " + produit + " LIKE '%" + recherche + "%' or " + datevente + " LIKE '%" + recherche + "%' ", con);
            SqlDataAdapter dt = null;
            dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }

        public int viderpanier()
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            string strquery = " truncate table panier";
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }
    }
}

