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

namespace InterfaceMedia
{
    public partial class FrmEmprunt : MetroForm
    {

        private Crud_Emprunt Ajout;


        public FrmEmprunt()
        {
            InitializeComponent();
            Ajout = new Crud_Emprunt();
            Crud_Emprunt Export = new Crud_Emprunt();

            GridEmprunt.DataSource = Export.afficheEmprunt();
        }


        private void btnAjoutEmp_Click(object sender, EventArgs e)
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
                int numE = Int16.Parse(txtbxNumEmp.Text);
                DateTime dateEm = Convert.ToDateTime(dtEmprunt.Text);
                DateTime dateRet = Convert.ToDateTime(dtRetour.Text);
                DateTime dateRetP = Convert.ToDateTime(dtRetourPrevu.Text);
                Emprunt lEmprunt = new Emprunt(numE, txtbxRefEx.Text,dateEm,dateRet,dateRetP);

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

        private void picHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Run(new FrmAccueilTest());
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }
    }
}
