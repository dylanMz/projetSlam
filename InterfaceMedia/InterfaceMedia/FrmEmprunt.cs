﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Forms;
using LibMedia;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Interceptors;

namespace InterfaceMedia
{
    public partial class FrmEmprunt : MetroForm
    {
        //Déclaration des objet permettant l'execution des procédure
        private Crud_Emprunt Ajout;
        private Crud_Emprunt Updat;
        private Crud_Emprunt Suppr;
        private Crud_Emprunt Search;
        private Crud_Emprunt ajRetour;
        private Crud_Emprunt LivreNonRendu;
        private Crud_Emprunt LivreEmp;
        private String leNiveau;
        Thread home;

        public FrmEmprunt(String leNiveau)
        {
            InitializeComponent();

            this.leNiveau = leNiveau;
            lblRang.Text = this.leNiveau;

            //Instanciation des objet permettant l'execution des procédure
            Ajout = new Crud_Emprunt();
            Updat = new Crud_Emprunt();
            Suppr = new Crud_Emprunt();
            ajRetour = new Crud_Emprunt();
            LivreEmp = new Crud_Emprunt();
            LivreNonRendu = new Crud_Emprunt();
            Search = new Crud_Emprunt();

            //Création du mask exemplaire
            MtxtbxRefEx.Mask = "0000_00";
            MtxtbxRefEx.MaskInputRejected += new MaskInputRejectedEventHandler(MtxtbxRefEx_MaskInputRejected);

            //Rempli dès l'ouverture la DataGridView
            Crud_Emprunt Export = new Crud_Emprunt();
            GridEmprunt.DataSource = Export.afficheEmprunt();


        }

        #region Evenement

        //Bouton permettant de revenir a la page d'acceuil
        private void picHome_Click(object sender, EventArgs e)
        {
            //permet de récuperer le niveau de l'utilisateur
            leNiveau = lblRang.Text;

            this.Close();
            home = new Thread(openformAccueil);
            home.SetApartmentState(ApartmentState.STA);
            home.Start();
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            if (btnAjouter.Text.Equals("Ajouter"))
            {

                clickBouton(btnAjouter);

                btnAjouter.Enabled = true;
                dtRetour.Enabled = false;

            }
            else if (btnAjouter.Text.Equals("Valider"))
            {
                int numE = Int32.Parse(txtbxNumEmp.Text);
                DateTime dateEm = Convert.ToDateTime(dtEmprunt.Text);
                DateTime dateRet = Convert.ToDateTime(dtRetour.Text);
                DateTime dateRetP = Convert.ToDateTime(dtRetourPrevu.Text);
                Emprunt lEmprunt = new Emprunt(numE, MtxtbxRefEx.Text, dateEm, dateRet, dateRetP);

                if (Ajout.verifExemplaire(lEmprunt).Equals("0"))
                {

                    btDialog("L'exemplaire n'existe pas! Pour ajouter un exemplaire cliquer sur Recommencer", false);
                }
                else
                {
                    Ajout.insertEmprunt(lEmprunt);
                }

                clickValider(btnAjouter, "Ajouter");

            }
            //Actualise la DataGridView
            GridEmprunt.DataSource = Ajout.afficheEmprunt();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnModifier.Text.Equals("Modifier"))
            {
                clickBouton(btnModifier);

                btnModifier.Enabled = true;
            }
            else if (btnModifier.Text.Equals("Valider"))
            {
                int numE = Int32.Parse(txtbxNumEmp.Text);
                DateTime dateEm = Convert.ToDateTime(dtEmprunt.Text);
                DateTime dateRet = Convert.ToDateTime(dtRetour.Text);
                DateTime dateRetP = Convert.ToDateTime(dtRetourPrevu.Text);
                Emprunt lEmprunt = new Emprunt(numE, MtxtbxRefEx.Text, dateEm, dateRet, dateRetP);

                if (Updat.verifEmprunt(lEmprunt).Equals("0"))
                {
                    btDialog("L'emprunt n'existe pas!", true);

                }
                else
                {
                    Updat.updateEmprunt(lEmprunt);

                }
                clickValider(btnModifier, "Modifier");
            }
            //Actualise la DataGridView
            GridEmprunt.DataSource = Updat.afficheEmprunt();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (btnSupprimer.Text.Equals("Supprimer"))
            {
                clickBouton(btnSupprimer);

                btnSupprimer.Enabled = true;
                dtEmprunt.Enabled = false;
                dtRetour.Enabled = false;
                dtRetourPrevu.Enabled = false;

            }
            else if (btnSupprimer.Text.Equals("Valider"))
            {
                int numE = Int32.Parse(txtbxNumEmp.Text);
                DateTime dateEm = Convert.ToDateTime(dtEmprunt.Text);
                Emprunt lEmprunt = new Emprunt(numE, MtxtbxRefEx.Text);

                if (Suppr.verifEmprunt(lEmprunt).Equals("0"))
                {
                    btDialog("L'emprunt n'existe pas!", false);
                }
                else
                {
                    Suppr.deleteEmprunt(lEmprunt);
                }
                clickValider(btnSupprimer, "Supprimer");

            }
            //Actualise la DataGridView
            GridEmprunt.DataSource = Suppr.afficheEmprunt();
        }

        private void btnAjRetour_Click(object sender, EventArgs e)
        {
            if (btnAjRetour.Text.Equals("Ajouter un retour"))
            {
                clickBouton(btnAjRetour);

                btnAjRetour.Enabled = true;

                dtRetourPrevu.Enabled = false;
                dtEmprunt.Enabled = false;

            }
            else if (btnAjRetour.Text.Equals("Valider"))
            {
                int numE = Int32.Parse(txtbxNumEmp.Text);
                DateTime dateEm = Convert.ToDateTime(dtEmprunt.Text);
                DateTime dateRet = Convert.ToDateTime(dtRetour.Text);
                Emprunt lEmprunt = new Emprunt(numE, MtxtbxRefEx.Text, dateEm, dateRet);

                if (ajRetour.verifEmprunt(lEmprunt).Equals("0"))
                {
                    btDialog("L'emprunt n'existe pas!", false);
                }
                else
                {
                    ajRetour.modifDate_Retour(lEmprunt);
                }

                clickValider(btnAjRetour, "Ajouter un retour");

            }

            GridEmprunt.DataSource = ajRetour.afficheEmprunt();
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            if (btnSearchEmp.Text.Equals("Rechercher emprunt"))
            {
                clickBouton(btnSearchEmp);

                btnSearchEmp.Enabled = true;
                dtEmprunt.Enabled = false;
                dtRetour.Enabled = false;
                dtRetourPrevu.Enabled = false;

                GridEmprunt.DataSource = Search.afficheEmprunt();
            }
            else if (btnSearchEmp.Text.Equals("Valider"))
            {
                int numE = Int32.Parse(txtbxNumEmp.Text);
                Emprunt lEmprunt = new Emprunt(numE, MtxtbxRefEx.Text);

                if (Search.verifEmprunt(lEmprunt).Equals("0"))
                {
                    btDialog("L'emprunt n'existe pas!", false);
                }
                else
                {
                    GridEmprunt.DataSource = Search.rechercheEmprunt(lEmprunt);
                }


                clickValider(btnSearchEmp, "Rechercher emprunt");
            }
        }

        private void btnLivre_Click(object sender, EventArgs e)
        {
            if (btnLivre.Text.Equals("Rechercher livre"))
            {
                clickBouton(btnLivre);

                gpbxChoix.Visible = true;
                rbLivreEmprunter.Enabled = true;
                rbLivreNonRendu.Enabled = true;
                btnLivre.Enabled = true;
                MtxtbxRefEx.Enabled = false;
                txtbxNumEmp.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                dtDate.Enabled = true;

                GridEmprunt.DataSource = LivreEmp.afficheEmprunt();

            }
            else if (btnLivre.Text.Equals("Valider"))
            {

                if (rbLivreEmprunter.Checked == true)
                {

                    DateTime lDate = Convert.ToDateTime(dtDate.Text);

                    GridEmprunt.DataSource = LivreEmp.rechercheDate_Emprunt(lDate);
                }
                else if (rbLivreNonRendu.Checked == true)
                {
                    DateTime uDate = Convert.ToDateTime(dtDate.Text);

                    GridEmprunt.DataSource = LivreEmp.rechercheNonRendu(uDate);
                }
                else
                {
                    btDialog("Vous devez selectionner une proposition", true);
                }

                clickValider(btnLivre, "Rechercher livre");
                gpbxChoix.Visible = false;

            }
        }

        private void GridEmprunt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string dtNull = GridEmprunt.CurrentRow.Cells["dateRetour"].Value.ToString();
            txtbxNumEmp.Text = GridEmprunt.CurrentRow.Cells["emp_num"].Value.ToString();
            MtxtbxRefEx.Text = GridEmprunt.CurrentRow.Cells["ExempRef"].Value.ToString();
            dtEmprunt.Text = GridEmprunt.CurrentRow.Cells["dateEmprunt"].Value.ToString();
            dtRetourPrevu.Text = GridEmprunt.CurrentRow.Cells["dateRetourPrevu"].Value.ToString();
            Emprunt lemprunt = new Emprunt(Convert.ToInt16(GridEmprunt.CurrentRow.Cells["emp_num"].Value), GridEmprunt.CurrentRow.Cells["ExempRef"].Value.ToString());
            if (dtNull != "01/01/0001 00:00:00")
            {
                dtRetour.Text = dtNull;
            }

            lblNb.Text = "Deja " + Ajout.nbEmprunter(lemprunt) + " livres d'empruntés";
        }

        //Ouvre une boite de dialogue quand la saisie est incorrecte sur le Mask
        private void MtxtbxRefEx_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            btDialog("Désolé la saisie autorisé est de la forme 0000_00", true);
        }

        //Permet de remettre les bouton a 0 sans valider
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (btnLivre.Text.Equals("Valider"))
            {
                gpbxChoix.Visible = false;
                rbLivreEmprunter.Checked = false;
                rbLivreNonRendu.Checked = false;
                dtDate.Text = "";
            }

            //les boutons sont remis par defaut
            btnAjouter.BackColor = Color.SteelBlue;
            btnModifier.BackColor = Color.SteelBlue;
            btnSupprimer.BackColor = Color.SteelBlue;
            btnAjRetour.BackColor = Color.SteelBlue;
            btnLivre.BackColor = Color.SteelBlue;
            btnSearchEmp.BackColor = Color.SteelBlue;

            btnAjouter.Enabled = true;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
            btnAjRetour.Enabled = true;
            btnLivre.Enabled = true;
            btnSearchEmp.Enabled = true;

            btnAjouter.Text = "Ajouter";
            btnModifier.Text = "Modifier";
            btnSupprimer.Text = "Supprimer";
            btnAjRetour.Text = "Ajouter un retour";
            btnLivre.Text = "Rechercher livre";
            btnSearchEmp.Text = "Rechercher emprunt";

            txtbxNumEmp.Enabled = false;
            MtxtbxRefEx.Enabled = false;
            dtEmprunt.Enabled = false;
            dtRetour.Enabled = false;
            dtRetourPrevu.Enabled = false;

            txtbxNumEmp.BackColor = Color.Silver;
            MtxtbxRefEx.BackColor = Color.Silver;

            //le bouton annuler disparait
            btnAnnuler.Visible = false;

            //Actualise la DataGridView
            GridEmprunt.DataSource = ajRetour.afficheEmprunt();

        }

        //Permet de quitter l'application
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Méthodes

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
            btnAjRetour.Enabled = false;
            btnSearchEmp.Enabled = false;
            btnLivre.Enabled = false;

            //Les textbox à remplir pour l'insertion se déverouille
            txtbxNumEmp.Enabled = true;
            MtxtbxRefEx.Enabled = true;
            dtEmprunt.Enabled = true;
            dtRetour.Enabled = true;
            dtRetourPrevu.Enabled = true;


            //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
            MtxtbxRefEx.BackColor = Color.White;
            txtbxNumEmp.BackColor = Color.White;

            //Reinistialisation des textbox
            txtbxNumEmp.Text = "";
            MtxtbxRefEx.Text = "";
            dtRetourPrevu.Text = "";
            dtRetour.Text = "";
            dtEmprunt.Text = "";
            dtDate.Text = "";
            rbLivreEmprunter.Checked = false;
            rbLivreNonRendu.Checked = false;


        }

        //Methode correspondant la validation des saisies utilisateurs
        public void clickValider(MetroFramework.Controls.MetroTile btn, string nomBtn)
        {

            btn.Text = nomBtn;
            btn.BackColor = Color.SteelBlue;
            btnAnnuler.Visible = false;

            //Re active les boutons
            btnAjouter.Enabled = true;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
            btnAjRetour.Enabled = true;
            btnSearchEmp.Enabled = true;
            btnLivre.Enabled = true;

            //Les textbox sont inacessibles.
            txtbxNumEmp.Enabled = false;
            MtxtbxRefEx.Enabled = false;
            dtEmprunt.Enabled = false;
            dtRetour.Enabled = false;
            dtRetourPrevu.Enabled = false;

            //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
            MtxtbxRefEx.BackColor = Color.Silver;
            txtbxNumEmp.BackColor = Color.Silver;

            //Reinistialisation des textbox
            txtbxNumEmp.Text = "";
            MtxtbxRefEx.Text = "";
            dtRetourPrevu.Text = "";
            dtRetour.Text = "";
            dtEmprunt.Text = "";
            dtDate.Text = "";
            rbLivreEmprunter.Checked = false;
            rbLivreNonRendu.Checked = false;
        }

        //Methode affichant une boite de dialogue avec un message personnaliser
        public void btDialog(String leMessage, Boolean zeroOuUn)
        {
            DialogResult result;
            if (zeroOuUn == true)
            {
                MessageBox.Show(leMessage, "Médiateque", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (zeroOuUn == false)
            {
                result = MessageBox.Show(leMessage, "Médiateque", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

                if (result == DialogResult.Retry)
                {
                    this.Close();
                    home = new Thread(openExemp);
                    home.SetApartmentState(ApartmentState.STA);
                    home.Start();
                }
            }
        }

        //Permet quand on clique sur une ligne de la DataGridView de remplir les champs
        private void openExemp()
        {
            Application.Run(new Frmlivre(leNiveau));
        }

        //Ouvre la form acceuil
        private void openformAccueil()
        {
            Application.Run(new FrmAccueilTest(leNiveau));
        }

        #endregion


    }
}
