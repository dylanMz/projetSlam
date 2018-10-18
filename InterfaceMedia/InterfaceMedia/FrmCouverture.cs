using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using LibMedia.LaibrairieClasses;

namespace InterfaceMedia
{
    public partial class FrmCouverture : MetroForm
    {

        public FrmCouverture()
        {
            InitializeComponent();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            FrmAccueilTest wAccueilTest = new FrmAccueilTest();
            wAccueilTest.ShowDialog();
            Form.ActiveForm.Close();
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
                txtBoxCode.Enabled = true;
                txtBoxTitre.Enabled = true;
                txtBoxAuteur.Enabled = true;
                txtBoxEditeur.Enabled = true;
                

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtBoxCode.BackColor = Color.White;
                txtBoxTitre.BackColor = Color.White;
                txtBoxAuteur.BackColor = Color.White;
                txtBoxEditeur.BackColor = Color.White;


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
                txtBoxCode.Enabled = false;
                txtBoxTitre.Enabled = false;
                txtBoxAuteur.Enabled = false;
                txtBoxEditeur.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtBoxCode.BackColor = Color.Silver;
                txtBoxTitre.BackColor = Color.Silver;
                txtBoxAuteur.BackColor = Color.Silver;
                txtBoxEditeur.BackColor = Color.Silver;
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
                txtBoxCode.Enabled = true;
                txtBoxTitre.Enabled = true;
                txtBoxAuteur.Enabled = true;
                txtBoxEditeur.Enabled = true;


                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtBoxCode.BackColor = Color.White;
                txtBoxTitre.BackColor = Color.White;
                txtBoxAuteur.BackColor = Color.White;
                txtBoxEditeur.BackColor = Color.White;

                OpenFileDialog openFile = new OpenFileDialog();
                openFile.DefaultExt = "C:/Users/h.zagorjewsky/Source/Repos/dylanMz/projetSlam/InterfaceMedia/InterfaceMedia/Resources";
                openFile.Filter = "Fichier MapInfoFormat (*.jpeg)|*.jpeg";
                openFile.ShowDialog();
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
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
            txtBoxCode.Enabled = false;
            txtBoxTitre.Enabled = false;
            txtBoxAuteur.Enabled = false;
            txtBoxEditeur.Enabled = false;

            //Le background color des textbox change de couleur pour indiquer qu'elles sont vérouillé
            txtBoxCode.BackColor = Color.Silver;
            txtBoxTitre.BackColor = Color.Silver;
            txtBoxAuteur.BackColor = Color.Silver;
            txtBoxEditeur.BackColor = Color.Silver;

            //le bouton annuler disparait
            btnAnnuler.Visible = false;
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
                btnModifier.Enabled = false;
                btnAjouter.Enabled = false;
                btnRechercher.Enabled = false;

                //Les textbox à remplir pour l'insertion se déverouille
                txtBoxCode.Enabled = true;
                txtBoxTitre.Enabled = true;
                txtBoxAuteur.Enabled = true;
                txtBoxEditeur.Enabled = true;


                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtBoxCode.BackColor = Color.White;
                txtBoxTitre.BackColor = Color.White;
                txtBoxAuteur.BackColor = Color.White;
                txtBoxEditeur.BackColor = Color.White;

            }

            else if (btnSupprimer.Text.Equals("Valider"))
            {
                btnSupprimer.Text = "Supprimer";
                btnSupprimer.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnModifier.Enabled = true;
                btnAjouter.Enabled = true;
                btnRechercher.Enabled = true;

                //Les textbox sont inacessibles.
                txtBoxCode.Enabled = false;
                txtBoxTitre.Enabled = false;
                txtBoxAuteur.Enabled = false;
                txtBoxEditeur.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                txtBoxCode.BackColor = Color.Silver;
                txtBoxTitre.BackColor = Color.Silver;
                txtBoxAuteur.BackColor = Color.Silver;
                txtBoxEditeur.BackColor = Color.Silver;
            }
        }
    }
}
