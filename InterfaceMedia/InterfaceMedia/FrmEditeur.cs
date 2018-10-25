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
    public partial class FrmEditeur : MetroForm
    {
        #region Propriétés
        private Crud_Editeur unEditeur;
        private ConnexionBase uneconnexion;
        Thread th;
        

        private int uneDateCreation;

        private String unCodeSortie;
        #endregion

        public FrmEditeur()
        {
            InitializeComponent();

            uneconnexion = new ConnexionBase();
            unEditeur = new Crud_Editeur(uneconnexion);

            RefreshGrid();

            DateTimeCreation.Format = DateTimePickerFormat.Custom;
            DateTimeCreation.CustomFormat = "yyyy";
            DateTimeCreation.ShowUpDown = true;
        }

        //Rempli le Grid avec les emprunteurs
        private void RempGridEditeur(List<Editeur> lesEditeurs)
        {
            GridEditeur.DataSource = lesEditeurs;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text.Equals("Ajouter"))
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

                //Reinistialisation des textbox
                txtCode.Text = "";
                txtNom.Text = "";
                DateTimeCreation.Text = "";
                txtMail.Text = "";
                txtCodePostal.Text = "";
                txtAdr.Text = "";
                txtTel.Text = "";
                txtFax.Text = "";
                txtVille.Text = "";
            }

            else if (btnAjouter.Text.Equals("Valider"))
            {
                unCodeSortie = "";

                btnAjouter.Text = "Ajouter";
                btnAjouter.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Remet les accessibilités des boutons par défauts
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnAjouter.Enabled = true;
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

                uneDateCreation = Convert.ToInt32(DateTimeCreation.Text);

                //Ajout d'un editeur
                unEditeur.ajout_editeur(txtNom.Text, txtAdr.Text, txtCodePostal.Text, txtVille.Text, txtMail.Text, txtFax.Text, txtTel.Text, uneDateCreation, unCodeSortie);


                //Reinistialisation des textbox
                txtCode.Text = "";
                txtNom.Text = "";
                DateTimeCreation.Text = "";
                txtMail.Text = "";
                txtCodePostal.Text = "";
                txtAdr.Text = "";
                txtTel.Text = "";
                txtFax.Text = "";
                txtVille.Text = "";

                RefreshGrid();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnModifier.Text.Equals("Modifier"))
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

            else if (btnModifier.Text.Equals("Valider"))
            {
                
                btnModifier.Text = "Modifier";
                btnModifier.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Remet les accessibilités des boutons par défauts
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnAjouter.Enabled = true;
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

                uneDateCreation = Convert.ToInt32(DateTimeCreation.Text);

                //Modification d'un editeur
                unEditeur.modification_editeur(txtCode.Text, txtNom.Text, txtAdr.Text, txtCodePostal.Text, txtVille.Text, txtMail.Text, txtFax.Text, txtTel.Text, uneDateCreation);


                //Reinistialisation des textbox
                txtCode.Text = "";
                txtNom.Text = "";
                DateTimeCreation.Text = "";
                txtMail.Text = "";
                txtCodePostal.Text = "";
                txtAdr.Text = "";
                txtTel.Text = "";
                txtFax.Text = "";
                txtVille.Text = "";

                //Actualisation du datagrid
                RefreshGrid();

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (btnSupprimer.Text.Equals("Supprimer"))
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

            else if (btnSupprimer.Text.Equals("Valider"))
            {
                btnSupprimer.Text = "Supprimer";
                btnSupprimer.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Remet les accessibilités des boutons par défauts
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnAjouter.Enabled = true;
                btnRechercher.Enabled = true;

            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (btnRechercher.Text.Equals("Rechercher"))
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

                //Reinistialisation des textbox
                txtCode.Text = "";
                txtNom.Text = "";
                DateTimeCreation.Text = "";
                txtMail.Text = "";
                txtCodePostal.Text = "";
                txtAdr.Text = "";
                txtTel.Text = "";
                txtFax.Text = "";
                txtVille.Text = "";
            }

            else if (btnRechercher.Text.Equals("Valider"))
            {
                btnRechercher.Text = "Rechercher";
                btnRechercher.BackColor = Color.SteelBlue;
                

                //Remet les accessibilités des boutons par défauts
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnAjouter.Enabled = true;
                btnRechercher.Enabled = true;
                btnAnnuler.Visible = true;

                //Les textbox sont inacessibles.
                txtNom.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;

                //Vide la liste
                unEditeur.lesEditeurs.Clear();

                //Recherche d'un ou de plusieurs editeurs
                uneconnexion = new ConnexionBase();
                unEditeur = new Crud_Editeur(uneconnexion);
                unEditeur.recherche_editeur(txtNom.Text);
                RempGridEditeur(unEditeur.lesEditeurs);


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

            //Remet les accessibilités des boutons par défauts
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
            btnAjouter.Enabled = true;
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

            //Reinistialisation des textbox
            txtCode.Text = "";
            txtNom.Text = "";
            DateTimeCreation.Text = "";
            txtMail.Text = "";
            txtCodePostal.Text = "";
            txtAdr.Text = "";
            txtTel.Text = "";
            txtFax.Text = "";
            txtVille.Text = "";


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

            RefreshGrid();



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
            Application.Run(new FrmAccueilTest());
        }

        //Affiche dans les textbox les valeurs de la ligne sélectionné.
        private void GridEditeur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = GridEditeur.CurrentRow.Cells["_EditeurNum"].Value.ToString();
            txtNom.Text = GridEditeur.CurrentRow.Cells["_EditeurNom"].Value.ToString();

            String date = GridEditeur.CurrentRow.Cells["_EditeurCreation"].Value.ToString();

            DateTimeCreation.Text = "01/01/"+date+" 00:00:00";

            txtVille.Text = GridEditeur.CurrentRow.Cells["_EditeurVille"].Value.ToString();
            txtAdr.Text = GridEditeur.CurrentRow.Cells["_EditeurAdresse"].Value.ToString();
            txtCodePostal.Text = GridEditeur.CurrentRow.Cells["_EditeurCP"].Value.ToString();
            txtTel.Text = GridEditeur.CurrentRow.Cells["_EditeurTel"].Value.ToString();
            txtFax.Text = GridEditeur.CurrentRow.Cells["_EditeurFax"].Value.ToString();
            txtMail.Text = GridEditeur.CurrentRow.Cells["_EditeurMail"].Value.ToString();

            //Déverouille le bouton modifier et supprimer
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;

        }

        public void RefreshGrid()
        {
            uneconnexion = new ConnexionBase();
            unEditeur = new Crud_Editeur(uneconnexion);
            unEditeur.Recup_Table_Editeur();
            RempGridEditeur(unEditeur.lesEditeurs);
            GridEditeur.Update();
            GridEditeur.Refresh();
        }
    }
}
