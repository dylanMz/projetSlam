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
using LibMedia;
using System.IO;


namespace InterfaceMedia
{
    public partial class FrmCouverture : MetroForm
    {
        #region propriétés
        //propriétés
        private CRUD_Couverture uneCouverture;
        private ConnexionBase _connexion;
        private OpenFileDialog openFile;
        private String leNiveau;
        private int wcode;
        private int wtome;
        private string nomCouv;
        private string unChemin;
        private Couverture wcouverture;
        #endregion

        #region constructeur
        //constructeur
        public FrmCouverture(String leNiveau)
        {
            //initalisation
            InitializeComponent();

            //récupérer le rang de l'utilisateur
            this.leNiveau = leNiveau;
            lblRang.Text = this.leNiveau;

            //connexion à la base de données
            _connexion = new ConnexionBase();
            uneCouverture = new CRUD_Couverture(_connexion);

            //mise à jour de la GridView
            RefreshGrid();
        }
        #endregion

        #region méthodes
        private void picHome_Click(object sender, EventArgs e)
        {
            //Retourner à l'acceuil
            FrmAccueilTest wAccueilTest = new FrmAccueilTest(lblRang.Text);
            wAccueilTest.ShowDialog();
            Form.ActiveForm.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //Vérification etat du bouton ajouter
            if (btnAjouter.Text.Equals("Ajouter"))
            {

                clickBouton(btnAjouter); //Appelle méthode clickBouton
                btnAjouter.Enabled = true; //activer le bouton ajouter
                OpenFileDialog openFile = new OpenFileDialog(); //Création d'une boite de dialogue
                openFile.DefaultExt = "InterfaceMedia/Couverture"; //paramétrage du chemin par défaut
                openFile.Filter = "Image Files(*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png|All files (*.*)|*.*"; //Filtrage des extensions 
                if (openFile.ShowDialog() == DialogResult.OK) //On ouvre la boite de dialogue et on vérifie si l'utilisateur clique sur ok
                {
                    nomCouv = System.IO.Path.GetFileNameWithoutExtension(openFile.FileName); //On récupère le chemin du fichier ouvert sans l'extension
                    pctBoxCouv.Image = Image.FromFile(openFile.FileName); //On affiche la couverture selectrionné dans une picture box
                }
                else
                {
                    btnAnnuler_Click(null, null); //appelle du bouton annuler
                }

            }
            //Vérification etat du bouton ajouter
            else if (btnAjouter.Text.Equals("Valider"))
            {
                clickValider(btnAjouter, "Ajouter"); //Appelle de la méthode cliclValider
                wcouverture = new Couverture(Int16.Parse(txtBoxCode.Text), nomCouv); //On instancie une nouvelle couverture
                uneCouverture.ajouter(wcouverture); //Appelle de la méthode Ajouter
                afficheImage(); //Appelle de la méthode afficheImage
                RefreshGrid(); //Mise à jour de la GridView
            }
        }


        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnModifier.Text.Equals("Modifier")) //Vérification etat du bouton modifier
            {
                clickBouton(btnModifier); //appelle de la méthode clickBouton
                btnModifier.Enabled = true; //Activer le bouton Modifier

                OpenFileDialog openFile = new OpenFileDialog(); //création d'une boite de dialogue
                openFile.DefaultExt = "InterfaceMedia/Couverture"; //paramétrage du chemin par défaut
                openFile.Filter = "Image Files(*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png|All files (*.*)|*.*"; //Filtrage des extensions
                openFile.ShowDialog();

                if (openFile.ShowDialog() == DialogResult.OK) //On ouvre la boite de dialogue et on vérifie si l'utilisateur clique sur ok
                {
                    nomCouv = System.IO.Path.GetFileNameWithoutExtension(openFile.FileName); //On récupère le chemin du fichier ouvert sans l'extension
                    pctBoxCouv.Image = Image.FromFile(openFile.FileName); //On affiche la couverture selectrionné dans une picture box
                }
                else
                {
                    btnAnnuler_Click(null, null); //appelle du bouton annuler
                }
                
            }

            else if (btnModifier.Text.Equals("Valider")) //vérification etat du bouton modifier
            {
                clickValider(btnModifier, "Modifier"); //appelle méthode clickValider
                btnAnnuler.Visible = true; //Affiche le bouton Annuler
                wcouverture = new Couverture(Int16.Parse(txtBoxCode.Text), nomCouv); //On instancie une nouvelle couverture
                uneCouverture.modifier(wcouverture); //appelle de la méthode
                afficheImage(); //Appelle méthode affiche image
                RefreshGrid(); //mise à jour de la gridView
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close(); //On quitte l'application
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //Changement de la couleur des boutons
            btnAjouter.BackColor = Color.SteelBlue;
            btnModifier.BackColor = Color.SteelBlue;
            btnSupprimer.BackColor = Color.SteelBlue;
            btnRechercher.BackColor = Color.SteelBlue;

            //Activiation des boutons 
            btnAjouter.Enabled = true;
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
            btnRechercher.Enabled = true;

            //On remet l'état des boutons à 0
            btnAjouter.Text = "Ajouter";
            btnModifier.Text = "Modifier";
            btnSupprimer.Text = "Supprimer";
            btnRechercher.Text = "Rechercher";

            //Les textbox sont inacessibles.
            txtBoxCode.Enabled = false;
            txtBoxTitre.Enabled = false;
            txtBoxTome.Enabled = false;
            txtBoxParution.Enabled = false;

            //Le background color des textbox change de couleur pour indiquer qu'elles sont vérouillé
            txtBoxCode.BackColor = Color.Silver;
            txtBoxTitre.BackColor = Color.Silver;
            txtBoxTome.BackColor = Color.Silver;
            txtBoxParution.BackColor = Color.Silver;

            //Le bouton annuler disparait
            btnAnnuler.Visible = false;

            //On met a jour la GridView
            RefreshGrid();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (btnSupprimer.Text.Equals("Supprimer")) //Vérification état du bouton Supprimer
            {
                clickBouton(btnSupprimer); //Appelle de la méthode supprimer
                btnSupprimer.Enabled = true; //Activation du bouton supprimer
                wcouverture = new Couverture(Int16.Parse(txtBoxCode.Text)); //Initialisation d'une nouvelle couverture
                uneCouverture.Supprimer(wcouverture); //Appelle de la méthode supprimer
            }

            else if (btnSupprimer.Text.Equals("Valider")) //Vérification état du bouton Supprimer
            {
                clickValider(btnSupprimer, "Supprimer"); //Appelle de la méthode clickValider
                RefreshGrid(); //Mise à jour de la GridView
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (btnRechercher.Text.Equals("Rechercher")) //Vérification état du bouton Rechercher
            {
                clickBouton(btnRechercher); //Appelle méthode clickBouton
                btnRechercher.Enabled = true; //Activation du bouton rechercher

                //On vide les champs des textes box
                txtBoxCode.Text = "";
                txtBoxTitre.Text = "";
                txtBoxTome.Text = "";
                txtBoxParution.Text = "";

            }
            else if (btnRechercher.Text.Equals("Valider")) //Vérification du bouton 
            {
                if (!txtBoxCode.Text.Equals("")) //Vérification du champ de la texte box code
                {
                    wcode = Convert.ToInt32(txtBoxCode.Text); //On convertie un type string en Int
                }

                if (!txtBoxTome.Text.Equals("")) //Vérification du champ de la texte box code
                {
                    wtome = Convert.ToInt32(txtBoxTome.Text); //On convertie un type string en Int
                }

                if (txtBoxTitre.Text != "") //vérification du champ de txtBoxTitre
                {
                    wcouverture = new Couverture(wcode, txtBoxTitre.Text, wtome, txtBoxParution.Text); //Initialisation d'une nouvelle couverture
                    if (uneCouverture.getExist(wcouverture) == true) //On vérifie que le Titre existe
                    {
                        txtBoxCode.Text = uneCouverture.getCode(wcouverture).ToString(); //On récupère le code Bd de ce Titre

                        //Connexion à la base de données
                        _connexion = new ConnexionBase();
                        uneCouverture = new CRUD_Couverture(_connexion);

                        GridViewBase.DataSource = uneCouverture.rechercher(wcouverture); //On affiche notre recherche dans la base de données
                        GridViewBase.Update(); //On modifie les valeurs de la GridView
                        GridViewBase.Refresh(); //On affiche les nouvelles valeurs

                        clickValider(btnRechercher, "Rechercher"); //Appelle de la méthode clickValider

                        afficheImage(); //Appelle de la méthode afficheImage
                        btnAnnuler.Visible = true; //On affiche le bouton annuler
                    }
                    else
                    {
                        MessageBox.Show("Ce Titre n'existe pas dans la base de données"); //Message d'erreur
                    }
                }

                if(txtBoxCode.Text != "") //vérification du champ de txtBoxCode
                {
                    wcouverture = new Couverture(wcode, txtBoxTitre.Text, wtome, txtBoxParution.Text); //On initialise une nouvelle couverture
                    if (uneCouverture.getCodeExist(wcouverture)==true) //On vérifie que le code Bd existe bien
                    {
                        //Connexion à la base de données
                        _connexion = new ConnexionBase();
                        uneCouverture = new CRUD_Couverture(_connexion);

                        wcouverture = new Couverture(wcode, txtBoxTitre.Text, wtome, txtBoxParution.Text); //On initialise une nouvelle couverture
                        GridViewBase.DataSource = uneCouverture.rechercher(wcouverture); //On affiche notre recherche dans la base de données
                        GridViewBase.Update(); //On modifie les valeurs de la GridView
                        GridViewBase.Refresh(); //On affiche les nouvelles valeurs

                        clickValider(btnRechercher, "Rechercher"); //Appelle de la méthode clickValider

                        afficheImage(); //Appelle de la méthode afficheImage
                        btnAnnuler.Visible = true; //On affiche le bouton annuler
                    }

                    else
                    {
                        MessageBox.Show("Ce code de Bd n'existe pas dans la base de données"); //Message d'erreur
                    }
                }

                if (txtBoxTome.Text != "") //vérification du champ de txtBoxTome
                {
                    wcouverture = new Couverture(wcode, txtBoxTitre.Text, wtome, txtBoxParution.Text); //On initialise une nouvelle couverture
                    if (uneCouverture.getTomeExist(wcouverture) == true) //On vérifie que le N°Tome existe bien
                    {
                        //Connexion à la base de données
                        _connexion = new ConnexionBase();
                        uneCouverture = new CRUD_Couverture(_connexion);

                        wcouverture = new Couverture(wcode, txtBoxTitre.Text, wtome, txtBoxParution.Text); //On initialise une nouvelle couverture
                        GridViewBase.DataSource = uneCouverture.rechercher(wcouverture); //On affiche notre recherche dans la GridView
                        GridViewBase.Update(); //On modifie les valeurs de la GridView
                        GridViewBase.Refresh(); //On affiche les nouvelles valeurs

                        clickValider(btnRechercher, "Rechercher"); //Appelle de la méthode ClickValider

                        btnAnnuler.Visible = true; //Appelle de la méthode annuler
                    }
                    else
                    {
                        MessageBox.Show("Aucun livre ne possède ce tome"); //Message d'erreur
                    }
                }
                if (txtBoxParution.Text != "") //vérification du champ de txtBoxParution
                {
                    wcouverture = new Couverture(wcode, txtBoxTitre.Text, wtome, txtBoxParution.Text); //On initialise une nouvelle couverture
                    if (uneCouverture.getAnneeExist(wcouverture) == true) //On vérifie qu'au moins une bd est sorti à la date indiqué
                    {
                        //Connexion à la base de données
                        _connexion = new ConnexionBase();
                        uneCouverture = new CRUD_Couverture(_connexion);

                        wcouverture = new Couverture(wcode, txtBoxTitre.Text, wtome, txtBoxParution.Text); //On initilialise une nouvelle couverture
                        GridViewBase.DataSource = uneCouverture.rechercher(wcouverture); //On affiche notre recherche dans la GridView
                        GridViewBase.Update(); //On modifie les valeurs de la GridView
                        GridViewBase.Refresh(); //On affiche les nouvelles valeurs

                        clickValider(btnRechercher, "Rechercher"); //On appelle la méthode clickValider

                        btnAnnuler.Visible = true; //On affiche le bouton annuler
                    }
                    else
                    {
                        MessageBox.Show("Aucun livre n'est sorti à cette date"); //Message d'erreur
                    }
                }

                //On affiche la première ligne de la GridView dans les textes Box
                txtBoxCode.Text = GridViewBase.CurrentRow.Cells["BdId"].Value.ToString();
                txtBoxTitre.Text = GridViewBase.CurrentRow.Cells["BdTitre"].Value.ToString();
                txtBoxParution.Text = GridViewBase.CurrentRow.Cells["BdParution"].Value.ToString();
                txtBoxTome.Text = GridViewBase.CurrentRow.Cells["BdTome"].Value.ToString();
            }          
        }

        private void GridViewBase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //On affiche dans les textes box la ligne sélectionnée au click sur la GridView
            txtBoxCode.Text = GridViewBase.CurrentRow.Cells["BdId"].Value.ToString();
            txtBoxTitre.Text = GridViewBase.CurrentRow.Cells["BdTitre"].Value.ToString();
            txtBoxParution.Text = GridViewBase.CurrentRow.Cells["BdParution"].Value.ToString();
            txtBoxTome.Text = GridViewBase.CurrentRow.Cells["BdTome"].Value.ToString();

            wcouverture = new Couverture(Int16.Parse(txtBoxCode.Text)); //Initialisation d'une nouvelle couverture

            if (uneCouverture.recupImage(wcouverture) == "nondispo") //On vérifie si l'image est disponible
            {
                pctBoxCouv.Image = Properties.Resources.nondispo; //Attribu l'image nondispo à la picture box
            }
            else //Ou non
            {
                afficheImage(); //appelle de la méthode afficheImage
            }
        }

        public void RefreshGrid()
        {
            //Connexion à la base de données
            CRUD_Couverture Export = new CRUD_Couverture(_connexion);
            GridViewBase.DataSource = Export.recupCouverture();

            GridViewBase.Update(); //On modifie les valeurs de la GridView
            GridViewBase.Refresh(); //On affiche les nouvelles valeurs
        }
        public void afficheImage()
        {
            wcouverture = new Couverture(Int16.Parse(txtBoxCode.Text)); //On initialise une nouvelle couverture
            string uneImage = uneCouverture.recupImage(wcouverture); //On récupère le nom de l'image

            //On vérifie l'extension de l'image et on crée le chemin d'accès 
            if (File.Exists(Application.StartupPath.Substring(0, Application.StartupPath.Length - 25).Replace('\\', '/') + "/Couverture/" + uneImage + ".png") == true)
            {
                unChemin = (Application.StartupPath.Substring(0, Application.StartupPath.Length - 25).Replace('\\', '/') + "/Couverture/" + uneImage + ".png");
            }
            else if (File.Exists(Application.StartupPath.Substring(0, Application.StartupPath.Length - 25).Replace('\\', '/') + "/Couverture/" + uneImage + ".jpg") == true)
            {
                unChemin = (Application.StartupPath.Substring(0, Application.StartupPath.Length - 25).Replace('\\', '/') + "/Couverture/" + uneImage + ".jpg");
            }
            else if (File.Exists(Application.StartupPath.Substring(0, Application.StartupPath.Length - 25).Replace('\\', '/') + "/Couverture/" + uneImage + ".jpeg") == true)
            {
                unChemin = (Application.StartupPath.Substring(0, Application.StartupPath.Length - 25).Replace('\\', '/') + "/Couverture/" + uneImage + ".jpeg");
            }

            pctBoxCouv.Image = Image.FromFile(unChemin); //On affiche l'image dans la picture box
        }

        private void clickBouton(MetroFramework.Controls.MetroTile btn)
        {
            //On change la couleur du bouton 
            btn.BackColor = Color.Green;
            //On change le texte écrit sur le bouton
            btn.Text = "Valider";

            //le bouton annuler apparait
            btnAnnuler.Visible = true;

            //Desactive tous les autres boutons
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
            btnRechercher.Enabled = false;
            btnAjouter.Enabled = false;

            //Les textbox à remplir pour l'insertion se déverouille
            txtBoxCode.Enabled = true;
            txtBoxTitre.Enabled = true;
            txtBoxTome.Enabled = true;
            txtBoxParution.Enabled = true;


            //Le background color des textbox change de couleur pour indiquer qu'elles sont déverouillés
            txtBoxCode.BackColor = Color.White;
            txtBoxTitre.BackColor = Color.White;
            txtBoxTome.BackColor = Color.White;
            txtBoxParution.BackColor = Color.White;
        }

        private void clickValider(MetroFramework.Controls.MetroTile btn, string nomBtn)
        {
            //On change le texte écrit sur le bouton
            btn.Text = nomBtn;
            //On change la couleur du bouton 
            btn.BackColor = Color.SteelBlue;

            //On affiche le bouton annuler
            btnAnnuler.Visible = false;

            //Re active les boutons
            btnModifier.Enabled = true;
            btnSupprimer.Enabled = true;
            btnRechercher.Enabled = true;
            btnAjouter.Enabled = true;

            //Les textbox sont inacessibles.
            txtBoxCode.Enabled = false;
            txtBoxTitre.Enabled = false;
            txtBoxTome.Enabled = false;
            txtBoxParution.Enabled = false;

            //Le background color des textbox change de couleur pour indiquer qu'elles sont verouillés
            txtBoxCode.BackColor = Color.Silver;
            txtBoxTitre.BackColor = Color.Silver;
            txtBoxTome.BackColor = Color.Silver;
            txtBoxParution.BackColor = Color.Silver;
        }
        #endregion
    }
}
