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
    
    public partial class FrmAdmin : MetroForm
    {
        #region Propriétés
        private Crud_Utilisateur unUtilisateur;
        private ConnexionBase uneconnexion;
        Thread th;
        #endregion

        public FrmAdmin()
        {
            InitializeComponent();

            uneconnexion = new ConnexionBase();
            unUtilisateur = new Crud_Utilisateur(uneconnexion);

            RefreshGrid();

        }

        //Rempli le Grid avec les emprunteurs
        private void RempGridUtilisateur(List<Utilisateur> lesUtilisateurs)
        {
            gridUtilisateur.DataSource = lesUtilisateurs;
        }

        //Affiche dans les textbox les valeurs de la ligne sélectionné.


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
            Application.Run(new FrmAccueilTest());
        }

        public void RefreshGrid()
        {
            uneconnexion = new ConnexionBase();
            unUtilisateur = new Crud_Utilisateur(uneconnexion);
            unUtilisateur.Recup_Table_Utilisateur();
            RempGridUtilisateur(unUtilisateur.lesUtilisateurs);
            gridUtilisateur.Columns["Mot_de_passe"].Visible = false;
            gridUtilisateur.Update();
            gridUtilisateur.Refresh();
        }

        private void gridUtilisateur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gridUtilisateur.CurrentRow.Cells["Numéro"].Value.ToString();
            txtNom.Text = gridUtilisateur.CurrentRow.Cells["Nom"].Value.ToString();
            txtPrenom.Text = gridUtilisateur.CurrentRow.Cells["Prénom"].Value.ToString();
            txtPseudo.Text = gridUtilisateur.CurrentRow.Cells["Pseudo"].Value.ToString();

            //Déverouille le bouton modifier et supprimer
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
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
                txtPseudo.Enabled = true;
                txtPrenom.Enabled = true;
                txtPassword.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                txtPseudo.BackColor = Color.White;
                txtPrenom.BackColor = Color.White;
                txtPassword.BackColor = Color.White;


                //Reinistialisation des textbox
                txtId.Text = "";
                txtNom.Text = "";
                txtPseudo.Text = "";
                txtPrenom.Text = "";
                txtPassword.Text = "";

            }

            else if (btnAjouter.Text.Equals("Valider"))
            {

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
                txtPseudo.Enabled = false;
                txtPrenom.Enabled = false;
                txtPassword.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;
                txtPseudo.BackColor = Color.Silver;
                txtPrenom.BackColor = Color.Silver;
                txtPassword.BackColor = Color.Silver;

                //Ajout d'un utilisateur
                //unUtilisateur.ajout_editeur(txtNom.Text, txtAdr.Text, txtCodePostal.Text, txtVille.Text, txtMail.Text, txtFax.Text, txtTel.Text, uneDateCreation, unCodeSortie);


                //Reinistialisation des textbox
                txtId.Text = "";
                txtNom.Text = "";
                txtPseudo.Text = "";
                txtPrenom.Text = "";
                txtPassword.Text = "";

                RefreshGrid();
            }
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
            txtId.Enabled = false;
            txtPseudo.Enabled = false;
            txtPrenom.Enabled = false;
            txtPassword.Enabled = false;

            //Reinistialisation des textbox
            txtNom.Text = "";
            txtId.Text = "";
            txtPseudo.Text = "";
            txtPrenom.Text = "";
            txtPassword.Text = "";

            //Le background color des textbox change de couleur pour indiquer qu'elles sont vérouillé
            txtNom.BackColor = Color.Silver;
            txtId.BackColor = Color.Silver;
            txtPseudo.BackColor = Color.Silver;
            txtPrenom.BackColor = Color.Silver;
            txtPassword.BackColor = Color.Silver;

            //le bouton annuler disparait
            btnAnnuler.Visible = false;

            RefreshGrid();
        }
    }
    
}


