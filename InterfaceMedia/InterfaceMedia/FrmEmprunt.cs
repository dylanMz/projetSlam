using System;
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

namespace InterfaceMedia
{
    public partial class FrmEmprunt : MetroForm
    {

        private Crud_Emprunt Ajout;
        private Crud_Emprunt Updat;
        private Crud_Emprunt Suppr;
        private Crud_Emprunt Search;
        private Crud_Emprunt ajRetour;
        private Crud_Emprunt LivreNonRendu;
        private Crud_Emprunt LivreEmp;
        Thread home;

        public FrmEmprunt()
        {
            InitializeComponent();
            Ajout = new Crud_Emprunt();
            Updat = new Crud_Emprunt();
            Suppr = new Crud_Emprunt();
            ajRetour = new Crud_Emprunt(); 
            LivreEmp = new Crud_Emprunt();
            LivreNonRendu = new Crud_Emprunt();
            Search = new Crud_Emprunt();

            Crud_Emprunt Export = new Crud_Emprunt();
            GridEmprunt.DataSource = Export.afficheEmprunt();
        }


        

        private void picHome_Click(object sender, EventArgs e)
        {
            this.Close();
            home = new Thread(openformAccueil);
            home.SetApartmentState(ApartmentState.STA);
            home.Start();

        }

        private void openformAccueil()
        {
            Application.Run(new FrmAccueilTest());
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            //activationBouton(btnAjouter, btnAjouter.Text);
            if (btnAjouter.Text.Equals("Ajouter"))
            {
                btnAjouter.BackColor = Color.Green;
                btnAjouter.Text = "Valider";

                //le bouton annuler apparait
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnAjRetour.Enabled = false;
                btnSearchEmp.Enabled = false;
                btnLivre.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                txtbxNumEmp.Enabled = true;
                txtbxRefEx.Enabled = true;
                dtEmprunt.Enabled = true;
                dtRetour.Enabled = true;
                dtRetourPrevu.Enabled = true;


                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtbxRefEx.BackColor = Color.White;
                txtbxNumEmp.BackColor = Color.White;

                //Reinistialisation des textbox
                txtbxNumEmp.Text = "";
                txtbxRefEx.Text = "";
                dtRetourPrevu.Text = "";
                dtRetour.Text = "";
                dtEmprunt.Text = "";

            }
            else if (btnAjouter.Text.Equals("Valider"))
            {
                int numE = Int32.Parse(txtbxNumEmp.Text);
                DateTime dateEm = Convert.ToDateTime(dtEmprunt.Text);
                DateTime dateRet = Convert.ToDateTime(dtRetour.Text);
                DateTime dateRetP = Convert.ToDateTime(dtRetourPrevu.Text);
                Emprunt lEmprunt = new Emprunt(numE, txtbxRefEx.Text, dateEm, dateRet, dateRetP);

                Ajout.insertEmprunt(lEmprunt);

                btnAjouter.Text = "Ajouter";
                btnAjouter.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
                btnAjRetour.Enabled = true;
                btnSearchEmp.Enabled = true;
                btnLivre.Enabled = true;

                //Les textbox sont inacessibles.
                txtbxNumEmp.Enabled = false;
                txtbxRefEx.Enabled = false;
                dtEmprunt.Enabled = false;
                dtRetour.Enabled = false;
                dtRetourPrevu.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtbxRefEx.BackColor = Color.Silver;
                txtbxNumEmp.BackColor = Color.Silver;

                //Reinistialisation des textbox
                txtbxNumEmp.Text = "";
                txtbxRefEx.Text = "";
                dtRetourPrevu.Text = "";
                dtRetour.Text = "";
                dtEmprunt.Text = "";

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
                btnAjRetour.Enabled = false;
                btnSearchEmp.Enabled = false;
                btnLivre.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                txtbxNumEmp.Enabled = true;
                txtbxRefEx.Enabled = true;
                dtEmprunt.Enabled = true;
                dtRetour.Enabled = true;
                dtRetourPrevu.Enabled = true;


                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtbxRefEx.BackColor = Color.White;
                txtbxNumEmp.BackColor = Color.White;

                //Reinistialisation des textbox
                txtbxNumEmp.Text = "";
                txtbxRefEx.Text = "";
                dtRetourPrevu.Text = "";
                dtRetour.Text = "";
                dtEmprunt.Text = "";

            }
            else if (btnModifier.Text.Equals("Valider"))
            {
                int numE = Int32.Parse(txtbxNumEmp.Text);
                DateTime dateEm = Convert.ToDateTime(dtEmprunt.Text);
                DateTime dateRet = Convert.ToDateTime(dtRetour.Text);
                DateTime dateRetP = Convert.ToDateTime(dtRetourPrevu.Text);
                Emprunt lEmprunt = new Emprunt(numE, txtbxRefEx.Text, dateEm, dateRet, dateRetP);

                Updat.updateEmprunt(lEmprunt);

                btnModifier.Text = "Modifier";
                btnModifier.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnAjouter.Enabled = true;
                btnSupprimer.Enabled = true;
                btnAjRetour.Enabled = true;
                btnSearchEmp.Enabled = true;
                btnLivre.Enabled = true;

                //Les textbox sont inacessibles.
                txtbxNumEmp.Enabled = false;
                txtbxRefEx.Enabled = false;
                dtEmprunt.Enabled = false;
                dtRetour.Enabled = false;
                dtRetourPrevu.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtbxRefEx.BackColor = Color.Silver;
                txtbxNumEmp.BackColor = Color.Silver;

                //Reinistialisation des textbox
                txtbxNumEmp.Text = "";
                txtbxRefEx.Text = "";
                dtRetourPrevu.Text = "";
                dtRetour.Text = "";
                dtEmprunt.Text = "";

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
                btnAjRetour.Enabled = false;
                btnSearchEmp.Enabled = false;
                btnLivre.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                txtbxNumEmp.Enabled = true;
                txtbxRefEx.Enabled = true;


                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtbxRefEx.BackColor = Color.White;
                txtbxNumEmp.BackColor = Color.White;

                //Reinistialisation des textbox
                txtbxNumEmp.Text = "";
                txtbxRefEx.Text = "";
                dtRetourPrevu.Text = "";
                dtRetour.Text = "";
                dtEmprunt.Text = "";

            }
            else if (btnSupprimer.Text.Equals("Valider"))
            {
                int numE = Int32.Parse(txtbxNumEmp.Text);
                DateTime dateEm = Convert.ToDateTime(dtEmprunt.Text);
                Emprunt lEmprunt = new Emprunt(numE, txtbxRefEx.Text);

                Suppr.deleteEmprunt(lEmprunt);

                btnSupprimer.Text = "Supprimer";
                btnSupprimer.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnAjouter.Enabled = true;
                btnModifier.Enabled = true;
                btnAjRetour.Enabled = true;
                btnSearchEmp.Enabled = true;
                btnLivre.Enabled = true;

                //Les textbox sont inacessibles.
                txtbxNumEmp.Enabled = false;
                txtbxRefEx.Enabled = false;
                dtEmprunt.Enabled = false;
                dtRetour.Enabled = false;
                dtRetourPrevu.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtbxRefEx.BackColor = Color.Silver;
                txtbxNumEmp.BackColor = Color.Silver;

                //Reinistialisation des textbox
                txtbxNumEmp.Text = "";
                txtbxRefEx.Text = "";
                dtRetourPrevu.Text = "";
                dtRetour.Text = "";
                dtEmprunt.Text = "";
            }
        }

        private void btnAjRetour_Click(object sender, EventArgs e)
        {
            if (btnAjRetour.Text.Equals("Ajouter un retour"))
            {
                btnAjRetour.BackColor = Color.Green;
                btnAjRetour.Text = "Valider";

                //le bouton annuler apparait
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnAjouter.Enabled = false;
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnSearchEmp.Enabled = false;
                btnLivre.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                txtbxNumEmp.Enabled = true;
                txtbxRefEx.Enabled = true;
                dtRetour.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtbxRefEx.BackColor = Color.White;
                txtbxNumEmp.BackColor = Color.White;

                //Reinistialisation des textbox
                txtbxNumEmp.Text = "";
                txtbxRefEx.Text = "";
                dtRetourPrevu.Text = "";
                dtRetour.Text = "";
                dtEmprunt.Text = "";

            }
            else if (btnAjRetour.Text.Equals("Valider"))
            {
                int numE = Int32.Parse(txtbxNumEmp.Text);
                DateTime dateEm = Convert.ToDateTime(dtEmprunt.Text);
                DateTime dateRet = Convert.ToDateTime(dtRetour.Text);
                Emprunt lEmprunt = new Emprunt(numE, txtbxRefEx.Text, dateEm, dateRet);

                ajRetour.modifDate_Retour(lEmprunt);

                btnAjRetour.Text = "Ajouter un retour";
                btnAjRetour.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnAjouter.Enabled = true;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
                btnAjRetour.Enabled = true;
                btnLivre.Enabled = true;

                //Les textbox sont inacessibles.
                txtbxNumEmp.Enabled = false;
                txtbxRefEx.Enabled = false;
                dtEmprunt.Enabled = false;
                dtRetour.Enabled = false;
                dtRetourPrevu.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtbxRefEx.BackColor = Color.Silver;
                txtbxNumEmp.BackColor = Color.Silver;

                //Reinistialisation des textbox
                txtbxNumEmp.Text = "";
                txtbxRefEx.Text = "";
                dtRetourPrevu.Text = "";
                dtRetour.Text = "";
                dtEmprunt.Text = "";
            }
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            if (btnSearchEmp.Text.Equals("Rechercher emprunt"))
            {
                btnSearchEmp.BackColor = Color.Green;
                btnSearchEmp.Text = "Valider";

                //le bouton annuler apparait
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnAjouter.Enabled = false;
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnAjRetour.Enabled = false;
                btnLivre.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                txtbxNumEmp.Enabled = true;
                txtbxRefEx.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtbxRefEx.BackColor = Color.White;
                txtbxNumEmp.BackColor = Color.White;

                //Reinistialisation des textbox
                txtbxNumEmp.Text = "";
                txtbxRefEx.Text = "";
                dtRetourPrevu.Text = "";
                dtRetour.Text = "";
                dtEmprunt.Text = "";

            }
            else if (btnSearchEmp.Text.Equals("Valider"))
            {
                int numE = Int32.Parse(txtbxNumEmp.Text);
                Emprunt lEmprunt = new Emprunt(numE, txtbxRefEx.Text);

                Search.rechercheEmprunt(lEmprunt);

                btnSearchEmp.Text = "Rechercher emprunt";
                btnSearchEmp.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnAjouter.Enabled = true;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
                btnAjRetour.Enabled = true;
                btnLivre.Enabled = true;

                //Les textbox sont inacessibles.
                txtbxNumEmp.Enabled = false;
                txtbxRefEx.Enabled = false;
                dtEmprunt.Enabled = false;
                dtRetour.Enabled = false;
                dtRetourPrevu.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtbxRefEx.BackColor = Color.Silver;
                txtbxNumEmp.BackColor = Color.Silver;

                //Reinistialisation des textbox
                txtbxNumEmp.Text = "";
                txtbxRefEx.Text = "";
                dtRetourPrevu.Text = "";
                dtRetour.Text = "";
                dtEmprunt.Text = "";

            }
        }

        private void btnLivre_Click(object sender, EventArgs e)
        {
            if (btnLivre.Text.Equals("Rechercher livre"))
            {
                btnModifier.BackColor = Color.Green;
                btnModifier.Text = "Valider";
                gpbxChoix.Visible = true;
                //le bouton annuler apparait
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnAjouter.Enabled = false;
                btnSupprimer.Enabled = false;
                btnAjRetour.Enabled = false;
                btnSearchEmp.Enabled = false;
                btnModifier.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                txtbxNumEmp.Enabled = true;
                txtbxRefEx.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtbxRefEx.BackColor = Color.White;
                txtbxNumEmp.BackColor = Color.White;

                //Reinistialisation des textbox
                txtbxNumEmp.Text = "";
                txtbxRefEx.Text = "";
                dtRetourPrevu.Text = "";
                dtRetour.Text = "";
                dtEmprunt.Text = "";
                dtDate.Text = "";
                rbLivreEmprunter.Checked = false;
                rbLivreNonRendu.Checked = false;

            }
            else if (btnLivre.Text.Equals("Valider"))
            {

                if(rbLivreEmprunter.Checked == true)
                {

                    DateTime Date = Convert.ToDateTime(dtDate.Text);

                    //GridEmprunt.DataSource = LivreNonRendu.rechercheDate_Emprunt(;
                }
                
                //Updat.updateEmprunt(lEmprunt);

                btnLivre.Text = "Modifier";
                btnLivre.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnAjouter.Enabled = true;
                btnSupprimer.Enabled = true;
                btnAjRetour.Enabled = true;
                btnSearchEmp.Enabled = true;
                btnModifier.Enabled = true;

                //Les textbox sont inacessibles.
                txtbxNumEmp.Enabled = false;
                txtbxRefEx.Enabled = false;
                dtEmprunt.Enabled = false;
                dtRetour.Enabled = false;
                dtRetourPrevu.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtbxRefEx.BackColor = Color.Silver;
                txtbxNumEmp.BackColor = Color.Silver;

                //Reinistialisation des textbox
                txtbxNumEmp.Text = "";
                txtbxRefEx.Text = "";
                dtRetourPrevu.Text = "";
                dtRetour.Text = "";
                dtEmprunt.Text = "";
                dtDate.Text = "";
                rbLivreEmprunter.Checked = false;
                rbLivreNonRendu.Checked = false;

            }
        }







        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if(btnLivre.Text.Equals("Valider"))
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
            txtbxRefEx.Enabled = false;
            dtEmprunt.Enabled = false;
            dtRetour.Enabled = false;
            dtRetourPrevu.Enabled = false;

            txtbxNumEmp.BackColor = Color.Silver;
            txtbxRefEx.BackColor = Color.Silver;
            
            //le bouton annuler disparait
            btnAnnuler.Visible = false;

        }

        //public void activationBouton(MetroFramework.Controls.MetroTile btn, string nomBtn)
        //{
        //    if (btn.Text.Equals("nomBtn"))
        //    {
        //        btn.BackColor = Color.Green;
        //        btn.Text = "Valider";

        //        //le bouton annuler apparait
        //        btnAnnuler.Visible = true;

        //        //Desactive tous les autres boutons
        //        btnModifier.Enabled = false;
        //        btnSupprimer.Enabled = false;
        //        btnAjRetour.Enabled = false;
        //        btnSearchEmp.Enabled = false;
        //        btnLivre.Enabled = false;

        //        //Les textbox à remplir pour l'insertion se déverouille
        //        txtbxNumEmp.Enabled = true;
        //        txtbxRefEx.Enabled = true;
        //        dtEmprunt.Enabled = true;
        //        dtRetour.Enabled = true;
        //        dtRetourPrevu.Enabled = true;


        //        //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
        //        txtbxRefEx.BackColor = Color.White;
        //        txtbxNumEmp.BackColor = Color.White;

        //        //Reinistialisation des textbox
        //        txtbxNumEmp.Text = "";
        //        txtbxRefEx.Text = "";
        //        dtRetourPrevu.Text = "";
        //        dtRetour.Text = "";
        //        dtEmprunt.Text = "";

        //    }
        //    else if (btn.Text.Equals("Valider"))
        //    {
        //        int numE = Int32.Parse(txtbxNumEmp.Text);
        //        DateTime dateEm = Convert.ToDateTime(dtEmprunt.Text);
        //        DateTime dateRet = Convert.ToDateTime(dtRetour.Text);
        //        DateTime dateRetP = Convert.ToDateTime(dtRetourPrevu.Text);
        //        Emprunt lEmprunt = new Emprunt(numE, txtbxRefEx.Text, dateEm, dateRet, dateRetP);

        //        btnAjouter.Text = "nomBtn";
        //        btnAjouter.BackColor = Color.SteelBlue;
        //        btnAnnuler.Visible = false;

        //        //Re active les boutons
        //        btnModifier.Enabled = true;
        //        btnSupprimer.Enabled = true;
        //        btnAjRetour.Enabled = true;
        //        btnSearchEmp.Enabled = true;
        //        btnLivre.Enabled = true;

        //        //Les textbox sont inacessibles.
        //        txtbxNumEmp.Enabled = false;
        //        txtbxRefEx.Enabled = false;
        //        dtEmprunt.Enabled = false;
        //        dtRetour.Enabled = false;
        //        dtRetourPrevu.Enabled = false;

        //        //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
        //        txtbxRefEx.BackColor = Color.Silver;
        //        txtbxNumEmp.BackColor = Color.Silver;

        //    }
        //}
    }
}
