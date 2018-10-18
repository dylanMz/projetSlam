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
    public partial class FrmEmprunteur : MetroForm
    {
        Thread th;
        private Crud_Emprunteur unEmprunteur;
        private ConnexionBase uneconnexion;
        private List<KeyValuePair<string, object>> parametresString;
        private List<KeyValuePair<DateTime, object>> parametresDateTime;

        public FrmEmprunteur()
        {
            InitializeComponent();
            uneconnexion = new ConnexionBase();
            unEmprunteur = new Crud_Emprunteur(uneconnexion);
            unEmprunteur.Recup_TableEmprunteur();
            RempGridEmprunteur(unEmprunteur.lesEmprunteurs);

        }

        private void metrotileQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        //emp
        
        //Rempli le Grid avec les emprunteurs
        private void RempGridEmprunteur(List<Emprunteur> lesemprunteur)
        {
            GridEmprunteur.DataSource = lesemprunteur;
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNom.Text = GridEmprunteur.CurrentRow.Cells["nom"].Value.ToString();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text.Equals("Ajouter"))
            {
                groupAjouterEmp.Enabled = true;
                btnAjouter.BackColor = Color.Green;
                btnAjouter.Text = "Valider";
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnFamille.Enabled = false;
                btnRechercher.Enabled = false;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.White;
                txtPrenom.BackColor = Color.White;
                txtMail.BackColor = Color.White;
                txtCodePostal.BackColor = Color.White;
                txtAdresse.BackColor = Color.White;
                txtVille.BackColor = Color.White;
                DateTimeNaissance.CalendarTitleBackColor = Color.Silver;
            }
            else if (btnAjouter.Text.Equals("Valider"))
            {
                groupAjouterEmp.Enabled = false;
                btnAjouter.Text = "Ajouter";
                btnAjouter.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnFamille.Enabled = true;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
                btnRechercher.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNom.BackColor = Color.Silver;
                txtPrenom.BackColor = Color.Silver;
                txtMail.BackColor = Color.Silver;
                txtCodePostal.BackColor = Color.Silver;
                txtAdresse.BackColor = Color.Silver;
                txtVille.BackColor = Color.Silver;

            }
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

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnModifier.Text.Equals("Modifier"))
            {
                groupAjouterEmp.Enabled = true;
                btnModifier.BackColor = Color.Green;
                btnModifier.Text = "Valider";

                //le bouton annuler apparait
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnAjouter.Enabled = false;
                btnSupprimer.Enabled = false;
                btnRechercher.Enabled = false;
                btnFamille.Enabled = false;



                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                groupAjouterEmp.BackColor = Color.White;
                //txtNom.BackColor = Color.White;
                //DateTimeRenouvellement.BackColor = Color.White;
                //txtMail.BackColor = Color.White;
                //txtCodePostal.BackColor = Color.White;
                //txtPrenom.BackColor = Color.White;
                //txtAdresse.BackColor = Color.White;
                //DateTimeNaissance.BackColor = Color.White;
                //DateTimeAdhesion.BackColor = Color.White;
                //txtVille.BackColor = Color.White;
            }
            else if (btnModifier.Text.Equals("Valider"))
            {
                List<KeyValuePair<String, Object>> parametresString = new List<KeyValuePair<String, Object>>(){

                     //wid est le nom du parametre de la procédure stokée, et id les valeurs.
                    new KeyValuePair<String, Object>("wnom", txtNom.Text),
                    new KeyValuePair<String, Object>("wprenom", txtPrenom.Text),
                    new KeyValuePair<String, Object>("wrue", txtAdresse.Text),
                    new KeyValuePair<String, Object>("wcodepostal", txtCodePostal.Text),
                    new KeyValuePair<String, Object>("wville", txtCodePostal.Text),
                    new KeyValuePair<String, Object>("wdatenaiss", DateTimeNaissance.Text),
                    new KeyValuePair<String, Object>("wmail", txtMail.Text),
                    new KeyValuePair<String, Object>("wpremadh", DateTimeAdhesion.Text),
                    new KeyValuePair<String, Object>("wrenadh", DateTimeRenouvellement.Text),
                  };
                if (uneconnexion.OuvrirConnexion() == true)
                {
                    String recupcode = null;
                    unEmprunteur.connectprocedure("proc_modif_emprunteur", ref recupcode, parametresString);

                }
                groupAjouterEmp.Enabled = false;
                btnModifier.Text = "Modifier";
                btnModifier.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;

                //Re active les boutons
                btnAjouter.Enabled = true;
                btnSupprimer.Enabled = true;
                btnRechercher.Enabled = true;
                btnFamille.Enabled = true;



                //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                groupAjouterEmp.BackColor = Color.Silver;
                //txtNom.BackColor = Color.Silver;
                //txtPrenom.BackColor = Color.Silver;
                //txtMail.BackColor = Color.Silver;
                //txtCodePostal.BackColor = Color.Silver;
                //txtAdresse.BackColor = Color.Silver;
                //DateTimeRenouvellement.BackColor = Color.Silver;
                //DateTimeNaissance.BackColor = Color.Silver;
                //DateTimeAdhesion.BackColor = Color.Silver;
                //txtVille.BackColor = Color.Silver;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //les boutons sont remis par defaut
            btnAjouter.BackColor = Color.SteelBlue;
            btnModifier.BackColor = Color.SteelBlue;
            btnSupprimer.BackColor = Color.SteelBlue;
            btnRechercher.BackColor = Color.SteelBlue;

            btnAjouter.Enabled = true;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
            btnRechercher.Enabled = true;
            btnFamille.Enabled = true;

            btnAjouter.Text = "Ajouter";
            btnModifier.Text = "Modifier";
            btnSupprimer.Text = "Supprimer";
            btnRechercher.Text = "Rechercher";

            //Les textbox sont inacessibles.
            groupAjouterEmp.Enabled = false;

            //Le background color des textbox change de couleur pour indiquer qu'elles sont vérouillé
            groupAjouterEmp.BackColor = Color.Silver;

            //le bouton annuler disparait
            btnAnnuler.Visible = false;
        }
    }
}
