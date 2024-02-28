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
    public partial class stock : UserControl
    {
        classes.Stocks stoc = new classes.Stocks();
        classes.MYCONNEXION M = new classes.MYCONNEXION();
        public stock()
        {
            InitializeComponent();
            loadlist();
        }

        private void stock_Load(object sender, EventArgs e)
        {
            loadlist();
        }
        private void loadlist() {
            dgstock.DataSource = stoc.GetStocks();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {

        }
        private void btnimprimer_Click(object sender, EventArgs e)
        {
            sorties.journalEntreSortie rpt = new sorties.journalEntreSortie();
            rpt.DataSource = M.get_Report_Z("GenerateJournal");
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sorties.etatStock rpt = new sorties.etatStock();
            rpt.DataSource = M.get_Report_Z("StockStatus");
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            dgstock.DataSource = stoc.recherche_Infromation(" vstock", "Produit", "TypeOperation", txtrecherche.Text);

        }

  }
        }
