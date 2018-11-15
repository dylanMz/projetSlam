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
        private CRUD_Couverture uneCouverture;
        private ConnexionBase _connexion;
        private OpenFileDialog openFile;
        private String leNiveau;
        private int wcode;
        private int wtome;
        private string nomCouv;
        private string unChemin;
        private Couverture wcouverture;


        public FrmCouverture(String leNiveau)
        {
            InitializeComponent();

            this.leNiveau = leNiveau;
            lblRang.Text = this.leNiveau;

            _connexion = new ConnexionBase();
            uneCouverture = new CRUD_Couverture(_connexion);      
            RefreshGrid();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            FrmAccueilTest wAccueilTest = new FrmAccueilTest(lblRang.Text);
            wAccueilTest.ShowDialog();
            Form.ActiveForm.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text.Equals("Ajouter"))
            {

                clickBouton(btnAjouter);
                btnAjouter.Enabled = true;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.DefaultExt = "InterfaceMedia/Couverture";
                openFile.Filter = "Image Files(*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png|All files (*.*)|*.*";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    nomCouv = System.IO.Path.GetFileNameWithoutExtension(openFile.FileName);
                    pctBoxCouv.Image = Image.FromFile(openFile.FileName);
                }
                else
                {
                    btnAnnuler_Click(null, null);
                }
               
            }


            else if (btnAjouter.Text.Equals("Valider"))
            {
                clickValider(btnAjouter, "Ajouter");
                wcouverture = new Couverture(Int16.Parse(txtBoxCode.Text), nomCouv);
                uneCouverture.ajouter(wcouverture);
                afficheImage();
                RefreshGrid();
            }
        }

        
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (btnModifier.Text.Equals("Modifier"))
            {

                clickBouton(btnModifier);
                btnModifier.Enabled = true;

                OpenFileDialog openFile = new OpenFileDialog();
                openFile.DefaultExt = "InterfaceMedia/Couverture";
                openFile.Filter = "Image Files(*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png|All files (*.*)|*.*";
                openFile.ShowDialog();

                nomCouv = System.IO.Path.GetFileNameWithoutExtension(openFile.FileName);
                pctBoxCouv.Image = Image.FromFile(openFile.FileName);
            }


            else if (btnModifier.Text.Equals("Valider"))
            {
                clickValider(btnModifier, "Modifier");
                btnAnnuler.Visible = true;
                wcouverture = new Couverture(Int16.Parse(txtBoxCode.Text), nomCouv);
                uneCouverture.modifier(wcouverture);
                afficheImage();
                RefreshGrid();
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
            txtBoxTome.Enabled = false;
            txtBoxParution.Enabled = false;

            //Le background color des textbox change de couleur pour indiquer qu'elles sont vérouillé
            txtBoxCode.BackColor = Color.Silver;
            txtBoxTitre.BackColor = Color.Silver;
            txtBoxTome.BackColor = Color.Silver;
            txtBoxParution.BackColor = Color.Silver;

            //le bouton annuler disparait
            btnAnnuler.Visible = false;

            RefreshGrid();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (btnSupprimer.Text.Equals("Supprimer"))
            {
                clickBouton(btnSupprimer);
                btnSupprimer.Enabled = true;
                wcouverture = new Couverture(Int16.Parse(txtBoxCode.Text));
                uneCouverture.Supprimer(wcouverture);
            }

            else if (btnSupprimer.Text.Equals("Valider"))
            {
                clickValider(btnSupprimer, "Supprimer");
                RefreshGrid();
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (btnRechercher.Text.Equals("Rechercher"))
            {
                clickBouton(btnRechercher);
                btnRechercher.Enabled = true;

                txtBoxCode.Text = "";
                txtBoxTitre.Text = "";
                txtBoxTome.Text = "";
                txtBoxParution.Text = "";


            }
            else if (btnRechercher.Text.Equals("Valider"))
            {
                    

               
                    if (!txtBoxCode.Text.Equals(""))
                    {
                        wcode = Convert.ToInt32(txtBoxCode.Text);
                    }

                    if (!txtBoxTome.Text.Equals(""))
                    {
                        wtome = Convert.ToInt32(txtBoxTome.Text);
                    }

                    _connexion = new ConnexionBase();
                    uneCouverture = new CRUD_Couverture(_connexion);
                    wcouverture = new Couverture(wcode, txtBoxTitre.Text, wtome, txtBoxParution.Text);
                    GridViewBase.DataSource = uneCouverture.rechercher(wcouverture);
                    GridViewBase.Update();
                    GridViewBase.Refresh();

                    if (txtBoxTitre.Text != "")
                    {
                        if (uneCouverture.getExist(wcouverture) == true)
                        {
                        wcouverture = new Couverture(txtBoxTitre.Text);
                        uneCouverture.getCode(wcouverture);
                        txtBoxCode.Text = uneCouverture.getCode(wcouverture).ToString();
                        }
                    }
                
                    txtBoxCode.Text = GridViewBase.CurrentRow.Cells["BdId"].Value.ToString();
                    txtBoxTitre.Text = GridViewBase.CurrentRow.Cells["BdTitre"].Value.ToString();
                    txtBoxParution.Text = GridViewBase.CurrentRow.Cells["BdParution"].Value.ToString();
                    txtBoxTome.Text = GridViewBase.CurrentRow.Cells["BdTome"].Value.ToString();
                    clickValider(btnRechercher, "Rechercher");

                    afficheImage();
                    btnAnnuler.Visible = true;

                }
                else
                {
                    MessageBox.Show("Ce Titre n'existe pas dans la base de données");
                } 
            
        }

        private void GridViewBase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxCode.Text = GridViewBase.CurrentRow.Cells["BdId"].Value.ToString();
            txtBoxTitre.Text = GridViewBase.CurrentRow.Cells["BdTitre"].Value.ToString();
            txtBoxParution.Text = GridViewBase.CurrentRow.Cells["BdParution"].Value.ToString();
            txtBoxTome.Text = GridViewBase.CurrentRow.Cells["BdTome"].Value.ToString();
            wcouverture = new Couverture(Int16.Parse(txtBoxCode.Text));

            if (uneCouverture.recupImage(wcouverture) == "nondispo")
            {
                pctBoxCouv.Image = Properties.Resources.nondispo;
            }
            else
            {
                afficheImage();            
            }
        }

        private void RempGridCouverture(List<Couverture> lesCouvertures)
        {
            GridViewBase.DataSource = lesCouvertures;
        }

        public void RefreshGrid()
        {
            CRUD_Couverture Export = new CRUD_Couverture(_connexion);
            GridViewBase.DataSource = Export.recupCouverture();
            GridViewBase.Update();
            GridViewBase.Refresh();
        }
        public void afficheImage()
        {
            wcouverture = new Couverture(Int16.Parse(txtBoxCode.Text));
            string uneImage = uneCouverture.recupImage(wcouverture);

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

            pctBoxCouv.Image = Image.FromFile(unChemin);
        }

        private void clickBouton(MetroFramework.Controls.MetroTile btn)
        {
            btn.BackColor = Color.Green;
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
            btn.Text = nomBtn;
            btn.BackColor = Color.SteelBlue;

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
    }
}
