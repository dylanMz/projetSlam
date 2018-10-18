using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibMedia;
using MetroFramework.Forms;

namespace InterfaceMedia
{
    public partial class FrmEditeur : MetroForm
    {
        private Crud_Editeur unEditeur;
        private ConnexionBase uneconnexion;
        private int uneDateCreation;

        public FrmEditeur()
        {
            InitializeComponent();
            uneconnexion = new ConnexionBase();
            unEditeur = new Crud_Editeur(uneconnexion);
            GridEditeur.DataSource = unEditeur.Recup_Table_Editeur("proc_affiche_editeur","editeur");

            
            DateTimeCreation.Format = DateTimePickerFormat.Custom;
            DateTimeCreation.CustomFormat = "yyyy";
            DateTimeCreation.ShowUpDown = true;
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
                uneDateCreation = Convert.ToInt32(DateTimeCreation.Text);

                //Ajout d'un editeur
                unEditeur.modifier_ajouter_editeur("proc_insert_editeur", txtNom.Text, txtAdr.Text, txtCodePostal.Text, txtVille.Text, txtMail.Text, txtFax.Text, txtTel.Text, uneDateCreation);


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

                GridEditeur.DataSource = unEditeur.Recup_Table_Editeur("proc_affiche_editeur", "editeur");

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

                //Re active les boutons
                btnAjouter.Enabled = true;
                btnModifier.Enabled = true;
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
            }

            else if (btnRechercher.Text.Equals("Valider"))
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



        }

        private void picHome_Click(object sender, EventArgs e)
        {
            FrmAccueilTest wAccueilTest = new FrmAccueilTest();
            wAccueilTest.ShowDialog();
            Form.ActiveForm.Close();
        }

        //Affiche dans les textbox les valeurs de la ligne sélectionné.
        private void GridEditeur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = GridEditeur.CurrentRow.Cells["EditeurNum"].Value.ToString();
            txtNom.Text = GridEditeur.CurrentRow.Cells["EditeurNom"].Value.ToString();

            //DateTimeCreation.Text = GridEditeur.CurrentRow.Cells["EditeurCreation"].Value.ToString();

            txtVille.Text = GridEditeur.CurrentRow.Cells["EditeurVille"].Value.ToString();
            txtAdr.Text = GridEditeur.CurrentRow.Cells["EditeurAdresse"].Value.ToString();
            txtCodePostal.Text = GridEditeur.CurrentRow.Cells["EditeurCP"].Value.ToString();
            txtTel.Text = GridEditeur.CurrentRow.Cells["EditeurTel"].Value.ToString();
            txtFax.Text = GridEditeur.CurrentRow.Cells["EditeurFax"].Value.ToString();
            txtMail.Text = GridEditeur.CurrentRow.Cells["EditeurMail"].Value.ToString();






        }
    }
}
