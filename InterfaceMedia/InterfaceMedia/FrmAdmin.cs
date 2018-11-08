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
        private String unNiveau;
        #endregion

        public FrmAdmin()
        {
            InitializeComponent();

            uneconnexion = new ConnexionBase();
            unUtilisateur = new Crud_Utilisateur(uneconnexion);

            RefreshGrid();

        }

        //Rempli le Grid avec les utilisateurs
        private void RempGridUtilisateur(List<Utilisateur> lesUtilisateurs)
        {
            gridUtilisateur.DataSource = lesUtilisateurs;
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


        //Affiche dans les textbox les valeurs de la ligne sélectionné.
        private void gridUtilisateur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            unId.Text = gridUtilisateur.CurrentRow.Cells["Numéro"].Value.ToString();
            txtNom.Text = gridUtilisateur.CurrentRow.Cells["Nom"].Value.ToString();
            txtPrenom.Text = gridUtilisateur.CurrentRow.Cells["Prénom"].Value.ToString();
            txtPseudo.Text = gridUtilisateur.CurrentRow.Cells["Pseudo"].Value.ToString();
            txtPassword.Text = gridUtilisateur.CurrentRow.Cells["Mot_de_passe"].Value.ToString();

            if (gridUtilisateur.CurrentRow.Cells[5].Value.ToString().Equals("user"))
            {
                metroRadioUtilisateur.Checked = true;
                metroRadioInvite.Checked = false;
                metroRadioAdmin.Checked = false;
            }
            if (gridUtilisateur.CurrentRow.Cells[5].Value.ToString().Equals("admin"))
            {
                metroRadioAdmin.Checked = true;
                metroRadioUtilisateur.Checked = false;
                metroRadioInvite.Checked = false;
            }
            if (gridUtilisateur.CurrentRow.Cells[5].Value.ToString().Equals("invit"))
            {
                metroRadioAdmin.Checked = false;
                metroRadioUtilisateur.Checked = false;
                metroRadioInvite.Checked = true;
            }

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

                //Les textbox (et les boutons radio) à remplir pour l'insertion se déverouille
                txtNom.Enabled = true;
                txtPseudo.Enabled = true;
                txtPrenom.Enabled = true;
                txtPassword.Enabled = true;
                metroRadioAdmin.Enabled = true;
                metroRadioInvite.Enabled = true;
                metroRadioUtilisateur.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                txtPseudo.BackColor = Color.White;
                txtPrenom.BackColor = Color.White;
                txtPassword.BackColor = Color.White;


                //Reinistialisation des textbox
                unId.Text = "";
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

                recupNiveau();

                //Gestion des erreurs
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Un ou des champs obligatoire.s sont manquant.s", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Ajout d'un utilisateur
                    unUtilisateur.ajout_utilisateur(txtPrenom.Text, txtNom.Text, txtPseudo.Text, txtPassword.Text, unNiveau);

                    //Reinistialisation des textbox et des boutons radio
                    unId.Text = "";
                    txtNom.Text = "";
                    txtPseudo.Text = "";
                    txtPrenom.Text = "";
                    txtPassword.Text = "";
                    metroRadioAdmin.Checked = false;
                    metroRadioInvite.Checked = false;
                    metroRadioUtilisateur.Checked = false;

                    RefreshGrid();
                } 

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
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = false;
                btnRechercher.Enabled = false;

                //Les textbox (et les boutons radio) à remplir pour l'insertion se déverouille
                txtNom.Enabled = true;
                txtPseudo.Enabled = true;
                txtPrenom.Enabled = true;
                txtPassword.Enabled = true;
                metroRadioAdmin.Enabled = true;
                metroRadioInvite.Enabled = true;
                metroRadioUtilisateur.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                txtPseudo.BackColor = Color.White;
                txtPrenom.BackColor = Color.White;
                txtPassword.BackColor = Color.White;

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
                txtPseudo.Enabled = false;
                txtPrenom.Enabled = false;
                txtPassword.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;
                txtPseudo.BackColor = Color.Silver;
                txtPrenom.BackColor = Color.Silver;
                txtPassword.BackColor = Color.Silver;

                recupNiveau();

                //Modification d'un utilisateur
                unUtilisateur.modification_utilisateur(Convert.ToInt16(unId.Text), txtPrenom.Text, txtNom.Text, txtPseudo.Text, txtPassword.Text, unNiveau);


                //Reinistialisation des textbox
                unId.Text = "";
                txtNom.Text = "";
                txtPseudo.Text = "";
                txtPrenom.Text = "";
                txtPassword.Text = "";
                metroRadioAdmin.Checked = false;
                metroRadioInvite.Checked = false;
                metroRadioUtilisateur.Checked = false;

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
                btnSupprimer.Enabled = true;
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

                recupNiveau();

                //Suppression d'un utilisateur
                unUtilisateur.suppression_utilisateur(Convert.ToInt16(unId.Text));

                //Reinistialisation des textbox et boutons radio
                unId.Text = "";
                txtNom.Text = "";
                txtPseudo.Text = "";
                txtPrenom.Text = "";
                txtPassword.Text = "";
                metroRadioAdmin.Checked = false;
                metroRadioInvite.Checked = false;
                metroRadioUtilisateur.Checked = false;

                RefreshGrid();
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

                //Desactive tous les autres boutons
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnAjouter.Enabled = false;

                //Les textbox (et les boutons radio) à remplir pour la recherche se déverouille
                txtNom.Enabled = true;
                txtPseudo.Enabled = true;
                txtPrenom.Enabled = true;
                metroRadioAdmin.Enabled = true;
                metroRadioInvite.Enabled = true;
                metroRadioUtilisateur.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                txtPseudo.BackColor = Color.White;
                txtPrenom.BackColor = Color.White;

                //Reinistialisation des textbox et des boutons radio
                unId.Text = "";
                txtNom.Text = "";
                txtPseudo.Text = "";
                txtPrenom.Text = "";
                txtPassword.Text = "";
            
                metroRadioAdmin.Checked = false;
                metroRadioInvite.Checked = false;
                metroRadioUtilisateur.Checked = false;

            }

            else if (btnRechercher.Text.Equals("Valider"))
            {

                btnRechercher.Text = "Rechercher";
                btnRechercher.BackColor = Color.SteelBlue;
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

                recupNiveau();

                //recherche d'un utilisateur
                //unUtilisateur.recherche_utilisateur();


                //Reinistialisation des textbox et des boutons radio
                unId.Text = "";
                txtNom.Text = "";
                txtPseudo.Text = "";
                txtPrenom.Text = "";
                txtPassword.Text = "";
                metroRadioAdmin.Checked = false;
                metroRadioInvite.Checked = false;
                metroRadioUtilisateur.Checked = false;

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

            //Les textbox et les boutons radio sont inacessibles.
            txtNom.Enabled = false;
            unId.Enabled = false;
            txtPseudo.Enabled = false;
            txtPrenom.Enabled = false;
            txtPassword.Enabled = false;
            metroRadioAdmin.Enabled = true;
            metroRadioInvite.Enabled = true;
            metroRadioUtilisateur.Enabled = true;

            //Reinistialisation des textbox et des boutons radio
            txtNom.Text = "";
            unId.Text = "";
            txtPseudo.Text = "";
            txtPrenom.Text = "";
            txtPassword.Text = "";
            metroRadioAdmin.Checked = false;
            metroRadioInvite.Checked = false;
            metroRadioUtilisateur.Checked = false;

            //Le background color des textbox change de couleur pour indiquer qu'elles sont vérouillé
            txtNom.BackColor = Color.Silver;
            unId.BackColor = Color.Silver;
            txtPseudo.BackColor = Color.Silver;
            txtPrenom.BackColor = Color.Silver;
            txtPassword.BackColor = Color.Silver;

            //le bouton annuler disparait
            btnAnnuler.Visible = false;

            RefreshGrid();
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
            //gridUtilisateur.Columns["Mot_de_passe"].Visible = false;
            gridUtilisateur.Update();
            gridUtilisateur.Refresh();
        }
        public void recupNiveau()
        {
            if (metroRadioAdmin.Checked == true)
            {
                unNiveau = "admin";
            }
            else if (metroRadioInvite.Checked == true)
            {
                unNiveau = "invit";
            }
            else unNiveau = "user";

        }


    }
    
}


