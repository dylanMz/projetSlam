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
        private string id;
        private String dateadh;
        private Crud_Emprunteur unEmprunteur;
        private ConnexionBase uneconnexion;

        public FrmEmprunteur()
        {
            InitializeComponent();
            RefreshGrid();

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

        //au clic dans le dataGrid rempli les informations dans les textbox ou datetime 
        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = GridEmprunteur.CurrentRow.Cells["numéro"].Value.ToString(); ;
            txtNom.Text = GridEmprunteur.CurrentRow.Cells["nom"].Value.ToString();
            txtPrenom.Text = GridEmprunteur.CurrentRow.Cells["prénom"].Value.ToString();
            txtMail.Text = GridEmprunteur.CurrentRow.Cells["mail"].Value.ToString();
            txtAdresse.Text = GridEmprunteur.CurrentRow.Cells["rue"].Value.ToString();
            txtCodePostal.Text = GridEmprunteur.CurrentRow.Cells["code_postal"].Value.ToString();
            txtVille.Text = GridEmprunteur.CurrentRow.Cells["ville"].Value.ToString();
            DateTimeNaissance.Text = GridEmprunteur.CurrentRow.Cells["naissance"].Value.ToString();

            String Adhesion = GridEmprunteur.CurrentRow.Cells["adhésion"].Value.ToString();
            if (Adhesion.Equals("01/01/0001 00:00:00"))
            {
                DateTimeAdhesion.Visible = false;
                ActiverAdh.Checked = false;
            }
            else
            {
                DateTimeAdhesion.Visible = true;
                DateTimeAdhesion.Text = Adhesion;
                ActiverAdh.Checked = true;
            }
            
            DateTimeRenouvellement.Text = GridEmprunteur.CurrentRow.Cells["renouvellement_adhésion"].Value.ToString();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text.Equals("Ajouter"))
            {
                groupAjouterEmp.Enabled = true;
                btnAjouter.BackColor = Color.Green;

                //vide les controls du groupbox
                foreach (Control c in groupAjouterEmp.Controls)
                {
                    if (c.GetType() == typeof(MetroFramework.Controls.MetroTextBox))
                        c.Text = "";

                }

                
                btnAjouter.Text = "Valider";
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnFamille.Enabled = false;
                btnRechercher.Enabled = false;


                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                groupAjouterEmp.BackColor = Color.White;
                //txtNom.BackColor = Color.White;
                //txtPrenom.BackColor = Color.White;
                //txtMail.BackColor = Color.White;
                //txtCodePostal.BackColor = Color.White;
                //txtAdresse.BackColor = Color.White;
                //txtVille.BackColor = Color.White;
                //DateTimeNaissance.CalendarTitleBackColor = Color.Silver;
            }
            else if (btnAjouter.Text.Equals("Valider"))
            {
                utilisemethodeprocedure("proc_insert_emprunteur");

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
                groupAjouterEmp.BackColor = Color.Silver;
                //txtNom.BackColor = Color.Silver;
                //txtPrenom.BackColor = Color.Silver;
                //txtMail.BackColor = Color.Silver;
                //txtCodePostal.BackColor = Color.Silver;
                //txtAdresse.BackColor = Color.Silver;
                //txtVille.BackColor = Color.Silver;

                //met à jour le datagrid
                RefreshGrid();

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
                ActiverAdh.Enabled = true;



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

                utilisemethodeprocedure("proc_modif_emprunteur");
               
                groupAjouterEmp.Enabled = false;
                ActiverAdh.Enabled = false;
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


                //met à jour le datagrid
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

        //Methode pour mettre à jour le grid
        public void RefreshGrid()
        {
            uneconnexion = new ConnexionBase();
            unEmprunteur = new Crud_Emprunteur(uneconnexion);
            unEmprunteur.Recup_TableEmprunteur();
            RempGridEmprunteur(unEmprunteur.lesEmprunteurs);
            GridEmprunteur.Update();
            GridEmprunteur.Refresh();
        }

        //Permet de faire appel à la methode connectprocedure et de remplir les paramétres de la procédure dans les listes
        public void utilisemethodeprocedure(String nomprocedure)
        {
            List<KeyValuePair<String, Object>> parametresString = new List<KeyValuePair<String, Object>>(){

                     //w.. est le nom du parametre de la procédure stokée, et txt.. les valeurs.
                    new KeyValuePair<String, Object>("wnom", txtNom.Text),
                    new KeyValuePair<String, Object>("wprenom", txtPrenom.Text),
                    new KeyValuePair<String, Object>("wrue", txtAdresse.Text),
                    new KeyValuePair<String, Object>("wcodepostal", txtCodePostal.Text),
                    new KeyValuePair<String, Object>("wville", txtVille.Text),
                    new KeyValuePair<String, Object>("wmail", txtMail.Text),
                  };

            //Verifie si il  ne possede pas une date adhesion est lui met une date null sinon garde la date
            if (DateTimeAdhesion.Visible == false)
            {
                dateadh = "01/01/0001 00:00:00";
            }
            else
            {
                dateadh = DateTimeAdhesion.Text;
            }
            List<KeyValuePair<String, Object>> parametresDate = new List<KeyValuePair<String, Object>>(){

                     //w..est le nom du parametre de la procédure stokée, et Date... les valeurs.
                     new KeyValuePair<String, Object>("wdatenaiss", DateTime.Parse(DateTimeNaissance.Text).ToString("yyyy-MM-dd")),
                     new KeyValuePair<String, Object>("wpremadh", DateTime.Parse(dateadh).ToString("yyyy-MM-dd")),
                     new KeyValuePair<String, Object>("wrenadh", DateTime.Parse(DateTimeRenouvellement.Text).ToString("yyyy-MM-dd")),
                  };

            String recupcode = null;
            //appel de la methode connectprocedure de Crud_Emprunteur
            unEmprunteur.connectprocedure(nomprocedure, ref recupcode, parametresString, parametresDate, Convert.ToInt32(id));
        }

        private void ActiverAdh_CheckedChanged(object sender, EventArgs e)
        {
            if(ActiverAdh.Checked == true)
            {
                DateTimeAdhesion.Visible = true;
            }
            else
            {
                DateTimeAdhesion.Visible = false;
                DateTimeAdhesion.ResetText();
            }
        }
    }
}
