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
        public List<String> listePays;
        private String leMessage;
        private String pays;
        private String leNiveau;


        public FrmAuteur(String leNiveau)
        {
            InitializeComponent();
            connexion = new ConnexionBase();
            unAuteur = new Crud_Auteur();
            dgvAuteur.DataSource = unAuteur.afficheAuteur();
            remp_cmbPays();

            this.leNiveau = leNiveau;
            lblRang.Text = this.leNiveau;
        }

        #region Méthodes
        public void remp_cmbPays()
        {
            listePays = unAuteur.CreateListPays();

            int i;
            for (i = 0; i<listePays.LongCount(); i++)
            {
                cmbPays.Items.Add(listePays[i]);
            }
        }

        
        #endregion

        #region Code Boutons
        //bouton ajouter
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            

            if (btnAjouter.Text == "Ajouter")
            {
                //Vide des champs
                txtCode.Text = "";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtPseudo.Text = "";
                txtBio.Text = "";
                rdoVivant.Checked = false;
                rdoDecede.Checked = false;
                chkNouvPays.Checked = false;

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
                chkNouvPays.Enabled = true;
                chkDateNaiss.Enabled = true;
                txtPays.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                txtPrenom.BackColor = Color.White;
                txtPseudo.BackColor = Color.White;
                txtBio.BackColor = Color.White;
                dtDateNaiss.BackColor = Color.White;
                rdoVivant.BackColor = Color.WhiteSmoke;
                rdoDecede.BackColor = Color.WhiteSmoke;
                cmbPays.BackColor = Color.White;

                //On verouille le DGV
                dgvAuteur.Enabled = false;

                //maj du dgv
                dgvAuteur.DataSource = unAuteur.afficheAuteur();

            }
            else if (btnAjouter.Text == "Valider")
            {
                //défini ou pays prend sa valeur
                if (chkNouvPays.Checked == true) //si on ajoute un nouveau pays
                {
                    pays = txtPays.Text;
                }
                else if (chkNouvPays.Checked == false) //si on prend un pays deja dans la liste
                {
                    pays = cmbPays.Text;
                }

                
                //ajout de l'auteur à la bdd
                if (chkDateNaiss.Checked == true && rdoDecede.Checked == true) //on a une date de naisance et une date de décès
                {
                    Auteur lAuteur = new Auteur(txtNom.Text, txtPrenom.Text, txtPseudo.Text, DateTime.Parse(dtDateNaiss.Text), DateTime.Parse(dtStatut.Text), pays, txtBio.Text);
                    unAuteur.ajouterAuteur(lAuteur);
                }
                else if (chkDateNaiss.Checked == false && rdoDecede.Checked == false) //on a une date de naissance mais pas de date de décès
                {
                    Auteur lAuteur = new Auteur(txtNom.Text, txtPrenom.Text, txtPseudo.Text, DateTime.Parse(dtDateNaiss.Text), null, pays, txtBio.Text);
                    unAuteur.ajouterAuteur(lAuteur);
                }
                else if (chkDateNaiss.Checked == true && rdoDecede.Checked == false) //on a pas de date de naissance ni de date de deces
                {
                    Auteur lAuteur = new Auteur(txtNom.Text, txtPrenom.Text, txtPseudo.Text, null, null, pays, txtBio.Text);
                    unAuteur.ajouterAuteur(lAuteur);
                }

                //btnValider --> btn Ajouter
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
                chkNouvPays.Enabled = false;
                chkDateNaiss.Enabled = false;
                txtPays.Enabled = false;


                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;
                txtPrenom.BackColor = Color.Silver;
                txtPseudo.BackColor = Color.Silver;
                txtBio.BackColor = Color.Silver;
                dtDateNaiss.BackColor = Color.Silver;
                rdoVivant.BackColor = Color.Silver;
                rdoDecede.BackColor = Color.Silver;
                cmbPays.BackColor = Color.Silver;

                //on déverouille le DGV
                dgvAuteur.Enabled = true;
            }
            
        }

        //bouton modifier
        private void btnModifier_Click(object sender, EventArgs e)
        {
          
            if (txtCode.Text == "")
            {
                leMessage = "Sélectionnez un auteur dans la liste pour le modifier";
                btDialog(leMessage);

            }
            else if (btnModifier.Text == "Modifier")
            {
                //ajout de l'auteur à la bdd
                if (chkDateNaiss.Checked == true && rdoDecede.Checked == true) //on a une date de naisance et une date de décès
                {
                    Auteur lAuteur = new Auteur(txtNom.Text, txtPrenom.Text, txtPseudo.Text, DateTime.Parse(dtDateNaiss.Text), DateTime.Parse(dtStatut.Text), pays, txtBio.Text);
                    unAuteur.modifierAuteur(lAuteur);
                }
                else if (chkDateNaiss.Checked == false && rdoDecede.Checked == false) //on a une date de naissance mais pas de date de décès
                {
                    Auteur lAuteur = new Auteur(txtNom.Text, txtPrenom.Text, txtPseudo.Text, DateTime.Parse(dtDateNaiss.Text), null, pays, txtBio.Text);
                    unAuteur.modifierAuteur(lAuteur);
                }
                else if (chkDateNaiss.Checked == true && rdoDecede.Checked == false) //on a pas de date de naissance ni de date de deces
                {
                    Auteur lAuteur = new Auteur(txtNom.Text, txtPrenom.Text, txtPseudo.Text, null, null, pays, txtBio.Text);
                    unAuteur.modifierAuteur(lAuteur);
                }

                //modifications visuelles
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
                chkNouvPays.Enabled = true;
                chkDateNaiss.Enabled = true;


                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                txtPrenom.BackColor = Color.White;
                txtPseudo.BackColor = Color.White;
                txtBio.BackColor = Color.White;
                dtDateNaiss.BackColor = Color.White;
                rdoVivant.BackColor = Color.WhiteSmoke;
                rdoDecede.BackColor = Color.WhiteSmoke;
                cmbPays.BackColor = Color.White;

                //On verouille le DGV
                dgvAuteur.Enabled = false;
            }

            else if (btnModifier.Text == "Valider")
            {
                //défini ou pays doit récupérer sa valeur
                if (chkNouvPays.Checked == true) // si on ajoute un nouveau pays
                {
                    pays = txtPays.Text;
                }
                else if (chkNouvPays.Checked == false) //si on prend un pays deja dans la liste
                {
                    pays = cmbPays.Text;
                }

                //modifiaction de l'auteur dans la bdd
                Auteur lAuteur = new Auteur(int.Parse(txtCode.Text), txtNom.Text, txtPrenom.Text, txtPseudo.Text, DateTime.Parse(dtDateNaiss.Text), DateTime.Parse(dtStatut.Text), pays, txtBio.Text);
                unAuteur.modifierAuteur(lAuteur);

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
                chkNouvPays.Enabled = false;
                chkDateNaiss.Enabled = false;


                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtNom.BackColor = Color.Silver;
                txtPrenom.BackColor = Color.Silver;
                txtPseudo.BackColor = Color.Silver;
                txtBio.BackColor = Color.Silver;
                dtDateNaiss.BackColor = Color.Silver;
                rdoVivant.BackColor = Color.Silver;
                rdoDecede.BackColor = Color.Silver;
                cmbPays.BackColor = Color.Silver;

                //Vide des champs
                txtCode.Text = "";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtPseudo.Text = "";
                txtBio.Text = "";
                rdoVivant.Checked = false;
                rdoDecede.Checked = false;

                //on déverouille le DGV
                dgvAuteur.Enabled = true;
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

                //On verouille le DGV
                dgvAuteur.Enabled = false;

                //Vide des champs
                txtCode.Text = "";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtPseudo.Text = "";
                txtBio.Text = "";
                rdoVivant.Checked = false;
                rdoDecede.Checked = false;
            }

            else if (btnRechercher.Text == "Valider")
            {
                
                if (txtCode.Text != "" || txtNom.Text != "" || txtPseudo.Text != "")
                {
                    //recherche de l'auteur dans la bdd
                    Auteur lAuteur = new Auteur(int.Parse(txtCode.Text), txtNom.Text, txtPseudo.Text);
                    unAuteur.rechercheAuteur(lAuteur);
                    
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

                    //on déverouille le DGV
                    dgvAuteur.Enabled = true;

                    //Vide des champs
                    txtCode.Text = "";
                    txtNom.Text = "";
                    txtPrenom.Text = "";
                    txtPseudo.Text = "";
                    txtBio.Text = "";
                    rdoVivant.Checked = false;
                    rdoDecede.Checked = false;
                }

                else //if (txtCode.Text == "" && txtNom.Text == "" && txtPseudo.Text == "")
                {
                    leMessage = "Rentrez au moins un critère de recherche" + txtCode.Text ;
                    btDialog(leMessage);
                }

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
            chkNouvPays.Checked = false;

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
            chkNouvPays.Enabled = false;
            dtStatut.Visible = false;
            chkDateNaiss.Enabled = false;
            txtPays.Enabled = false;


            //on déverouille le DGV
            dgvAuteur.Enabled = true;

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
            //permet de récuperer le niveau de l'utilisateur
            leNiveau = lblRang.Text;
            this.Close();
            th = new Thread(openformAccueil);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        //ouverture du formulaire accueil
        private void openformAccueil()
        {
            Application.Run(new FrmAccueilTest(leNiveau));
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

        private void dgvAuteur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dgvAuteur.CurrentRow.Cells["Id"].Value.ToString();
            txtNom.Text = dgvAuteur.CurrentRow.Cells["Nom"].Value.ToString();
            txtPrenom.Text = dgvAuteur.CurrentRow.Cells["Prénom"].Value.ToString();
            txtPseudo.Text = dgvAuteur.CurrentRow.Cells["Pseudo"].Value.ToString();
            dtDateNaiss.Text = dgvAuteur.CurrentRow.Cells["Date_Naissance"].Value.ToString();
            dtStatut.Text = dgvAuteur.CurrentRow.Cells["Date_Décès"].Value.ToString();
            if (dgvAuteur.CurrentRow.Cells["Date_Décès"].Value.ToString() == "")
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
            cmbPays.Text = dgvAuteur.CurrentRow.Cells["Pays"].Value.ToString();
            txtBio.Text = dgvAuteur.CurrentRow.Cells["Biographie"].Value.ToString();
        }

        //message erreur
        public void btDialog(String leMessage)
        {
            // Affiche une boite de dialogue pour indiquer une erreur
            MessageBox.Show(leMessage, "Erreur",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void chkNouvPays_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNouvPays.Checked == true)
            {
                cmbPays.Visible = false;
                txtPays.Visible = true;
                
            }
            else
            {
                cmbPays.Visible = true;
                txtPays.Visible = false;
                
            }
            
        }

        private void chkDateNaiss_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDateNaiss.Checked == true)
            {
                dtDateNaiss.Enabled = false;
            }
            else
            {
                dtDateNaiss.Enabled = true;
            }
        }
    }
    #endregion

}
