using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class FrmConnexion : MetroForm
    {
        private ConnexionBase uneconnexion;
        private Crud_Utilisateur unUtilisateur;
        private Boolean uneCo;
        private Thread th;
        private String leNiveau;

        public FrmConnexion()
        {
            InitializeComponent();
            uneconnexion = new ConnexionBase();
            unUtilisateur = new Crud_Utilisateur(uneconnexion);

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Utilisateur lUtilisateur = new Utilisateur(txtIdentifiant.Text, txtPassword.Text);
            leNiveau = unUtilisateur.recup_connexion(lUtilisateur);

                uneCo = unUtilisateur._boolCo;

                    
                if (uneCo == true) //L'utilisateur est bien dans la base de données, l'application s'ouvre.
                {
                    this.Close();
                    th = new Thread(openformAccueil);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMdpOublie_Click(object sender, EventArgs e)
        {
            //Pas fait.
        }

        //Ouvre l'interface Accueil avec son type d'utilisateur (leNiveau)
        private void openformAccueil()
        {
            Application.Run(new FrmAccueilTest(leNiveau));
        }

        //Permet de presser la touche ENTREE pour déclencher l'évenement du bouton connexion.
        private void Entrer(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnConnexion.PerformClick();
            }
            
        }
    }
}
