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
    public partial class fournisseur : UserControl
    {
        classes.clsfournisseur clsf = new classes.clsfournisseur();
        classes.MYCONNEXION M = new classes.MYCONNEXION();
        public fournisseur()
        {
            InitializeComponent();
            loadListe();
        }

        private void dgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindigClass()
        {
            clsf.Codefournisseur = txtcode.Text;
            clsf.Nom = txtnom.Text;
            clsf.Adresse = txtadresse.Text;
            clsf.Numero = txtnumero.Text;
            clsf.Mail = txtmail.Text;
        }
        private void refresh()
        {
            txtcode.Text = "";
            txtnom.Text = "";
            txtadresse.Text = "";
            txtnumero.Text = "";
            txtmail.Text = "";
        }
        private void loadListe()
        {
            try
            {
                dgfournisseur.DataSource = clsf.getclient();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur" + ex);
            }
        }
        private void dgfournisseur_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgfournisseur.RowCount > 0)
            {
                txtcode.Text = dgfournisseur["dgcode", dgfournisseur.CurrentRow.Index].Value.ToString();
                txtnom.Text = dgfournisseur["dgnom", dgfournisseur.CurrentRow.Index].Value.ToString();
                txtadresse.Text = dgfournisseur["dgadresse", dgfournisseur.CurrentRow.Index].Value.ToString();
                txtnumero.Text = dgfournisseur["dgnumero", dgfournisseur.CurrentRow.Index].Value.ToString();
                txtmail.Text = dgfournisseur["dgmail", dgfournisseur.CurrentRow.Index].Value.ToString();
                btnmodifier.Enabled = true;
                btnsupprimer.Enabled = true;
                btnenregistrer.Enabled = false;
            }
        }

        private void fournisseur_Load(object sender, EventArgs e)
        {
            loadListe();
        }

        private void btnmodifier_Click_1(object sender, EventArgs e)
        {
            bindigClass();
            int value = clsf.modifierfournisseur(clsf);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuer avec succès", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListe();
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadListe();
                refresh();
            }
            btnenregistrer.Enabled = true;
        }

        private void btnenregistrer_Click_1(object sender, EventArgs e)
        {
            bindigClass();
            int value = clsf.AjouterFournisseur(clsf);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuer avec succès", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
                loadListe();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                refresh();
                loadListe();
            }
        }

        private void btnsupprimer_Click_1(object sender, EventArgs e)
        {
            bindigClass();
            int value = clsf.supprimerfournisseur(clsf);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuer avec succès", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListe();
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadListe();
                refresh();
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            dgfournisseur.DataSource = clsf.recherche_Infromation(" fournisseur", "nom", "adresse", "telephone", txtrecherche.Text);
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            sorties.listeFournisseur rpt = new sorties.listeFournisseur();
            rpt.DataSource = M.get_Report_Z("afficher_fournisseur");
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}
