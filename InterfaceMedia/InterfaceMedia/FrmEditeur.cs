﻿using System;
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

                //le bouton annuler apparait
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnRechercher.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                txtNom.Enabled = true;
                DateTimeCreation.Enabled = true;
                txtMail.Enabled = true;
                txtCodePostal.Enabled = true;
                txtAdr.Enabled = true;
                txtTel.Enabled = true;
                txtFax.Enabled = true;
                txtVille.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                DateTimeCreation.BackColor = Color.White;
                txtMail.BackColor = Color.White;
                txtCodePostal.BackColor = Color.White;
                txtAdr.BackColor = Color.White;
                txtTel.BackColor = Color.White;
                txtFax.BackColor = Color.White;
                txtVille.BackColor = Color.White;

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
                DateTimeCreation.Enabled = false;
                txtMail.Enabled = false;
                txtCodePostal.Enabled = false;
                txtAdr.Enabled = false;
                txtTel.Enabled = false;
                txtFax.Enabled = false;
                txtVille.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;
                DateTimeCreation.BackColor = Color.Silver;
                txtMail.BackColor = Color.Silver;
                txtCodePostal.BackColor = Color.Silver;
                txtAdr.BackColor = Color.Silver;
                txtTel.BackColor = Color.Silver;
                txtFax.BackColor = Color.Silver;
                txtVille.BackColor = Color.Silver;

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
                DateTimeCreation.Enabled = true;
                txtMail.Enabled = true;
                txtCodePostal.Enabled = true;
                txtAdr.Enabled = true;
                txtTel.Enabled = true;
                txtFax.Enabled = true;
                txtVille.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                DateTimeCreation.BackColor = Color.White;
                txtMail.BackColor = Color.White;
                txtCodePostal.BackColor = Color.White;
                txtAdr.BackColor = Color.White;
                txtTel.BackColor = Color.White;
                txtFax.BackColor = Color.White;
                txtVille.BackColor = Color.White;
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
                DateTimeCreation.Enabled = false;
                txtMail.Enabled = false;
                txtCodePostal.Enabled = false;
                txtAdr.Enabled = false;
                txtTel.Enabled = false;
                txtFax.Enabled = false;
                txtVille.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;
                DateTimeCreation.BackColor = Color.Silver;
                txtMail.BackColor = Color.Silver;
                txtCodePostal.BackColor = Color.Silver;
                txtAdr.BackColor = Color.Silver;
                txtTel.BackColor = Color.Silver;
                txtFax.BackColor = Color.Silver;
                txtVille.BackColor = Color.Silver;
            }
        }



        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (btnSupprimer.Text == "Supprimer")
            {
                btnSupprimer.BackColor = Color.Green;
                btnSupprimer.Text = "Valider";

                //le bouton annuler apparait
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnAjouter.Enabled = false;
                btnModifier.Enabled = false;
                btnRechercher.Enabled = false;
            }

            else if (btnSupprimer.Text == "Valider")
            {
                btnSupprimer.Text = "Supprimer";
                btnSupprimer.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnAjouter.Enabled = true;
                btnModifier.Enabled = true;
                btnRechercher.Enabled = true;
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
                txtNom.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;

                //Desactive tous les autres boutons
                btnAjouter.Enabled = false;
                btnSupprimer.Enabled = false;
                btnModifier.Enabled = false;
            }

            else if (btnRechercher.Text == "Valider")
            {
                btnRechercher.Text = "Rechercher";
                btnRechercher.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnAjouter.Enabled = true;
                btnSupprimer.Enabled = true;
                btnModifier.Enabled = true;

                //Les textbox sont inacessibles.
                txtNom.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;

            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //les boutons sont remis par defaut
            btnAjouter.BackColor = Color.SteelBlue;
            btnModifier.BackColor = Color.SteelBlue;
            btnSupprimer.BackColor = Color.SteelBlue;
            btnRechercher.BackColor = Color.SteelBlue;

            btnAjouter.Enabled = true;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
            btnRechercher.Enabled = true;

            btnAjouter.Text = "Ajouter";
            btnModifier.Text = "Modifier";
            btnSupprimer.Text = "Supprimer";
            btnRechercher.Text = "Rechercher";

            //Les textbox sont inacessibles.
            txtNom.Enabled = false;
            DateTimeCreation.Enabled = false;
            txtMail.Enabled = false;
            txtCodePostal.Enabled = false;
            txtAdr.Enabled = false;
            txtTel.Enabled = false;
            txtFax.Enabled = false;
            txtVille.Enabled = false;

            //Le background color des textbox change de couleur pour indiquer qu'elles sont vérouillé
            txtNom.BackColor = Color.Silver;
            DateTimeCreation.BackColor = Color.Silver;
            txtMail.BackColor = Color.Silver;
            txtCodePostal.BackColor = Color.Silver;
            txtAdr.BackColor = Color.Silver;
            txtTel.BackColor = Color.Silver;
            txtFax.BackColor = Color.Silver;
            txtVille.BackColor = Color.Silver;

            //le bouton annuler disparait
            btnAnnuler.Visible = false;



        }

        private void picHome_Click(object sender, EventArgs e)
        {
            FrmAccueilTest wAccueilTest = new FrmAccueilTest();
            wAccueilTest.ShowDialog();
            Form.ActiveForm.Close();
        }
    }
}
