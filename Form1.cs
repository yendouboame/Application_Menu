using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Menu
{
    public partial class FrmChoixMenu : Form
    {
        public FrmChoixMenu()
        {
            InitializeComponent();
        }

        private void btnCocher_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in gbMenu.Controls)
            {
                checkBox.Checked = true;
            }
        }

        private void btnDecocherTout_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in gbMenu.Controls)
            {
                checkBox.Checked = false;
            }
        }

        private void btnCommander_Click(object sender, EventArgs e)
        {
            bool commandeVide = true;
            StringBuilder sb = new StringBuilder();

            foreach (CheckBox checkBox in gbMenu.Controls)
            {
                if (checkBox.Checked)
                {
                    sb.Append("\n- " + checkBox.Text);
                    commandeVide = false;
                }
            }
            if (commandeVide == false)
                MessageBox.Show("Vous avez commandé :" + sb.ToString(), "Commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Vous n'avez rien commandé", "Commande", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
