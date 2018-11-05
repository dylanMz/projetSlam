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
    public partial class FrmAuteur : MetroForm
    {
        Thread th;
        private ConnexionBase connexion;
        private Crud_Auteur unAuteur;
        private Crud_Auteur wpaysAuteur;
        public List<String> listePays;

        public FrmAuteur()
        {
            InitializeComponent();
            connexion = new ConnexionBase();
            unAuteur = new Crud_Auteur(connexion);
            dgvAuteur.DataSource = unAuteur.afficheAuteur();
        }

        #region Constructeur.s
        //public List<String> FrmAuteur()
        //{

 //       }
        #endregion
            
        #region Code Boutons
        //bouton ajouter
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
                btnRechercher.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                txtNom.Enabled = true;
                txtPrenom.Enabled = true;
                txtPseudo.Enabled = true;
                txtBio.Enabled = true;
                dtDateNaiss.Enabled = true;
                rdoVivant.Enabled = true;
                rdoDecede.Enabled = true;
                cmbPays.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                txtPrenom.BackColor = Color.White;
                txtPseudo.BackColor = Color.White;
                txtBio.BackColor = Color.White;
                dtDateNaiss.BackColor = Color.White;
                rdoVivant.BackColor = Color.WhiteSmoke;
                rdoDecede.BackColor = Color.WhiteSmoke;
                cmbPays.BackColor = Color.White;

            }

            else if (btnAjouter.Text == "Valider")
            {
                btnAjouter.Text = "Ajouter";
                btnAjouter.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnModifier.Enabled = true;
                btnRechercher.Enabled = true;

                //Les textbox sont inacessibles.
                txtNom.Enabled = false;
                txtPrenom.Enabled = false;
                txtPseudo.Enabled = false;
                txtBio.Enabled = false;
                dtDateNaiss.Enabled = false;
                rdoVivant.Enabled = false;
                rdoDecede.Enabled = false;
                cmbPays.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;
                txtPrenom.BackColor = Color.Silver;
                txtPseudo.BackColor = Color.Silver;
                txtBio.BackColor = Color.Silver;
                dtDateNaiss.BackColor = Color.Silver;
                rdoVivant.BackColor = Color.Silver;
                rdoDecede.BackColor = Color.Silver;
                cmbPays.BackColor = Color.Silver;
            }
        }

        //bouton modifier
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
                btnRechercher.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                txtNom.Enabled = true;
                txtPrenom.Enabled = true;
                txtPseudo.Enabled = true;
                txtBio.Enabled = true;
                dtDateNaiss.Enabled = true;
                rdoVivant.Enabled = true;
                rdoDecede.Enabled = true;
                cmbPays.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                txtPrenom.BackColor = Color.White;
                txtPseudo.BackColor = Color.White;
                txtBio.BackColor = Color.White;
                dtDateNaiss.BackColor = Color.White;
                rdoVivant.BackColor = Color.WhiteSmoke;
                rdoDecede.BackColor = Color.WhiteSmoke;
                cmbPays.BackColor = Color.White;
            }

            else if (btnModifier.Text == "Valider")
            {
                btnModifier.Text = "Modifier";
                btnModifier.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnAjouter.Enabled = true;
                btnRechercher.Enabled = true;

                //Les textbox sont inacessibles.
                txtNom.Enabled = false;
                txtPrenom.Enabled = false;
                txtPseudo.Enabled = false;
                txtBio.Enabled = false;
                dtDateNaiss.Enabled = false;
                rdoVivant.Enabled = false;
                rdoDecede.Enabled = false;
                cmbPays.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;
                txtPrenom.BackColor = Color.Silver;
                txtPseudo.BackColor = Color.Silver;
                txtBio.BackColor = Color.Silver;
                dtDateNaiss.BackColor = Color.Silver;
                rdoVivant.BackColor = Color.Silver;
                rdoDecede.BackColor = Color.Silver;
                cmbPays.BackColor = Color.Silver;
            }
        }

        //bouton rechercher
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (btnRechercher.Text == "Rechercher")
            {
                btnRechercher.BackColor = Color.Green;
                btnRechercher.Text = "Valider";

                //le bouton annuler apparait
                btnAnnuler.Visible = true;

                //Les ou le textbox.s a remplir pour la recherche se déverouille
                txtCode.Enabled = true;
                txtNom.Enabled = true;
                txtPseudo.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtCode.BackColor = Color.White;
                txtNom.BackColor = Color.White;
                txtPseudo.BackColor = Color.White;

                //Desactive tous les autres boutons
                btnAjouter.Enabled = false;
                btnModifier.Enabled = false;
            }

            else if (btnRechercher.Text == "Valider")
            {
                btnRechercher.Text = "Rechercher";
                btnRechercher.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnAjouter.Enabled = true;
                btnModifier.Enabled = true;

                //Les textbox sont inacessibles.
                txtCode.Enabled = false;
                txtNom.Enabled = false;
                txtPseudo.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtCode.BackColor = Color.Silver;
                txtNom.BackColor = Color.Silver;
                txtPseudo.BackColor = Color.Silver;

            }
        }

        //bouton annuler
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //les boutons sont remis par defaut
            btnAjouter.BackColor = Color.SteelBlue;
            btnModifier.BackColor = Color.SteelBlue;
            btnRechercher.BackColor = Color.SteelBlue;

            btnAjouter.Enabled = true;
            btnModifier.Enabled = true;
            btnRechercher.Enabled = true;

            btnAjouter.Text = "Ajouter";
            btnModifier.Text = "Modifier";
            btnRechercher.Text = "Rechercher";

            //Vide des champs
            txtCode.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtPseudo.Text = "";
            txtBio.Text = "";
            rdoVivant.Checked = false;
            rdoDecede.Checked = false;

            //Les textbox sont inacessibles.
            txtCode.Enabled = false;
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            txtPseudo.Enabled = false;
            txtBio.Enabled = false;
            dtDateNaiss.Enabled = false;
            rdoVivant.Enabled = false;
            rdoDecede.Enabled = false;
            cmbPays.Enabled = false;

            //Le background color des textbox change de couleur pour indiquer qu'elles sont verrouillées
            txtCode.BackColor = Color.Silver;
            txtNom.BackColor = Color.Silver;
            txtPrenom.BackColor = Color.Silver;
            txtPseudo.BackColor = Color.Silver;
            txtBio.BackColor = Color.Silver;
            dtDateNaiss.BackColor = Color.Silver;
            rdoVivant.BackColor = Color.Silver;
            rdoDecede.BackColor = Color.Silver;
            cmbPays.BackColor = Color.Silver;

            //le bouton annuler disparait
            btnAnnuler.Visible = false;
        }

        //bouton quitter
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //image retour menu home
        private void picHome_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openformAccueil);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        //ouverture du formulaire accueil
        private void openformAccueil()
        {
            Application.Run(new FrmAccueilTest());
        }

        private void rdoDecede_CheckedChanged(object sender, EventArgs e)
        {
            //Affiche et deverouille le dateTime de décés.
            dtStatut.Visible = true;
            dtStatut.Enabled = true;
        }

        private void rdoVivant_CheckedChanged(object sender, EventArgs e)
        {
            //rend invisible et verouille le dateTime de décés
            dtStatut.Visible = false;
            dtStatut.Enabled = false;
        }

        private void cmbPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbPays.DisplayMember = wpaysAuteur.paysAuteur();
        }

        private void dgvAuteur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dgvAuteur.CurrentRow.Cells[0].Value.ToString();
            txtNom.Text = dgvAuteur.CurrentRow.Cells[1].Value.ToString();
            txtPrenom.Text = dgvAuteur.CurrentRow.Cells[2].Value.ToString();
            txtPseudo.Text = dgvAuteur.CurrentRow.Cells[3].Value.ToString();
            //dtDateNaiss.Value = dgvAuteur.CurrentRow.Cells[0].Value.ToString();
            //dtStatut.Value = dgvAuteur.CurrentRow.Cells[0].Value.ToString();
            if (dgvAuteur.CurrentRow.Cells[5].Value.ToString() == "")
            {
                rdoVivant.Checked = true;
                rdoDecede.Checked = false;
            }
            else
            {
                rdoVivant.Checked = false;
                rdoDecede.Checked = true;
                //dtStatut.Value = dgvAuteur.CurrentRow.Cells[0].Value.ToString();
            }
            cmbPays.Text = dgvAuteur.CurrentRow.Cells[6].Value.ToString();
            txtBio.Text = dgvAuteur.CurrentRow.Cells[7].Value.ToString();
        }

    }
    #endregion

}
