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
    public partial class depense : UserControl

    {
        classes.clsdepense clsp = new classes.clsdepense();
        classes.MYCONNEXION M = new classes.MYCONNEXION();
        public depense()
        {
            InitializeComponent();
        }

        private void bindigClass()
        {
            clsp.Id = txtcode.Text;
            clsp.Libelle = txtlibelle.Text;
            clsp.Debit = Convert.ToDecimal(txtdebit.Text);
            clsp.Credit = Convert.ToDecimal(txtcredit.Text);
        }
        private void refresh()
        {
            txtcode.Text = "";
            txtlibelle.Text = "";
            txtdebit.Text = "";
            txtcredit.Text = "";
        }
        private void loading()
        {
            try
            {
                dgdepense.DataSource = clsp.getdepense();
            }
            catch ( Exception ex)
            {
                MessageBox.Show("erreur" + ex);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void depense_Load(object sender, EventArgs e)
        {
            loading();
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            bindigClass();
            int value = clsp.Ajouterdepense(clsp);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuer avec succès", "depense", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loading();
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "depense", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loading();
                refresh();
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindigClass();
            int value = clsp.Modifierdepense(clsp);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuer avec succès", "depense", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loading();
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "depense", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loading();
                refresh();
            }
            btnenregistrer.Enabled = true;
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            bindigClass();
            int value = clsp.supprimerdepense(clsp);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuer avec succès", "depense", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loading();
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "depense", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loading();
                refresh();
            }
        }

        private void rapportchekdate()
        {
            // Vérifiez que les contrôles dateDebut et dateFin sont correctement définis et contiennent des valeurs valides
            DateTime dateDebuts = dateDebut.Value;
            DateTime dateFins = dateFin.Value;
            try
            {
                // Créez une instance de votre rapport
                sorties.rapportDepensechekdate rpt = new sorties.rapportDepensechekdate();

                // Remplissez le rapport avec les données en utilisant votre fonction
                rpt.DataSource = M.getJournalsEntreDates(dateDebuts, dateFins, "GetJournalsEntreDates");

                // Affichez l'aperçu du rapport
                using (ReportPrintTool printool = new ReportPrintTool(rpt))
                {
                    printool.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération du rapport : " + ex.Message);
            }
        }

        private void btncheckdate_Click(object sender, EventArgs e)
        {
            rapportchekdate();
        }

        private void dgdepense_DoubleClick(object sender, EventArgs e)
        {
            if (dgdepense.RowCount > 0)
            {
                txtcode.Text = dgdepense["dgid", dgdepense.CurrentRow.Index].Value.ToString();
                txtlibelle.Text = dgdepense["dglibelle", dgdepense.CurrentRow.Index].Value.ToString();
                txtdebit.Text = dgdepense["dgdebit", dgdepense.CurrentRow.Index].Value.ToString();
                txtcredit.Text = dgdepense["dgcredit", dgdepense.CurrentRow.Index].Value.ToString();
                btnmodifier.Enabled = true;
                btnsupprimer.Enabled = true;
                btnenregistrer.Enabled = false;
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            dgdepense.DataSource = clsp.recherche_Infromation(" journal", "libelle", "dateoperation", txtrecherche.Text);

        }
    }
}
