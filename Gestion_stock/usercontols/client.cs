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
    public partial class client : UserControl
    {
        classes.clsclient clsc =new classes.clsclient();
        classes.MYCONNEXION M = new classes.MYCONNEXION();
        ToolTip tool = new ToolTip();
        public client()
        {
            InitializeComponent();
            tool.SetToolTip(btnenregistrer, "Enregistrer");
            tool.SetToolTip(btnmodifier, "Modifier");
            tool.SetToolTip(btnsupprimer, "Supprimer");
            tool.SetToolTip(pictureBox1, "actualiser");
        }

        private void client_Load(object sender, EventArgs e)
        {
            loadListe();
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            bindigClass();
            int value = clsc.Ajouterclient(clsc);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuer avec succès", "adherant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListe();
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "adherant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadListe();
                refresh();
            }
        }
        private void bindigClass()
        {
            clsc.Codeclient = txtcode.Text;
            clsc.Nom = txtnom.Text;
            clsc.Adresse = txtadresse.Text;
            clsc.Numero = txtnumero.Text;
            clsc.Mail = txtmail.Text;
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
                dgclient.DataSource = clsc.getclient();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur" + ex);
            }
        }

        private void dgclient_DoubleClick(object sender, EventArgs e)
        {
            if (dgclient.RowCount > 0)
            {
                txtcode.Text = dgclient["dgcode", dgclient.CurrentRow.Index].Value.ToString();
                txtnom.Text = dgclient["dgnom", dgclient.CurrentRow.Index].Value.ToString();
                txtadresse.Text = dgclient["dgadresse", dgclient.CurrentRow.Index].Value.ToString();
                txtnumero.Text = dgclient["dgnumero", dgclient.CurrentRow.Index].Value.ToString();
                txtmail.Text = dgclient["dgmail", dgclient.CurrentRow.Index].Value.ToString();
                btnmodifier.Enabled = true;
                btnsupprimer.Enabled = true;
                btnenregistrer.Enabled = false;
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            bindigClass();
            int value = clsc.modifierclient(clsc);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuer avec succès", "Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListe();
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadListe();
                refresh();
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            bindigClass();
            int value = clsc.supprimerclient(clsc);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuer succès", "adherant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListe();
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "adherant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadListe();
                refresh();
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            dgclient.DataSource = clsc.recherche_Infromation(" client", "nom", "adresse", "telephone", txtrecherche.Text);
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            sorties.listeClient rpt = new sorties.listeClient();
            rpt.DataSource = M.get_Report_Z("afficher_client");
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadListe();
        }
    }
}
