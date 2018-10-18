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
    public partial class FrmAuteur : MetroForm
    {
        public FrmAuteur()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text == "Ajouter")
            {
                btnAjouter.BackColor = Color.Green;
                btnAjouter.Text = "Valider";

                //le bouton annuler apparait
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnRechercher.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                txtNom.Enabled = true;
                txtPrenom.Enabled = true;
                txtPseudo.Enabled = true;
                txtBio.Enabled = true;
                dtDateNaiss.Enabled = true;
                rdoVivant.Enabled = true;
                rdoDecede.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                txtPrenom.BackColor = Color.White;
                txtPseudo.BackColor = Color.White;
                txtBio.BackColor = Color.White;
                dtDateNaiss.BackColor = Color.White;
                rdoVivant.BackColor = Color.White;
                rdoDecede.BackColor = Color.White;

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

                //Les textbox sont inacessibles.
                txtNom.Enabled = false;
                txtPrenom.Enabled = false;
                txtPseudo.Enabled = false;
                txtBio.Enabled = false;
                dtDateNaiss.Enabled = false;
                rdoVivant.Enabled = false;
                rdoDecede.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;
                txtPrenom.BackColor = Color.Silver;
                txtPseudo.BackColor = Color.Silver;
                txtBio.BackColor = Color.Silver;
                dtDateNaiss.BackColor = Color.Silver;
                rdoVivant.BackColor = Color.Silver;
                rdoDecede.BackColor = Color.Silver;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnModifier.Text == "Modifier")
            {
                btnModifier.BackColor = Color.Green;
                btnModifier.Text = "Valider";

                //le bouton annuler apparait
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnAjouter.Enabled = false;
                btnSupprimer.Enabled = false;
                btnRechercher.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                txtNom.Enabled = true;
                txtPrenom.Enabled = true;
                txtPseudo.Enabled = true;
                txtBio.Enabled = true;
                dtDateNaiss.Enabled = true;
                rdoVivant.Enabled = true;
                rdoDecede.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                txtPrenom.BackColor = Color.White;
                txtPseudo.BackColor = Color.White;
                txtBio.BackColor = Color.White;
                dtDateNaiss.BackColor = Color.White;
                rdoVivant.BackColor = Color.White;
                rdoDecede.BackColor = Color.White;
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

                //Les textbox sont inacessibles.
                txtNom.Enabled = false;
                txtPrenom.Enabled = false;
                txtPseudo.Enabled = false;
                txtBio.Enabled = false;
                dtDateNaiss.Enabled = false;
                rdoVivant.Enabled = false;
                rdoDecede.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;
                txtPrenom.BackColor = Color.Silver;
                txtPseudo.BackColor = Color.Silver;
                txtBio.BackColor = Color.Silver;
                dtDateNaiss.BackColor = Color.Silver;
                rdoVivant.BackColor = Color.Silver;
                rdoDecede.BackColor = Color.Silver;
            }
        }
    }
}
