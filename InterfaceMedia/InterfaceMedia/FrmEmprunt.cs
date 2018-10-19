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
        Thread home;

        public FrmEmprunt()
        {
            InitializeComponent();
            Ajout = new Crud_Emprunt();
            Updat = new Crud_Emprunt();
            Suppr = new Crud_Emprunt();
            Search = new Crud_Emprunt();

            Ajout = new Crud_Emprunt();
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

                btnModifier.Text = "Ajouter";
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

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnAjRetour_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {

        }

        private void btnLivre_Click(object sender, EventArgs e)
        {

        }







        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
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

            GroupSaisie.Enabled = false;

            GroupSaisie.BackColor = Color.Silver;

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
