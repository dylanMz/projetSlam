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
        private int wnum;
        private int num;
        Thread th;
        private string id;
        private Crud_Famille unefamille;
        private Crud_Emprunteur unEmprunteur;
        private ConnexionBase uneconnexion;
        private List<Famille> lesfamille;
        private int unchef;
        private Boolean newfamille = false;
        private String leNiveau;

        public FrmEmprunteur(String leNiveau)
        {
            InitializeComponent();
            unefamille = new Crud_Famille();
            this.leNiveau = leNiveau;
            RefreshGrid();
            lblRang.Text = this.leNiveau;
            if (this.leNiveau.Equals("Personnel"))
            {
                btnAjouter.Enabled = false;
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;

            }else if(this.leNiveau.Equals("Responsable secteur"))
            {
                btnSupprimer.Enabled = false;
            }


        }

        //Fermer l'application
        private void metrotileQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
 
        
        //Rempli le Grid avec les emprunteurs
        private void RempGridEmprunteur(List<Emprunteur> lesemprunteur)
        {
            GridEmprunteur.DataSource = lesemprunteur;
        }

        //au clic dans le dataGrid rempli les informations dans les textbox ou datetime 
        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.leNiveau.Equals("Admin"))
            {
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
            }
            id = GridEmprunteur.CurrentRow.Cells["numéro"].Value.ToString(); ;
            txtNom.Text = GridEmprunteur.CurrentRow.Cells["nom"].Value.ToString();
            txtPrenom.Text = GridEmprunteur.CurrentRow.Cells["prénom"].Value.ToString();
            txtMail.Text = GridEmprunteur.CurrentRow.Cells["mail"].Value.ToString();
            txtAdresse.Text = GridEmprunteur.CurrentRow.Cells["rue"].Value.ToString();
            txtCodePostal.Text = GridEmprunteur.CurrentRow.Cells["code_postal"].Value.ToString();
            txtVille.Text = GridEmprunteur.CurrentRow.Cells["ville"].Value.ToString();
            DateTimeNaissance.Text = GridEmprunteur.CurrentRow.Cells["naissance"].Value.ToString();

            String Adhesion = GridEmprunteur.CurrentRow.Cells["adhésion"].Value.ToString();
            DateTimeAdhesion.Text = Adhesion;
                
            
            
            DateTimeRenouvellement.Text = GridEmprunteur.CurrentRow.Cells["renouvellement_adhésion"].Value.ToString();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text.Equals("Ajouter"))
            {
                groupAjouterEmp.Enabled = true;
                

                //vide les controls du groupbox
                vidercontrols();

                clickButton(btnAjouter);
                btnAjouter.Enabled = true;


                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                modifcouleurControlActif();

            }
            else if (btnAjouter.Text.Equals("Valider"))
            {
                if (txtNom.Text.Equals("") | txtPrenom.Text.Equals("") | txtAdresse.Text.Equals("") | txtCodePostal.Text.Equals("") | txtVille.Text.Equals(""))
                {
                    MessageBox.Show("Des champs importants sont vides", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    utilisemethodeprocedure("proc_insert_emprunteur");
                    groupAjouterEmp.Enabled = false;

                    clickvalider(btnAjouter);
                    //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                    modifcouleurControlVerou();


                    //met à jour le datagrid
                    RefreshGrid();
                }

            }
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            //permet de récuperer le niveau de l'utilisateur
            leNiveau = lblRang.Text;
            //Ferme FrmEmprunteur
            this.Close();
            //Permet d'ouvrir FrmAccueil
            th = new Thread(openformAccueil);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        private void openformAccueil()
        {
            //Ouvre FrmAccueil
            Application.Run(new FrmAccueilTest(leNiveau));
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            
            if (btnModifier.Text.Equals("Modifier")&!txtNom.Text.Equals(""))
            {
                groupAjouterEmp.Enabled = true;
               

                //Desactive tous les autres boutons
                clickButton(btnModifier);

                btnModifier.Enabled = true;



                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                modifcouleurControlActif();

            }
            else if (btnModifier.Text.Equals("Valider"))
            {

                utilisemethodeprocedure("proc_update_emprunteur");
               
                groupAjouterEmp.Enabled = false;

                clickvalider(btnModifier);


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
            lblmotif.Visible = false;
            txtMotif.Visible = false;


            //Le background color des textbox change de couleur pour indiquer qu'elles sont vérouillé
            modifcouleurControlVerou();

            //le bouton annuler disparait
            btnAnnuler.Visible = false;
            vidercontrols();

            //met à jour la datagrid
            RefreshGrid();
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

        //Permets de faire appel à la méthode connectprocedure et de remplir les paramètres de la procédure dans les listes
        public void utilisemethodeprocedure(String nomprocedure)
        {
            String recupcode = null;
            Emprunteur ConnectEmprunteur = new Emprunteur(Convert.ToInt32(id),txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtCodePostal.Text, txtVille.Text, Convert.ToDateTime(DateTime.Parse(DateTimeNaissance.Text).ToString("yyyy-MM-dd")), txtMail.Text, Convert.ToDateTime(DateTime.Parse(DateTimeAdhesion.Text).ToString("yyyy-MM-dd")), Convert.ToDateTime(DateTime.Parse(DateTimeRenouvellement.Text).ToString("yyyy-MM-dd")));
            //appel de la methode connectprocedure de Crud_Emprunteur
            unEmprunteur.connectprocedure(nomprocedure, ref recupcode, ConnectEmprunteur);
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


        //Permets de récupérer les lignes sélectionnées dans le datagrid
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
                    
                    num = Convert.ToInt16(GridEmprunteur.SelectedRows[i].Cells[0].Value.ToString());
                    String nom = GridEmprunteur.SelectedRows[i].Cells[1].Value.ToString();
                    String prenom = GridEmprunteur.SelectedRows[i].Cells[2].Value.ToString();
                    String rue = GridEmprunteur.SelectedRows[i].Cells[3].Value.ToString();
                    String codepostal = GridEmprunteur.SelectedRows[i].Cells[4].Value.ToString();
                    String ville = GridEmprunteur.SelectedRows[i].Cells[5].Value.ToString();
                    DateTime naiis = Convert.ToDateTime(GridEmprunteur.SelectedRows[i].Cells[6].Value.ToString());
                    String mail = GridEmprunteur.SelectedRows[i].Cells[7].Value.ToString();
                    //Ajoute dans famille tout les emprunteurs sélectionnés
                    Famille cetteFamille = new Famille(num);
                    int lechef = unefamille.cheffamille(cetteFamille); ;
                        lesfamille.Add(new Famille(num, nom, prenom, rue, codepostal, ville, naiis, mail, lechef));
                    

                    
                    

                }
                //Permet de recupérer les membre d'une famille et le chef
                Famille numFamille = new Famille(num);
                unchef = unefamille.cheffamille(numFamille);
                if(unchef == 0)
                {
                    unchef = num;
                }
                //si un emprunteur est choisi il recherche les membres de la famille
                if (selectedRowCount == 1)
                {
                    newfamille = false;
                    unefamille.lesfamilles.Clear();
                    lesfamille.Clear();
                    Famille idfamille = new Famille(unchef);
                    unefamille.Recup_Toutelafamille(idfamille);
                    FrmFamille lafamille = new FrmFamille(unefamille.lesfamilles, newfamille);
                    lafamille.Show();
                }
                else
                {
                    newfamille = true;
                    FrmFamille lafamille = new FrmFamille(lesfamille, newfamille);
                    lafamille.Show();
                }


            }


        }
        //au clic du bouton recherche
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
                if (!txtNum.Text.Equals(""))
                {
                    wnum = Convert.ToInt32(txtNum.Text);
                }
                //met à jour le datagrid
                unEmprunteur.lesEmprunteurs.Clear();
                uneconnexion = new ConnexionBase();
                unEmprunteur = new Crud_Emprunteur(uneconnexion);
                Emprunteur Remprunteur = new Emprunteur(wnum,txtNom.Text);
                unEmprunteur.recherche("proc_recherche_emprunteur", Remprunteur);
                RempGridEmprunteur(unEmprunteur.lesEmprunteurs);
                GridEmprunteur.Update();
                GridEmprunteur.Refresh();

                groupAjouterEmp.Enabled = false;
                btnRechercher.Text = "Rechercher";
                btnRechercher.BackColor = Color.SteelBlue;
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

                

                

            }
        }


        //clic sur le bouton supprimer (pour supprimer un emprunteur)
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (btnSupprimer.Text.Equals("Supprimer") & !txtNom.Text.Equals(""))
            {
                groupAjouterEmp.Enabled = true;
                txtNom.Enabled = false;
                txtMail.Enabled = false;
                txtCodePostal.Enabled = false;
                txtAdresse.Enabled = false;
                txtPrenom.Enabled = false;
                txtVille.Enabled = false;
                DateTimeNaissance.Enabled = false;
                DateTimeAdhesion.Enabled = false;
                DateTimeRenouvellement.Enabled = false;
                btnSupprimer.BackColor = Color.Green;
                btnSupprimer.Text = "Valider";

                txtMotif.Visible = true;
                lblmotif.Visible = true;

                //le bouton annuler apparait
                btnAnnuler.Visible = true;

                //Desactive tous les autres boutons
                btnAjouter.Enabled = false;
                btnModifier.Enabled = false;
                btnRechercher.Enabled = false;
                btnFamille.Enabled = false;



                //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
                modifcouleurControlActif();

            }
            else if (btnSupprimer.Text.Equals("Valider"))
            {

                //Si le motif du retrait est vide alors affiche un message d'erreur
                if (txtMotif.Text.Equals(""))
                {
                    MessageBox.Show("Vous devez saisir un motif pour supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    Emprunteur NumEmprunteur = new Emprunteur(Convert.ToInt32(id));
                    unEmprunteur.deleteEmprunteur("proc_delete_emprunteur", NumEmprunteur, txtMotif.Text);

                    lblmotif.Visible = false;
                    txtMotif.Visible = false;

                    groupAjouterEmp.Enabled = false;
                    txtNom.Enabled = true;
                    txtMail.Enabled = true;
                    txtCodePostal.Enabled = true;
                    txtAdresse.Enabled = true;
                    txtPrenom.Enabled = true;
                    txtVille.Enabled = true;
                    DateTimeNaissance.Enabled = true;
                    DateTimeAdhesion.Enabled = true;
                    DateTimeRenouvellement.Enabled = true;
                    btnSupprimer.Text = "Supprimer";
                    btnSupprimer.BackColor = Color.SteelBlue;
                    btnAnnuler.Visible = false;

                    //Re active les boutons
                    btnAjouter.Enabled = true;
                    btnModifier.Enabled = true;
                    btnRechercher.Enabled = true;
                    btnFamille.Enabled = true;



                    //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
                    modifcouleurControlVerou();



                    //met à jour le datagrid
                    RefreshGrid();
                }


            }
            
        }

        //Méthode correspondant au click sur un des boutons
        public void clickButton(MetroFramework.Controls.MetroTile btn)
        {
            btn.BackColor = Color.Green;
            btn.Text = "Valider";
            //le bouton annuler apparait
            btnAnnuler.Visible = true;

            //Desactive tous les autres boutons
            btnAjouter.Enabled = false;
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
            btnFamille.Enabled = false;
            btnRechercher.Enabled = false;
        }

        //Méthode correspondant au click sur un des boutons pour valider
        public void clickvalider(MetroFramework.Controls.MetroTile btn)
        {
            btn.Text = "Ajouter";
            btn.BackColor = Color.SteelBlue;
            btnAnnuler.Visible = false;

            //Re active les boutons
            btnAjouter.Enabled = true;
            btnFamille.Enabled = true;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
            btnRechercher.Enabled = true;
        }


        //Ajoute 1 an à la date de renouvellement 
        private void DateAdhesion(object sender, EventArgs e)
        {
            DateTime myTime = DateTimeAdhesion.Value;
            int année = myTime.Year + 1;
            int mois = myTime.Month;
            int jour = myTime.Day;

            DateTimeRenouvellement.Value = new DateTime(année, mois, jour);
        }
    }
}
