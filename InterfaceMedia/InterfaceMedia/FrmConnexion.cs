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
        private Boolean laVar;
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
            
                leNiveau = unUtilisateur.recup_connexion(txtIdentifiant.Text, txtPassword.Text);

                laVar = unUtilisateur.myVar;

                if (laVar == true)
                {
                    this.Close();
                    th = new Thread(openformAccueil);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Pseudo ou mot de passe invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
        }


        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMdpOublie_Click(object sender, EventArgs e)
        {

        }


        private void openformAccueil()
        {
            Application.Run(new FrmAccueilTest(leNiveau));
        }

        private void Entrer(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnConnexion.PerformClick();
            }
            
        }
    }
}
