using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock.classes
{
    class clsdepense
    {
        string id;
        string libelle;
        decimal debit;
        decimal credit;
        DateTime dateoperation;

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

        public string Libelle
        {
            get
            {
                return libelle;
            }

            set
            {
                libelle = value;
            }
        }

        public decimal Credit
        {
            get
            {
                return credit;
            }

            set
            {
                credit = value;
            }
        }

        public decimal Debit
        {
            get
            {
                return debit;
            }

            set
            {
                debit = value;
            }
        }

        public DateTime Dateoperation
        {
            get
            {
                return dateoperation;
            }

            set
            {
                dateoperation = value;
            }
        }

        //=============================methode d'ajout client==========================//
        SqlConnection con;
        public int Ajouterdepense(clsdepense clsdepense)
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_journal @libelle,@debit,@credit; ";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prlibelle = new SqlParameter("@libelle", clsdepense.libelle);
                SqlParameter prdebit = new SqlParameter("@debit", clsdepense.debit);
                SqlParameter prcredit = new SqlParameter("@credit", clsdepense.credit);
                cmd.Parameters.Add(prlibelle);
                cmd.Parameters.Add(prdebit);
                cmd.Parameters.Add(prcredit);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }

        public int Modifierdepense(clsdepense clsdepense)
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_journal @id,@libelle,@debit,@credit; ";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prid = new SqlParameter("@id", clsdepense.id);
                SqlParameter prlibelle = new SqlParameter("@libelle", clsdepense.libelle);
                SqlParameter prdebit = new SqlParameter("@debit", clsdepense.debit);
                SqlParameter prcredit = new SqlParameter("@credit", clsdepense.credit);
                cmd.Parameters.Add(prid);
                cmd.Parameters.Add(prlibelle);
                cmd.Parameters.Add(prdebit);
                cmd.Parameters.Add(prcredit);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }

        public int supprimerdepense(clsdepense clsdepense)
        {
            int value = 0;
            string strquery = "exec delete_journal @id";
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prid = new SqlParameter("@id", clsdepense.id);
                cmd.Parameters.Add(prid);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }

        public List<clsdepense> getdepense()
        {
            List<clsdepense> list = new List<clsdepense>();
            con = new dataconnexion().DBConnect();
            string strquery = "exec afficher_journalLimit;";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsdepense clsc = new clsdepense();
                clsc.id = dr["id"].ToString();
                clsc.libelle = dr["libelle"].ToString();
                clsc.debit =Convert.ToDecimal(dr["debit"]);
                clsc.credit =Convert.ToDecimal(dr["credit"]);
                clsc.dateoperation = Convert.ToDateTime( dr["dateoperation"]);
                list.Add(clsc);
            }
            return list;
        }

        public DataTable recherche_Infromation(string NomTable, string Libelle, string Dateoperation, string recherche)
        {
            con = new dataconnexion().DBConnect();
            if (!con.State.ToString().ToLower().Equals("open")) con.Open();
            SqlCommand cmd = new SqlCommand("select * from " + NomTable + " WHERE " + Libelle + " LIKE '%" + recherche + "%' or " + Dateoperation + " LIKE '%" + recherche + "%' ", con);
            SqlDataAdapter dt = null;
            dt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dt.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }
    }
}
