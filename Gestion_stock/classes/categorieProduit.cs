using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock.classes
{
    class categorieProduit
    {
        int codecategorieprod;
        string designation;

        public int Codecategorieprod
        {
            get
            {
                return codecategorieprod;
            }

            set
            {
                codecategorieprod = value;
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
        //=========================== get liste=========================//
        private SqlConnection con;
        public List<categorieProduit>getcategorie()
        {
            List<categorieProduit> list = new List<categorieProduit>();
            con = new dataconnexion().DBConnect();
            string strquery = "afficher_categorie";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categorieProduit clsC = new categorieProduit();
                clsC.codecategorieprod = Convert.ToInt32(dr["codecategorie"].ToString());
                clsC.designation = dr["designation"].ToString();
                list.Add(clsC);
            }
            return list;
        }
    }
}
