﻿using System;
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
    public partial class vente : UserControl
    {
        classes.Ventes sell = new classes.Ventes();
        classes.clsclient clsclient = new classes.clsclient();
        classes.Produits clsproduit = new classes.Produits();
        classes.MYCONNEXION M = new classes.MYCONNEXION();
        public vente()
        {
            InitializeComponent();
            loadlist();
        }
        private void bindingclasse()
        {
            sell.Id = txtcode.Text;
            sell.Quantite = Convert.ToInt32(txtquantitevente.Text);
            sell.Client_id = Convert.ToString(cmbrefclient.SelectedValue);
            sell.Produit_id = Convert.ToString(cmbproduitref.SelectedValue);
            sell.PVunitaires1 = Convert.ToDecimal(txtprix.Text);
            sell.Date = Convert.ToDateTime(txtdatevente.Text);
        }
        private void loadlist() 
        {
            dgventes.DataSource = sell.getVentes();
            clsclient.chargercomboboxclient(cmbrefclient);
            clsproduit.chargercomboboxproduit(cmbproduitref);
        }
        private void refresh()
        {
            txtcode.Text = "";
            cmbrefclient.Text = "";
            cmbproduitref.Text = "";
            txtquantitevente.Text = "";
            txtprix.Text = "";
            txtdatevente.Text = "";
        }
        private void vente_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void btnenregistrer_Click_1(object sender, EventArgs e)
        {

            bindingclasse();
            int value = sell.Ajoutervente(sell);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "vente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "vente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
                refresh();
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindingclasse();
            int value = sell.modifierventes(sell);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "vente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "vente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
                refresh();
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            bindingclasse();
            int value = sell.supprimervente(sell);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "vente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "vente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadlist();
                refresh();
            }
        }

        private void dgventes_DoubleClick(object sender, EventArgs e)
        {
            if(dgventes.RowCount > 0)
            {
                txtcode.Text = dgventes["dgcode", dgventes.CurrentRow.Index].Value.ToString();
                cmbrefclient.Text= dgventes["dgclient", dgventes.CurrentRow.Index].Value.ToString();
                cmbproduitref.Text= dgventes["dgproduit", dgventes.CurrentRow.Index].Value.ToString();
                txtquantitevente.Text= dgventes["dgquantite", dgventes.CurrentRow.Index].Value.ToString();
                txtprix.Text= dgventes["dgprix", dgventes.CurrentRow.Index].Value.ToString();
                txtdatevente.Text= dgventes["dgdatevente", dgventes.CurrentRow.Index].Value.ToString();
                btnenregistrer.Enabled = false;
                btnmodifier.Enabled = true;
                btnsupprimer.Enabled = true;
            }
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            sorties.listeAchat rpt = new sorties.listeAchat();
            rpt.DataSource = M.get_Report_Z("afficher_vente");
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            dgventes.DataSource = sell.recherche_Infromation(" affiche_ventes", "client", "produit", "dateVente", txtrecherche.Text);

        }

        private void btnfacture_Click(object sender, EventArgs e)
        {
            sorties.facture rpt = new sorties.facture();
            rpt.DataSource = M.get_Report_Z("afficher_panier");
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }

            int value = sell.viderpanier();

            if (value == 0)
            {
                MessageBox.Show("Operation effectuée avec succès", "panier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operation effectuée avec succès", "panier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnjour_Click(object sender, EventArgs e)
        {
            sorties.rapportVenteJour rpt = new sorties.rapportVenteJour();
            rpt.DataSource = M.get_Report_venteJour("affiche_ventes","dateVentes",txtdatevente.Text);
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadlist();
        }
    }
}
