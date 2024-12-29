using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace Gestion_stock.usercontols
{
    public partial class produit : UserControl
    {
        classes.Produits clsf = new classes.Produits();
        classes.MYCONNEXION M = new classes.MYCONNEXION();
        public produit()
        {
            InitializeComponent();
        }
        private void BindingClasse2()
        {
            clsf.Id = txtcode.Text;
            clsf.Quantite = Convert.ToInt32(txtquantite.Text);
            clsf.Nom = txtNom.Text.ToString();
            clsf.Prix = Convert.ToDecimal(txtprixU.Text);
            clsf.Designation = txtdesignation.Text;
            clsf.Barcode = txtbarcode.Text;
        }
        private void loadliste()
        {
            try
            {
                dgproduit.DataSource = clsf.GetProduits();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur" + ex);
            }
        }
        private void refresh()
        {
            txtcode.Text = "";
            txtNom.Text = "";
            txtdesignation.Text = "";
            txtbarcode.Text = "";
            txtprixU.Text = "0";
            txtquantite.Text = "0";
        }

        private void produit_Load(object sender, EventArgs e)
        {
            loadliste();
        }

        private void dgproduit_DoubleClick(object sender, EventArgs e)
        {
            if(dgproduit.RowCount > 0)
            {
                txtcode.Text = dgproduit["dgcode", dgproduit.CurrentRow.Index].Value.ToString();
                txtNom.Text = dgproduit["dgnom", dgproduit.CurrentRow.Index].Value.ToString();
                txtdesignation.Text = dgproduit["dgdescription", dgproduit.CurrentRow.Index].Value.ToString();
                txtprixU.Text = dgproduit["dgprixU", dgproduit.CurrentRow.Index].Value.ToString();
                txtquantite.Text = dgproduit["dgquantite", dgproduit.CurrentRow.Index].Value.ToString();
                txtbarcode.Text = dgproduit["dgbarcode", dgproduit.CurrentRow.Index].Value.ToString();
                btnenregistrer.Enabled = false;
                btnmodifier.Enabled = true;
                btnsupprimer.Enabled = true;
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClasse2();
                int value = clsf.modifierproduits(clsf);

                if (value >= 1)
                {

                    MessageBox.Show("Operation effctuer avec succès", "produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadliste();
                    refresh();
                }
                else
                {
                    MessageBox.Show("Operation non effectuer", "produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loadliste();
                    refresh();
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("eureur", "produit"+ ex,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnenregistrer.Enabled = true;
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            BindingClasse2();
            int value = clsf.supprimerprod(clsf);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuer avec succès", "produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadliste();
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadliste();
                refresh();
            }
        }

        private void btnenregistrer_Click_1(object sender, EventArgs e)
        {
            BindingClasse2();
            int value = clsf.Ajouterproduit(clsf);

            if (value >= 1)
            {
                MessageBox.Show("Operation effctuer avec succès", "produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadliste();
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "produit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadliste();
                refresh();
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            dgproduit.DataSource = clsf.recherche_Infromation(" produits", "nom", "descriptions",  txtrecherche.Text);
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            sorties.listeProduit rpt = new sorties.listeProduit();
            rpt.DataSource = M.get_Report_Z("afficher_produit");
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadliste();
        }
    }
}
