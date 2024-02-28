using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Gestion_stock.classes
{
    class Produits
    {
        string id;
        string nom;
        string designation;
        decimal prix;
        int quantite;
        string barcode;

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

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Designation
        {
            get
            {
                return designation;
            }

            set
            {
                designation = value;
            }
        }

        public decimal Prix
        {
            get
            {
                return prix;
            }

            set
            {
                prix = value;
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

        public string Barcode
        {
            get
            {
                return barcode;
            }

            set
            {
                barcode = value;
            }
        }

        public int Ajouterproduit(Produits produit)
        {
            int value = 0;
            int values = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_produits @nom,@descriptions,@prix,@stock,@devise;";
                
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prnom = new SqlParameter("@nom", produit.nom);
                SqlParameter prdescription = new SqlParameter("@descriptions", produit.designation);
                SqlParameter prprixu = new SqlParameter("@prix", produit.prix);
                SqlParameter prquantite = new SqlParameter("@stock", produit.quantite);
                SqlParameter prdevise = new SqlParameter("@devise", produit.Barcode);
                cmd.Parameters.Add(prnom);
                cmd.Parameters.Add(prdescription);
                cmd.Parameters.Add(prprixu);
                cmd.Parameters.Add(prquantite);
                cmd.Parameters.Add(prdevise);
                value = cmd.ExecuteNonQuery();
                int tmp = value + values;
                return tmp;
            }
            else
            {
                return value;
            }

        }
        public int modifierproduits(Produits produit)
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_produits @code,@nom,@descriptions,@prix,@stock,@barcode;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcode = new SqlParameter("@code", produit.id);
                SqlParameter prnom = new SqlParameter("@nom", produit.nom);
                SqlParameter prdescription = new SqlParameter("@descriptions", produit.designation);
                SqlParameter prprixu = new SqlParameter("@prix", produit.prix);
                SqlParameter prquantite = new SqlParameter("@stock", produit.quantite);
                SqlParameter prdevise = new SqlParameter("@barcode", produit.Barcode);
                cmd.Parameters.Add(prcode);
                cmd.Parameters.Add(prnom);
                cmd.Parameters.Add(prdescription);
                cmd.Parameters.Add(prprixu);
                cmd.Parameters.Add(prquantite);
                cmd.Parameters.Add(prdevise);
                value = cmd.ExecuteNonQuery();
                return value;
            }
            else
            {
                return value;
            }
        }

        public int supprimerprod(Produits produit)
        {
            int value = 0;
            string strquery = "exec delete_produits @codeproduit";
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeclient = new SqlParameter("@codeproduit", produit.id);
                cmd.Parameters.Add(prcodeclient);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }
        public List<Produits> GetProduits()
        {
            List<Produits> list = new List<Produits>();
            con = new dataconnexion().DBConnect();
            string strquery = " exec afficher_produit";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Produits clsc = new Produits();
                clsc.Id = dr["id"].ToString();
                clsc.Nom = (dr["nom"]).ToString();
                clsc.Designation = Convert.ToString(dr["descriptions"]);
                clsc.Prix = Convert.ToDecimal(dr["prix"]);
                clsc.Quantite = Convert.ToInt32(dr["stock"]);
                clsc.Barcode = Convert.ToString(dr["barcode"]);
                list.Add(clsc);
            }
            return list;
        }

        public void chargercomboboxproduit(ComboBox list)
        {
            con = new dataconnexion().DBConnect();
            try
            {
                var chrg = new SqlCommand("chargement_produit", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new SqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "produit");
                list.DataSource = ds.Tables["produit"];
                list.ValueMember = "id";
                list.DisplayMember = "descriptions";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable recherche_Infromation(string NomTable, string nom, string description, string recherche)
        {
            con = new dataconnexion().DBConnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            SqlCommand cmd = new SqlCommand("select * from " + NomTable + " WHERE " + nom + " LIKE '%" + recherche + "%' or " + description + " LIKE '%" + recherche + "%'", con);
            SqlDataAdapter dt = null;
            dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
    }
}
