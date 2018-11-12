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
        private String leNiveau;
        #endregion

        public FrmAdmin(string leNiveau)
        {
            InitializeComponent();
            this.leNiveau = leNiveau;
            lblRang.Text = this.leNiveau;
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
            //permet de récuperer le niveau de l'utilisateur
            unNiveau = lblRang.Text;
            //Ferme FrmEmprunteur
            this.Close();
            //Permet d'ouvrir FrmAccueil
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

            if (gridUtilisateur.CurrentRow.Cells[5].Value.ToString().Equals("Personnel"))
            {
                metroRadioSecteur.Checked = false;
                metroRadioPersonnel.Checked = true;
                metroRadioAdmin.Checked = false;
                metroRadioStock.Checked = false;
            }
            if (gridUtilisateur.CurrentRow.Cells[5].Value.ToString().Equals("Admin"))
            {
                metroRadioSecteur.Checked = false;
                metroRadioPersonnel.Checked = false;
                metroRadioAdmin.Checked = true;
                metroRadioStock.Checked = false;
            }
            if (gridUtilisateur.CurrentRow.Cells[5].Value.ToString().Equals("Responsable secteur"))
            {
                metroRadioSecteur.Checked = true;
                metroRadioPersonnel.Checked = false;
                metroRadioAdmin.Checked = false;
                metroRadioStock.Checked = false;
            }
            if (gridUtilisateur.CurrentRow.Cells[5].Value.ToString().Equals("Responsable stock"))
            {
                metroRadioSecteur.Checked = false;
                metroRadioPersonnel.Checked = false;
                metroRadioAdmin.Checked = false;
                metroRadioStock.Checked = true;
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

                //Les textbox (et les boutons radio) à remplir pour l'insertion se déverouille
                txtNom.Enabled = true;
                txtPseudo.Enabled = true;
                txtPrenom.Enabled = true;
                txtPassword.Enabled = true;
                metroRadioAdmin.Enabled = true;
                metroRadioPersonnel.Enabled = true;
                metroRadioSecteur.Enabled = true;
                metroRadioStock.Enabled = true;

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
                    metroRadioPersonnel.Checked = false;
                    metroRadioSecteur.Checked = false;

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

                //Les textbox (et les boutons radio) à remplir pour l'insertion se déverouille
                txtNom.Enabled = true;
                txtPseudo.Enabled = true;
                txtPrenom.Enabled = true;
                txtPassword.Enabled = true;
                metroRadioAdmin.Enabled = true;
                metroRadioPersonnel.Enabled = true;
                metroRadioSecteur.Enabled = true;
                metroRadioStock.Enabled = true;


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
                metroRadioPersonnel.Checked = false;
                metroRadioSecteur.Checked = false;

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
                metroRadioPersonnel.Checked = false;
                metroRadioSecteur.Checked = false;

                RefreshGrid();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //les boutons sont remis par defaut
            btnAjouter.BackColor = Color.SteelBlue;
            btnModifier.BackColor = Color.SteelBlue;
            btnSupprimer.BackColor = Color.SteelBlue;

            //Remet les accessibilités des boutons par défauts
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
            btnAjouter.Enabled = true;

            btnAjouter.Text = "Ajouter";
            btnModifier.Text = "Modifier";
            btnSupprimer.Text = "Supprimer";

            //Les textbox et les boutons radio sont inacessibles.
            txtNom.Enabled = false;
            unId.Enabled = false;
            txtPseudo.Enabled = false;
            txtPrenom.Enabled = false;
            txtPassword.Enabled = false;
            metroRadioAdmin.Enabled = false;
            metroRadioPersonnel.Enabled = false;
            metroRadioSecteur.Enabled = false;
            metroRadioStock.Enabled = false;


            //Reinistialisation des textbox et des boutons radio
            txtNom.Text = "";
            unId.Text = "";
            txtPseudo.Text = "";
            txtPrenom.Text = "";
            txtPassword.Text = "";
            metroRadioAdmin.Checked = false;
            metroRadioPersonnel.Checked = false;
            metroRadioSecteur.Checked = false;

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
            Application.Run(new FrmAccueilTest(unNiveau));
        }
        public void RefreshGrid()
        {
            uneconnexion = new ConnexionBase();
            unUtilisateur = new Crud_Utilisateur(uneconnexion);
            unUtilisateur.Recup_Table_Utilisateur();
            RempGridUtilisateur(unUtilisateur.lesUtilisateurs);
            gridUtilisateur.Update();
            gridUtilisateur.Refresh();
        }
        public void recupNiveau()
        {

            if (metroRadioPersonnel.Checked == true)
            {
                unNiveau = "Personnel";
            }

            if (metroRadioSecteur.Checked == true)
            {
                unNiveau = "Responsable secteur";
            }

            if (metroRadioStock.Checked == true)
            {
                unNiveau = "Responsable stock";
            }
            else  unNiveau = "Admin";


        }


    }
    
}


