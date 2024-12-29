using Gestion_stock.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_stock
{
    public partial class Login : Form
    {
        classes.MYCONNEXION M = new classes.MYCONNEXION();
        SqlConnection con;
        public Login()
        {
            InitializeComponent();
        }

        private bool EstConnexionValide(string nomUtilisateur, string motDePasse)
        {
            con = new dataconnexion().DBConnect();
            using (con)
            {

                // Requête SQL pour vérifier les informations d'identification
                string query = "SELECT COUNT(*) FROM logins WHERE username = @NomUtilisateur AND passwords = @MotDePasse";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Paramètres pour éviter les attaques par injection SQL
                    command.Parameters.AddWithValue("@NomUtilisateur", nomUtilisateur);
                    command.Parameters.AddWithValue("@MotDePasse", motDePasse);

                    // Exécution de la requête
                    int count = (int)command.ExecuteScalar();

                    // Si le nombre de lignes retourné est supérieur à 0, les informations d'identification sont valides
                    return count > 0;
                }
            }
        }

        private void btnconnection_Click(object sender, EventArgs e)
        {
            try
            {

                string nomUtilisateur = txtusername.Text;
                string motDePasse = txtpassword.Text;

                if (EstConnexionValide(nomUtilisateur, motDePasse))
                {
                    MessageBox.Show("connexion reussie avec succès", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    home home = new home();
                    Login lg = new Login();
                    this.Hide();
                    home.Show();
                    // Vous pouvez effectuer d'autres actions ici après la connexion réussie
                }
                else
                {
                    MessageBox.Show("Échec de la connexion. Veuillez vérifier vos informations.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur", ex.Message);
            }
        }

        private void btndisconnect_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
