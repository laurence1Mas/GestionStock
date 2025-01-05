using Gestion_stock.usercontols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_stock
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new stock());
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new client());
        }

        private void btnFournisseur_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new fournisseur());
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new produit());
        }

        private void btnApprov_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new approvisionnemnt());
        }

        private void btnVente_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new vente());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new Userdashboard());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new aide());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndepense_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new depense());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
