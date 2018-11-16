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
        private String leNiveau;
        private String ancienNom;
        Thread th;
        

        private int uneDateCreation;

        private int unCodeSortie;
        #endregion

        public FrmEditeur(String leNiveau)
        {
            InitializeComponent();

            this.leNiveau = leNiveau;
            lblRang.Text = this.leNiveau;

            unEditeur = new Crud_Editeur();

            RefreshGrid();

            //Permet d'avoir que l'année
            DateTimeCreation.Format = DateTimePickerFormat.Custom;
            DateTimeCreation.CustomFormat = "yyyy";
            DateTimeCreation.ShowUpDown = true;

        }

        //Rempli le Grid avec les editeurs
        private void RempGridEditeur(List<Editeur> lesEditeurs)
        {
            
            GridEditeur.DataSource = lesEditeurs;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text.Equals("Ajouter"))
            {
                //Execute la méthode clickbouton qui gère les accessibilités et le design des textbox et des boutons.
                clickBouton(btnAjouter);

                btnAjouter.Enabled = true;
            }

            else if (btnAjouter.Text.Equals("Valider"))
            {
                uneDateCreation = Convert.ToInt32(DateTimeCreation.Text);

                //Affiche un message d'erreur si le champ nom est vide
                if (txtNom.Text.Equals(""))
                {
                    MessageBox.Show("Veuillez renseigner un nom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Ajout d'un editeur
                    Editeur lEditeur = new Editeur(txtNom.Text, uneDateCreation, txtAdr.Text, txtCodePostal.Text, txtVille.Text, txtTel.Text, txtFax.Text, txtMail.Text);
                    unCodeSortie = unEditeur.ajout_editeur(lEditeur);

                    //Affiche une erreur si le nom de l'éditeur est déjà présent dans la base.
                    if (unCodeSortie == 99)
                    {
                        MessageBox.Show("Cet editeur est déjà présent dans la base, insertion annulé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    clickValider(btnAjouter, "Ajouter");

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

                //Le grid est inacessible en attendant que l'utilisateur valide ou annule
                GridEditeur.Enabled = false;


            }

            else if (btnModifier.Text.Equals("Valider"))
            {
                uneDateCreation = Convert.ToInt32(DateTimeCreation.Text);

                ancienNom = GridEditeur.CurrentRow.Cells["Nom"].Value.ToString();

                //Affiche un message d'erreur si le champ nom est vide
                if (txtNom.Text.Equals(""))
                {
                    MessageBox.Show("Veuillez renseigner un nom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    //Modification d'un editeur
                    Editeur lEditeur = new Editeur(Convert.ToInt16(code.Text), txtNom.Text, uneDateCreation, txtAdr.Text, txtCodePostal.Text, txtVille.Text, txtTel.Text, txtFax.Text, txtMail.Text, ancienNom);
                    unEditeur.modification_editeur(lEditeur, ancienNom);

                    clickValider(btnModifier, "Modifier");

                    //Reinistialisation des textbox
                    code.Text = "";
                    txtNom.Text = "";
                    DateTimeCreation.Text = "";
                    txtMail.Text = "";
                    txtCodePostal.Text = "";
                    txtAdr.Text = "";
                    txtTel.Text = "";
                    txtFax.Text = "";
                    txtVille.Text = "";

                    //Le grid est de nouveau accessible
                    GridEditeur.Enabled = true;

                    //Actualisation du datagrid
                    RefreshGrid();
                }

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

                //Le grid est inacessible en attendant que l'utilisateur valide ou annule
                GridEditeur.Enabled = false;


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

                //Suppression d'un editeur
                Editeur lEditeur = new Editeur(txtNom.Text);
                unEditeur.suppression_editeur(lEditeur);

                //Reinistialisation des textbox
                code.Text = "";
                txtNom.Text = "";
                DateTimeCreation.Text = "";
                txtMail.Text = "";
                txtCodePostal.Text = "";
                txtAdr.Text = "";
                txtTel.Text = "";
                txtFax.Text = "";
                txtVille.Text = "";

                //Le grid est de nouveau accessible
                GridEditeur.Enabled = true;

                //Actualisation du datagrid
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

                //Les ou le textbox.s a remplir pour la recherche se déverouille
                txtNom.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;

                //Desactive tous les autres boutons
                btnAjouter.Enabled = false;
                btnSupprimer.Enabled = false;
                btnModifier.Enabled = false;

                //Reinistialisation des textbox
                code.Text = "";
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

                Editeur lEditeur = new Editeur(txtNom.Text);
                unEditeur.recherche_editeur(lEditeur);

                RempGridEditeur(unEditeur.lesEditeurs);

            }
        }

        private void btnQuitter_Click_1(object sender, EventArgs e)
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
            code.Text = "";
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

            //Le grid est de nouveau accessible
            GridEditeur.Enabled = true;

            RefreshGrid();



        }

        private void picHome_Click(object sender, EventArgs e)
        {
            //permet de récuperer le niveau de l'utilisateur
            leNiveau = lblRang.Text;
            //Ferme FrmEditeur
            this.Close();
            //Permet d'ouvrir FrmAccueil
            th = new Thread(openformAccueil);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        //Ouvre l'interface accueil avec le niveau de l'utilisateur
        private void openformAccueil()
        {
            Application.Run(new FrmAccueilTest(leNiveau));
        }

        //Affiche dans les textbox les valeurs de la ligne sélectionné.
        private void GridEditeur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            code.Text = GridEditeur.CurrentRow.Cells["Numéro"].Value.ToString();
            txtNom.Text = GridEditeur.CurrentRow.Cells["Nom"].Value.ToString();

            String date = GridEditeur.CurrentRow.Cells["Création"].Value.ToString();

            DateTimeCreation.Text = "01/01/"+date+" 00:00:00";

            txtVille.Text = GridEditeur.CurrentRow.Cells["Ville"].Value.ToString();
            txtAdr.Text = GridEditeur.CurrentRow.Cells["Adresse"].Value.ToString();
            txtCodePostal.Text = GridEditeur.CurrentRow.Cells["Code_Postal"].Value.ToString();
            txtTel.Text = GridEditeur.CurrentRow.Cells["Téléphone"].Value.ToString();
            txtFax.Text = GridEditeur.CurrentRow.Cells["Fax"].Value.ToString();
            txtMail.Text = GridEditeur.CurrentRow.Cells["Mail"].Value.ToString();

            //Déverouille les boutons modifier et supprimer en fonction des droits de l'utilisateur.
            if (leNiveau.Equals("Responsable stock"))
            {
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = false;
            }
            else
            {
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
            }


        }

        public void RefreshGrid()
        {
            if (lblRang.Text == "Admin")
            {
                uneconnexion = new ConnexionBase();
                unEditeur = new Crud_Editeur(uneconnexion);
                unEditeur.Recup_Table_Editeur_archive();
                RempGridEditeur(unEditeur.lesEditeurs);

                GridEditeur.Columns["_AncienNom"].Visible = false;

                GridEditeur.Update();
                GridEditeur.Refresh();
            }
            else
            {
                uneconnexion = new ConnexionBase();
                unEditeur = new Crud_Editeur(uneconnexion);
                unEditeur.Recup_Table_Editeur();
                RempGridEditeur(unEditeur.lesEditeurs);

                GridEditeur.Columns["_AncienNom"].Visible = false;

                GridEditeur.Update();
                GridEditeur.Refresh();
            }

        }

        //Méthode correspondant au click sur un des boutons
        public void clickBouton(MetroFramework.Controls.MetroTile btn)
        {
            btn.BackColor = Color.Green;
            btn.Text = "Valider";

            //le bouton annuler apparait
            btnAnnuler.Visible = true;

            //Desactive tous les autres boutons
            btnAjouter.Enabled = false;
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
            code.Text = "";
            txtNom.Text = "";
            DateTimeCreation.Text = "";
            txtMail.Text = "";
            txtCodePostal.Text = "";
            txtAdr.Text = "";
            txtTel.Text = "";
            txtFax.Text = "";
            txtVille.Text = "";

        }

        //Methode correspondant la validation des saisies utilisateurs
        public void clickValider(MetroFramework.Controls.MetroTile btn, string nomBtn)
        {

            btn.Text = nomBtn;
            btn.BackColor = Color.SteelBlue;
            btnAnnuler.Visible = false;

            //Déverouille les boutons modifier et supprimer en fonction des droits de l'utilisateur.
            if (leNiveau.Equals("Responsable stock"))
            {
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
            }
            else
            {
                btnAjouter.Enabled = true;
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnRechercher.Enabled = true;
            }

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

            //Reinistialisation des textbox
            code.Text = "";
            txtNom.Text = "";
            DateTimeCreation.Text = "";
            txtMail.Text = "";
            txtCodePostal.Text = "";
            txtAdr.Text = "";
            txtTel.Text = "";
            txtFax.Text = "";
            txtVille.Text = "";

        }
    }
}
