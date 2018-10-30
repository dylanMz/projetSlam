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
        private List<Famille> lesfamille;
        private String lesidfamilles;

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
                vidercontrols();

                
                btnAjouter.Text = "Valider";
                btnAnnuler.Visible = true;
                ActiverAdh.Enabled = true;

                //Desactive tous les autres boutons
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnFamille.Enabled = false;
                btnRechercher.Enabled = false;


                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                modifcouleurControlActif();

            }
            else if (btnAjouter.Text.Equals("Valider"))
            {
                utilisemethodeprocedure("proc_insert_emprunteur");

                groupAjouterEmp.Enabled = false;
                btnAjouter.Text = "Ajouter";
                btnAjouter.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;
                ActiverAdh.Enabled = false;

                //Re active les boutons
                btnFamille.Enabled = true;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
                btnRechercher.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                modifcouleurControlVerou();


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
            if (btnModifier.Text.Equals("Modifier")&!txtNom.Text.Equals(""))
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
                modifcouleurControlActif();

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
                modifcouleurControlVerou();



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
            txtNum.Visible = false;
            lblnum.Visible = false;


            //Le background color des textbox change de couleur pour indiquer qu'elles sont vérouillé
            modifcouleurControlVerou();

            //le bouton annuler disparait
            btnAnnuler.Visible = false;
            ActiverAdh.Enabled = false;
            vidercontrols();
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

        //Verifier le changement d'etat du metrotoggle
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


        //vider les controls du groupbox
        public void vidercontrols()
        {
            foreach (Control c in groupAjouterEmp.Controls)
            {
                if (c.GetType() == typeof(MetroFramework.Controls.MetroTextBox))
                    c.Text = "";
                if (c.GetType() == typeof(MetroFramework.Controls.MetroDateTime))
                    c.ResetText();
            }
        }

        //modifier les couleurs en vérouiller pour les controls
        public void modifcouleurControlVerou()
        {
            foreach (Control c in groupAjouterEmp.Controls)
            {
                if (c.GetType() == typeof(MetroFramework.Controls.MetroTextBox))
                    c.BackColor = Color.Silver;
                if (c.GetType() == typeof(MetroFramework.Controls.MetroDateTime))
                    c.BackColor = Color.Silver; ;
            }
        }

        //modifier les couleurs en Actif pour les controls
        public void modifcouleurControlActif()
        {
            foreach (Control c in groupAjouterEmp.Controls)
            {
                if (c.GetType() == typeof(MetroFramework.Controls.MetroTextBox))
                    c.BackColor = Color.White;
                if (c.GetType() == typeof(MetroFramework.Controls.MetroDateTime))
                    c.BackColor = Color.White; ;
            }
        }


        private void btnFamille_Click(object sender, EventArgs e)
        {
            //  _desEmprunteurs = new List<Emprunteur>();
            //MessageBox.Show(sb.ToString(), "Les lignes sélectionnées");
            recupeselectionfamille();
            
        }


        //permet de recuperer les lignes séléctionné dans le datagrid
        public void recupeselectionfamille()
        {
            lesfamille = new List<Famille>();
            Int32 selectedRowCount =
             GridEmprunteur.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {

                    int num = Convert.ToInt16(GridEmprunteur.SelectedRows[i].Cells[0].Value.ToString());
                    String nom = GridEmprunteur.SelectedRows[i].Cells[1].Value.ToString();
                    String prenom = GridEmprunteur.SelectedRows[i].Cells[2].Value.ToString();
                    String rue = GridEmprunteur.SelectedRows[i].Cells[3].Value.ToString();
                    String codepostal = GridEmprunteur.SelectedRows[i].Cells[4].Value.ToString();
                    String ville = GridEmprunteur.SelectedRows[i].Cells[5].Value.ToString();
                    DateTime naiis = Convert.ToDateTime(GridEmprunteur.SelectedRows[i].Cells[6].Value.ToString());
                    String mail = GridEmprunteur.SelectedRows[i].Cells[7].Value.ToString();
                    DateTime prem = Convert.ToDateTime(GridEmprunteur.SelectedRows[i].Cells[8].Value.ToString());
                    DateTime ren = Convert.ToDateTime(GridEmprunteur.SelectedRows[i].Cells[9].Value.ToString());



                    
                    lesfamille.Add(new Famille(num, nom, prenom, rue, codepostal, ville, naiis, mail, prem, ren));

                    //sb.Append("ligne: ");
                    //sb.Append(GridEmprunteur.SelectedRows[i].Index.ToString());
                    //sb.Append(Environment.NewLine);
                    //sb.Append("Numéro: ");
                    //sb.Append(GridEmprunteur.SelectedRows[i].Cells[0].Value.ToString());
                    //sb.Append(Environment.NewLine);
                    //sb.Append(GridEmprunteur.SelectedRows[i].Cells[1].Value.ToString());
                    //sb.Append(Environment.NewLine);
                    //sb.Append(GridEmprunteur.SelectedRows[i].Cells[2].Value.ToString());
                    //sb.Append(Environment.NewLine);
                }
                FrmFamille lafamille = new FrmFamille(lesfamille);
                lafamille.Show();
            }


        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (btnRechercher.Text.Equals("Rechercher"))
            {

                lblnum.Visible = true;
                txtNum.Visible = true;
                txtNum.Enabled = true;
                txtNom.Enabled = true;
                groupAjouterEmp.Enabled = true;
                txtMail.Enabled = false;
                txtCodePostal.Enabled = false;
                txtAdresse.Enabled = false;
                txtPrenom.Enabled = false;
                txtVille.Enabled = false;
                DateTimeNaissance.Enabled = false;
                DateTimeAdhesion.Enabled = false;
                DateTimeRenouvellement.Enabled = false;
                btnRechercher.BackColor = Color.Green;

                //vide les controls du groupbox
                vidercontrols();


                btnRechercher.Text = "Valider";
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
                btnFamille.Enabled = false;
                btnAjouter.Enabled = false;


                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNum.BackColor = Color.White;
                txtNom.BackColor = Color.White;

            }
            else if (btnRechercher.Text.Equals("Valider"))
            {
                utilisemethodeprocedure("proc_recherche_emprunteur");

                groupAjouterEmp.Enabled = false;
                btnRechercher.Text = "Rechercher";
                btnRechercher.BackColor = Color.SteelBlue;
                btnAnnuler.Visible = false;
                groupAjouterEmp.Enabled = false;
                txtMail.Enabled = true;
                txtCodePostal.Enabled = true;
                txtAdresse.Enabled = true;
                txtPrenom.Enabled = true;
                txtVille.Enabled = true;
                DateTimeNaissance.Enabled = true;
                DateTimeAdhesion.Enabled = true;
                DateTimeRenouvellement.Enabled = true;

                //Re active les boutons
                btnFamille.Enabled = true;
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
                btnAjouter.Enabled = true;

                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                txtNum.Visible = false;
                lblnum.Visible = false;
                txtNom.BackColor = Color.Silver;
                txtNum.BackColor = Color.Silver;



                //met à jour le datagrid
                RefreshGrid();

            }
        }
    }
}
