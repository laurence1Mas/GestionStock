using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gestion_stock.classes;

namespace Gestion_stock.usercontols
{
    public partial class Userdashboard : UserControl
    {
        SqlConnection con;
        public Userdashboard()
        {
            InitializeComponent();
            chargement_label();
            graphiqueAchats();
            graphiqueventes();
            graphiqueApprovisionnemnt();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Userdashboard_Load(object sender, EventArgs e)
        {
            chargement_label();
            graphiqueAchats();
            graphiqueventes();
            graphiqueApprovisionnemnt();
        }

        private void chargement_label()
        {
            int value = 0;
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                con = new dataconnexion().DBConnect();
                string visiteur = "select count(*)from client ";
                var cmd1 = new SqlCommand(visiteur, con);
                float n1 = float.Parse(cmd1.ExecuteScalar().ToString());
                lblclient.Text = n1.ToString();

                string controle = "select count(*)from fournisseur ";
                var cmd2 = new SqlCommand(controle, con);
                float n2 = float.Parse(cmd2.ExecuteScalar().ToString());
                lblfournisseur.Text = n2.ToString();

                string visite = "select count(*)from produits ";
                var cmd3 = new SqlCommand(visite, con);
                float n3 = float.Parse(cmd3.ExecuteScalar().ToString());
                lblproduit.Text = n3.ToString();

                string agent = "select count(*)from vente ";
                var cmd4 = new SqlCommand(agent, con);
                float n4 = float.Parse(cmd4.ExecuteScalar().ToString());
                lblvente.Text = n4.ToString();

                value = cmd1.ExecuteNonQuery();
                value = cmd2.ExecuteNonQuery();
                value = cmd3.ExecuteNonQuery();
                value = cmd4.ExecuteNonQuery();
            }
        }
        private void graphiqueAchats()
        {
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                con = new dataconnexion().DBConnect();
                string query = "select top 10 count(*)as Flux,produits.nom as produit from achats inner join produits on produits.id=achats.produit_id group by produits.nom,achats.dateAchat";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    graphiqueAchat.Series["Series1"].Points.AddXY(reader["produit"],reader["Flux"]);
                }
            }
        }
        private void graphiqueApprovisionnemnt()
        {
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                con = new dataconnexion().DBConnect();
                string query = "select top 5 count(*)as Flux,produits.nom as produit,achats.dateAchat as dateAchat from achats inner join produits on produits.id=achats.produit_id group by produits.nom,achats.dateAchat";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chart1.Series["Series1"].Points.AddXY(reader["produit"], reader["dateAchat"]);
                    //chart1.Series["Series2"].Points.AddXY(reader["produit"], reader["dateAchat"]);

                }
            }
        }
        private void graphiqueventes()
        {
            con = new dataconnexion().DBConnect();
            if (con != null)
            {
                con = new dataconnexion().DBConnect();
                string query = "select top 5 count(*)as Flux,produits.nom as produit from vente inner join produits on produits.id=vente.produit_id group by produits.nom,vente.dateVente";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    graphiqueVente.Series["Series1"].Points.AddXY(reader["produit"], reader["Flux"]);

                }
            }
        }
    }
}
