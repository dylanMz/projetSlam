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
using System.Threading;
using LibMedia;


namespace InterfaceMedia
{
    public partial class Frmlivre : MetroForm
    {
        private ConnexionBase connexion;
        private Crud_livre unlivre;
        private CRUD_Exemplaire unexemplaire;
        public string format;
        private List<String> rempauteur;
        private List<String> remediteur;
        private List<String> remserie;
        private String leNiveau;
        Thread th;
        private String resultat;
        private bool pasvalide;
        private bool erreurtype;

        public Frmlivre(String leNiveau)
        {
            InitializeComponent();
            connexion = new ConnexionBase();
            unlivre = new Crud_livre();
            unexemplaire = new CRUD_Exemplaire();
            dtgrvLivre.DataSource = unlivre.afficherlivre();
            // remplissage des combo box
            remp_cmbx();
            remp_cmbbx_nomauteur();
            remp_cmbbx_nomediteur();
            remp_cmbbx_nomserie();


            this.leNiveau = leNiveau;
            lblRang.Text = this.leNiveau;
      
        }







        #region combo box
        //remplissage des 2 combobox auteur 
        public void remp_cmbbx_nomauteur()
        {
            rempauteur = unlivre.affiche_nomauteur();

            int i;
            for (i = 0; i != rempauteur.LongCount(); i++)
            {
                if (!rempauteur[i].Equals(""))
                {
                    cmbbxauteur.Items.Add(rempauteur[i]);
                    cmbbauteurdessin.Items.Add(rempauteur[i]);
                }
            }
        }

        public void remp_cmbbx_nomediteur()
        {
            remediteur = unlivre.affiche_nomediteur();

            int i;
            for (i = 0; i != remediteur.LongCount(); i++)
            {
                cmbbxediteur.Items.Add(remediteur[i]);

            }

        }

        public void remp_cmbbx_nomserie()
        {
            remserie = unlivre.affiche_nomserie();

            int i;
            for (i = 0; i != remserie.LongCount(); i++)
            {
                cmbbxserie.Items.Add(remserie[i]);

            }

        }

        public void reset()
        {

            txtbxcode.Text = "";
            txtbxtitre.Text = "";
            txtbxisbn.Text = "";
            txtbxcouleur.Text = "";
            txtbxtome.Text = "";
            cmbbxannee.SelectedItem = null;
            cmbbxmois.SelectedItem = null;
            txtbxformat.Text = "";
            txtbxpage.Text = "";
            txtbxcommentaire.Text = "";

            txtbxreferencerexemp.Text = "";

            cmbbxauteur.SelectedItem = null;
            cmbbauteurdessin.SelectedItem = null;
            cmbbxediteur.SelectedItem = null;
            cmbbxserie.SelectedItem = null;
            codelivreexmp.Text = "";
            txtbxmotif.Text = "";

            txtbxcommentaire.Text = "";
        }
        public void remp_cmbx()
        {
            // remplissage combo box annee
            for (int i = 1940; i <= DateTime.Now.Year; i++)
            {
                cmbbxannee.Items.Add(i);
            }
            // remplissage combo box mois
            for (int a = 01; a <= 12; a++)
            {
                if (a < 10)
                {
                    cmbbxmois.Items.Add("0" + a);
                }
                else
                {
                    cmbbxmois.Items.Add(a);
                }
            }

        }
        #endregion


        #region Bouton
        // bouton ajouter
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
                if (btnexemp.Text.Equals("Livre"))
                {

                    // textbox activer pour l'insertion

                    txtbxtitre.Enabled = true;
                    txtbxisbn.Enabled = true;
                    txtbxcouleur.Enabled = true;
                    txtbxtome.Enabled = true;
                    cmbbxannee.Enabled = true;
                    cmbbxmois.Enabled = true;
                    txtbxformat.Enabled = true;
                    txtbxpage.Enabled = true;
                    txtbxcommentaire.Enabled = true;
                    

                    cmbbxauteur.Enabled = true;
                    cmbbauteurdessin.Enabled = true;
                    cmbbxediteur.Enabled = true;
                    cmbbxserie.Enabled = true;

                    // modification des couleur 

                    txtbxtitre.BackColor = Color.White;
                    txtbxisbn.BackColor = Color.White;
                    txtbxcouleur.BackColor = Color.White;
                    txtbxtome.BackColor = Color.White;
                    cmbbxannee.BackColor = Color.White;
                    cmbbxmois.BackColor = Color.White;
                    txtbxformat.BackColor = Color.White;
                    txtbxpage.BackColor = Color.White;
                    txtbxcommentaire.BackColor = Color.White;
                   
                    cmbbxauteur.BackColor = Color.White;
                    cmbbauteurdessin.BackColor = Color.White;
                    cmbbxediteur.BackColor = Color.White;
                    cmbbxserie.BackColor = Color.White;
                }
                if (btnexemp.Text.Equals("exemplaire"))
                {


                    txtbxreferencerexemp.Enabled = true;
                    codelivreexmp.Enabled = true;
                    rdbtnA.Enabled = true;
                    rdbtnb.Enabled = true;
                    rdbtnta.Enabled = true;
                    rdbtntb.Enabled = true;


                    // modification des couleur 

                    txtbxreferencerexemp.BackColor = Color.White;
                    codelivreexmp.BackColor = Color.White;
                }

            }
            else if (btnAjouter.Text.Equals("Valider"))
            {

                if (btnexemp.Text.Equals("exemplaire"))
                {

                    if (rdbtnA.Checked == true)
                    {
                        resultat = rdbtnA.Text;
                    }
                    else if (rdbtnb.Checked == true)
                    {
                        resultat = rdbtnb.Text;
                        
                    }
                    else if (rdbtnta.Checked == true)
                    {
                        resultat = rdbtnta.Text;
                        
                    }
                    else if (rdbtntb.Checked == true)
                    {
                        resultat = rdbtntb.Text;
                    }
                    try
                    {
                        Convert.ToInt32(codelivreexmp.Text);
                    }
                    catch
                    {

                        btDialog("Code est un entier", true);
                        erreurtype = false;
                    }


                    if (erreurtype == true)
                    {
                        Exemplaire lexemplaire = new Exemplaire(txtbxreferencerexemp.Text, resultat, Int32.Parse(codelivreexmp.Text));
                        unexemplaire.ajout_exemplaire(lexemplaire);
                        reset();
                    }
                }
                else if (btnexemp.Text.Equals("Livre"))
                {
                    string parutiontotal;


                    parutiontotal = cmbbxmois.Text + "/" + cmbbxannee.Text;
                    if (!txtbxtitre.Text.Equals("") && !txtbxisbn.Equals("") && !txtbxcouleur.Text.Equals("") && !txtbxtome.Text.Equals("") && !parutiontotal.Equals("") && !txtbxformat.Text.Equals("") && !txtbxpage.Text.Equals("") && !txtbxcommentaire.Text.Equals("") && !cmbbxediteur.Text.Equals("") && !cmbbxserie.Text.Equals(""))
                    {
                        erreurtype = true;
                        try
                        {
                            Convert.ToInt32(txtbxtome.Text);
                        }
                        catch
                        {
                            btDialog("Tome est un entier", true);
                            erreurtype = false;
                        }
                        try
                        {
                            Convert.ToInt32(txtbxpage.Text);
                        }
                        catch { 
                       
                            btDialog("Page est un entier", true);
                            erreurtype = false;
                        }

                        if (erreurtype == true)
                        {
                            Livre lelivre = new Livre(txtbxtitre.Text, txtbxisbn.Text, Int32.Parse(txtbxtome.Text), parutiontotal, Int32.Parse(txtbxpage.Text), txtbxcouleur.Text, txtbxcommentaire.Text, txtbxformat.Text);
                            unlivre.ajout_livre(lelivre, cmbbxediteur.Text, cmbbxserie.Text);
                            
                        }
                        if (cmbbxauteur.Text != null && erreurtype == true)
                        {
                            unlivre.insert_participer(cmbbxauteur.Text, 0);
                        }
                        if (cmbbauteurdessin.Text != null && erreurtype == true)
                        {
                            unlivre.insert_participer(cmbbauteurdessin.Text, 1);
                           
                        }
                        reset();
                    }
                    else
                    {
                        btDialog("Tout les champs doivent etre remplis", true);
                    }
                    
                }
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
                cmbbxmois.Enabled = false;
                txtbxformat.Enabled = false;
                txtbxpage.Enabled = false;
                txtbxcommentaire.Enabled = false;
                txtbxcode.Enabled = false; 
                    
                txtbxreferencerexemp.Enabled = false;
                rdbtnA.Enabled = false;
                rdbtnb.Enabled = false;
                rdbtnta.Enabled = false;
                rdbtntb.Enabled = false;
                codelivreexmp.Enabled = false;
                cmbbxauteur.Enabled = false;
                cmbbauteurdessin.Enabled = false;
                cmbbxediteur.Enabled = false;
                cmbbxserie.Enabled = false;

                // modification des couleur 
                txtbxcode.BackColor = Color.Silver;
                txtbxtitre.BackColor = Color.Silver;
                txtbxisbn.BackColor = Color.Silver;
                txtbxcouleur.BackColor = Color.Silver;
                txtbxtome.BackColor = Color.Silver;
                cmbbxannee.BackColor = Color.Silver;
                cmbbxmois.BackColor = Color.Silver;
                txtbxformat.BackColor = Color.Silver;
                txtbxpage.BackColor = Color.Silver;
                txtbxcommentaire.BackColor = Color.Silver;
              
                txtbxreferencerexemp.BackColor = Color.Silver;
                codelivreexmp.BackColor = Color.Silver;
                cmbbxauteur.BackColor = Color.Silver;
                cmbbauteurdessin.BackColor = Color.Silver;
                cmbbxediteur.BackColor = Color.Silver;
                cmbbxserie.BackColor = Color.Silver;


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
            cmbbxmois.Enabled = false;
            txtbxformat.Enabled = false;
            txtbxpage.Enabled = false;
            txtbxcommentaire.Enabled = false;
            txtbxmotifexemp.Enabled = false;

   
            txtbxreferencerexemp.Enabled = false;
            rdbtnA.Enabled = false;
            rdbtnb.Enabled = false;
            rdbtnta.Enabled = false;
            rdbtntb.Enabled = false;
            cmbbxauteur.Enabled = false;
            cmbbauteurdessin.Enabled = false;
            cmbbxediteur.Enabled = false;
            cmbbxserie.Enabled = false;
            codelivreexmp.Enabled = false;
            txtbxmotif.Visible = false;
            lblmotif.Visible = false;
            lblcommentaire.Visible = true;
            txtbxcommentaire.Visible = true;
            // modification des couleur 
            txtbxcode.BackColor = Color.Silver;
            txtbxtitre.BackColor = Color.Silver;
            txtbxisbn.BackColor = Color.Silver;
            txtbxcouleur.BackColor = Color.Silver;
            txtbxtome.BackColor = Color.Silver;
            cmbbxannee.BackColor = Color.Silver;
            cmbbxmois.BackColor = Color.Silver;
            txtbxformat.BackColor = Color.Silver;
            txtbxpage.BackColor = Color.Silver;
            txtbxcommentaire.BackColor = Color.Silver;
            txtbxmotifexemp.BackColor = Color.Silver;
            txtbxreferencerexemp.BackColor = Color.Silver;
            cmbbxauteur.BackColor = Color.Silver;
            cmbbauteurdessin.BackColor = Color.Silver;
            cmbbxediteur.BackColor = Color.Silver;
            cmbbxserie.BackColor = Color.Silver;
            codelivreexmp.BackColor = Color.Silver;

            rdbtnA.Checked = false;
            rdbtnb.Checked = false;
            rdbtnta.Checked = false;
            rdbtntb.Checked = false;
            reset();

            dtgrvLivre.DataSource = unlivre.afficherlivre();

        }
        //bouton rechercher
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
                if (btnexemp.Text.Equals("Livre"))
                {

                    txtbxtitre.Enabled = true;
                    cmbbxannee.Enabled = true;
                    cmbbxmois.Enabled = true;

                    txtbxtitre.BackColor = Color.White;
                    cmbbxannee.BackColor = Color.White;
                    cmbbxmois.BackColor = Color.White;
                }
                else if (btnexemp.Text.Equals("exemplaire"))
                {
                    codelivreexmp.Enabled = true;
                    txtbxreferencerexemp.Enabled = true;
                    rdbtnA.Enabled = true;
                    rdbtnb.Enabled = true;
                    rdbtnta.Enabled = true;
                    rdbtntb.Enabled = true;

                    codelivreexmp.BackColor = Color.White;
                    txtbxreferencerexemp.BackColor = Color.White;
                }
            }
            else if (btnRechercher.Text.Equals("Valider"))
            {
                if (btnexemp.Text.Equals("Livre"))
                {
                    string parutiontotal;
                    //affichage de la recherche livre  dans le datagridview

                    if ((cmbbxmois.Text == "") && (cmbbxannee.Text == ""))
                    {
                        parutiontotal = "";

                        Livre lelivre = new Livre(txtbxtitre.Text, parutiontotal);
                        dtgrvLivre.DataSource = unlivre.recherche_livre(lelivre);

                    }
                    else
                    {

                        parutiontotal = cmbbxmois.Text + "/" + cmbbxannee.Text;
                        Livre lelivre = new Livre(txtbxtitre.Text, parutiontotal);
                        dtgrvLivre.DataSource = unlivre.recherche_livre(lelivre);

                    }
                }
                else if (btnexemp.Text.Equals("exemplaire"))
                {

                    format = "";
                    if (rdbtnA.Checked == true)
                    {
                        format = rdbtnA.Text;
                    }
                    else if (rdbtnb.Checked == true)
                    {
                        format = rdbtnb.Text;
                    }
                    else if (rdbtnta.Checked == true)
                    {
                        format = rdbtnta.Text;
                    }
                    else if (rdbtntb.Checked == true)
                    {
                        format = rdbtntb.Text;
                    }
                    //  || (!txtbxreferencerexemp.Text.Equals("   _") && !codelivreexmp.Equals("")) || (!format.Equals("") && !codelivreexmp.Equals(""))
                    pasvalide = false;
                    if (!txtbxreferencerexemp.Text.Equals("    _") && !format.Equals(""))
                    {
                       
                        pasvalide = true;
                    }
                    if (!txtbxreferencerexemp.Text.Equals("    _") && !codelivreexmp.Text.Equals(""))
                    {
                        pasvalide = true;
                    }

                    if (!format.Equals("") && !codelivreexmp.Text.Equals(""))
                    {
                        pasvalide = true;
                    }
                    if (pasvalide == false)
                    {
                        Exemplaire lexemplaire = new Exemplaire(txtbxreferencerexemp.Text, format, codelivreexmp.Text);
                        dtgrvLivre.DataSource = unexemplaire.recherche_exemplaire(lexemplaire);

                        rdbtnA.Checked = false;
                        rdbtnb.Checked = false;
                        rdbtnta.Checked = false;
                        rdbtntb.Checked = false;
                    }
                    if(pasvalide == true)
                    {
                        btDialog("vous ne pouvez faire qu'une recherche a la foie", true);
                        rdbtnA.Checked = false;
                        rdbtnb.Checked = false;
                        rdbtnta.Checked = false;
                        rdbtntb.Checked = false;
                    }

                }

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
                cmbbxmois.Enabled = false;
                txtbxreferencerexemp.Enabled = false;
                codelivreexmp.Enabled = false;
                rdbtnA.Enabled = false;
                rdbtnb.Enabled = false;
                rdbtnta.Enabled = false;
                rdbtntb.Enabled = false;
                // change la couleur 
                txtbxtitre.BackColor = Color.Silver;
                cmbbxannee.BackColor = Color.Silver;
                cmbbxmois.BackColor = Color.Silver;
                txtbxreferencerexemp.BackColor = Color.Silver;
                codelivreexmp.BackColor = Color.Silver;
            }

        }
        // BOUTON SUPPRIMER
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (btnSupprimer.Text.Equals("Supprimer"))
            {
                btnSupprimer.BackColor = Color.Green;
                btnSupprimer.Text = "Valider";
                btnAnnuler.Visible = true;

                btnRechercher.Enabled = false;
                btnModifier.Enabled = false;
                btnAjouter.Enabled = false;

                if (btnexemp.Text.Equals("Livre"))
                {
                    // textbox activer pour l'insertion

                    txtbxcode.Enabled = true;

                    txtbxmotif.Visible = true;
                    lblmotif.Visible = true;
                    lblcommentaire.Visible = false;
                    txtbxcommentaire.Visible = false;

                    // modification des couleur 

                    txtbxcode.BackColor = Color.White;





                }
                else if (btnexemp.Text.Equals("exemplaire"))
                {
                    // textbox activer pour l'insertion



                    txtbxreferencerexemp.Enabled = true;
                    txtbxmotifexemp.Enabled = true;


                    // modification des couleur 



                    txtbxmotifexemp.BackColor = Color.White;

                    txtbxreferencerexemp.BackColor = Color.White;
                }
            }
            else if (btnSupprimer.Text.Equals("Valider"))
            {
                if (btnexemp.Text.Equals("Livre"))
                {
                    erreurtype= true;
                    try
                    {
                        Convert.ToInt32(txtbxcode.Text);
                    }
                    catch
                    {
                        btDialog("ce n'est pas un entier", true);
                        erreurtype = false;
                    }

                    if (erreurtype == true) { 
                        Livre lelivre = new Livre(Int32.Parse(txtbxcode.Text));
                        unlivre.delet_participer(lelivre);
                        unlivre.Delete_livre(lelivre);


                        unlivre.delet_motif(txtbxmotif.Text, lelivre);
                        reset();

                    }
                }
                else if (btnexemp.Text.Equals("exemplaire"))
                {
                    Exemplaire lexemplaire = new Exemplaire(txtbxreferencerexemp.Text, resultat, codelivreexmp.Text);
                    unexemplaire.delete_exemplaire(lexemplaire);
                    unexemplaire.delete_motif(lexemplaire,txtbxmotifexemp.Text);
                    reset();
                }



                btnSupprimer.BackColor = Color.SteelBlue;
                btnSupprimer.Text = "Supprimer";
                btnAnnuler.Visible = false;

                //active les autres boutons

                btnRechercher.Enabled = true;
                btnModifier.Enabled = true;
                btnAjouter.Enabled = true;

                // desactive les boutons    
                txtbxcode.Enabled = false;
                txtbxreferencerexemp.Enabled = false;
                txtbxmotif.Visible = false;
                lblmotif.Visible = false;
                lblcommentaire.Visible = true;
                txtbxcommentaire.Visible = true;
                txtbxmotifexemp.Enabled = false;

                // change la couleur 
                txtbxcode.BackColor = Color.Silver;
                txtbxmotifexemp.BackColor = Color.Silver;
                txtbxreferencerexemp.BackColor = Color.Silver;

            }
      }

        //  BOUTON MODIFIER
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
                if (btnexemp.Text.Equals("Livre"))
                {
                    // textbox activer pour l'insertion

                    txtbxtitre.Enabled = true;
                    txtbxisbn.Enabled = true;
                    txtbxcouleur.Enabled = true;
                    txtbxtome.Enabled = true;
                    cmbbxannee.Enabled = true;
                    cmbbxmois.Enabled = true;
                    txtbxformat.Enabled = true;
                    txtbxpage.Enabled = true;
                    txtbxcommentaire.Enabled = true;
                  

                    cmbbxauteur.Enabled = true;
                    cmbbauteurdessin.Enabled = true;
                    cmbbxediteur.Enabled = true;
                    cmbbxserie.Enabled = true;


                    // modification des couleur 

                    txtbxtitre.BackColor = Color.White;
                    txtbxisbn.BackColor = Color.White;
                    txtbxcouleur.BackColor = Color.White;
                    txtbxtome.BackColor = Color.White;
                    cmbbxannee.BackColor = Color.White;
                    cmbbxmois.BackColor = Color.White;
                    txtbxformat.BackColor = Color.White;
                    txtbxpage.BackColor = Color.White;
                    txtbxcommentaire.BackColor = Color.White;
                

                    cmbbxauteur.BackColor = Color.White;
                    cmbbauteurdessin.BackColor = Color.White;
                    cmbbxediteur.BackColor = Color.White;
                    cmbbxserie.BackColor = Color.White;



                }
                else if (btnexemp.Text.Equals("exemplaire"))
                {
                    // textbox activer pour l'insertion
                    codelivreexmp.Enabled = true;
                    txtbxreferencerexemp.Enabled = true;
                    rdbtnA.Enabled = true;
                    rdbtnb.Enabled = true;
                    rdbtnta.Enabled = true;
                    rdbtntb.Enabled = true;



                    // modification des couleur 


                    txtbxreferencerexemp.BackColor = Color.White;

                    codelivreexmp.BackColor = Color.White;
                }
            }
            else if (btnModifier.Text.Equals("Valider"))
            {
                if (btnexemp.Text.Equals("Livre"))
                {
                    
                        erreurtype = true;
                        try
                        {
                            Convert.ToInt32(txtbxtome.Text);
                        }
                        catch
                        {
                            btDialog("Tome est un entier", true);
                            erreurtype = false;
                        }
                        try
                        {
                            Convert.ToInt32(txtbxpage.Text);
                        }
                        catch
                        {
                            btDialog("Page est un entier", true);
                            erreurtype = false;
                        }
                        if (erreurtype == true)
                        {
                            string parutiontotal = cmbbxmois.Text + "/" + cmbbxannee.Text;
                             
                            Livre lelivre = new Livre(Int32.Parse(txtbxcode.Text), txtbxtitre.Text, txtbxisbn.Text, Int32.Parse(txtbxtome.Text), parutiontotal, Int32.Parse(txtbxpage.Text), "", txtbxcouleur.Text, txtbxcommentaire.Text, txtbxformat.Text, 1, 1);
                            unlivre.update_livre(lelivre, cmbbxediteur.Text, cmbbxserie.Text);
                            reset();

                    
                    }
                }
                else if (btnexemp.Text.Equals("exemplaire"))
                {
                    //verifie en l'etat du radiobouton
                    if (rdbtnA.Checked == true)
                    {
                        resultat = rdbtnA.Text;
                    }
                    else if (rdbtnb.Checked == true)
                    {
                        resultat = rdbtnb.Text;                 
                    }
                    else if (rdbtnta.Checked == true)
                    {
                        resultat = rdbtnta.Text;                
                    }
                    else if (rdbtntb.Checked == true)
                    {
                        resultat = rdbtntb.Text;                    
                    }
                    erreurtype = true;
                    try
                    {
                        Convert.ToInt32(codelivreexmp.Text);
                    }
                    catch
                    {

                        btDialog("Code est un entier", true);
                        erreurtype = false;
                    }
                    if (erreurtype == true)
                    {
                        Exemplaire lexemplaire = new Exemplaire(txtbxreferencerexemp.Text, resultat, Int32.Parse(codelivreexmp.Text));
                        unexemplaire.update_exemplaire(lexemplaire);
                        reset();
                    }
                }

                // repasse le bouton ajouter en "ajouter" + modification couleur + desactive le bouton annuler
                btnModifier.Text = "Modifier";
                btnModifier.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //reactivation des autres boutons 
                btnRechercher.Enabled = true;
                btnSupprimer.Enabled = true;
                btnAjouter.Enabled = true;

                // textbox desactiver pour l'insertion
                txtbxtitre.Enabled = false;
                txtbxisbn.Enabled = false;
                txtbxcouleur.Enabled = false;
                txtbxtome.Enabled = false;
                cmbbxannee.Enabled = false;
                cmbbxmois.Enabled = false;
                txtbxformat.Enabled = false;
                txtbxpage.Enabled = false;
                txtbxcommentaire.Enabled = false;
            
                txtbxreferencerexemp.Enabled = false;
                rdbtnA.Enabled = false;
                rdbtnb.Enabled = false;
                rdbtnta.Enabled = false;
                rdbtntb.Enabled = false;
                codelivreexmp.Enabled = false;
                cmbbxauteur.Enabled = false;
                cmbbauteurdessin.Enabled = false;
                cmbbxediteur.Enabled = false;
                cmbbxserie.Enabled = false;

                // modification des couleur 
                txtbxcode.BackColor = Color.Silver;
                txtbxtitre.BackColor = Color.Silver;
                txtbxisbn.BackColor = Color.Silver;
                txtbxcouleur.BackColor = Color.Silver;
                txtbxtome.BackColor = Color.Silver;
                cmbbxannee.BackColor = Color.Silver;
                cmbbxmois.BackColor = Color.Silver;
                txtbxformat.BackColor = Color.Silver;
                txtbxpage.BackColor = Color.Silver;
                txtbxcommentaire.BackColor = Color.Silver;
     
                txtbxreferencerexemp.BackColor = Color.Silver;
                codelivreexmp.BackColor = Color.Silver;
                cmbbxauteur.BackColor = Color.Silver;
                cmbbauteurdessin.BackColor = Color.Silver;
                cmbbxediteur.BackColor = Color.Silver;
                cmbbxserie.BackColor = Color.Silver;
                txtbxcode.BackColor = Color.Silver;
            }
        }
        //bouton LIVRE/EXEMPLAIRE
        private void btnexemp_Click(object sender, EventArgs e)
        {
            #region remet par defaut 
            // textbox desactiver pour l'insertion
            txtbxtitre.Enabled = false;
            txtbxisbn.Enabled = false;
            txtbxcouleur.Enabled = false;
            txtbxtome.Enabled = false;
            cmbbxmois.Enabled = false;
            cmbbxannee.Enabled = false;
            txtbxformat.Enabled = false;
            txtbxpage.Enabled = false;
            txtbxcommentaire.Enabled = false;
          
            txtbxreferencerexemp.Enabled = false;
            rdbtnA.Enabled = false;
            rdbtnb.Enabled = false;
            rdbtnta.Enabled = false;
            rdbtntb.Enabled = false;
            codelivreexmp.Enabled = false;
            cmbbxauteur.Enabled = false;
            cmbbauteurdessin.Enabled = false;
            cmbbxediteur.Enabled = false;
            cmbbxserie.Enabled = false;
            txtbxmotifexemp.Enabled = false;

            // modification des couleur 
            txtbxcode.BackColor = Color.Silver;
            txtbxtitre.BackColor = Color.Silver;
            txtbxisbn.BackColor = Color.Silver;
            txtbxcouleur.BackColor = Color.Silver;
            txtbxtome.BackColor = Color.Silver;
            cmbbxannee.BackColor = Color.Silver;
            cmbbxmois.BackColor = Color.Silver;
            txtbxformat.BackColor = Color.Silver;
            txtbxpage.BackColor = Color.Silver;
            txtbxcommentaire.BackColor = Color.Silver;

            txtbxmotifexemp.BackColor = Color.Silver;
            txtbxreferencerexemp.BackColor = Color.Silver;
            codelivreexmp.BackColor = Color.Silver;
            cmbbxauteur.BackColor = Color.Silver;
            cmbbauteurdessin.BackColor = Color.Silver;
            cmbbxediteur.BackColor = Color.Silver;
            cmbbxserie.BackColor = Color.Silver;
            #endregion

            if (btnexemp.Text.Equals("Livre") & btnAjouter.Text.Equals("Valider"))
            {
                btnexemp.Text = "exemplaire";
                grpboxexemp.Visible = true;


                txtbxreferencerexemp.Enabled = true;
                rdbtnA.Enabled = true;
                rdbtnb.Enabled = true;
                rdbtnta.Enabled = true;
                rdbtntb.Enabled = true;

                codelivreexmp.Enabled = true;

                // modification des couleur 

                txtbxreferencerexemp.BackColor = Color.White;
                codelivreexmp.BackColor = Color.White;


            }


            else if (btnexemp.Text.Equals("exemplaire") & btnAjouter.Text.Equals("Valider"))
            {
                btnexemp.Text = "Livre";
                grpboxexemp.Visible = false;


                // textbox activer pour l'insertion

                txtbxtitre.Enabled = true;
                txtbxisbn.Enabled = true;
                txtbxcouleur.Enabled = true;
                txtbxtome.Enabled = true;
                cmbbxannee.Enabled = true;
                cmbbxmois.Enabled = true;
                txtbxformat.Enabled = true;
                txtbxpage.Enabled = true;
                txtbxcommentaire.Enabled = true;
               


                cmbbxauteur.Enabled = true;
                cmbbauteurdessin.Enabled = true;
                cmbbxediteur.Enabled = true;
                cmbbxserie.Enabled = true;

                txtbxcode.Enabled = false;
                txtbxcode.Enabled = true;
                // modification des couleur 

                txtbxtitre.BackColor = Color.White;
                txtbxisbn.BackColor = Color.White;
                txtbxcouleur.BackColor = Color.White;
                txtbxtome.BackColor = Color.White;
                cmbbxannee.BackColor = Color.White;
                cmbbxmois.BackColor = Color.White;
                txtbxformat.BackColor = Color.White;
                txtbxpage.BackColor = Color.White;
                txtbxcommentaire.BackColor = Color.White;


                cmbbauteurdessin.BackColor = Color.White;
                cmbbxauteur.BackColor = Color.White;
                cmbbxediteur.BackColor = Color.White;
                cmbbxserie.BackColor = Color.White;
            }

            if (btnexemp.Text.Equals("Livre") & btnModifier.Text.Equals("Valider"))
            {
                btnexemp.Text = "exemplaire";
                grpboxexemp.Visible = true;


                txtbxreferencerexemp.Enabled = true;
                codelivreexmp.Enabled = true;
                rdbtnA.Enabled = true;
                rdbtnb.Enabled = true;
                rdbtnta.Enabled = true;
                rdbtntb.Enabled = true;
                // modification des couleur 

                txtbxreferencerexemp.BackColor = Color.White;
                codelivreexmp.BackColor = Color.White;

            }


            else if (btnexemp.Text.Equals("exemplaire") & btnModifier.Text.Equals("Valider"))
            {
                btnexemp.Text = "Livre";
                grpboxexemp.Visible = false;


                // textbox activer pour l'insertion

                txtbxtitre.Enabled = true;
                txtbxisbn.Enabled = true;
                txtbxcouleur.Enabled = true;
                txtbxtome.Enabled = true;
                cmbbxannee.Enabled = true;
                cmbbxmois.Enabled = true;
                txtbxformat.Enabled = true;
                txtbxpage.Enabled = true;
                txtbxcommentaire.Enabled = true;

                cmbbauteurdessin.Enabled = true;
                cmbbxauteur.Enabled = true;
                cmbbxediteur.Enabled = true;
                cmbbxserie.Enabled = true;

                // modification des couleur 
                txtbxcode.BackColor = Color.White;
                txtbxtitre.BackColor = Color.White;
                txtbxisbn.BackColor = Color.White;
                txtbxcouleur.BackColor = Color.White;
                txtbxtome.BackColor = Color.White;
                cmbbxannee.BackColor = Color.White;
                cmbbxmois.BackColor = Color.White;
                txtbxformat.BackColor = Color.White;
                txtbxpage.BackColor = Color.White;
                txtbxcommentaire.BackColor = Color.White;


                cmbbauteurdessin.BackColor = Color.White;
                cmbbxauteur.BackColor = Color.White;
                cmbbxediteur.BackColor = Color.White;
                cmbbxserie.BackColor = Color.White;

            }
            if (btnexemp.Text.Equals("exemplaire") & btnSupprimer.Text.Equals("Valider"))
            {
                btnexemp.Text = "Livre";
                grpboxexemp.Visible = false;
                // textbox activer pour l'insertion

                txtbxcode.Enabled = true;

                txtbxmotif.Visible = true;
                lblmotif.Visible = true;
                lblcommentaire.Visible = false;
                txtbxcommentaire.Visible = false;

                // modification des couleur 

                txtbxcode.BackColor = Color.White;





            }
            else if (btnexemp.Text.Equals("Livre") & btnSupprimer.Text.Equals("Valider"))
            {
                btnexemp.Text = "exemplaire";
                grpboxexemp.Visible = true;
                // textbox activer pour l'insertion



                txtbxreferencerexemp.Enabled = true;
                txtbxmotif.Visible = true;
                lblmotif.Visible = true;
                lblcommentaire.Visible = false;
                txtbxcommentaire.Visible = false;

                // modification des couleur 




                txtbxreferencerexemp.BackColor = Color.White;

            }
            if (btnexemp.Text.Equals("exemplaire") & btnRechercher.Text.Equals("Valider"))
            {
                btnexemp.Text = "Livre";     

                grpboxexemp.Visible = false;

                txtbxtitre.Enabled = true;
                cmbbxannee.Enabled = true;
                cmbbxmois.Enabled = true;

                txtbxtitre.BackColor = Color.White;
                cmbbxannee.BackColor = Color.White;
                cmbbxmois.BackColor = Color.White;
            }
            else if (btnexemp.Text.Equals("Livre") & btnRechercher.Text.Equals("Valider"))
            {
                btnexemp.Text = "exemplaire";
                grpboxexemp.Visible = true;

                codelivreexmp.Enabled = true;
                txtbxreferencerexemp.Enabled = true;
                rdbtnA.Enabled = true;
                rdbtnb.Enabled = true;
                rdbtnta.Enabled = true;
                rdbtntb.Enabled = true;

                codelivreexmp.BackColor = Color.White;
                txtbxreferencerexemp.BackColor = Color.White;
            }

        }


        // affichage des informations de la base dans le datagridview
        private void dtgrvlivre_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (btnexemp.Text.Equals("Livre"))
            {
                txtbxcode.Text = dtgrvLivre.CurrentRow.Cells[0].Value.ToString();
                txtbxtitre.Text = dtgrvLivre.CurrentRow.Cells[1].Value.ToString();
                txtbxisbn.Text = dtgrvLivre.CurrentRow.Cells[2].Value.ToString();
                txtbxtome.Text = dtgrvLivre.CurrentRow.Cells[3].Value.ToString();


                // permet de séparer le mois et l'annee et les affecter leur combo box
                string totalparution = dtgrvLivre.CurrentRow.Cells[4].Value.ToString();
                cmbbxmois.Text = totalparution.Substring(0, 2);
                cmbbxannee.Text = totalparution.Substring(3, 4);


                txtbxpage.Text = dtgrvLivre.CurrentRow.Cells[5].Value.ToString();
                txtbxcouleur.Text = dtgrvLivre.CurrentRow.Cells[6].Value.ToString();
                txtbxcommentaire.Text = dtgrvLivre.CurrentRow.Cells[7].Value.ToString();
                txtbxformat.Text = dtgrvLivre.CurrentRow.Cells[8].Value.ToString();
               // txtbxserie.Text = dtgrvLivre.CurrentRow.Cells[9].Value.ToString();
                //txtbxediteur.Text = dtgrvLivre.CurrentRow.Cells[10].Value.ToString();
            }

        }
        #endregion
        //ferme 
        private void metrotileQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // retourne au menu
        private void picHome_Click(object sender, EventArgs e)
        {
            //permet de récuperer le niveau de l'utilisateur
            leNiveau = lblRang.Text;

            this.Close();
            th = new Thread(openAccueil);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

    
        private void openAccueil()
        {
            Application.Run(new FrmAccueilTest(leNiveau));
        }

        //Methode affichant une boite de dialogue avec un message personnaliser
        public void btDialog(String leMessage, Boolean zeroOuUn)
        {
            if (zeroOuUn == true)
            {
                MessageBox.Show(leMessage, "Médiateque", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (zeroOuUn == false)
            {
                MessageBox.Show(leMessage, "Médiateque", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }

        }


    }

}

