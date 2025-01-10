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
    public partial class frm_client : Form
    {
        classes.clsclient clsc = new classes.clsclient();
        public frm_client()
        {
            InitializeComponent();
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            bindigClass();
            int value = clsc.Ajouterclient(clsc);

            if (value >= 1)
            {
                MessageBox.Show("Operation effectuer avec succès", "client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                refresh();
            }
        }
    }
}
