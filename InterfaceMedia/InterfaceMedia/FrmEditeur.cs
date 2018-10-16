using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace InterfaceMedia
{
    public partial class FrmEditeur : MetroForm
    {
        public FrmEditeur()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text == "Ajouter")
            {
                btnAjouter.BackColor = Color.Green;
                btnAjouter.Text = "Valider";
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnRechercher.Enabled = false;
            }

            else if (btnAjouter.Text == "Valider")
            {
                btnAjouter.Text = "Ajouter";
                btnAjouter.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
                btnRechercher.Enabled = true;

            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnModifier.Text == "Modifier")
            {
                btnModifier.BackColor = Color.Green;
                btnModifier.Text = "Valider";
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnAjouter.Enabled = false;
                btnSupprimer.Enabled = false;
                btnRechercher.Enabled = false;
            }

            else if (btnModifier.Text == "Valider")
            {
                btnModifier.Text = "Modifier";
                btnModifier.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnAjouter.Enabled = true;
                btnSupprimer.Enabled = true;
                btnRechercher.Enabled = true;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
