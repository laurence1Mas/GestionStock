using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Gestion_stock.classes
{
    class clsfournisseur
    {
        string codefournisseur;
        string nom;
        string adresse;
        string numero;
        string mail;

        

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
          

        
        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        public string Codefournisseur
        {
            get
            {
                return codefournisseur;
            }

            set
            {
                codefournisseur = value;
            }
        }

        SqlConnection con;
        public int AjouterFournisseur(clsfournisseur clsfournisseur)
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_fournisseur @nom,@adresse,@numero,@mail; ";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prnom = new SqlParameter("@nom", clsfournisseur.nom);
                SqlParameter pradresse = new SqlParameter("@adresse", clsfournisseur.adresse);
                SqlParameter prnumero = new SqlParameter("@numero", clsfournisseur.numero);
                SqlParameter prmail = new SqlParameter("@mail", clsfournisseur.mail);
                cmd.Parameters.Add(prnom);
                cmd.Parameters.Add(pradresse);
                cmd.Parameters.Add(prnumero);
                cmd.Parameters.Add(prmail);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }
        //=============================modification fournisseur====================================//
        public int modifierfournisseur(clsfournisseur clsfournisseur)
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_fournisseur @codefournisseur,@nom,@adresse, @numero, @mail;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcode = new SqlParameter("@codefournisseur", clsfournisseur.Codefournisseur);
                SqlParameter prnom = new SqlParameter("@nom", clsfournisseur.nom);
                SqlParameter pradresse = new SqlParameter("@adresse", clsfournisseur.adresse);
                SqlParameter prnumero = new SqlParameter("@numero", clsfournisseur.numero);
                SqlParameter prmail = new SqlParameter("@mail", clsfournisseur.mail);
                cmd.Parameters.Add(prcode);
                cmd.Parameters.Add(prnom);
                cmd.Parameters.Add(pradresse);
                cmd.Parameters.Add(prnumero);
                cmd.Parameters.Add(prmail);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }
        //============================suppression fournisseur======================================//
        public int supprimerfournisseur(clsfournisseur clsfournisseur)
        {
            int value = 0;
            string strquery = "exec delete_fournisseur @codeclient";
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeclient = new SqlParameter("@codeclient", clsfournisseur.Codefournisseur);
                cmd.Parameters.Add(prcodeclient);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }
        //==========================getliste fournisseur===========================================//
        public List<clsfournisseur> getclient()
        {
            List<clsfournisseur> list = new List<clsfournisseur>();
            con = new dataconnexion().DBConnect();
            string strquery = " exec afficher_fournisseur;";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsfournisseur clsc = new clsfournisseur();
                clsc.Codefournisseur = dr["id"].ToString();
                clsc.Nom = dr["nom"].ToString();
                clsc.Adresse = dr["adresse"].ToString();
                clsc.Numero = dr["telephone"].ToString();
                clsc.Mail = dr["mail"].ToString();
                list.Add(clsc);
            }
            return list;
        }
        public void chargercomboboxfournisseur(ComboBox list)
        {
            con = new dataconnexion().DBConnect();
            try
            {
                var chrg = new SqlCommand("chargement_fournisseur", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new SqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "fournisseur");
                list.DataSource = ds.Tables["fournisseur"];
                list.ValueMember = "id";
                list.DisplayMember = "nom";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void chargerlistboxfournisseur(ListBox list)
        {
            con = new dataconnexion().DBConnect();
            try
            {
                var chrg = new SqlCommand("chargement_fournisseur", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new SqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "fournisseur");
                list.DataSource = ds.Tables["fournisseur"];
                list.ValueMember = "id";
                list.DisplayMember = "nom";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable recherche_Infromation(string NomTable, string Nom, string adresse, string numero, string recherche)
        {
            con = new dataconnexion().DBConnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            SqlCommand cmd = new SqlCommand("select * from " + NomTable + " WHERE " + Nom + " LIKE '%" + recherche + "%' or " + adresse + " LIKE '%" + recherche + "%' or " + numero + " LIKE '%" + recherche + "%' ", con);
            SqlDataAdapter dt = null;
            dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
    }
}
