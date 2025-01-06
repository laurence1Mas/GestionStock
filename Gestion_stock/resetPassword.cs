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
    public partial class resetPassword : Form
    {
        classes.ClsLogin clsL = new classes.ClsLogin();
        public resetPassword()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }
        private void bindingclass()
        {
            clsL.Username = txtusername.Text;
            clsL.Password = txtpassword.Text;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsL.resetlogin(clsL);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuer avec succès", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
            }
            else
            {
                MessageBox.Show("Operation non effectuer", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Refresh();
            }
        }
    }
}
