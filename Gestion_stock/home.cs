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
            panel3.Height = btnclient.Height;
            panel3.Top = btnclient.Top;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            panel3.Height = btnStock.Height;
            panel3.Top = btnStock.Top;
            container.Controls.Clear();
            container.Controls.Add(new stock());
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            panel3.Height = btnclient.Height;
            panel3.Top = btnclient.Top;
            container.Controls.Clear();
            container.Controls.Add(new client());
        }

        private void btnFournisseur_Click(object sender, EventArgs e)
        {
            panel3.Height = btnFournisseur.Height;
            panel3.Top = btnFournisseur.Top;
            container.Controls.Clear();
            container.Controls.Add(new fournisseur());
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            panel3.Height = btnproduit.Height;
            panel3.Top = btnproduit.Top;
            container.Controls.Clear();
            container.Controls.Add(new produit());
        }

        private void btnApprov_Click(object sender, EventArgs e)
        {
            panel3.Height = btnApprov.Height;
            panel3.Top = btnApprov.Height;
            container.Controls.Clear();
            container.Controls.Add(new approvisionnemnt());
        }

        private void btnVente_Click(object sender, EventArgs e)
        {
            panel3.Height = btnVente.Height;
            panel3.Top = btnVente.Height;
            container.Controls.Clear();
            container.Controls.Add(new vente());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            panel3.Height = btnVente.Height;
            panel3.Top = btnVente.Height;
            container.Controls.Clear();
            container.Controls.Add(new Userdashboard());
        }
    }
}
