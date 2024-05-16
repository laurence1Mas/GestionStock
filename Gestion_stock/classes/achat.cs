using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gestion_stock.classes
{
    class Achat
    {
        string id;
        string Fournisseur_id;
        int quantite_achat;
        string produit_id;
        decimal PAunitaires;
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

        public string Fournisseur_id1
        {
            get
            {
                return Fournisseur_id;
            }

            set
            {
                Fournisseur_id = value;
            }
        }

        public int Quantite_achat
        {
            get
            {
                return quantite_achat;
            }

            set
            {
                quantite_achat = value;
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

        public decimal PAunitaires1
        {
            get
            {
                return PAunitaires;
            }

            set
            {
                PAunitaires = value;
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

        public int Ajouterachat(Achat achat)
        {
            int value = 0;
            int values = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_achat @fournisseur,@quantite,@produit,@prixu;";
                string querytwo = "exec Gestion_stock @produit, @quantite, @types, @prixu;";
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlCommand execut = new SqlCommand(querytwo, con);

                SqlParameter pridfournisseur = new SqlParameter("@fournisseur", achat.Fournisseur_id);
                SqlParameter prquantite = new SqlParameter("@quantite", achat.quantite_achat);
                SqlParameter pridproduit = new SqlParameter("@produit", achat.produit_id);
                SqlParameter prPAU = new SqlParameter("@prixu", achat.PAunitaires1);

                SqlParameter type = new SqlParameter("@types", "ENTREE");
                SqlParameter prquantites = new SqlParameter("@quantite", achat.Quantite_achat);
                SqlParameter pridproduits = new SqlParameter("@produit", achat.Produit_id);
                SqlParameter prPAUs = new SqlParameter("@prixu", achat.PAunitaires1);
                cmd.Parameters.Add(pridfournisseur);
                cmd.Parameters.Add(prquantite);
                cmd.Parameters.Add(pridproduit);
                cmd.Parameters.Add(prPAU);
                execut.Parameters.Add(pridproduits);
                execut.Parameters.Add(prquantites);
                execut.Parameters.Add(type);
                execut.Parameters.Add(prPAUs);
                value = cmd.ExecuteNonQuery();
                values = execut.ExecuteNonQuery();
                int tmp = value + values;
                return tmp;
            }
            else
            {
                return value;
            }
        }
        public int modifierachat(Achat Achats)
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_achat @codeachat,@fournisseur,@quantite,@produit,@prixu;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcode = new SqlParameter("@codeachat", Achats.Id);
                SqlParameter prfournisseur = new SqlParameter("@fournisseur", Achats.Fournisseur_id1);
                SqlParameter prquantite = new SqlParameter("@quantite", Achats.Quantite_achat);
                SqlParameter prprixu = new SqlParameter("@prixu", Achats.PAunitaires1);
                SqlParameter prproduit = new SqlParameter("@produit", Achats.Produit_id);
                //SqlParameter prdate = new SqlParameter("@produit", Achats.date);

                cmd.Parameters.Add(prcode);
                cmd.Parameters.Add(prfournisseur);
                cmd.Parameters.Add(prproduit);
                cmd.Parameters.Add(prquantite);
                cmd.Parameters.Add(prprixu);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }
        //============================suppression achat======================================//
        public int supprimerachat(Achat Achats)
        {
            int value = 0;
            string strquery = "exec delete_achat @codeachat";
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeachat = new SqlParameter("@codeachat", Achats.Id);
                cmd.Parameters.Add(prcodeachat);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }
        //==========================getliste achat===========================================//
        public List<Achat> getachat()
        {
            List<Achat> list = new List<Achat>();
            con = new dataconnexion().DBConnect();
            string strquery = "exec afficher_achat";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Achat clsc = new Achat();
                clsc.Id =  dr["id"].ToString();
                clsc.Fournisseur_id1 = dr["fournisseur"].ToString();
                clsc.Produit_id = dr["produit"].ToString();
                clsc.Quantite_achat = Convert.ToInt32(dr["quantite_achat"]);
                clsc.PAunitaires1 = Convert.ToDecimal(dr["PAUnitaires"]);
                clsc.Date =Convert.ToDateTime( dr["date_achat"]);
                list.Add(clsc);
            }
            return list;
        }
        public DataTable recherche_Infromation(string NomTable, string fournisseur, string produit, string dateachat, string recherche)
        {
            con = new dataconnexion().DBConnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            SqlCommand cmd = new SqlCommand("select * from " + NomTable + " WHERE " + fournisseur + " LIKE '%" + recherche + "%' or " + produit + " LIKE '%" + recherche + "%' or " + dateachat + " LIKE '%" + recherche + "%' ", con);
            SqlDataAdapter dt = null;
            dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
    }
}
