using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_stock.frms
{
    public partial class frm_fournisseur : Form
    {
        classes.clsfournisseur clsf = new classes.clsfournisseur();
        public frm_fournisseur()
        {
            InitializeComponent();
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            bindigClass();
            int value = clsf.AjouterFournisseur(clsf);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuer avec succès", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                refresh();
            }
        }
    }
}
