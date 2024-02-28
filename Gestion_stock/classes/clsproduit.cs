using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock.classes
{
    class clsproduit
    {
        int codeproduit;
        int refcategorie;
        string designation;
        decimal prixU;

        public int Codeproduit
        {
            get
            {
                return codeproduit;
            }

            set
            {
                codeproduit = value;
            }
        }

        public int Refcategorie
        {
            get
            {
                return refcategorie;
            }

            set
            {
                refcategorie = value;
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

        public decimal PrixU
        {
            get
            {
                return prixU;
            }

            set
            {
                prixU = value;
            }
        }
        //==========================Ajouter produit==============================//
        SqlConnection con;
        public int Ajouterproduit(clsproduit clsproduits)
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "insert_produit @refcategorie,@designation,@prixU";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcategorie = new SqlParameter("@refcategorie", clsproduits.refcategorie);
                SqlParameter prdesignation = new SqlParameter("@designation", clsproduits.designation);
                SqlParameter prprixu = new SqlParameter("@prixU", clsproduits.prixU);
                cmd.Parameters.Add(prcategorie);
                cmd.Parameters.Add(prdesignation);
                cmd.Parameters.Add(prprixu);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }
        //==========================modifier produit==============================//
        public int modifierproduit(clsproduit clsproduits)
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "update_produit @idproduit @refcategorie,@designation,@prixU";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeproduit = new SqlParameter("@idproduit", clsproduits.codeproduit);
                SqlParameter prcategorie = new SqlParameter("@refcategorie", clsproduits.refcategorie);
                SqlParameter prdesignation = new SqlParameter("@designation", clsproduits.designation);
                SqlParameter prprixu = new SqlParameter("@prixU", clsproduits.prixU);
                cmd.Parameters.Add(prcodeproduit);
                cmd.Parameters.Add(prcategorie);
                cmd.Parameters.Add(prdesignation);
                cmd.Parameters.Add(prprixu);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }
        //====================== suppression produit==================================//
        public int supprimerproduit(clsproduit clsproduits)
        {
            int value = 0;
            string strquery = "delete_produit @codeproduit";
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeclient = new SqlParameter("@codeproduit", clsproduits.codeproduit);
                cmd.Parameters.Add(prcodeclient);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }
        public List<clsproduit> getproduit()
        {
            List<clsproduit> list = new List<clsproduit>();
            con = new dataconnexion().DBConnect();
            string strquery = "afficher_produit";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsproduit clsp = new clsproduit();
                clsp.codeproduit = Convert.ToInt32(dr["code"].ToString());
                clsp.refcategorie = Convert.ToInt32(dr["categorie"].ToString());
                clsp.designation = dr["designation"].ToString();
                clsp.prixU = Convert.ToDecimal(dr["PA"].ToString());
                list.Add(clsp);
            }
            return list;
        }
    }
}
