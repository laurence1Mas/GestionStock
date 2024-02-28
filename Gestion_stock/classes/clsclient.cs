using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Gestion_stock.classes
{
    class clsclient
    {
        string codeclient;
        string nom;
        string adresse;
        string numero;
        string mail;

        public string Codeclient
        {
            get
            {
                return codeclient;
            }

            set
            {
                codeclient = value;
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
        //=============================methode d'ajout client==========================//
        SqlConnection con;
        public int Ajouterclient(clsclient clsclients)
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_client @nom,@adresse,@numero,@mail; ";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prnom = new SqlParameter("@nom", clsclients.nom);
                SqlParameter pradresse = new SqlParameter("@adresse", clsclients.adresse);
                SqlParameter prnumero = new SqlParameter("@numero", clsclients.numero);
                SqlParameter prmail = new SqlParameter("@mail", clsclients.mail);
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
        //=============================modification client====================================//
        public int modifierclient(clsclient clsclients)
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_client @codeclient,@nom, @adresse,@numero, @mail;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcode = new SqlParameter("@codeclient", clsclients.codeclient);
                SqlParameter prnom = new SqlParameter("@nom", clsclients.nom);
                SqlParameter pradresse = new SqlParameter("@adresse", clsclients.adresse);
                SqlParameter prnumero = new SqlParameter("@numero", clsclients.numero);
                SqlParameter prmail = new SqlParameter("@mail", clsclients.mail);
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
        //============================suppression client======================================//
        public int supprimerclient(clsclient clsclients)
        {
            int value = 0;
            string strquery = "exec delete_client @codeclient";
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeclient = new SqlParameter("@codeclient", clsclients.codeclient);
                cmd.Parameters.Add(prcodeclient);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }
        //==========================getliste client===========================================//
        public List<clsclient> getclient()
        {
            List<clsclient> list = new List<clsclient>();
            con = new dataconnexion().DBConnect();
            string strquery = "exec afficher_client ;";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsclient clsc = new clsclient();
                clsc.Codeclient = dr["id"].ToString();
                clsc.Nom = dr["nom"].ToString();
                clsc.adresse = dr["adresse"].ToString();
                clsc.numero = dr["telephone"].ToString();
                clsc.mail = dr["mail"].ToString();
                list.Add(clsc);
            }
            return list;
        }

        public void chargercomboboxclient(ComboBox list)
        {
            con = new dataconnexion().DBConnect();
            try
            {
                var chrg = new SqlCommand("chargement_client", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new SqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "client");
                list.DataSource = ds.Tables["client"];
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
            SqlCommand cmd = new SqlCommand("select * from "  + NomTable + " WHERE " + Nom + " LIKE '%" + recherche + "%' or " + adresse + " LIKE '%" + recherche + "%' or " + numero + " LIKE '%" + recherche + "%' ", con);
            SqlDataAdapter  dt = null;
             dt = new SqlDataAdapter(cmd);
            DataSet  ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
    }
}

