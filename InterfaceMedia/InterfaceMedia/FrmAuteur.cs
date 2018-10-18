using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibMedia;
using MetroFramework.Forms;

namespace InterfaceMedia
{
    public partial class FrmAuteur : MetroForm
    {
        Thread th;
        private Crud_Auteur wpaysAuteur;
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
                btnRechercher.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                txtNom.Enabled = true;
                txtPrenom.Enabled = true;
                txtPseudo.Enabled = true;
                txtBio.Enabled = true;
                dtDateNaiss.Enabled = true;
                rdoVivant.Enabled = true;
                rdoDecede.Enabled = true;
                cmbPays.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                txtPrenom.BackColor = Color.White;
                txtPseudo.BackColor = Color.White;
                txtBio.BackColor = Color.White;
                dtDateNaiss.BackColor = Color.White;
                rdoVivant.BackColor = Color.White;
                rdoDecede.BackColor = Color.White;
                cmbPays.BackColor = Color.White;

            }

            else if (btnAjouter.Text == "Valider")
            {
                btnAjouter.Text = "Ajouter";
                btnAjouter.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnModifier.Enabled = true;
                btnRechercher.Enabled = true;

                //Les textbox sont inacessibles.
                txtNom.Enabled = false;
                txtPrenom.Enabled = false;
                txtPseudo.Enabled = false;
                txtBio.Enabled = false;
                dtDateNaiss.Enabled = false;
                rdoVivant.Enabled = false;
                rdoDecede.Enabled = false;
                cmbPays.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;
                txtPrenom.BackColor = Color.Silver;
                txtPseudo.BackColor = Color.Silver;
                txtBio.BackColor = Color.Silver;
                dtDateNaiss.BackColor = Color.Silver;
                rdoVivant.BackColor = Color.Silver;
                rdoDecede.BackColor = Color.Silver;
                cmbPays.BackColor = Color.Silver;
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
                btnRechercher.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                txtNom.Enabled = true;
                txtPrenom.Enabled = true;
                txtPseudo.Enabled = true;
                txtBio.Enabled = true;
                dtDateNaiss.Enabled = true;
                rdoVivant.Enabled = true;
                rdoDecede.Enabled = true;
                cmbPays.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                txtPrenom.BackColor = Color.White;
                txtPseudo.BackColor = Color.White;
                txtBio.BackColor = Color.White;
                dtDateNaiss.BackColor = Color.White;
                rdoVivant.BackColor = Color.White;
                rdoDecede.BackColor = Color.White;
                cmbPays.BackColor = Color.White;
            }

            else if (btnModifier.Text == "Valider")
            {
                btnModifier.Text = "Modifier";
                btnModifier.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnAjouter.Enabled = true;
                btnRechercher.Enabled = true;

                //Les textbox sont inacessibles.
                txtNom.Enabled = false;
                txtPrenom.Enabled = false;
                txtPseudo.Enabled = false;
                txtBio.Enabled = false;
                dtDateNaiss.Enabled = false;
                rdoVivant.Enabled = false;
                rdoDecede.Enabled = false;
                cmbPays.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;
                txtPrenom.BackColor = Color.Silver;
                txtPseudo.BackColor = Color.Silver;
                txtBio.BackColor = Color.Silver;
                dtDateNaiss.BackColor = Color.Silver;
                rdoVivant.BackColor = Color.Silver;
                rdoDecede.BackColor = Color.Silver;
                cmbPays.BackColor = Color.Silver;
            }


        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (btnRechercher.Text == "Rechercher")
            {
                btnRechercher.BackColor = Color.Green;
                btnRechercher.Text = "Valider";

                //le bouton annuler apparait
                btnAnnuler.Visible = true;

                //Les ou le textbox.s a remplir pour la recherche se déverouille
                txtCode.Enabled = true;
                txtNom.Enabled = true;
                txtPseudo.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtCode.BackColor = Color.White;
                txtNom.BackColor = Color.White;
                txtPseudo.BackColor = Color.White;

                //Desactive tous les autres boutons
                btnAjouter.Enabled = false;
                btnModifier.Enabled = false;
            }

            else if (btnRechercher.Text == "Valider")
            {
                btnRechercher.Text = "Rechercher";
                btnRechercher.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnAjouter.Enabled = true;
                btnModifier.Enabled = true;

                //Les textbox sont inacessibles.
                txtCode.Enabled = false;
                txtNom.Enabled = false;
                txtPseudo.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;

            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //les boutons sont remis par defaut
            btnAjouter.BackColor = Color.SteelBlue;
            btnModifier.BackColor = Color.SteelBlue;
            btnRechercher.BackColor = Color.SteelBlue;

            btnAjouter.Enabled = true;
            btnModifier.Enabled = true;
            btnRechercher.Enabled = true;

            btnAjouter.Text = "Ajouter";
            btnModifier.Text = "Modifier";
            btnRechercher.Text = "Rechercher";

            //Les textbox sont inacessibles.
            txtCode.Enabled = false;
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            txtPseudo.Enabled = false;
            txtBio.Enabled = false;
            dtDateNaiss.Enabled = false;
            rdoVivant.Enabled = false;
            rdoDecede.Enabled = false;
            cmbPays.Enabled = false;

            //Le background color des textbox change de couleur pour indiquer qu'elles sont vérouillé
            txtCode.BackColor = Color.Silver;
            txtNom.BackColor = Color.Silver;
            txtPrenom.BackColor = Color.Silver;
            txtPseudo.BackColor = Color.Silver;
            txtBio.BackColor = Color.Silver;
            dtDateNaiss.BackColor = Color.Silver;
            rdoVivant.BackColor = Color.Silver;
            rdoDecede.BackColor = Color.Silver;
            cmbPays.BackColor = Color.Silver;

            //le bouton annuler disparait
            btnAnnuler.Visible = false;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformAccueil);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openformAccueil()
        {
            Application.Run(new FrmCouverture());
        }

        private void rdoDecede_CheckedChanged(object sender, EventArgs e)
        {
            if (dtStatut.Visible == false)
            {
                //Affiche et deverouille le dateTime de décés.
                dtStatut.Visible = true;
                dtStatut.Enabled = true;
            }
            
        }

        private void rdoVivant_CheckedChanged(object sender, EventArgs e)
        {
            if (dtStatut.Visible == true)
            {
                //rend invisible et verouille le dateTime de décés
                dtStatut.Visible = false;
                dtStatut.Enabled = false;
            }
        }

        private void cmbPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            wpaysAuteur.paysAuteur(); 
        }
    }
}
