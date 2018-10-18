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
    public partial class Frmlivre : MetroForm
    {
        public Frmlivre()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            if (btnAjouter.Text.Equals("Ajouter"))
            {
                // modification de couleur du bouton ajouter + le passe en "valider" et afficher annuler
                btnAjouter.BackColor = Color.Green;
                btnAjouter.Text = "Valider";
                btnAnnuler.Visible = true;

                //desactiver les autres boutons 
                btnRechercher.Enabled = false;
                btnSupprimer.Enabled = false;
                btnModifier.Enabled = false;


                // textbox activer pour l'insertion

                txtbxtitre.Enabled = true;
                txtbxisbn.Enabled = true;
                txtbxcouleur.Enabled = true;
                txtbxtome.Enabled = true;
                cmbbxannee.Enabled = true;
                txtbxformat.Enabled = true;
                txtbxpage.Enabled = true;
                txtbxcommentaire.Enabled = true;
                txtbxediteur.Enabled = true;
                txtbxserie.Enabled = true;
                txtbxauteur.Enabled = true;
                txtbxreferencerexemp.Enabled = true;
                rdbtnA.Enabled = true;
                rdbtnb.Enabled = true;
                rdbtnta.Enabled = true;
                rdbtntb.Enabled = true;

                // modification des couleur 
                txtbxcode.BackColor = Color.White;
                txtbxtitre.BackColor = Color.White;
                txtbxisbn.BackColor = Color.White;
                txtbxcouleur.BackColor = Color.White;
                txtbxtome.BackColor = Color.White;
                cmbbxannee.BackColor = Color.White;
                txtbxformat.BackColor = Color.White;
                txtbxpage.BackColor = Color.White;
                txtbxcommentaire.BackColor = Color.White;
                txtbxediteur.BackColor = Color.White;
                txtbxserie.BackColor = Color.White;
                txtbxauteur.BackColor = Color.White;
                txtbxreferencerexemp.BackColor = Color.White;


            }
            else if (btnAjouter.Text.Equals("Valider"))
            {
                // repasse le bouton ajouter en "ajouter" + modification couleur + desactive le bouton annuler
                btnAjouter.Text = "Ajouter";
                btnAjouter.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //reactivation des autres boutons 
                btnRechercher.Enabled = true;
                btnSupprimer.Enabled = true;
                btnModifier.Enabled = true;


                // textbox desactiver pour l'insertion
                txtbxtitre.Enabled = false;
                txtbxisbn.Enabled = false;
                txtbxcouleur.Enabled = false;
                txtbxtome.Enabled = false;
                cmbbxannee.Enabled = false;
                txtbxformat.Enabled = false;
                txtbxpage.Enabled = false;
                txtbxcommentaire.Enabled = false;
                txtbxediteur.Enabled = false;
                txtbxserie.Enabled = false;
                txtbxauteur.Enabled = false;
                txtbxreferencerexemp.Enabled = false;
                rdbtnA.Enabled = false;
                rdbtnb.Enabled = false;
                rdbtnta.Enabled = false;
                rdbtntb.Enabled = false;

                // modification des couleur 
                txtbxcode.BackColor = Color.Silver;
                txtbxtitre.BackColor = Color.Silver;
                txtbxisbn.BackColor = Color.Silver;
                txtbxcouleur.BackColor = Color.Silver;
                txtbxtome.BackColor = Color.Silver;
                cmbbxannee.BackColor = Color.Silver;
                txtbxformat.BackColor = Color.Silver;
                txtbxpage.BackColor = Color.Silver;
                txtbxcommentaire.BackColor = Color.Silver;
                txtbxediteur.BackColor = Color.Silver;
                txtbxserie.BackColor = Color.Silver;
                txtbxauteur.BackColor = Color.Silver;
                txtbxreferencerexemp.BackColor = Color.Silver;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // remise par defaut
            btnAjouter.Enabled = true;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
            btnRechercher.Enabled = true;

            btnAjouter.Text = "Ajouter";
            btnModifier.Text = "Modifier";
            btnSupprimer.Text = "Supprimer";
            btnRechercher.Text = "Rechercher";

            // enleve le bouton annuler
            btnAnnuler.Visible = false;

            // remet la couleur de bleu
            btnAjouter.BackColor = Color.SteelBlue;
            btnModifier.BackColor = Color.SteelBlue;
            btnSupprimer.BackColor = Color.SteelBlue;
            btnRechercher.BackColor = Color.SteelBlue;

            // textbox activer pour l'insertion
            txtbxcode.Enabled = false;
            txtbxtitre.Enabled = false;
            txtbxisbn.Enabled = false;
            txtbxcouleur.Enabled = false;
            txtbxtome.Enabled = false;
            cmbbxannee.Enabled = false;
            txtbxformat.Enabled = false;
            txtbxpage.Enabled = false;
            txtbxcommentaire.Enabled = false;
            txtbxediteur.Enabled = false;
            txtbxserie.Enabled = false;
            txtbxauteur.Enabled = false;
            txtbxreferencerexemp.Enabled = false;
            rdbtnA.Enabled = false;
            rdbtnb.Enabled = false;
            rdbtnta.Enabled = false;
            rdbtntb.Enabled = false;
            // modification des couleur 
            txtbxcode.BackColor = Color.Silver;
            txtbxtitre.BackColor = Color.Silver;
            txtbxisbn.BackColor = Color.Silver;
            txtbxcouleur.BackColor = Color.Silver;
            txtbxtome.BackColor = Color.Silver;
            cmbbxannee.BackColor = Color.Silver;
            txtbxformat.BackColor = Color.Silver;
            txtbxpage.BackColor = Color.Silver;
            txtbxcommentaire.BackColor = Color.Silver;
            txtbxediteur.BackColor = Color.Silver;
            txtbxserie.BackColor = Color.Silver;
            txtbxauteur.BackColor = Color.Silver;
            txtbxreferencerexemp.BackColor = Color.Silver;



        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (btnRechercher.Text.Equals("Rechercher"))
            {
                btnRechercher.BackColor = Color.Green;
                btnRechercher.Text = "Valider";
                btnAnnuler.Visible = true;


                //desactive les autres boutons

                btnSupprimer.Enabled = false;
                btnModifier.Enabled = false;
                btnAjouter.Enabled = false;


                txtbxtitre.Enabled = true;
                cmbbxannee.Enabled = true;

                txtbxtitre.BackColor = Color.White;
                cmbbxannee.BackColor = Color.White;
            }
            else if (btnRechercher.Text.Equals("Valider"))
            {

                btnRechercher.BackColor = Color.SteelBlue;
                btnRechercher.Text = "Rechercher";
                btnAnnuler.Visible = false;

                //active les autres boutons

                btnSupprimer.Enabled = true;
                btnModifier.Enabled = true;
                btnAjouter.Enabled = true;

                // desactive les boutons    
                txtbxtitre.Enabled = false;
                cmbbxannee.Enabled = false;

                // change la couleur 
                txtbxtitre.BackColor = Color.Silver;
                cmbbxannee.BackColor = Color.Silver;

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            if (btnModifier.Text.Equals("Modifier"))
            {
                // modification de couleur du bouton ajouter + le passe en "valider" et afficher annuler
                btnModifier.BackColor = Color.Green;
                btnModifier.Text = "Valider";
                btnAnnuler.Visible = true;

                //desactiver les autres boutons 
                btnRechercher.Enabled = false;
                btnSupprimer.Enabled = false;
                btnAjouter.Enabled = false;


                // textbox activer pour l'insertion

                txtbxtitre.Enabled = true;
                txtbxisbn.Enabled = true;
                txtbxcouleur.Enabled = true;
                txtbxtome.Enabled = true;
                cmbbxannee.Enabled = true;
                txtbxformat.Enabled = true;
                txtbxpage.Enabled = true;
                txtbxcommentaire.Enabled = true;
                txtbxediteur.Enabled = true;
                txtbxserie.Enabled = true;
                txtbxauteur.Enabled = true;
                txtbxreferencerexemp.Enabled = true;
                rdbtnA.Enabled = true;
                rdbtnb.Enabled = true;
                rdbtnta.Enabled = true;
                rdbtntb.Enabled = true;

                // modification des couleur 

                txtbxtitre.BackColor = Color.White;
                txtbxisbn.BackColor = Color.White;
                txtbxcouleur.BackColor = Color.White;
                txtbxtome.BackColor = Color.White;
                cmbbxannee.BackColor = Color.White;
                txtbxformat.BackColor = Color.White;
                txtbxpage.BackColor = Color.White;
                txtbxcommentaire.BackColor = Color.White;
                txtbxediteur.BackColor = Color.White;
                txtbxserie.BackColor = Color.White;
                txtbxauteur.BackColor = Color.White;
                txtbxreferencerexemp.BackColor = Color.White;
            }
            else if (btnModifier.Text.Equals("Valider"))
            {
                // repasse le bouton ajouter en "ajouter" + modification couleur + desactive le bouton annuler
                btnModifier.Text = "Modifier";
                btnModifier.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //reactivation des autres boutons 
                btnRechercher.Enabled = true;
                btnSupprimer.Enabled = true;
                btnModifier.Enabled = true;


                // textbox desactiver pour l'insertion
                txtbxtitre.Enabled = false;
                txtbxisbn.Enabled = false;
                txtbxcouleur.Enabled = false;
                txtbxtome.Enabled = false;
                cmbbxannee.Enabled = false;
                txtbxformat.Enabled = false;
                txtbxpage.Enabled = false;
                txtbxcommentaire.Enabled = false;
                txtbxediteur.Enabled = false;
                txtbxserie.Enabled = false;
                txtbxauteur.Enabled = false;
                txtbxreferencerexemp.Enabled = false;
                rdbtnA.Enabled = false;
                rdbtnb.Enabled = false;
                rdbtnta.Enabled = false;
                rdbtntb.Enabled = false;

                // modification des couleur 
                txtbxcode.BackColor = Color.Silver;
                txtbxtitre.BackColor = Color.Silver;
                txtbxisbn.BackColor = Color.Silver;
                txtbxcouleur.BackColor = Color.Silver;
                txtbxtome.BackColor = Color.Silver;
                cmbbxannee.BackColor = Color.Silver;
                txtbxformat.BackColor = Color.Silver;
                txtbxpage.BackColor = Color.Silver;
                txtbxcommentaire.BackColor = Color.Silver;
                txtbxediteur.BackColor = Color.Silver;
                txtbxserie.BackColor = Color.Silver;
                txtbxauteur.BackColor = Color.Silver;
                txtbxreferencerexemp.BackColor = Color.Silver;

            }
        }
    }
}