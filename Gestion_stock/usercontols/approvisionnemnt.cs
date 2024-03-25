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
    public partial class approvisionnemnt : UserControl
    {
        classes.Achat achats = new classes.Achat();
        classes.clsfournisseur clsfournisseur = new classes.clsfournisseur();
        classes.Produits clsproduit = new classes.Produits();
        classes.MYCONNEXION M = new classes.MYCONNEXION();
        ToolTip tool = new ToolTip();
        public approvisionnemnt()
        {
            InitializeComponent();
            loadlist();
            tool.SetToolTip(btnenregistrer, "Enregistrer");
            tool.SetToolTip(btnmodifier, "Modifier");
            tool.SetToolTip(btnsupprimer, "Supprimer");
            tool.SetToolTip(pictureBox1, "actualiser");
        }
        private void bindingclasse() {
            achats.Id = txtcode.Text;
            achats.Fournisseur_id1 = Convert.ToString(cmbfournisseur.SelectedValue);
            achats.Quantite_achat =Convert.ToInt32( txtquantiteAchat.Text);
            achats.PAunitaires1 = Convert.ToDecimal(txtprixAU.Text);
            achats.Produit_id = Convert.ToString(cmbproduit.SelectedValue);
        }
        private void loadlist()
        {
            clsfournisseur.chargercomboboxfournisseur(cmbfournisseur);
            clsproduit.chargercomboboxproduit(cmbproduit);
            dgachat.DataSource = achats.getachat();
        }
        private void setnull()
        {
            txtprixAU.Text = "";
            txtquantiteAchat.Text = "";
            txtcode.Text = "";
            cmbfournisseur.Text = "";
            cmbproduit.Text = "";

        }
        private void approvisionnemnt_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            bindingclasse();
            int value = achats.Ajouterachat(achats);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "achat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                setnull();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "achat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
                setnull();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindingclasse();
            int value = achats.modifierachat(achats);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "achat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                setnull();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "achat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
                setnull();
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            bindingclasse();
            int value = achats.supprimerachat(achats);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "achat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                setnull();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "achat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
                setnull();
            }
        }

        private void dgachat_DoubleClick(object sender, EventArgs e)
        {
            if(dgachat.RowCount > 0)
            {
                txtcode.Text = dgachat["dgcode", dgachat.CurrentRow.Index].Value.ToString();
                cmbfournisseur.Text= dgachat["dgfournisseur", dgachat.CurrentRow.Index].Value.ToString();
                cmbproduit.Text= dgachat["dgproduit", dgachat.CurrentRow.Index].Value.ToString();
                txtquantiteAchat.Text= dgachat["dgquantiteA", dgachat.CurrentRow.Index].Value.ToString();
                txtprixAU.Text= dgachat["dgprixau", dgachat.CurrentRow.Index].Value.ToString();
                txtdateAchat.Text= dgachat["dgdateachat", dgachat.CurrentRow.Index].Value.ToString();
                btnenregistrer.Enabled = false;
                btnmodifier.Enabled = true;
                btnsupprimer.Enabled = true;
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            dgachat.DataSource = achats.recherche_Infromation(" Vachat", "fournisseur", "produit", "dateAchat", txtrecherche.Text);
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            sorties.listeAchat rpt = new sorties.listeAchat();
            rpt.DataSource = M.get_Report_Z("afficher_achat");
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }

        private void btnjour_Click(object sender, EventArgs e)
        {
            sorties.rapportjourApprovisionnement rpt = new sorties.rapportjourApprovisionnement();
            rpt.DataSource = M.get_Report_approvijour("Vachat", "dateAchat", txtdateAchat.Text);
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadlist();
        }

        private void btn_bon_entrer_Click(object sender, EventArgs e)
        {
            sorties.bon_entrer_stock rpt = new sorties.bon_entrer_stock();
            rpt.DataSource = M.get_Report_Bon_entrer_stock("Vachat", "dateAchat", "fournisseur", txtdateAchat.Text,cmbfournisseur.Text);
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}
